using System;
using System.Collections.Generic;
using System.Text;

namespace lab_8_2
{
    class DateIndexer
    {

        public DateTime newDate;

        public DateIndexer() { }

        public DateIndexer(int day, int month, int year)
        {
            newDate = new DateTime(year, month, day);
        }

        public DateTime this[int index]
        {
            get
            {
                return newDate.AddDays(index);
            }
            set
            {
                newDate = value;
            }
        }
    }

}

