using System;

namespace LibraryTut {
	public class MathLib {

		// Right click Solution.
		// Add > New Project... > .Net Core Console 
		// Select the top level of the new project
		// Right click > Add > New project refernce
		// Change the name of the namespace 


		public static int Add(int a, int b) {
			return a + b;
		}
		public static int Subtract(int a, int b) {
			return a - b;
		}
		public static int Multiply(int a, int b) {
			return a * b;
		}
		public static int Divide(int a, int b) {
			return a / b;
		}
		public static int Modulo(int a, int b) {
			return a % b;
		}
		public static int Power(int a, int b) {
			var x = (b == 0) ? 1 : a;
			for (var idx = 1; idx < b; idx++) {
				x *= a;
			};
			return x;
		}




	}
}
