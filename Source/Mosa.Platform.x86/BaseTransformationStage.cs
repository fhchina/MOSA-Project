/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Michael Ruck (grover) <sharpos@michaelruck.de>
 *  Scott Balmos <sbalmos@fastmail.fm>
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 */

using Mosa.Compiler.Framework;
using Mosa.Compiler.Framework.Platform;

namespace Mosa.Platform.x86
{
	/// <summary>
	///
	/// </summary>
	public abstract class BaseTransformationStage : BasePlatformTransformationStage
	{
		protected override string Platform { get { return "x86"; } }

		public static X86Instruction GetMove(Operand Destination, Operand Source)
		{
			if (Source.IsSingle && Destination.IsSingle)
			{
				return X86.Movss;
			}
			else if (Source.IsDouble && Destination.IsDouble)
			{
				return X86.Movsd;
			}
			else if (Source.IsSingle && Destination.IsDouble)
			{
				return X86.Cvtss2sd;
			}
			else if (Source.IsDouble && Destination.IsSingle)
			{
				return X86.Cvtsd2ss;
			}
			else
			{
				return X86.Mov;
			}
		}
	}
}