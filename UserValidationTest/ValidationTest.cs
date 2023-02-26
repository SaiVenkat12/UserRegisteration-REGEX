using UserRegistrationUsingRegex;
namespace UserValidationTest
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        [DataRow("Abcjd", "Happy")]
        [DataRow("Xyc", "Happy")]
        [DataRow("abcjd", "Sad")]
        [DataRow("RaLL", "Sad")]
        public void Validating_First_Name(string fname,string expected)
        {
           
            ValidatingUser user = new ValidatingUser();
            string actual = ValidatingUser.FName(fname);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Abcjd", "Happy")]
        [DataRow("Xyz", "Happy")]
        [DataRow("abcd", "Sad")]
        [DataRow("Ra", "Sad")]
        public void Validating_Last_Name(string lname, string expected)
        {

            ValidatingUser user = new ValidatingUser();
            string actual = ValidatingUser.LName(lname);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("abc.xyz@bl.co.in", "Happy")]
        [DataRow("abc-100@yahoo.com", "Happy")]
        [DataRow("abc@%*.com", "Sad")]
        [DataRow("abc@gmail.com.", "Sad")]
        public void Validating_Email(string email, string expected)
        {

            ValidatingUser user = new ValidatingUser();
            string actual = ValidatingUser.Email(email);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("91 7888890271", "Happy")]
        [DataRow("01 7838890271", "Happy")]
        [DataRow("917888890271", "Sad")]
        [DataRow("91 78888 90271", "Sad")]
        public void Validating_MobileNumber(string number, string expected)
        {

            ValidatingUser user = new ValidatingUser();
            string actual = ValidatingUser.MobileNumber(number);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Abcjd@111", "Happy")]
        [DataRow("Xyz1&uiodLL", "Happy")]
        [DataRow("ab,1lmks", "Sad")]
        [DataRow("Racociocl", "Sad")]
        public void Validating_Password(string pass, string expected)
        {

            ValidatingUser user = new ValidatingUser();
            string actual = ValidatingUser.Password(pass);
            Assert.AreEqual(expected, actual);
        }
    }
}