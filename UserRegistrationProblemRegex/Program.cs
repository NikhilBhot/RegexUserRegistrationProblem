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
    }
}
