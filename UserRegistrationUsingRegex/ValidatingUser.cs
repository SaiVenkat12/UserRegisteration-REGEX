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
            string Pattren = "^[a-zA-Z0-9]([.+-_]{0,1}[a-zA-z0-9]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,}([.]{0,1}[A-Za-z]{2,}?([.]{0,1}[A-Za-z]{2,}))*[,]{0,1}$";
            string pattren = "^[a-zA-Z0-9]([.+-_]?[a-zA-z0-9])*@[0-9a-zA-Z]+.[a-zA-Z]{2,}([.]{0,1}[A-Za-z]{2,})+([.]{0,1}[A-Za-z]{2,})*[,]?$";
            
            if (Regex.IsMatch(eMail, pattren))
            {
                Console.WriteLine("Email is Valid");
            }
            else
                Console.WriteLine("Email is InValid");
        }
        public static void MobileNumber()
        {
            string pattren = "^[0-9]{2}[ ]*[6-9]{1}[0-9]{9}$";
            Console.WriteLine("Enter the Mobile Number :");
            string number = Console.ReadLine();
            if (Regex.IsMatch(number, pattren))
            {
                Console.WriteLine("Mobile Number is Valid");
            }
            else
                Console.WriteLine("Mobile Number is InValid");
        }
        public static void Password()
        {
            string pattren = "(?=.*[A-Z])[A-za-z0-9]{8,}$";
            Console.WriteLine("Enter the Password :");
            string password = Console.ReadLine();
            if (Regex.IsMatch(password, pattren))
            {
                Console.WriteLine("Password is Valid");
            }
            else
                Console.WriteLine("Password is InValid");
        }
    }
}
