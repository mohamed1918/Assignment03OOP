namespace Assignment03OOP
{
    internal class HiringDataBase
    {

        public int CompareTo(HiringDate other)
        {
            DateOnly Year = default;
            TimeOnly Month = default;
            DateTimeKind Day = default;
            DateTime thisDate = new DateTime(Year, Month, Day);
            DateTime otherDate = new DateTime(other.Year, other.Month, other.Day);
            return thisDate.CompareTo(otherDate);
        }
    }
}