using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5.BLL.Services;

namespace Task5.BLLTests.Services
{
	[TestClass()]
	public class PolynomialTests
	{
		[TestMethod()]
		public void Sum_obj_and_obj()
		{
			var polynomA = new Polynomial(new double[]{3, 4 });
			var polynomB = new Polynomial(new double[]{3, 3});

			var expected = new double[] {6, 7};
			var result = polynomA + polynomB;

			Assert.AreEqual(expected[0], result.Elements[0]);
			Assert.AreEqual(expected[1], result.Elements[1]);
		}

		[TestMethod()]
		public void Sum_arr_and_obj()
		{
			var arrA = new double[]{-10, 8};
			var polynomB = new Polynomial(new double[] { 7, 1 });

			var result = arrA + polynomB;
			var expected = new double[] { -3, 9 };

			Assert.AreEqual(expected[0], result.Elements[0]);
			Assert.AreEqual(expected[1], result.Elements[1]);
		}

		[TestMethod()]
		public void Sum_obj_and_arr()
		{
			var polynomA = new Polynomial(new double[] { 5, 5 });
			var arrB = new double[] {11, 0};

			var expected = new double[] { 16, 5 };
			var result = polynomA + arrB;

			Assert.AreEqual(expected[0], result.Elements[0]);
			Assert.AreEqual(expected[1], result.Elements[1]);
		}

		[TestMethod()]
		public void Sub_obj_and_obj()
		{
			var polynomA = new Polynomial(new double[] { 3, 4 });
			var polynomB = new Polynomial(new double[] { 3, 3 });

			var expected = new double[] { 0, 1 };
			var result = polynomA - polynomB;

			Assert.AreEqual(expected[0], result.Elements[0]);
			Assert.AreEqual(expected[1], result.Elements[1]);
		}

		[TestMethod()]
		public void Sub_arr_and_obj()
		{
			var arrA = new double[] { -15, 4 };
			var polynomB = new Polynomial(new double[] { 6, -10 });

			var result = arrA - polynomB;
			var expected = new double[] { -21, 14 };

			Assert.AreEqual(expected[0], result.Elements[0]);
		}

		[TestMethod()]
		public void Sub_obj_and_arr()
		{
			var polynomA = new Polynomial(new double[] { 5, 5 });
			var arrB = new double[] { 11, 3 };

			var expected = new double[] { -6, 2 };
			var result = polynomA - arrB;

			Assert.AreEqual(expected[0], result.Elements[0]);
			Assert.AreEqual(expected[1], result.Elements[1]);
		}

		[TestMethod()]
		public void Mult_obj_and_obj()
		{
			var polynomA = new Polynomial(new double[] { 3, 4 });
			var polynomB = new Polynomial(new double[] { 3, 3 });

			var expected = new double[] { 9, 12 };
			var result = polynomA * polynomB;

			Assert.AreEqual(expected[0], result.Elements[0]);
			Assert.AreEqual(expected[1], result.Elements[1]);
		}

		[TestMethod()]
		public void Mult_arr_and_obj()
		{
			var arrA = new double[] { -15, 4 };
			var polynomB = new Polynomial(new double[] { 6, -10 });

			var result = arrA * polynomB;
			var expected = new double[] { -90, -40};

			Assert.AreEqual(expected[0], result.Elements[0]);
		}

		[TestMethod()]
		public void Mult_obj_and_arr()
		{
			var polynomA = new Polynomial(new double[] { 5, 5 });
			var arrB = new double[] { 11, 3 };

			var expected = new double[] { 55, 15 };
			var result = polynomA * arrB;

			Assert.AreEqual(expected[0], result.Elements[0]);
			Assert.AreEqual(expected[1], result.Elements[1]);
		}
	}
}