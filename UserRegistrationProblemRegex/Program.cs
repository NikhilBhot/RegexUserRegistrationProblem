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
}
}
