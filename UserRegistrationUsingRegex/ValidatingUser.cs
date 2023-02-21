using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    internal class ValidatingUser
    {
        public static void FName()
        {
            string pattren = "^[A-Z]{1}[a-z]{2,}$";
            Console.WriteLine("Enter the First Name :");
            string fName=Console.ReadLine();
            if (Regex.IsMatch(fName, pattren))
            {
                Console.WriteLine("Name is Valid");
            }
            else
                Console.WriteLine("Name is InValid");
        }
        public static void LName()
        {
            string pattren = "^[A-Z]{1}[a-z]{2,}$";
            Console.WriteLine("Enter the First Name :");
            string lName = Console.ReadLine();
            if (Regex.IsMatch(lName, pattren))
            {
                Console.WriteLine("Name is Valid");
            }
            else
                Console.WriteLine("Name is InValid");
        }
        public static void Email(string eMail)
        {
            string Pattren = "^[a-zA-Z0-9]{1,}[.]{0,1}[a-z]{1,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}([.]{0,1}[A-Za-z]{2,})$";
            if (Regex.IsMatch(eMail, Pattren))
            {
                Console.WriteLine("Email is Valid");
            }
            else
                Console.WriteLine("Email is InValid");
        }

    }
}
