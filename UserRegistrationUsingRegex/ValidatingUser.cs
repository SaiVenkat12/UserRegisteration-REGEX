﻿using System;
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
    }
}
