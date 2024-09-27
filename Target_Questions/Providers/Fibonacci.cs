using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Questions.Providers
{
	public static class Fibonacci
	{
		public static string IsFibonacciNumber(this int Target)
		{
			List<int> List_Fibonacci = new List<int> { 0, 1 };
			int next_number = 0;
			bool resp = false;

			while (next_number < Target)
			{
				next_number = List_Fibonacci[^1] + List_Fibonacci[^2];
				List_Fibonacci.Add(next_number);
				if (List_Fibonacci.Contains(Target)) resp = true;
			}
			return resp ? $"O número {Target} pertence a sequência de fibonacci" : $"O número {Target} não pertence a sequência de fibonacci";
		}
	}
}
