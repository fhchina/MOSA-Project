﻿/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Michael Fröhlich (aka grover, <mailto:sharpos@michaelruck.de>)
 *  
 */

using System;

using MbUnit.Framework;

namespace Test.Mosa.Runtime.CompilerFramework.CLI
{
	[TestFixture]
	public class UInt32Fixture 
	{
		private readonly ArithmeticInstructionTestRunner<uint, uint> arithmeticTests = new ArithmeticInstructionTestRunner<uint, uint>
		{
			ExpectedTypeName = @"uint",
			TypeName = @"uint"
		};

		private readonly BinaryLogicInstructionTestRunner<uint, uint, int> logicTests = new BinaryLogicInstructionTestRunner<uint, uint, int>
		{
			ExpectedTypeName = @"uint",
			TypeName = @"uint",
			ShiftTypeName = @"int",
			IncludeNot = false
		};

		private readonly ComparisonInstructionTestRunner<uint> comparisonTests = new ComparisonInstructionTestRunner<uint>
		{
			TypeName = @"uint"
		};

		private readonly SZArrayInstructionTestRunner<uint> arrayTests = new SZArrayInstructionTestRunner<uint>
		{
			TypeName = @"uint"
		};

		#region Add

		[Row(0, 0)]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0)]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0)]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0)]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0)]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0)]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0)]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Add(uint a, uint b)
		{
			this.arithmeticTests.Add((a + b), a, b);
		}

		#endregion // Add

		#region Sub

		[Row(0, 0)]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0)]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0)]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0)]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0)]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0)]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0)]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Sub(uint a, uint b)
		{
			this.arithmeticTests.Sub((a - b), a, b);
		}

		#endregion // Sub

		#region Mul

		[Row(0, 0)]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0)]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0)]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0)]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0)]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0)]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0)]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Mul(uint a, uint b)
		{
			this.arithmeticTests.Mul((a * b), a, b);
		}

		#endregion // Mul

		#region Div

		[Row(0, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Div(uint a, uint b)
		{
			this.arithmeticTests.Div((a / b), a, b);
		}

		#endregion // Div

		#region Rem

		[Row(0, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0, ExpectedException = typeof(DivideByZeroException))]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Rem(uint a, uint b)
		{
			this.arithmeticTests.Rem((a % b), a, b);
		}

		#endregion // Rem

		#region Ret

		[Row(0)]
		[Row(1)]
		[Row(2)]
		[Row(UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1)]
		[Row(17)]
		[Row(123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Ret(uint value)
		{
			this.arithmeticTests.Ret(value);
		}

		#endregion // Ret

		#region And

		[Row(0, 0)]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0)]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0)]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0)]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0)]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0)]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0)]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void And(uint first, uint second)
		{
			this.logicTests.And((first & second), first, second);
		}

		#endregion // And

		#region Or

		[Row(0, 0)]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0)]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0)]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0)]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0)]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0)]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0)]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Or(uint first, uint second)
		{
			this.logicTests.Or((first | second), first, second);
		}

		#endregion // Or

		#region Xor

		[Row(0, 0)]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0)]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0)]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0)]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0)]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0)]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0)]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Xor(uint first, uint second)
		{
			this.logicTests.Xor((first ^ second), first, second);
		}

		#endregion // Xor

		#region Comp

		[Row(0)]
		[Row(1)]
		[Row(2)]
		[Row(UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1)]
		[Row(17)]
		[Row(123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Comp(uint first)
		{
			this.logicTests.Comp(~first, first);
		}

		#endregion // Comp

		#region Shl

		//[Row(0, 0)]
		//[Row(0, 1)]
		//[Row(0, 2)]
		//[Row(0, 3)]
		//[Row(0, 4)]
		//[Row(0, 5)]
		//[Row(0, 6)]
		//[Row(0, 7)]
		//[Row(0, 8)]
		//[Row(0, 9)]
		//[Row(0, 10)]
		//[Row(0, 11)]
		//[Row(0, 12)]
		//[Row(0, 13)]
		//[Row(0, 14)]
		//[Row(0, 15)]
		//[Row(0, 16)]
		//[Row(0, 17)]
		//[Row(0, 18)]
		//[Row(0, 19)]
		//[Row(0, 20)]
		//[Row(0, 21)]
		//[Row(0, 22)]
		//[Row(0, 23)]
		//[Row(0, 24)]
		//[Row(0, 25)]
		//[Row(0, 26)]
		//[Row(0, 27)]
		//[Row(0, 28)]
		//[Row(0, 29)]
		//[Row(0, 30)]
		//[Row(0, 31)]
		//[Row(1, 0)]
		//[Row(1, 1)]
		//[Row(1, 2)]
		//[Row(1, 3)]
		//[Row(1, 4)]
		//[Row(1, 5)]
		//[Row(1, 6)]
		//[Row(1, 7)]
		//[Row(1, 8)]
		//[Row(1, 9)]
		//[Row(1, 10)]
		//[Row(1, 11)]
		//[Row(1, 12)]
		//[Row(1, 13)]
		//[Row(1, 14)]
		//[Row(1, 15)]
		//[Row(1, 16)]
		//[Row(1, 17)]
		//[Row(1, 18)]
		//[Row(1, 19)]
		//[Row(1, 20)]
		//[Row(1, 21)]
		//[Row(1, 22)]
		//[Row(1, 23)]
		//[Row(1, 24)]
		//[Row(1, 25)]
		//[Row(1, 26)]
		//[Row(1, 27)]
		//[Row(1, 28)]
		//[Row(1, 29)]
		//[Row(1, 30)]
		//[Row(1, 31)]
		//[Row(2, 0)]
		//[Row(2, 1)]
		//[Row(2, 2)]
		//[Row(2, 3)]
		//[Row(2, 4)]
		//[Row(2, 5)]
		//[Row(2, 6)]
		//[Row(2, 7)]
		//[Row(2, 8)]
		//[Row(2, 9)]
		//[Row(2, 10)]
		//[Row(2, 11)]
		//[Row(2, 12)]
		//[Row(2, 13)]
		//[Row(2, 14)]
		//[Row(2, 15)]
		//[Row(2, 16)]
		//[Row(2, 17)]
		//[Row(2, 18)]
		//[Row(2, 19)]
		//[Row(2, 20)]
		//[Row(2, 21)]
		//[Row(2, 22)]
		//[Row(2, 23)]
		//[Row(2, 24)]
		//[Row(2, 25)]
		//[Row(2, 26)]
		//[Row(2, 27)]
		//[Row(2, 28)]
		//[Row(2, 29)]
		//[Row(2, 30)]
		//[Row(2, 31)]
		//[Row(UInt32.MaxValue, 0)]
		//[Row(UInt32.MaxValue, 1)]
		//[Row(UInt32.MaxValue, 2)]
		//[Row(UInt32.MaxValue, 3)]
		//[Row(UInt32.MaxValue, 4)]
		//[Row(UInt32.MaxValue, 5)]
		//[Row(UInt32.MaxValue, 6)]
		//[Row(UInt32.MaxValue, 7)]
		//[Row(UInt32.MaxValue, 8)]
		//[Row(UInt32.MaxValue, 9)]
		//[Row(UInt32.MaxValue, 10)]
		//[Row(UInt32.MaxValue, 11)]
		//[Row(UInt32.MaxValue, 12)]
		//[Row(UInt32.MaxValue, 13)]
		//[Row(UInt32.MaxValue, 14)]
		//[Row(UInt32.MaxValue, 15)]
		//[Row(UInt32.MaxValue, 16)]
		//[Row(UInt32.MaxValue, 17)]
		//[Row(UInt32.MaxValue, 18)]
		//[Row(UInt32.MaxValue, 19)]
		//[Row(UInt32.MaxValue, 20)]
		//[Row(UInt32.MaxValue, 21)]
		//[Row(UInt32.MaxValue, 22)]
		//[Row(UInt32.MaxValue, 23)]
		//[Row(UInt32.MaxValue, 24)]
		//[Row(UInt32.MaxValue, 25)]
		//[Row(UInt32.MaxValue, 26)]
		//[Row(UInt32.MaxValue, 27)]
		//[Row(UInt32.MaxValue, 28)]
		//[Row(UInt32.MaxValue, 29)]
		//[Row(UInt32.MaxValue, 30)]
		//[Row(UInt32.MaxValue, 31)]
		//[Row(UInt32.MaxValue - 1, 0)]
		//[Row(UInt32.MaxValue - 1, 1)]
		//[Row(UInt32.MaxValue - 1, 2)]
		//[Row(UInt32.MaxValue - 1, 3)]
		//[Row(UInt32.MaxValue - 1, 4)]
		//[Row(UInt32.MaxValue - 1, 5)]
		//[Row(UInt32.MaxValue - 1, 6)]
		//[Row(UInt32.MaxValue - 1, 7)]
		//[Row(UInt32.MaxValue - 1, 8)]
		//[Row(UInt32.MaxValue - 1, 9)]
		//[Row(UInt32.MaxValue - 1, 10)]
		//[Row(UInt32.MaxValue - 1, 11)]
		//[Row(UInt32.MaxValue - 1, 12)]
		//[Row(UInt32.MaxValue - 1, 13)]
		//[Row(UInt32.MaxValue - 1, 14)]
		//[Row(UInt32.MaxValue - 1, 15)]
		//[Row(UInt32.MaxValue - 1, 16)]
		//[Row(UInt32.MaxValue - 1, 17)]
		//[Row(UInt32.MaxValue - 1, 18)]
		//[Row(UInt32.MaxValue - 1, 19)]
		//[Row(UInt32.MaxValue - 1, 20)]
		//[Row(UInt32.MaxValue - 1, 21)]
		//[Row(UInt32.MaxValue - 1, 22)]
		//[Row(UInt32.MaxValue - 1, 23)]
		//[Row(UInt32.MaxValue - 1, 24)]
		//[Row(UInt32.MaxValue - 1, 25)]
		//[Row(UInt32.MaxValue - 1, 26)]
		//[Row(UInt32.MaxValue - 1, 27)]
		//[Row(UInt32.MaxValue - 1, 28)]
		//[Row(UInt32.MaxValue - 1, 29)]
		//[Row(UInt32.MaxValue - 1, 30)]
		//[Row(UInt32.MaxValue - 1, 31)]
		//[Row(17, 0)]
		//[Row(17, 1)]
		//[Row(17, 2)]
		//[Row(17, 3)]
		//[Row(17, 4)]
		//[Row(17, 5)]
		//[Row(17, 6)]
		//[Row(17, 7)]
		//[Row(17, 8)]
		//[Row(17, 9)]
		//[Row(17, 10)]
		//[Row(17, 11)]
		//[Row(17, 12)]
		//[Row(17, 13)]
		//[Row(17, 14)]
		//[Row(17, 15)]
		//[Row(17, 16)]
		//[Row(17, 17)]
		//[Row(17, 18)]
		//[Row(17, 19)]
		//[Row(17, 20)]
		//[Row(17, 21)]
		//[Row(17, 22)]
		//[Row(17, 23)]
		//[Row(17, 24)]
		//[Row(17, 25)]
		//[Row(17, 26)]
		//[Row(17, 27)]
		//[Row(17, 28)]
		//[Row(17, 29)]
		//[Row(17, 30)]
		//[Row(17, 31)]
		//[Row(123, 0)]
		//[Row(123, 1)]
		//[Row(123, 2)]
		//[Row(123, 3)]
		//[Row(123, 4)]
		//[Row(123, 5)]
		//[Row(123, 6)]
		//[Row(123, 7)]
		//[Row(123, 8)]
		//[Row(123, 9)]
		//[Row(123, 10)]
		//[Row(123, 11)]
		//[Row(123, 12)]
		//[Row(123, 13)]
		//[Row(123, 14)]
		//[Row(123, 15)]
		//[Row(123, 16)]
		//[Row(123, 17)]
		//[Row(123, 18)]
		//[Row(123, 19)]
		//[Row(123, 20)]
		//[Row(123, 21)]
		//[Row(123, 22)]
		//[Row(123, 23)]
		//[Row(123, 24)]
		//[Row(123, 25)]
		//[Row(123, 26)]
		//[Row(123, 27)]
		//[Row(123, 28)]
		//[Row(123, 29)]
		//[Row(123, 30)]
		//[Row(123, 31)]
		//[Test, Author("tgiphil", "phil@thinkedge.com")]
		//public void Shl(uint first, int second)
		//{
		//    this.logicTests.Shl((first << second), first, second);
		//}

		#endregion // Shl

		#region Shr

		//[Row(0, 0)]
		//[Row(0, 1)]
		//[Row(0, 2)]
		//[Row(0, 3)]
		//[Row(0, 4)]
		//[Row(0, 5)]
		//[Row(0, 6)]
		//[Row(0, 7)]
		//[Row(0, 8)]
		//[Row(0, 9)]
		//[Row(0, 10)]
		//[Row(0, 11)]
		//[Row(0, 12)]
		//[Row(0, 13)]
		//[Row(0, 14)]
		//[Row(0, 15)]
		//[Row(0, 16)]
		//[Row(0, 17)]
		//[Row(0, 18)]
		//[Row(0, 19)]
		//[Row(0, 20)]
		//[Row(0, 21)]
		//[Row(0, 22)]
		//[Row(0, 23)]
		//[Row(0, 24)]
		//[Row(0, 25)]
		//[Row(0, 26)]
		//[Row(0, 27)]
		//[Row(0, 28)]
		//[Row(0, 29)]
		//[Row(0, 30)]
		//[Row(0, 31)]
		//[Row(1, 0)]
		//[Row(1, 1)]
		//[Row(1, 2)]
		//[Row(1, 3)]
		//[Row(1, 4)]
		//[Row(1, 5)]
		//[Row(1, 6)]
		//[Row(1, 7)]
		//[Row(1, 8)]
		//[Row(1, 9)]
		//[Row(1, 10)]
		//[Row(1, 11)]
		//[Row(1, 12)]
		//[Row(1, 13)]
		//[Row(1, 14)]
		//[Row(1, 15)]
		//[Row(1, 16)]
		//[Row(1, 17)]
		//[Row(1, 18)]
		//[Row(1, 19)]
		//[Row(1, 20)]
		//[Row(1, 21)]
		//[Row(1, 22)]
		//[Row(1, 23)]
		//[Row(1, 24)]
		//[Row(1, 25)]
		//[Row(1, 26)]
		//[Row(1, 27)]
		//[Row(1, 28)]
		//[Row(1, 29)]
		//[Row(1, 30)]
		//[Row(1, 31)]
		//[Row(2, 0)]
		//[Row(2, 1)]
		//[Row(2, 2)]
		//[Row(2, 3)]
		//[Row(2, 4)]
		//[Row(2, 5)]
		//[Row(2, 6)]
		//[Row(2, 7)]
		//[Row(2, 8)]
		//[Row(2, 9)]
		//[Row(2, 10)]
		//[Row(2, 11)]
		//[Row(2, 12)]
		//[Row(2, 13)]
		//[Row(2, 14)]
		//[Row(2, 15)]
		//[Row(2, 16)]
		//[Row(2, 17)]
		//[Row(2, 18)]
		//[Row(2, 19)]
		//[Row(2, 20)]
		//[Row(2, 21)]
		//[Row(2, 22)]
		//[Row(2, 23)]
		//[Row(2, 24)]
		//[Row(2, 25)]
		//[Row(2, 26)]
		//[Row(2, 27)]
		//[Row(2, 28)]
		//[Row(2, 29)]
		//[Row(2, 30)]
		//[Row(2, 31)]
		//[Row(UInt32.MaxValue, 0)]
		//[Row(UInt32.MaxValue, 1)]
		//[Row(UInt32.MaxValue, 2)]
		//[Row(UInt32.MaxValue, 3)]
		//[Row(UInt32.MaxValue, 4)]
		//[Row(UInt32.MaxValue, 5)]
		//[Row(UInt32.MaxValue, 6)]
		//[Row(UInt32.MaxValue, 7)]
		//[Row(UInt32.MaxValue, 8)]
		//[Row(UInt32.MaxValue, 9)]
		//[Row(UInt32.MaxValue, 10)]
		//[Row(UInt32.MaxValue, 11)]
		//[Row(UInt32.MaxValue, 12)]
		//[Row(UInt32.MaxValue, 13)]
		//[Row(UInt32.MaxValue, 14)]
		//[Row(UInt32.MaxValue, 15)]
		//[Row(UInt32.MaxValue, 16)]
		//[Row(UInt32.MaxValue, 17)]
		//[Row(UInt32.MaxValue, 18)]
		//[Row(UInt32.MaxValue, 19)]
		//[Row(UInt32.MaxValue, 20)]
		//[Row(UInt32.MaxValue, 21)]
		//[Row(UInt32.MaxValue, 22)]
		//[Row(UInt32.MaxValue, 23)]
		//[Row(UInt32.MaxValue, 24)]
		//[Row(UInt32.MaxValue, 25)]
		//[Row(UInt32.MaxValue, 26)]
		//[Row(UInt32.MaxValue, 27)]
		//[Row(UInt32.MaxValue, 28)]
		//[Row(UInt32.MaxValue, 29)]
		//[Row(UInt32.MaxValue, 30)]
		//[Row(UInt32.MaxValue, 31)]
		//[Row(UInt32.MaxValue - 1, 0)]
		//[Row(UInt32.MaxValue - 1, 1)]
		//[Row(UInt32.MaxValue - 1, 2)]
		//[Row(UInt32.MaxValue - 1, 3)]
		//[Row(UInt32.MaxValue - 1, 4)]
		//[Row(UInt32.MaxValue - 1, 5)]
		//[Row(UInt32.MaxValue - 1, 6)]
		//[Row(UInt32.MaxValue - 1, 7)]
		//[Row(UInt32.MaxValue - 1, 8)]
		//[Row(UInt32.MaxValue - 1, 9)]
		//[Row(UInt32.MaxValue - 1, 10)]
		//[Row(UInt32.MaxValue - 1, 11)]
		//[Row(UInt32.MaxValue - 1, 12)]
		//[Row(UInt32.MaxValue - 1, 13)]
		//[Row(UInt32.MaxValue - 1, 14)]
		//[Row(UInt32.MaxValue - 1, 15)]
		//[Row(UInt32.MaxValue - 1, 16)]
		//[Row(UInt32.MaxValue - 1, 17)]
		//[Row(UInt32.MaxValue - 1, 18)]
		//[Row(UInt32.MaxValue - 1, 19)]
		//[Row(UInt32.MaxValue - 1, 20)]
		//[Row(UInt32.MaxValue - 1, 21)]
		//[Row(UInt32.MaxValue - 1, 22)]
		//[Row(UInt32.MaxValue - 1, 23)]
		//[Row(UInt32.MaxValue - 1, 24)]
		//[Row(UInt32.MaxValue - 1, 25)]
		//[Row(UInt32.MaxValue - 1, 26)]
		//[Row(UInt32.MaxValue - 1, 27)]
		//[Row(UInt32.MaxValue - 1, 28)]
		//[Row(UInt32.MaxValue - 1, 29)]
		//[Row(UInt32.MaxValue - 1, 30)]
		//[Row(UInt32.MaxValue - 1, 31)]
		//[Row(17, 0)]
		//[Row(17, 1)]
		//[Row(17, 2)]
		//[Row(17, 3)]
		//[Row(17, 4)]
		//[Row(17, 5)]
		//[Row(17, 6)]
		//[Row(17, 7)]
		//[Row(17, 8)]
		//[Row(17, 9)]
		//[Row(17, 10)]
		//[Row(17, 11)]
		//[Row(17, 12)]
		//[Row(17, 13)]
		//[Row(17, 14)]
		//[Row(17, 15)]
		//[Row(17, 16)]
		//[Row(17, 17)]
		//[Row(17, 18)]
		//[Row(17, 19)]
		//[Row(17, 20)]
		//[Row(17, 21)]
		//[Row(17, 22)]
		//[Row(17, 23)]
		//[Row(17, 24)]
		//[Row(17, 25)]
		//[Row(17, 26)]
		//[Row(17, 27)]
		//[Row(17, 28)]
		//[Row(17, 29)]
		//[Row(17, 30)]
		//[Row(17, 31)]
		//[Row(123, 0)]
		//[Row(123, 1)]
		//[Row(123, 2)]
		//[Row(123, 3)]
		//[Row(123, 4)]
		//[Row(123, 5)]
		//[Row(123, 6)]
		//[Row(123, 7)]
		//[Row(123, 8)]
		//[Row(123, 9)]
		//[Row(123, 10)]
		//[Row(123, 11)]
		//[Row(123, 12)]
		//[Row(123, 13)]
		//[Row(123, 14)]
		//[Row(123, 15)]
		//[Row(123, 16)]
		//[Row(123, 17)]
		//[Row(123, 18)]
		//[Row(123, 19)]
		//[Row(123, 20)]
		//[Row(123, 21)]
		//[Row(123, 22)]
		//[Row(123, 23)]
		//[Row(123, 24)]
		//[Row(123, 25)]
		//[Row(123, 26)]
		//[Row(123, 27)]
		//[Row(123, 28)]
		//[Row(123, 29)]
		//[Row(123, 30)]
		//[Row(123, 31)]
		//[Test, Author("tgiphil", "phil@thinkedge.com")]
		//public void Shr(uint first, int second)
		//{
		//    this.logicTests.Shr((first >> second), first, second);
		//}

		#endregion // Shr
		#region Ceq

		[Row(0, 0)]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0)]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0)]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0)]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0)]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0)]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0)]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Ceq(uint first, uint second)
		{
			this.comparisonTests.Ceq((first == second), first, second);
		}

		#endregion // Ceq

		#region Cgt

		[Row(0, 0)]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0)]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0)]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0)]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0)]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0)]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0)]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Cgt(uint first, uint second)
		{
			this.comparisonTests.Cgt((first > second), first, second);
		}

		#endregion // Cgt

		#region Clt

		[Row(0, 0)]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0)]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0)]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0)]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0)]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0)]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0)]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Clt(uint first, uint second)
		{
			this.comparisonTests.Clt((first < second), first, second);
		}

		#endregion // Clt

		#region Cge

		[Row(0, 0)]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0)]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0)]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0)]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0)]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0)]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0)]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Cge(uint first, uint second)
		{
			this.comparisonTests.Cge((first >= second), first, second);
		}

		#endregion // Cge

		#region Cle

		[Row(0, 0)]
		[Row(0, 1)]
		[Row(0, 2)]
		[Row(0, UInt32.MaxValue)]
		[Row(0, UInt32.MaxValue - 1)]
		[Row(0, 17)]
		[Row(0, 123)]
		[Row(1, 0)]
		[Row(1, 1)]
		[Row(1, 2)]
		[Row(1, UInt32.MaxValue)]
		[Row(1, UInt32.MaxValue - 1)]
		[Row(1, 17)]
		[Row(1, 123)]
		[Row(2, 0)]
		[Row(2, 1)]
		[Row(2, 2)]
		[Row(2, UInt32.MaxValue)]
		[Row(2, UInt32.MaxValue - 1)]
		[Row(2, 17)]
		[Row(2, 123)]
		[Row(UInt32.MaxValue, 0)]
		[Row(UInt32.MaxValue, 1)]
		[Row(UInt32.MaxValue, 2)]
		[Row(UInt32.MaxValue, UInt32.MaxValue)]
		[Row(UInt32.MaxValue, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue, 17)]
		[Row(UInt32.MaxValue, 123)]
		[Row(UInt32.MaxValue - 1, 0)]
		[Row(UInt32.MaxValue - 1, 1)]
		[Row(UInt32.MaxValue - 1, 2)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue)]
		[Row(UInt32.MaxValue - 1, UInt32.MaxValue - 1)]
		[Row(UInt32.MaxValue - 1, 17)]
		[Row(UInt32.MaxValue - 1, 123)]
		[Row(17, 0)]
		[Row(17, 1)]
		[Row(17, 2)]
		[Row(17, UInt32.MaxValue)]
		[Row(17, UInt32.MaxValue - 1)]
		[Row(17, 17)]
		[Row(17, 123)]
		[Row(123, 0)]
		[Row(123, 1)]
		[Row(123, 2)]
		[Row(123, UInt32.MaxValue)]
		[Row(123, UInt32.MaxValue - 1)]
		[Row(123, 17)]
		[Row(123, 123)]
		[Test, Author("tgiphil", "phil@thinkedge.com")]
		public void Cle(uint first, uint second)
		{
			this.comparisonTests.Cle((first <= second), first, second);
		}

		#endregion // Cle

		#region Newarr

		[Test, Author(@"Michael Fröhlich, sharpos@michaelruck.de")]
		public void Newarr()
		{
			this.arrayTests.Newarr();
		}

		#endregion // Newarr

		#region Ldlen

		[Row(0)]
		[Row(1)]
		[Row(10)]
		[Test, Author(@"Michael Fröhlich, sharpos@michaelruck.de")]
		public void Ldlen(int length)
		{
			this.arrayTests.Ldlen(length);
		}

		#endregion // Ldlen

		#region Stelem

		[Row(0, UInt32.MinValue)]
		[Row(0, 1)]
		[Row(0, UInt32.MaxValue)]
		[Row(3, UInt32.MinValue)]
		[Row(6, 1)]
		[Row(2, UInt32.MaxValue)]
		[Test, Author(@"Michael Fröhlich, sharpos@michaelruck.de")]
		public void Stelem(int index, uint value)
		{
			this.arrayTests.Stelem(index, value);
		}

		#endregion // Stelem

		#region Ldelem

		[Row(0, UInt32.MinValue)]
		[Row(0, 1)]
		[Row(0, UInt32.MaxValue)]
		[Row(3, UInt32.MinValue)]
		[Row(6, 1)]
		[Row(2, UInt32.MaxValue)]
		[Test, Author(@"Michael Fröhlich, sharpos@michaelruck.de")]
		public void Ldelem(int index, uint value)
		{
			this.arrayTests.Ldelem(index, value);
		}

		#endregion // Ldelem

		#region Ldelema

		[Row(0, UInt32.MinValue)]
		[Row(0, 1)]
		[Row(0, UInt32.MaxValue)]
		[Row(3, UInt32.MinValue)]
		[Row(6, 1)]
		[Row(2, UInt32.MaxValue)]
		[Test, Author(@"Michael Fröhlich, sharpos@michaelruck.de")]
		public void Ldelema(int index, uint value)
		{
			this.arrayTests.Ldelema(index, value);
		}

		#endregion // Ldelema
	}
}
