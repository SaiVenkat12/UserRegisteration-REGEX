using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    public class ValidatingUser
    {
        public static string FName(string fName)
        {
            string pattren = "^[A-Z]{1}[a-z]{2,}$";
            
            if (Regex.IsMatch(fName, pattren))
            {
                return"Happy";
            }
            else
                return "Sad";
        }
        public static string LName(string lName)
        {
            string pattren = "^[A-Z]{1}[a-z]{2,}$";
            
            if (Regex.IsMatch(lName, pattren))
            {
                return "Happy";
            }
            else
                return "Sad";
        }
        public static string Email(string eMail)
        {
            string pattren = "^[a-zA-Z0-9]{1,}[.+-_]?[a-zA-z0-9]{1,}[@]{1}[0-9a-zA-Z]+.[a-zA-Z]{2,}([.]{0,1}[A-Za-z]{2,})+([.]{0,1}[A-Za-z]{2,})*[,]?$";
            if (Regex.IsMatch(eMail, pattren))
            {
                return "Happy";
            }
            else
                return "Sad";
        }
        public static string MobileNumber(string number)
        {
            string pattren = "^[0-9]{2}[ ][6-9]{1}[0-9]{9}$";
            
            if (Regex.IsMatch(number, pattren))
            {
                return "Happy";
            }
            else
                return "Sad";
        }
        public static string Password(string password)
        {
            string pattren = "(?=.*[A-Z])(?=.*[0-9])(?=.*[.,/+_@!#$%&*]{1}).{8,}$";
            if(Regex.IsMatch(password,pattren))
            {
                return "Happy";
            }
            else
                return "Sad";
        }
    }
}
