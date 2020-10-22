using System;
using System.Reflection.Metadata.Ecma335;

namespace TestApplicationLibrary {
	public class Math {
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
			return a - (a / b) * b;
		}
		public static int Squared(int a) {
			return a * a;
		}
		public static int Cubed(int a) {
			return a * a * a;
		}
		public static int Quadratic(int a) {
			if(a >= -7 && a <= 27) {
				return 2 * Squared(a) + 3 * a + 7;
			}
			return 0;
		}
		public static bool ConvertToInt(string num, out int nbr) {
			try {
				nbr = Convert.ToInt32(num);
			}
			catch {
				nbr = 0;
				return false;
			}
			return true;

		}
	}
}
