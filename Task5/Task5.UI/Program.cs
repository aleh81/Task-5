using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.BLL.Services;

namespace Task5.UI
{
	class Program
	{
		static void Main(string[] args)
		{
			var polynomA = new Polynomial(new double[] { 3, 4 });
			var polynomB = new Polynomial(new double[] { 3, 3 });
			var result = polynomA + polynomB;

			Console.WriteLine(result);

			Console.ReadKey();
		}
	}
}
