using System;
using System.Collections.Generic;
using System.Linq;

namespace DateScanner
{
    class DateContainer
    {
        public List<Date> ListOfDates;

        public DateContainer()
        {
            ListOfDates = new List<Date>();
        }

        public void Add(Date date)
        {
            ListOfDates.Add(date);
        }

        public void Display()
        {
            SetDatesInProperOrder();
            Console.WriteLine(ProperString());
        }

        public string ProperString()
        {
            if (ListOfDates[0].Year != ListOfDates[1].Year)
            {
                return ListOfDates[0].Day + '.' + ListOfDates[0].Month + '.'
                    + ListOfDates[0].Year + " - " + ListOfDates[1].Day +
                    '.' + ListOfDates[1].Month + '.' + ListOfDates[1].Year;
            }

            if (ListOfDates[0].Month != ListOfDates[1].Month)
            {
                return ListOfDates[0].Day + '.' + ListOfDates[0].Month + " - "
                    + ListOfDates[1].Day + '.' + ListOfDates[1].Month + '.' +
                    ListOfDates[1].Year;
            }

            if (ListOfDates[0].Day != ListOfDates[1].Day)
            {
                return ListOfDates[0].Day + " - " + ListOfDates[1].Day + '.' +
                    ListOfDates[1].Month + '.' + ListOfDates[1].Year;
            }

            return ListOfDates[0].Day + '.' + ListOfDates[0].Month + '.' + ListOfDates[0].Year;

        }

        //Dates must be display in proper order(chronology)
        public void SetDatesInProperOrder()
        {
            if (ListOfDates[0].Year != ListOfDates[1].Year)
            {
                ListOfDates = ListOfDates.OrderBy(Date => Date.Year).ToList();
                return;
            }

            if (ListOfDates[0].Month != ListOfDates[1].Month)
            {
                ListOfDates = ListOfDates.OrderBy(Date => Date.Month).ToList();
                return;
            }

            if (ListOfDates[0].Day != ListOfDates[1].Day)
            {
                ListOfDates = ListOfDates.OrderBy(Date => Date.Day).ToList();
                return;
            }



        }
    }
}
