using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment03OOP
{
    public class HiringDate : IComparable<HiringDate>
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int CompareTo(HiringDate other)
        {
            DateTime thisDate = new DateTime(Year, Month, Day);
            DateTime otherDate = new DateTime(other.Year, other.Month, other.Day);
            return thisDate.CompareTo(otherDate);
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }
}