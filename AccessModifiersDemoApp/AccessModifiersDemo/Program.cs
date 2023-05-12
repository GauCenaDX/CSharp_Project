
using System;
using DemoLibrary;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            // Only have access to
            person.FirstName = "Zoro";
            person.SayHello();
            person.SSN = "123456789";
            Console.WriteLine(person.SSN);

            // Only way to change this person last name
            person.ChangeLastName("Luffy");
            Console.WriteLine($"This person last name is {person.LastName} now.");


            // Employee inherited from Person, Manager inherited from Employee.
            // Both Employee and Manager have access to Protected entity in Person.
            Employee employee = new Employee();
            Manager manager = new Manager();

            employee.FirstName = "John";
            employee.ChangeLastName("Doe");
            manager.FirstName = "Mama";
            manager.ChangeLastName("Mamma");
            Console.WriteLine();
            Console.WriteLine($"Former last name: {employee.GetFormerLastName()}");
            Console.WriteLine($"All names: {manager.GetAllNames()}");


            //DataAccess data = new DataAccess();
            //Console.WriteLine();
            //Console.WriteLine(data.GetConnectionString());
            person.SavePerson();


            Console.WriteLine();
            Console.WriteLine("End of Program. Hit Enter to exit.");
            Console.ReadLine();
        }
    }

    public class ModifiedDataAccess : DataAccess
    {
        public void GetUnsecureConnectionInfo()
        {
            GetConnectionString();
        }
    }

    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            // Inaccessible due to its protection level
            //DataAccess data = new DataAccess();
            //string conn = data.GetConnectionString();

            formerLastName = "Origin";


            ModifiedDataAccess data = new ModifiedDataAccess();
            data.GetUnsecureConnectionInfo();

            // No direct access to nickName
            GetNickName();
        }
    }
}
