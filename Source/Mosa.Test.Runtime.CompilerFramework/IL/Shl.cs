﻿/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Alex Lyman <mail.alex.lyman@gmail.com>
 *  Simon Wollwage (rootnode) <kintaro@think-in-co.de>
 *  Michael Fröhlich (grover) <michael.ruck@michaelruck.de>
 *  Kai P. Reisert <kpreisert@googlemail.com>
 *  
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using MbUnit.Framework;

namespace Mosa.Test.Runtime.CompilerFramework.IL
{
	[TestFixture]
	public class Shl : CodeDomTestRunner
	{
		private static string CreateTestCode(string name, string typeIn, string typeOut)
		{
			return CreateTestCode(name, typeIn, typeIn, typeOut);
		}

		private static string CreateTestCode(string name, string typeInA, string typeInB, string typeOut)
		{
			return @"
				static class Test
				{
					static bool " + name + "(" + typeOut + " expect, " + typeInA + " a, " + typeInB + @" b)
					{
						return expect == (a << b);
					}
				}" + Code.AllTestCode;
		}

		private static string CreateTestCodeWithReturn(string name, string typeInA, string typeInB, string typeOut)
		{
			return @"
				static class Test
				{
					static " + typeOut + " " + name + "(" + typeOut + " expect, " + typeInA + " a, " + typeInB + @" b)
					{
						return (a << b);
					}
				}" + Code.AllTestCode;
		}

		private static string CreateConstantTestCode(string name, string typeIn, string typeOut, string constLeft, string constRight)
		{
			if (String.IsNullOrEmpty(constRight))
			{
				return @"
					static class Test
					{
						static bool " + name + "(" + typeOut + " expect, " + typeIn + @" x)
						{
							return expect == (" + constLeft + @" << x);
						}
					}" + Code.AllTestCode;
			}
			else if (String.IsNullOrEmpty(constLeft))
			{
				return @"
					static class Test
					{
						static bool " + name + "(" + typeOut + " expect, " + typeIn + @" x)
						{
							return expect == (x << " + constRight + @");
						}
					}" + Code.AllTestCode;
			}
			else
			{
				throw new NotSupportedException();
			}
		}

		private static string CreateConstantTestCodeWithReturn(string name, string typeIn, string typeOut, string constLeft, string constRight)
		{
			if (String.IsNullOrEmpty(constRight))
			{
				return @"
					static class Test
					{
						static " + typeOut + " " + name + "(" + typeOut + " expect, " + typeIn + @" x)
						{
							return (" + constLeft + @" << x);
						}
					}" + Code.AllTestCode;
			}
			else if (String.IsNullOrEmpty(constLeft))
			{
				return @"
					static class Test
					{
						static " + typeOut + " " + name + "(" + typeOut + " expect, " + typeIn + @" x)
						{
							return (x << " + constRight + @");
						}
					}" + Code.AllTestCode;
			}
			else
			{
				throw new NotSupportedException();
			}
		}

		#region C
		
		[Row(0, 0)]
		[Row(17, 128)]
		[Row('a', 'Z')]
		[Row(char.MinValue, char.MaxValue)]
		[Test, Author("boddlnagg", "kpreisert@googlemail.com")]
		public void ShlC(char a, char b)
		{
			CodeSource = CreateTestCode("AddC", "char", "int");
			Assert.IsTrue(Run<bool>("", "Test", "AddC", (a << b), a, b));
		}

		[Row(0, 'a')]
		[Row('-', '.')]
		[Row('a', 'Z')]
		[Test, Author("boddlnagg", "kpreisert@googlemail.com")]
		public void ShlConstantCRight(char a, char b)
		{
			CodeSource = CreateConstantTestCodeWithReturn("ShlConstantCRight", "char", "int", null, "'" + b.ToString() + "'");
			Assert.AreEqual(a << b, Run<int>("", "Test", "ShlConstantCRight", (char)(a << b), a));
		}

		[Row('a', 0)]
		[Row('-', '.')]
		[Row('a', 'Z')]
		[Test, Author("boddlnagg", "kpreisert@googlemail.com")]
		public void ShlConstantCLeft(char a, char b)
		{
			CodeSource = CreateConstantTestCodeWithReturn("ShlConstantCLeft", "char", "int", "'" + a.ToString() + "'", null);
			Assert.AreEqual(a << b, Run<int>("", "Test", "ShlConstantCLeft", (char)(a << b), b));
		}
		#endregion

		#region I1
		
		[Row(1, 2)]
		[Row(23, 21)]
		// And reverse
		[Row(2, 1)]
		[Row(21, 23)]
		// (MinValue, X) Cases
		[Row(sbyte.MinValue, 0)]
		[Row(sbyte.MinValue, 1)]
		[Row(sbyte.MinValue, 17)]
		[Row(sbyte.MinValue, 123)]
		// (MaxValue, X) Cases
		[Row(sbyte.MaxValue, 0)]
		[Row(sbyte.MaxValue, 1)]
		[Row(sbyte.MaxValue, 17)]
		[Row(sbyte.MaxValue, 123)]
		// (X, MinValue) Cases
		[Row(0, sbyte.MinValue)]
		[Row(1, sbyte.MinValue)]
		[Row(17, sbyte.MinValue)]
		[Row(123, sbyte.MinValue)]
		// (X, MaxValue) Cases
		[Row(0, sbyte.MaxValue)]
		[Row(1, sbyte.MaxValue)]
		[Row(17, sbyte.MaxValue)]
		[Row(123, sbyte.MaxValue)]
		// Extremvaluecases
		[Row(sbyte.MinValue, sbyte.MaxValue)]
		[Row(sbyte.MaxValue, sbyte.MinValue)]
		[Test, Author("alyman", "mail.alex.lyman@gmail.com")]
		public void ShlI1(sbyte a, sbyte b)
		{
			CodeSource = CreateTestCode("ShlI1", "sbyte", "int");
			Assert.IsTrue(Run<bool>("", "Test", "ShlI1", a << b, a, b));
		}

		[Row(-42, 48)]
		[Row(17, 1)]
		[Row(0, 0)]
		[Row(sbyte.MinValue, sbyte.MaxValue)]
		[Test, Author("boddlnagg", "kpreisert@googlemail.com")]
		public void ShlConstantI1Right(sbyte a, sbyte b)
		{
			CodeSource = CreateConstantTestCode("ShlConstantI1Right", "sbyte", "int", null, b.ToString());
			Assert.IsTrue(Run<bool>("", "Test", "ShlConstantI1Right", (a << b), a));
		}

		[Row(-42, 48)]
		[Row(17, 1)]
		[Row(0, 0)]
		[Row(sbyte.MinValue, sbyte.MaxValue)]
		[Test, Author("boddlnagg", "kpreisert@googlemail.com")]
		public void ShlConstantI1Left(sbyte a, sbyte b)
		{
			CodeSource = CreateConstantTestCode("ShlConstantI1Left", "sbyte", "int", a.ToString(), null);
			Assert.IsTrue(Run<bool>("", "Test", "ShlConstantI1Left", (a << b), b));
		}
		#endregion

		#region I2
		
		[Row(1, 2)]
		[Row(23, 21)]
		// And reverse
		[Row(2, 1)]
		[Row(21, 23)]
		// (MinValue, X) Cases
		[Row(short.MinValue, 0)]
		[Row(short.MinValue, 1)]
		[Row(short.MinValue, 17)]
		[Row(short.MinValue, 123)]
		// (MaxValue, X) Cases
		[Row(short.MaxValue, 0)]
		[Row(short.MaxValue, 1)]
		[Row(short.MaxValue, 17)]
		[Row(short.MaxValue, 123)]
		// (X, MinValue) Cases
		[Row(0, short.MinValue)]
		[Row(1, short.MinValue)]
		[Row(17, short.MinValue)]
		[Row(123, short.MinValue)]
		// (X, MaxValue) Cases
		[Row(0, short.MaxValue)]
		[Row(1, short.MaxValue)]
		[Row(17, short.MaxValue)]
		[Row(123, short.MaxValue)]
		// Extremvaluecases
		[Row(short.MinValue, short.MaxValue)]
		[Row(short.MaxValue, short.MinValue)]
		[Test, Author("alyman", "mail.alex.lyman@gmail.com")]
		public void ShlI2(short a, short b)
		{
			CodeSource = CreateTestCode("ShlI2", "short", "int");
			Assert.IsTrue(Run<bool>("", "Test", "ShlI2", (a << b), a, b));
		}

		[Row(-23, 148)]
		[Row(17, 1)]
		[Row(0, 0)]
		[Row(short.MinValue, short.MaxValue)]
		[Test, Author("boddlnagg", "kpreisert@googlemail.com")]
		public void ShlConstantI2Right(short a, short b)
		{
			CodeSource = CreateConstantTestCode("ShlConstantI2Right", "short", "int", null, b.ToString());
			Assert.IsTrue(Run<bool>("", "Test", "ShlConstantI2Right", (a << b), a));
		}

		[Row(-23, 148)]
		[Row(17, 1)]
		[Row(0, 0)]
		[Row(short.MinValue, short.MaxValue)]
		[Test, Author("boddlnagg", "kpreisert@googlemail.com")]
		public void ShlConstantI2Left(short a, short b)
		{
			CodeSource = CreateConstantTestCode("ShlConstantI2Left", "short", "int", a.ToString(), null);
			Assert.IsTrue(Run<bool>("", "Test", "ShlConstantI2Left", (a << b), b));
		}
		#endregion

		#region I4
	
		[Row(1, 2)]
		[Row(23, 21)]
		// And reverse
		[Row(2, 1)]
		[Row(21, 23)]
		// (MinValue, X) Cases
		[Row(int.MinValue, 0)]
		[Row(int.MinValue, 1)]
		[Row(int.MinValue, 17)]
		[Row(int.MinValue, 123)]
		// (MaxValue, X) Cases
		[Row(int.MaxValue, 0)]
		[Row(int.MaxValue, 1)]
		[Row(int.MaxValue, 17)]
		[Row(int.MaxValue, 123)]
		// (X, MinValue) Cases
		[Row(0, int.MinValue)]
		[Row(1, int.MinValue)]
		[Row(17, int.MinValue)]
		[Row(123, int.MinValue)]
		// (X, MaxValue) Cases
		[Row(0, int.MaxValue)]
		[Row(1, int.MaxValue)]
		[Row(17, int.MaxValue)]
		[Row(123, int.MaxValue)]
		// Extremvaluecases
		[Row(int.MinValue, int.MaxValue)]
		[Row(int.MaxValue, int.MinValue)]
		[Test, Author("alyman", "mail.alex.lyman@gmail.com")]
		public void ShlI4(int a, int b)
		{
			CodeSource = CreateTestCode("ShlI4", "int", "int");
			Assert.IsTrue(Run<bool>("", "Test", "ShlI4", (a << b), a, b));
		}

		[Row(-23, 148)]
		[Row(17, 1)]
		[Row(0, 0)]
		[Row(int.MinValue, int.MaxValue)]
		[Test, Author("boddlnagg", "kpreisert@googlemail.com")]
		public void ShlConstantI4Right(int a, int b)
		{
			CodeSource = CreateConstantTestCode("ShlConstantI4Right", "int", "int", null, b.ToString());
			Assert.IsTrue(Run<bool>("", "Test", "ShlConstantI4Right", (a << b), a));
		}

		[Row(-23, 148)]
		[Row(17, 1)]
		[Row(0, 0)]
		[Row(int.MinValue, int.MaxValue)]
		[Test, Author("boddlnagg", "kpreisert@googlemail.com")]
		public void ShlConstantI4Left(int a, int b)
		{
			CodeSource = CreateConstantTestCode("ShlConstantI4Left", "int", "int", a.ToString(), null);
			Assert.IsTrue(Run<bool>("", "Test", "ShlConstantI4Left", (a << b), b));
		}
		#endregion

		#region I8
	
		[Row(1, 1)]
		[Row(1, 0)]
		[Row(0, 1)]
		[Row(unchecked((long)0x8000000000000000), 64)]
		[Test, Author("alyman", "mail.alex.lyman@gmail.com")]
		public void ShlI8(long a, int b)
		{
			CodeSource = CreateTestCodeWithReturn("ShlI8", "long", "int", "long");
			Assert.AreEqual((a << b), Run<long>("", "Test", "ShlI8", (a << b), a, b));
		}

		[Row(-23, 148)]
		[Row(17, 1)]
		[Row(0, 0)]
		[Row(0, 1)]
		[Test, Author("boddlnagg", "kpreisert@googlemail.com")]
		public void ShlConstantI8Right(long a, int b)
		{
			CodeSource = CreateConstantTestCode("ShlConstantI8Right", "long", "long", null, b.ToString());
			Assert.IsTrue(Run<bool>("", "Test", "ShlConstantI8Right", (a << b), a));
		}

		[Row(-23, 148)]
		[Row(17, 1)]
		[Row(0, 0)]
		[Row(0, 1)]
		[Test, Author("boddlnagg", "kpreisert@googlemail.com")]
		public void ShlConstantI8Left(long a, int b)
		{
			CodeSource = CreateConstantTestCode("ShlConstantI8Left", "int", "long", a.ToString(), null);
			Assert.IsTrue(Run<bool>("", "Test", "ShlConstantI8Left", (a << b), b));
		}
		#endregion
	}
}