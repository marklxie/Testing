using System;
using Lib = TestApplicationLibrary;
using Xunit;

namespace Testing {
	public class UnitTest1 {
		[Theory]
		[InlineData(5,2,3)]
		[InlineData(-5,3,2)]
		[InlineData(0,7,-7)]

		public void TestMathAdd(int exp, int a, int b) {
			//First is expected, the 2nd is actual
			Assert.Equal(exp, Lib.Math.Add(a, b));
		}
		[Theory]
		[InlineData(3,4,1)]
		[InlineData(0, 1, 1)]
		[InlineData(-1, 0, 1)]


		public void TestMathSubtract(int exp, int a, int b) {
			Assert.Equal(exp, Lib.Math.Subtract(a, b));
		}
		[Theory]
		[InlineData(3, 3, 1)]
		[InlineData(1, 1, 1)]
		[InlineData(0, 0, 1)]

		public void TestMathMultiply(int exp, int a, int b) {
			Assert.Equal(exp, Lib.Math.Multiply(a, b));
		}

		[Theory]
		[InlineData(0, 9, 3)]
		[InlineData(1, 5, 2)]
		[InlineData(7, 15, 8)]

		public void TestMathModulo(int exp, int a, int b) {
			Assert.Equal(exp, Lib.Math.Modulo(a, b));
		}

		[Theory]
		[InlineData(7, 0)]
		[InlineData(0, -8)]
		[InlineData(0, 28)]
		[InlineData(1546, 27)]
		[InlineData(84, -7)]

		public void TestMathQuad(int exp, int a) {
			Assert.Equal(exp, Lib.Math.Quadratic(a));
		}
	}
}
