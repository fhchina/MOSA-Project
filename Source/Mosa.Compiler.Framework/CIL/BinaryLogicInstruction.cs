﻿/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 */

using Mosa.Compiler.Metadata;
using Mosa.Compiler.MosaTypeSystem;
using System;

namespace Mosa.Compiler.Framework.CIL
{
	/// <summary>
	/// Intermediate representation of a IL binary logic instruction.
	/// </summary>
	public sealed class BinaryLogicInstruction : BinaryInstruction
	{
		#region Operand Table

		/// <summary>
		/// Operand table according to ISO/IEC 23271:2006 (E), Partition III, 1.5, Table 5.
		/// </summary>
		private static readonly StackTypeCode[][] opTable = new StackTypeCode[][] {
			new StackTypeCode[] { StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown },
			new StackTypeCode[] { StackTypeCode.Unknown, StackTypeCode.Int32,   StackTypeCode.Unknown, StackTypeCode.N,       StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown },
			new StackTypeCode[] { StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Int64,   StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown },
			new StackTypeCode[] { StackTypeCode.Unknown, StackTypeCode.N,       StackTypeCode.Unknown, StackTypeCode.N,       StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown },
			new StackTypeCode[] { StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown },
			new StackTypeCode[] { StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown },
			new StackTypeCode[] { StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown, StackTypeCode.Unknown },
		};

		#endregion Operand Table

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="BinaryLogicInstruction"/> class.
		/// </summary>
		/// <param name="opcode">The opcode.</param>
		public BinaryLogicInstruction(OpCode opcode)
			: base(opcode, 1)
		{
		}

		#endregion Construction

		#region Methods

		/// <summary>
		/// Validates the instruction operands and creates a matching variable for the result.
		/// </summary>
		/// <param name="ctx">The context.</param>
		/// <param name="compiler">The compiler.</param>
		public override void Resolve(Context ctx, BaseMethodCompiler compiler)
		{
			base.Resolve(ctx, compiler);

			var stackTypeForOperand1 = TypeSystem.GetStackType(ctx.Operand1.Type);
			var stackTypeForOperand2 = TypeSystem.GetStackType(ctx.Operand2.Type);

			if (ctx.Operand1.IsValueType && ctx.Operand1.Type.BaseType.IsEnum)
			{
				stackTypeForOperand1 = TypeSystem.GetStackType(ctx.Operand1.Type.Fields[0].Type);
			}

			if (ctx.Operand2.IsValueType && ctx.Operand2.Type.BaseType.IsEnum)
			{
				stackTypeForOperand2 = TypeSystem.GetStackType(ctx.Operand2.Type.Fields[0].Type);
			}

			var result = opTable[(int)stackTypeForOperand1][(int)stackTypeForOperand2];

			if (result == StackTypeCode.Unknown)
			{
				throw new InvalidOperationException(@"Invalid virtualLocal result of instruction: " + result.ToString() + " (" + ctx.Operand1.ToString() + ")");
			}

			ctx.Result = compiler.CreateVirtualRegister(compiler.TypeSystem.GetType(result));
		}

		private static StackTypeCode FromSigType(CilElementType type)
		{
			switch (type)
			{
				case CilElementType.I1: goto case CilElementType.U4;
				case CilElementType.I2: goto case CilElementType.U4;
				case CilElementType.I4: goto case CilElementType.U4;
				case CilElementType.U1: goto case CilElementType.U4;
				case CilElementType.U2: goto case CilElementType.U4;
				case CilElementType.U4: return StackTypeCode.Int32;
			}

			throw new NotSupportedException();
		}

		/// <summary>
		/// Allows visitor based dispatch for this instruction object.
		/// </summary>
		/// <param name="visitor">The visitor.</param>
		/// <param name="context">The context.</param>
		public override void Visit(ICILVisitor visitor, Context context)
		{
			visitor.BinaryLogic(context);
		}

		#endregion Methods
	}
}