using System;
using System.Collections.Generic;

namespace DemoOOP_POP
{
	class Program
	{
		static List<int> ids = new List<int>();
		static List<string> names = new List<string>();
		static List<int> ages = new List<int>();
		static List<double> gpas = new List<double>();

		static void InputStudent()
		{
			Console.WriteLine("Enter student information:");
			Console.Write("Enter Id: ");
			int id = int.Parse(Console.ReadLine() ?? "");
			Console.Write("Enter Name: ");
			string name = Console.ReadLine() ?? "";
			Console.Write("Enter Age: ");
			int age = int.Parse(Console.ReadLine() ?? "");
			Console.Write("Enter GPA: ");
			double gpa = double.Parse(Console.ReadLine() ?? "");

			ids.Add(id);
			names.Add(name);
			ages.Add(age);
			gpas.Add(gpa);
		}

		static void AddStudent()
		{
			InputStudent();
			Console.WriteLine("Add Student Successfully!");
		}

		static void SearchStudent(int id)
		{
			int index = ids.IndexOf(id);
			if (index == -1)
			{
				Console.WriteLine("Student not exist");
				return;
			}

			Console.WriteLine($"Student: id:{ids[index]}, name: {names[index]}, age: {ages[index]}, gpa: {gpas[index]}");
		}

		static void DeleteStudent(int id)
		{
			int index = ids.IndexOf(id);
			if (index == -1)
			{
				Console.WriteLine("Student not exist");
				return;
			}

			Console.WriteLine($"Student: id:{ids[index]}, name: {names[index]}, age: {ages[index]}, gpa: {gpas[index]}");
			Console.WriteLine($"Delete Student {ids[index]} successfully!!!!");

			ids.RemoveAt(index);
			names.RemoveAt(index);
			ages.RemoveAt(index);
			gpas.RemoveAt(index);
		}

		static void Main(string[] args)
		{
			int choice;

			do
			{
				try
				{
					Console.WriteLine("Student Manager");
					Console.WriteLine("1. Add Student");
					Console.WriteLine("2. Delete Student");
					Console.WriteLine("3. Search Student");
					Console.WriteLine("4. Exit the program");

					Console.Write("Enter your choice (1-4): ");
					choice = int.Parse(Console.ReadLine() ?? "");

					switch (choice)
					{
						case 1:
							AddStudent();
							break;
						case 2:
							Console.Write("Enter Id student need delete: ");
							int id = int.Parse(Console.ReadLine() ?? "");
							DeleteStudent(id);
							break;
						case 3:
							Console.Write("Enter Id student need find: ");
							int id1 = int.Parse(Console.ReadLine() ?? "");
							SearchStudent(id1);
							break;
						case 4:
							Console.WriteLine("Thanks :)))))");
							return;
						default:
							Console.WriteLine("Invalid selection, please re-enter!");
							break;
					}
				}
				catch (Exception ex)
				{
					choice = 0;
					Console.WriteLine(ex.Message);
				}

				Console.ReadLine();

			} while (choice != 7);
		}
	}
}
