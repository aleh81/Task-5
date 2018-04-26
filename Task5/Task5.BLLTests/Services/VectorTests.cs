using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5.BLL.Services;

namespace Task5.BLLTests.Services
{
	[TestClass()]
	public class VectorTests
	{
		[TestMethod()]
		public void SumOfTwoVectorsTest()
		{
			var vectorA = new Vector(1,3,5);
			var vectorB = new Vector(2,3,1);

			var result = vectorA + vectorB;
			var expected = new Vector(3, 6, 6);

			Assert.AreEqual(expected.X, result.X);
			Assert.AreEqual(expected.Y, result.Y);
			Assert.AreEqual(expected.Z, result.Z);

			//step 2
			try
			{
				var notInitializedVector = new Vector();
				var initializedVector = new Vector(2.5, 8, 1.25);

				var newVector = notInitializedVector + initializedVector;
			}
			catch (Exception e)
			{
				Assert.AreEqual("System.ArgumentException", e.GetType().ToString());
				Assert.AreEqual("ERROR: Vector is not initialized", e.Message);
			}
		}

		[TestMethod()]
		public void DifferenceOfTwoVectorsTest()
		{
			var vectorA = new Vector(7, 2, 9);
			var vectorB = new Vector(2, 3, 1);

			var result = vectorA - vectorB;
			var expected = new Vector(5, -1, 8);

			Assert.AreEqual(expected.X, result.X);
			Assert.AreEqual(expected.Y, result.Y);
			Assert.AreEqual(expected.Z, result.Z);

			//step 2
			try
			{
				var notInitializedVector = new Vector();
				var initializedVector = new Vector(2.5, 8, 1.25);

				var newVector = notInitializedVector - initializedVector;
			}
			catch (Exception e)
			{
				Assert.AreEqual("System.ArgumentException", e.GetType().ToString());
				Assert.AreEqual("ERROR: Vector is not initialized", e.Message);
			}
		}

		[TestMethod()]
		public void MultiplicationOfTwoVectorsTest()
		{
			var vectorA = new Vector(3, 4, 7);
			var vectorB = new Vector(5, 2, 2);

			var result = vectorA * vectorB;
			var expected = new Vector(15, 8, 14);

			Assert.AreEqual(expected.X, result.X);
			Assert.AreEqual(expected.Y, result.Y);
			Assert.AreEqual(expected.Z, result.Z);

			//step 2
			try
			{
				var notInitializedVector = new Vector();
				var initializedVector = new Vector(2.5, 8, 1.25);

				var newVector = notInitializedVector * initializedVector;
			}
			catch (Exception e)
			{
				Assert.AreEqual("System.ArgumentException", e.GetType().ToString());
				Assert.AreEqual("ERROR: Vector is not initialized", e.Message);
			}
		}

		[TestMethod()]
		public void DivisionOfTwoVectorsTest()
		{
			var vectorA = new Vector(12, 4, 21);
			var vectorB = new Vector(6, -2, 7);

			var result = vectorA / vectorB;
			var expected = new Vector(2, -2, 3);

			Assert.AreEqual(expected.X, result.X);
			Assert.AreEqual(expected.Y, result.Y);
			Assert.AreEqual(expected.Z, result.Z);

			//step 2
			try
			{
				var notInitializedVector = new Vector();
				var initializedVector = new Vector(2.5, 8, 1.25);

				var newVector = notInitializedVector / initializedVector;
			}
			catch (Exception e)
			{
				Assert.AreEqual("System.ArgumentException", e.GetType().ToString());
				Assert.AreEqual("ERROR: Vector is not initialized", e.Message);
			}
		}

		[TestMethod()]
		public void VectorMultipliedByScalarTest()
		{
			var vector = new Vector(3, 2, 4);
			var scalar = 3;

			var result = vector * scalar;
			var expected = new Vector(9, 6, 12);

			Assert.AreEqual(expected.X, result.X);
			Assert.AreEqual(expected.Y, result.Y);
			Assert.AreEqual(expected.Z, result.Z);

			//step 2
			try
			{
				var notInitializedVector = new Vector();
				var initializedVector = new Vector(2.5, 8, 1.25);

				var newVector = notInitializedVector * 9;
			}
			catch (Exception e)
			{
				Assert.AreEqual("System.ArgumentException", e.GetType().ToString());
				Assert.AreEqual("ERROR: Vector is not initialized", e.Message);
			}
		}
	}
}