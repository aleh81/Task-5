using System;

namespace Task5.BLL.Services
{
	/// <summary>
	/// Class describing a vector
	/// </summary>
	public class Vector
	{
		/// <summary>
		/// / West - east direction
		/// </summary>
		public double X { get; private set; }
		/// <summary>
		/// Up and down direction
		/// </summary>
		public double Y { get; private set; }
		/// <summary>
		/// North-south direction
		/// </summary>
		public double Z { get; private set; }

		private const string ExeptionVectorInitialized = "ERROR: Vector is not initialized";

		/// <summary>
		/// Default constructor
		/// </summary>
		public Vector() : this(0, 0, 0)
		{
		}

		/// <summary>
		/// Constructor initializing vector
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		public Vector(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}


		/// <summary>
		/// Summation of two vectors
		/// </summary>
		/// <param name="a">First vector</param>
		/// <param name="b">Second vector</param>
		/// <returns>New object or exception</returns>
		public static Vector operator +(Vector a, Vector b) =>
			new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);


		/// <summary>
		/// Difference of two vectors
		/// </summary>
		/// <param name="a">First vector</param>
		/// <param name="b">Second vector</param>
		/// <returns>New object or exception</returns>
		public static Vector operator -(Vector a, Vector b) =>
			 new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

		/// <summary>
		/// Multiplication of two vectors
		/// </summary>
		/// <param name="a">First vector</param>
		/// <param name="b">Second vector</param>
		/// <returns>New object or exception</returns>
		public static Vector operator *(Vector a, Vector b) =>
			new Vector(a.X * b.X, a.Y * b.Y, a.Z * b.Z);

		/// <summary>
		/// Vector multiblied by a scalar
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="scalar"></param>
		/// <returns>New object or exception</returns>
		public static Vector operator *  (Vector vector, int scalar) =>
				new Vector(vector.X * scalar, vector.Y * scalar, vector.Z * scalar);

		/// <summary>
		/// Division of two vectors
		/// </summary>
		/// <param name="a">First vector</param>
		/// <param name="b">Second vector</param>
		/// <returns>New object or exception</returns>
		public static Vector operator /(Vector a, Vector b) =>
			new Vector(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
	}
}
