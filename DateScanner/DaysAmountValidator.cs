using System;

namespace DateScanner
{
    public class DaysAmountValidator
    {
        public int MaxNumberOfDays { get; set; }
        public int Year { get; set; }

        public DaysAmountValidator(string year) 
        {
            Year = int.Parse(year);
        }

        public bool EstimateNumberOfDays(int Month)
        {
            switch (Month)
            {
                case 1:
                    MaxNumberOfDays = 31;
                    break;

                case 2:
                    if (Year % 4 == 0) MaxNumberOfDays = 29;
                    else MaxNumberOfDays = 28;
                    break;

                case 3:
                    MaxNumberOfDays = 31;
                    break;

                case 4:
                    MaxNumberOfDays = 30;
                    break;

                case 5:
                    MaxNumberOfDays = 31;
                    break;

                case 6:
                    MaxNumberOfDays = 30;
                    break;

                case 7:
                    MaxNumberOfDays = 31;
                    break;

                case 8:
                    MaxNumberOfDays = 31;
                    break;

                case 9:
                    MaxNumberOfDays = 30;
                    break;

                case 10:
                    MaxNumberOfDays = 31;
                    break;

                case 11:
                    MaxNumberOfDays = 30;
                    break;

                case 12:
                    MaxNumberOfDays = 31;
                    break;

                default: throw new Exception("Something went wrong");
            }

            return true;
        }
    }
}
