using System;
using System.Text.RegularExpressions;

namespace PincodeRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Email");
            string emailId = Console.ReadLine();
            Regex reEmail = new Regex(@"^([a-z0-9][a-z0-9+_-]*\.?[a-z0-9]+@([a-z0-9]([a-z0-9-]*[a-z])?\.)([a-z0-9]([a-z0-9-]*[a-z])\.?)([a-z]{2})?)$");
            if (reEmail.IsMatch(emailId))
            {
                Console.WriteLine("Valid Email");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }
    }
}
