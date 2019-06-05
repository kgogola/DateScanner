using DateScanner.Constants;
using DateScanner.Exceptions;
using System;

namespace DateScanner
{
    public class DateAuthentication
    {
        public string PotentialDayField { get; set; }
        public string PotentialMonthField { get; set; }
        public string PotentialYearField { get; set; }
        public string Argument { get; set; }

        public DateAuthentication(string argument)
        {
            Argument = argument;
        }

        public void CheckDate()
        {
            FormatValidation();
            RangeAndTypeValidation();
        }

        public void FormatValidation()
        {
            try
            {
                if (InputValidator.CheckFormatOfDate(Argument) == false)
                    throw new BadDateFormatException();

                string[] datePart = Argument.Split('.');
                PotentialDayField = datePart[0];
                PotentialMonthField = datePart[1];
                PotentialYearField = datePart[2];
            }
            catch (BadDateFormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        public void RangeAndTypeValidation()
        {
            if (InputValidator.CheckYear(PotentialYearField) == false 
                || InputValidator.CheckMonth(PotentialMonthField) == false 
                || InputValidator.CheckDay(PotentialDayField, 
                PotentialMonthField, PotentialYearField) == false)
            {
                throw new Exception("Something went wrong");
            }
        }
    }
}
