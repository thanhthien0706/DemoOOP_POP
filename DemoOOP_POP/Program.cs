using DemoOOP_POP;

int choice;

StudentManage studentManage = new StudentManage();

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
				studentManage.AddStudent();
				break;
			case 2:
				Console.WriteLine("Enter Id student need delete: ");
				var id = int.Parse(Console.ReadLine() ?? "");
				studentManage.DeleteStudent(id);
				break;
			case 3:
				Console.WriteLine("Enter Id student need find: ");
				var id1 = int.Parse(Console.ReadLine() ?? "");
				studentManage.SearchStudent(id1);
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