using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCovariance
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
			object[] objArr = daysOfWeek;


			foreach (object obj in objArr)
				Console.WriteLine(obj);


		}
	}
}
