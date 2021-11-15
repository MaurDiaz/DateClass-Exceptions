using System;

namespace ActivityE1
{
    class InvalidDateException : Exception
    {
        public InvalidDateException()
        {

        }
        public InvalidDateException(int date):base(String.Format($"Invalid {date} format"))
        {

        }
    }

}