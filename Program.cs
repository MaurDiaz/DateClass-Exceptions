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
                        throw new InvalidDateException("year");
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

            do{
                try
                {
                    Console.WriteLine("Enter a month:");
                    month = int.Parse(Console.ReadLine());
                    if(month < 1 || month > 12 )
                    {
                        throw new InvalidDateException("month");
                    }
                    date.Month = month;
                    hasRightFormat = true;
                }
                catch(InvalidDateException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Month must be between 1 and 12. Please try again.");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }while(!hasRightFormat);

            hasRightFormat = false;

            do{
                try
                {
                    Console.WriteLine("Enter a day:");
                    day = int.Parse(Console.ReadLine());
                    
                    if(date.LeapYear(date.Year) == true && date.Month == 2)
                    {
                        if(day < 1 || day > 29)
                        {
                            throw new InvalidDateException("day");
                        }
                    }
                    else if(day < 1 || day > date.DaysOfTheMonth(date.Month))
                    {
                        throw new InvalidDateException("day");
                    }
                    date.Day = day;
                    hasRightFormat = true;
                }
                catch(InvalidDateException e)
                {
                    Console.WriteLine(e.Message);
                    if(date.LeapYear(date.Year) == true && date.Month == 2)
                    {
                        Console.WriteLine($"Day must be between 1 and 29. Please try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Day must be between 1 and {date.DaysOfTheMonth(date.Month)}. Please try again.");
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }while(!hasRightFormat);
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
