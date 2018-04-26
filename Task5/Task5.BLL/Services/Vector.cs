using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public double X { get; set; }
		/// <summary>
		/// Up and down direction
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// North-south direction
		/// </summary>
		public double Z { get; set; }

		/// <summary>
		/// Default constructor
		/// </summary>
		public Vector(): this(0, 0, 0)
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
	}
}
