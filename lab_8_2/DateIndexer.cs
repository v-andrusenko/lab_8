using System;
using System.Collections.Generic;
using System.Text;

namespace lab_8_2
{
    class DateIndexer
    {
        int day;
        int month;
        int year;
        public DateTime newDate;

        public DateIndexer() { }

        public DateIndexer(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
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

