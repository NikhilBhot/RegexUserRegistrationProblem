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
        }


        /*As a User need to enter a valid FirstName
           - First name starts with Cap and has minimum 3 characters
         */
        static bool ValidateFirstName(string firstName)
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(firstName, pattern);
        }
    }
}