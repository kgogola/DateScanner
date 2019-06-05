using DateScanner.Constants;
using DateScanner.Exceptions;

namespace DateScanner
{
    public static class InputValidator
    {
        //every input should consits of 2 dates
        public static bool CheckAmountOfArguments(int amountOfArguments)
        {
            if (amountOfArguments != 2)
            {
                return false;
            }

            return true;
        }

        //every date should consits of 3 parts(day.month.year)
        public static bool CheckFormatOfDate(string arg)
        {
            string[] datePart = arg.Split('.');
            if (datePart.Length == 3) return true;
            else return false;
        }

        //EVERY PART OF DATE
        //1st - it is possible parse string to int
        //2nd - must be in proper range 
        //(range of days depends on month and year)


        public static bool CheckYear(string potentialYear)
        {
            if (!(int.TryParse(potentialYear, out int year)))
            {
                throw new BadTypeOfDateElementsException();
            }

            if (year < 0 || year > DateDetailsConstants.MaxNumberOfYears)
            {
                throw new DataOutOfRangeException();
            }

            return true;
        }

        public static bool CheckMonth(string potentialMonth)
        {
            if (!(int.TryParse(potentialMonth, out int month)))
            {
                throw new BadTypeOfDateElementsException();
            }

            if (month < 0 || month > DateDetailsConstants.MaxNumberOfMonths)
            {
                throw new DataOutOfRangeException();
            }

            return true;
        }

        public static bool CheckDay(string potentialDay, string potentialMonth, 
            string potentialYear)
        {
            if (!(int.TryParse(potentialDay, out int day)))
            {
                throw new BadTypeOfDateElementsException();
            }

            DaysAmountValidator amountOfDays =
                new DaysAmountValidator(potentialYear);

            amountOfDays.EstimateNumberOfDays(int.Parse(potentialMonth));

            if (day < 0 || day > amountOfDays.MaxNumberOfDays)
            {
                throw new DataOutOfRangeException();
            }

            return true;
        }
    }
}
