using System;
using System.Collections.Generic;

namespace ActivityE1
{
    class Date
    {
        
        private Dictionary<int, int> daysInAMonth = new Dictionary<int, int>(){ 
            {1,31},{2,28},{3,31},{4,30},{5,31},{6,30},{7,31},{8,31},{9,30},{10,31},{11,30},{12,31}    
        };
        public int Day {get; set;}
        public int Month {get; set;}
        public int Year {get; set;}

        public Date()
        {

        }
        public int DaysOfTheMonth(int month)
        {
            return daysInAMonth[month];
        }
        public bool LeapYear(int year)
        {
            bool isLeapYear = false;
            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        isLeapYear = true;
                        return isLeapYear;
                    }
                }
                else
                {
                    isLeapYear = true;
                    return isLeapYear;
                }
            }
            return isLeapYear;
        }

    }
}