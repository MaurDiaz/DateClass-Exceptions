using System;

namespace ActivityE1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasRightFormat = false;
            int year, month, day;
            Date date  = new Date();
            
            do{
                try
                {
                    Console.WriteLine("Enter a year:");
                    year = int.Parse(Console.ReadLine());
                    if(year < 0)
                    {
                        throw new InvalidDateException(year);
                    }
                    date.Year = year;
                    hasRightFormat = true;
                }
                catch(InvalidDateException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Year must be greater than zero. Please try again.");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                } 
            }while(!hasRightFormat);
            
            hasRightFormat = false;
            Console.WriteLine(date.LeapYear(date.Year));

            // do{
            //     try
            //     {
            //         Console.WriteLine("Enter a month:");
            //         month = int.Parse(Console.ReadLine());
            //         if(month < 1 || month > 12 )
            //         {
            //             throw new InvalidDateException(month);
            //         }
            //     }
            //     catch(InvalidDateException e)
            //     {
            //         Console.WriteLine(e.Message);
            //         Console.WriteLine("Month must be between 1 and 12. Please try again.");
            //     }
            //     catch(FormatException)
            //     {
            //         Console.WriteLine("Invalid input. Please try again.");
            //     }
            //     hasRightFormat = true;
            // }while(!hasRightFormat);

            // Console.WriteLine("Enter a month:");
            // month = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter a day:");
            // day = int.Parse(Console.ReadLine());
      //validate whether the date was created correctly and catch an error if not
      //catch any format errors as well
      Console.Read();
        }
    }
}
