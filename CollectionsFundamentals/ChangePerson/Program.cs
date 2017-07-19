﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePerson
{
	class Program
	{
		static void Main(string[] args)
		{
			Person[] people = new Person[] {
				new Person { Name = "Bill", Age = 7 },
				new Person { Name = "Ben", Age = 8 }
			};

			foreach(Person person in people)
			{
				person.Age = 20;
				Console.WriteLine(person);
			}
		}

		public class Person
		{
			public string Name { get; set; }
			public int Age { get; set; }

			public override string ToString()
			{
				return string.Format($"{Name}, {Age} years old.");
			}
		}
	}
}
