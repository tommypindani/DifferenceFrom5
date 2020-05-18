using System;
using System.Linq.Expressions;

namespace DifferenceFrom5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number greater than 0 and less than 5");
            var input = Console.ReadLine();
            try
            {
                var isValidNumber = false;
                var validNumber = 0;
                if (!(isValidNumber = int.TryParse(input, out validNumber)))
                {
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("Enter a number greater than 0 and less than 5");
                    
                }
                else if (validNumber < 0 || validNumber > 5)
                {
                    Console.WriteLine("Number is less than 0 or greater than 5");
                    Console.WriteLine("Enter a number greater than 0 and less than 5");
                    
                }
                else
                {
                    Console.WriteLine(NumberUtility.CalculateDifferenceFrom5(validNumber));
                   
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

    }
}
