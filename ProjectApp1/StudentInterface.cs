using System;


namespace ProjectApp1

{
    interface StudentInterface
    {
        int ID
        {
            get;
            set;
        }

        string FirstName
        {
            get;
            set;
        }

        string MiddleName
        {
            get;
            set;
        }

        string LastName
        {
            get;
            set;
        }

        DateTime DateofBirth
        {
            get;
            set;
        }


        string Class
        {
            get;
            set;
        }

        string Grade
        {
            get;
            set;
        }

        void Display();
    }
}
