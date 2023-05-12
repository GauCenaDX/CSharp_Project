
using System;

namespace DemoLibrary
{
    //internal class DataAccess
    //{
    //    internal string GetConnectionString()
    //    {
	//		  return "Sensitive data";
	//	  }
	//}

    public class DataAccess
    {
        protected internal string GetConnectionString()
        {
            return "Sensitive data";
        }
    }

    public class Person
	{
		//private string formerLastName = "";
		protected string formerLastName = "";
		private protected string nickName = "PrivateProtected";

        public string FirstName { get; set; }
		public string LastName { get; private set; }

		private string _ssn;

		public string SSN
		{
			get
			{
				return $"xxx-xx-{_ssn.Substring(_ssn.Length - 4)}";
			}

			set
			{
				_ssn = value;
			}
		}

		public void ChangeLastName(string newLastName)
		{
			formerLastName = LastName;
			LastName = newLastName;
		}

		public void SayHello()
		{
			Console.WriteLine($"Hello {FirstName}");
		}

		public void SavePerson()
		{
			DataAccess data = new DataAccess();
			string conn = data.GetConnectionString();
			// Saves a person
		}
	}

	public class Employee : Person
	{
		public string GetFormerLastName()
		{
			return formerLastName;
		}

		public string GetNickName()
		{
			return nickName;
		}
	}

	public class Manager : Employee
	{
		public string GetAllNames()
		{
			return $"{FirstName}, {LastName}, {formerLastName}";
		}
	}
}

