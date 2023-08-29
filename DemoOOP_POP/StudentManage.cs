using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP_POP
{
	internal class StudentManage
	{
		private List<Student> students;

		public StudentManage()
		{
			students = new List<Student>();
		}

		private Student InputStudent()
		{
			Console.WriteLine("Enter infor student:");
			Console.Write("Enter Id: ");
			int id = int.Parse(Console.ReadLine() ?? "");
			Console.Write("Enter Name: ");
			string name = Console.ReadLine() ?? "";
			Console.Write("Enter Age: ");
			int age = int.Parse(Console.ReadLine() ?? "");
			Console.Write("Enter GPA: ");
			double gpa = double.Parse(Console.ReadLine() ?? "");
			return new Student(id, name, age, gpa);
		}

		public void AddStudent()
		{
			students.Add(InputStudent());
			Console.WriteLine("Add Student Successfully!");
		}

		public void SearchStudent(int id)
		{
			var st = students.FirstOrDefault(st => st.Id == id);

			if (st == null)
			{
				Console.WriteLine("Student not exist");
				return;
			}

			st.DisplayInfor();
		}

		public void DeleteStudent(int id)
		{
			var st = students.FirstOrDefault(st => st.Id == id);

			if (st == null)
			{
				Console.WriteLine("Student not exist");
				return;
			}

			students.Remove(st);
			Console.WriteLine($"Delete Student {st.Id} successfully!!!!");
			st.DisplayInfor();
		}
	}
}
