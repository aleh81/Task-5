using System;
using System.Text;

namespace Task5.BLL.Services
{
	public class Polynomial
	{
		public double[] Elements { get; private set; }

		public Polynomial(double[] elements)
		{
			Elements = elements;
		}

		private static double[] Sum(double[] argA, double[] argB) =>
			Operate(argA, argB, (a, b) => a + b);

		public static Polynomial operator +(Polynomial a, Polynomial b) =>
		    new Polynomial(Sum(a.Elements, b.Elements));

		public static Polynomial operator +(double[] argA, Polynomial b) =>
			new Polynomial(Sum(argA, b.Elements));

		public static Polynomial operator +(Polynomial a, double[] argB) =>
		    new Polynomial(Sum(a.Elements, argB));

		private static double[] Sub(double[] argA, double[] argB) =>
			Operate(argA, argB, (a, b) => a - b);

		public static Polynomial operator -(Polynomial a, Polynomial b) =>
			new Polynomial(Sub(a.Elements, b.Elements));

		public static Polynomial operator -(double[] argA, Polynomial b) =>
			new Polynomial(Sub(argA, b.Elements));

		public static Polynomial operator -(Polynomial a, double[] argB) =>
		new Polynomial(Sub(a.Elements, argB));

		private static double[] Mul(double[] argA, double[] argB) =>
		    Operate(argA, argB, (a, b) => a * b);

		public static Polynomial operator *(Polynomial a, Polynomial b) =>
		    new Polynomial(Mul(a.Elements, b.Elements));

		public static Polynomial operator *(double[] argA, Polynomial b) =>
		    new Polynomial(Mul(argA, b.Elements));

		public static Polynomial operator *(Polynomial a, double[] argB) =>
		    new Polynomial(Mul(a.Elements, argB));

		private static double[] Operate(double[] a, double[] b, Func<double, double, double> operation)
		{
			if (operation == null || a == null || b == null)
			{
				throw new ArgumentException();
			}

			if (a.Length == 0)
			{
				return b;
			}

			if (b.Length == 0)
			{
				return a;
			}

			double[] result;

			if (a.Length == b.Length)
			{
				result = new double[a.Length];
				for (var i = 0; i < a.Length; i++)
				{
					result[i] = operation(a[i], b[i]);
				}
			}
			else if (a.Length > b.Length)
			{
				result = new double[a.Length];
				Buffer.BlockCopy(a, 0, result, 0, a.Length * sizeof(double));

				for (var i = 0; i < b.Length; i++)
				{
					result[i] = operation(a[i], b[i]);
				}
			}
			else
			{
				result = new double[b.Length];
				Buffer.BlockCopy(b, 0, result, 0, b.Length * sizeof(double));

				for (var i = 0; i < a.Length; i++)
				{
					result[i] = operation(a[i], b[i]);
				}
			}

			return result;
		}

		public override string ToString()
		{
			var result = new StringBuilder();

			for (var i = 0; i < Elements.Length; i++)
			{
				if (Elements[i] != 0)
				{
					result.Append($"{Elements[i]}*X^{i} ");
				}
			}

			return result.ToString();
		}
	}
}
