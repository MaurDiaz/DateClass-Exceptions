Create a class to represent a date and use exceptions to notify users of incorrect use.

  1.Create a class called Date with members for the year, month, and day. The user should be able to get and set the data members, as well as set all members with a single function call.

  2.Make the class throw an appropriate custom exception if the user attempts to set an invalid date. Year should be greater than zero, month should be between 1 and 12, and day depends on the month (don’t forget leap years).
  
  3.Override the class’s ToString method to print the date in the format “<Year>-<Month>-<Day>”.
  4.Bonus: Add a constructor. What happens if the constructor throws an exception? 

  Note: each month has a different amount of days.