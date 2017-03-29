using System;

namespace OutVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Old way of doing this
            string employeeFirstName, employeeLastName, employeeDesignation;
            GetEmployee(out employeeFirstName, out employeeLastName, out employeeDesignation);
            Console.WriteLine("\r\nOld way of doing this");
            Console.WriteLine(employeeFirstName);
            Console.WriteLine(employeeLastName);
            Console.WriteLine(employeeDesignation);

            //New way of doing this
            GetEmployee(out string firstName, out string lastName, out string designation);
            Console.WriteLine("\r\nNew way of doing this");
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(designation);
            Console.ReadLine();

        }

        static void GetEmployee(out string firstName, out string lastName, out string designation)
        {
            firstName = "Jalpesh";
            lastName = "Vadgama";
            designation = "Technical Architect";
        }
    }
}
