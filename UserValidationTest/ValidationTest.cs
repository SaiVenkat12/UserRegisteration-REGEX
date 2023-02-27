using UserRegistrationUsingRegex;
namespace UserValidationTest
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        [DataRow("Abcjd", "Happy")]
        [DataRow("RaLL", "Sad")]
        [DataRow(null, "Firstname is invalid")]
        public void Validating_First_Name(string fname,string expected)
        {
            try
            {
                string actual = ValidatingUser.FName(fname);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }

        }
        [TestMethod]
        [DataRow("Abcjd", "Happy")]
        [DataRow("Ra", "Sad")]
        [DataRow(null, "Lastname is invalid")]
        public void Validating_Last_Name(string lname, string expected)
        {
            try
            { 
                string actual = ValidatingUser.LName(lname);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }
        [TestMethod]
        [DataRow("abc.xyz@bl.co.in", "Happy")]
        [DataRow("abc@gmail.com.", "Sad")]
        [DataRow(null, "Email is invalid")]
        public void Validating_Email(string email, string expected)
        {
            try
            {
                string actual = ValidatingUser.Email(email);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }
        [TestMethod]
        [DataRow("91 7888890271", "Happy")]
        [DataRow("91 78888 90271", "Sad")]
        [DataRow(null, "MobileNumber is invalid")]
        public void Validating_MobileNumber(string number, string expected)
        {
            try
            {
                string actual = ValidatingUser.MobileNumber(number);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }
        [TestMethod]
        [DataRow("Abcjd@111", "Happy")]
        [DataRow("Racociocl", "Sad")]
        [DataRow(null, "Password is invalid")]
        public void Validating_Password(string pass, string expected)
        {
            try
            {
                string actual = ValidatingUser.Password(pass);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }
        [TestMethod]
        [DataRow(new string[] { "abc.xyz@bl.co.in", "abc-100@yahoo.com,", "abc.100@yahoo.com", "abc@100yahoo.com", "abc@gmail.com.com", "abc.100@abc.com.au", "ABC1@APPLE.com," }, "Happy")]
        [DataRow(new string[] { "asc@kd@.com", "bc@gmail.com,in", "abc-100@.com,", "abc@gmail.com.", "abc@%*.com", "abc..nn@gmail.com.", "abc@%*.com", "abc@gmail.com.1a" }, "Sad")]
        public void Validating_Mutiple_Email(string[] email, string expected)
        {

            ValidatingUser user = new ValidatingUser();

            foreach (string s in email)
            {
                Console.Write("\n" + s + " -");
                string actual = ValidatingUser.Email(s);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}