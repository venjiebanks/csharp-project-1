using System;


namespace ProjectApp1

{
    class Student : StudentInterface
    {
        string ClassName;
        public string Class
        {
            get
            {
                return ClassName;
            }

            set
            {
                ClassName = value;
            }
        }

        DateTime dateofBirth;
        public DateTime DateofBirth
        {
            get
            {
                return dateofBirth;
            }

            set
            {
                dateofBirth = value;
            }
        }

        string fName;
        public string FirstName
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
            }
        }

        string mName;
        public string MiddleName
        {
            get
            {
                return mName;
            }

            set
            {
                mName = value;
            }
        }

        string lName;
        public string LastName
        {
            get
            {
                return lName;
            }

            set
            {
                lName = value;
            }
        }

        int id;
        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        string grade;
        public string Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }




        public void Display()
        {
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Middle Name: " + MiddleName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Date of Birth: " + DateofBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine("Class: " + Class);
   

        }
    }
}