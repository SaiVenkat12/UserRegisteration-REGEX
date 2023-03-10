using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("User Registration Using Regular Expression");
            string[] email = new string[] { "abc.xyz@bl.co.in", "abc-100@yahoo.com,", "abc.100@yahoo.com", "abc@100yahoo.com", "abc@gmail.com.com", "abc.100@abc.com.au", "ABC1@APPLE.com,", "asc@kd@.com", "bc@gmail.com,in", "abc-100@.com,", "abc@gmail.com.", "abc@%*.com", "abc..nn@gmail.com.", "abc@%*.com", "abc@gmail.com.1a" };
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("\nChoose \n1.First Name \n2.Last Name \n3.Email \n4.Check Multiple Emails \n5.Mobile Number \n6.Password \n22.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the First Name :");
                        string fName = Console.ReadLine();
                        ValidatingUser.FName(fName);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Lastt Name :");
                        string lName = Console.ReadLine();
                        ValidatingUser.LName(lName);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Email Name :");
                        string eMail = Console.ReadLine();
                        ValidatingUser.Email(eMail);
                        break;
                    case 4:
                        foreach (string s in email)
                        {
                            Console.Write("\n" + s + " -");
                            Console.WriteLine(ValidatingUser.Email(s));
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter the Mobile Number :");
                        string number = Console.ReadLine();
                        ValidatingUser.MobileNumber(number);
                        break;
                    case 6:
                        Console.WriteLine("Enter the Password :");
                        string password = Console.ReadLine();
                        ValidatingUser.Password(password);
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
