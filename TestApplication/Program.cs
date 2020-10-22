using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace TestApplication {
	class Program {
		static void Main(string[] args) {
			var num = "123";
			int hold;

			Console.WriteLine(TestApplicationLibrary.Math.ConvertToInt(num, out hold));
			Console.WriteLine(hold);
			num = "1234";
			var chicken = TestApplicationLibrary.Math.ConvertToInt(num, out hold) ? 100 : 0;
			Console.WriteLine(chicken);
			var kirby = new Dictionary<int,string> {[1] ="A"};
			kirby.Add(2, "fast");
			Console.WriteLine(kirby[1]);

		}
	}
}
