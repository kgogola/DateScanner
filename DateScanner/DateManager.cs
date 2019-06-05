using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateScanner
{
    public class DateManager
    {
        public DateManager(string [] arguments)
        {
            DateContainer dateContainer = new DateContainer();
            DateAuthentication dateAuthentication;
            Date date;
          
            for(int i = 0; i< arguments.Length; i++)
            {
                dateAuthentication = new DateAuthentication(arguments[i]);
                dateAuthentication.CheckDate();
                date = new Date(arguments[i]);
                dateContainer.Add(date);
            }
            dateContainer.Display();
        }
    }
}
