using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Using Regular Expression");
            string[] email = new string[] { "abc.xyz@bl.co.in", "abc-100@yahoo.com,", "abc.100@yahoo.com", "abc@100yahoo.com", "abc@gmail.com.com", "abc.100@abc.com.au", "ABC1@APPLE.com,", "asc@kd@.com", "bc@gmail.com,in", "abc-100@.com,", "abc@gmail.com.", };
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("\n1.First Name \n2.Last Name \n3.Email  \n22.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ValidatingUser.FName();
                        break;
                    case 2:
                        ValidatingUser.LName();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Email Name :");
                        string eMail = Console.ReadLine();
                        ValidatingUser.Email(eMail);
                        break;
                    case 22:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct number ! ");
                        break;
                }
            }
        }
    }
}
