using System;

namespace Com.Cognizant.Moviecruiser.Utility
{
    public class DateUtility
    {
        public DateTime ConvertToDate(string inputDate)
        {
            return DateTime.Parse(inputDate);
        }
    }
}