using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = "Hello World";
			object obj = str;

			var strList = new List<string> { "Monday", "Tuesday" };

			//List<object> objList = (List<object>)strList; //As far as compiler is concerned they are different types

			IEnumerable<object> objEnum = strList;
		}
	}
}
