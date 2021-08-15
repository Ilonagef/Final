using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;





namespace CshConsoleAPI
{
	public class CStrTrim
	{
		/***
		* Trim left white spaces by replasing with empty string.
		*/
		public static string ltrim(in string s)
		{
			return Regex.Replace(s, "^\\s+", "");
		}

		/***
		* Trim righ white spaces by replasing with empty string.
		*/
		public static string rtrim(in string s)
		{
			return	Regex.Replace(s, "\\s+$", "");
		}

		/***
		* Trim left and right using trim functions.
		*/
		public static string trim(in string s)
		{
			return ltrim(rtrim(s));
		}
	}
}
