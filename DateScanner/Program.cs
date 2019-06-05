using DateScanner.Exceptions;
using System;

namespace DateScanner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] Arguments = input.Split(' ');

            try
            {
                if(InputValidator.CheckAmountOfArguments(Arguments.Length)==false)
                {
                    throw new BadAmountOfArgException("Invalid amount of arguments");
                }
            }
            catch (BadAmountOfArgException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }

            DateManager dateManager = new DateManager(Arguments);
            Console.Read();
        }
    }
}
