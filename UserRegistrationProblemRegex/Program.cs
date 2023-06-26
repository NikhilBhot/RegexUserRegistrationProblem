using System.Text.RegularExpressions;

namespace UserRegistrationProblemRegex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            bool isValidFirstName = ValidateFirstName(firstName);

            if (isValidFirstName)
            {
                Console.WriteLine("Valid first name.");
            }
            else
            {
                Console.WriteLine("Invalid first name. First name should start with a capital letter and have a minimum of 3 characters.");
            }

            Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            bool isValidLastName = ValidateLastName(lastName);

            if (isValidLastName)
            {
                Console.WriteLine("Valid last name.");
            }
            else
            {
                Console.WriteLine("Invalid last name. Last name should start with a capital letter and have a minimum of 3 characters.");
            }

            Console.ReadLine();

            Console.WriteLine("Enter your email address:");
            string email = Console.ReadLine();

            bool isValidEmail = ValidateEmail(email);

            if (isValidEmail)
            {
                Console.WriteLine("Valid email address.");
            }
            else
            {
                Console.WriteLine("Invalid email address. Email should have 3 mandatory parts (abc, bl & co) and 2 optional parts (xyz & in) with precise @ and . positions.");
            }

            Console.ReadLine();

            Console.WriteLine("Enter your mobile number:");
            string mobileNumber = Console.ReadLine();

            bool isValidMobileNumber = ValidateMobileNumber(mobileNumber);

            if (isValidMobileNumber)
            {
                Console.WriteLine("Valid mobile number.");
            }
            else
            {
                Console.WriteLine("Invalid mobile number. Mobile number should follow the format: Country code followed by a space and a 10-digit number.");
            }

            Console.ReadLine();

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            bool isValidPassword = ValidatePassword(password);

            if (isValidPassword)
            {
                Console.WriteLine("Valid password.");
            }
            else
            {
                Console.WriteLine("Invalid password. The password must meet the following criteria:\n" +
                    "1. Minimum 8 characters\n" +
                    "2. Should have at least 1 uppercase letter\n" +
                    "3. Should have at least 1 numeric digit\n" +
                    "4. Should have exactly 1 special character");
            }

            Console.ReadLine();

        }
    


    /*As a User need to enter a valid FirstName
       - First name starts with Cap and has minimum 3 characters
     */
    static bool ValidateFirstName(string firstName)
    {
        string pattern = "^[A-Z][a-zA-Z]{2,}$";
        return Regex.IsMatch(firstName, pattern);
    }

        /*As a User need to enter a valid Last Name - Last name starts with Cap and has minimum 3 characters
         */
    static bool ValidateLastName(string lastName)
    {
        string pattern = "^[A-Z][a-zA-Z]{2,}$";
        return Regex.IsMatch(lastName, pattern);
    }
        /*As a User need to enter a valid email
            - E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional (xyz & in) with
                precise @ and . positions
         */
        static bool ValidateEmail(string email)
    {
         string pattern = @"^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(\.[a-zA-Z]{2,}){1,2}$";
         return Regex.IsMatch(email, pattern);
    }

        /*As a User need to follow pre -defined Mobile Format - E.g. 91 9919819801 - Country code 
         follow by space and 10 digit number
         */
        static bool ValidateMobileNumber(string mobileNumber)
        {
            if (mobileNumber.Length != 12 || !mobileNumber.StartsWith("91 ") || !long.TryParse(mobileNumber.Substring(3), out _))
            {
                return false;
            }

            return true;
        }
        static bool ValidatePassword(string password)
        {
            bool isLengthValid = password.Length >= 8;
            bool hasUppercase = false;
            bool hasNumericDigit = false;
            bool hasSpecialCharacter = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUppercase = true;
                }
                else if (char.IsDigit(c))
                {
                    hasNumericDigit = true;
                }
                else if (char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    hasSpecialCharacter = true;
                }
            }

            return isLengthValid && hasUppercase && hasNumericDigit && hasSpecialCharacter;
        }
    }
}
