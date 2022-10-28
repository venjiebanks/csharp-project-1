
using System;
using System.Collections.Generic;

namespace ProjectApp1
{
    class Program
    {
        static Dictionary<int, Student> listDictionary = new Dictionary<int, Student>();
        static void Main(string[] args)
        {
            while (true)
            {
             
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("==========================");
                Console.WriteLine("1) Input a new Student");
                Console.WriteLine("2) List of Students in a Class ");
                Console.WriteLine("3) Search Student by ID");
                Console.WriteLine("4) Exit");
                Console.WriteLine("==========================");
                Console.Write("\nEnter a number: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateStudent();
                        break;
                    case 2:
                        SearchClass();
                        break;
                    case 3:
                        break;
                    case 4:
                        return;
                }
            }
        }

        private static void SearchClass()
        {
            bool found = false;
            Console.Write("\nEnter Class Name: ");
            String search = Console.ReadLine();
            Console.WriteLine("All student of class " + search);
            foreach (Student student in listDictionary.Values)
            {
                if (student.Class.Equals(search))
      
                {
                    Console.WriteLine("==========================");
                    student.Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No students were found!");
            }
        }

  


        // Create a new student
        private static void CreateStudent()
        {
            Student student = new Student();

            //Increment a student ID
            student.ID = listDictionary.Count + 1;


            Console.Write("\nEnter First Name: ");
            student.FirstName = Console.ReadLine();


            Console.Write("Do you have a Middle Name? (y/n): ");
            string mname = Console.ReadLine();
            if (mname == "y" || mname == "Y")
            {
                Console.Write("Enter Middle Name: ");
                student.MiddleName = Console.ReadLine();
            }

            else
            {
                student.MiddleName = "N/A";
            }

            Console.Write("Enter Last Name: ");
            student.LastName = Console.ReadLine();


            while (true)
            {
                Console.Write("Enter Date of Birth (mm/dd/yy): ");
                DateTime dDate;
                try
                {
                    student.DateofBirth = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("The date is not in the correct format!");
                    Console.WriteLine("Please use mm/dd/yy");
                }
            }

          
            Console.Write("Enter Grade: ");
            student.Grade = Console.ReadLine();


            Console.Write("Enter Class: ");
            student.Class = Console.ReadLine();


            listDictionary.Add(student.ID, student);
            Console.WriteLine("Successfully added a student!");

 
            Console.Write("\nDo you want to go back to Main Menu? (y/n)");
            string m = Console.ReadLine();

            if(m == "y" || m == "Y")
            {
                Console.Clear();
            }
            if(m == "n" || m == "N")
            {
                Environment.Exit(0);
            }


        }
    }
}
