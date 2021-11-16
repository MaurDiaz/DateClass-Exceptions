using System;

namespace ActivityE1
{
    class InvalidDateException : Exception
    {
        public InvalidDateException()
        {

        }
        public InvalidDateException(string date):base(String.Format($"Invalid {date} range"))
        {

        }
    }

}