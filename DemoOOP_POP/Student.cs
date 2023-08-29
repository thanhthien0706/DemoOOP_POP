using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP_POP
{
	internal class Student : Person
	{
		public double GPA { get; set; }

		public Student(int id, string name, int age, double gpa)
		{
			Id = id;
			Name = name;
			Age = age;
			GPA = gpa;
		}

		public override void DisplayInfor()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"Student: id:{Id}, name: {Name}, age: {Age}, gpa: {GPA}");
			Console.ResetColor();
		}
	}
}
