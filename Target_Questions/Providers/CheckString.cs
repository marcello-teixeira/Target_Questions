using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Questions.Providers
{
	public static class CheckString
	{
		public static string StringHasA(this string Text)
		{
			string formattedText = Text.ToLower();
			int count = 0;

			bool resp = formattedText.Contains('a');

			if(resp)
			{
				foreach (var ch in formattedText)
				{
					if (ch == 'a') count++;
				}
			}

			return resp ? $"A letra 'a' pertence a string e aparece {count} vezes" : $"A letra 'a' não pertence a string";
		}
		
	}
}
