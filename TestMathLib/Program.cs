using System;
using TestMathLib;

namespace LibraryTut {
	class Program {
		static void Main(string[] args) {

			var a = 12;
			var b = 3;

			var x1 = MathLib.Add(a,b);
			Console.WriteLine($"{a}+{b} = {x1}");
			var x2 = MathLib.Subtract(a,b);
			Console.WriteLine($"{a}-{b} = {x2}");
			var x3 = MathLib.Multiply(a,b);
			Console.WriteLine($"{a}*{b} = {x3}");
			var x4 = MathLib.Divide(a,b);
			Console.WriteLine($"{a}/{b} = {x4}");
			var x5 = MathLib.Modulo(a,b);
			Console.WriteLine($"{a}%{b} = {x5}");
			var x6 = MathLib.Power(a,b);
			Console.WriteLine($"{a}^{b} = {x6}");

			
			Console.WriteLine($"{a}^{a} = { a.Squared() }");

		}
	}
}


