using System;

public class LeapYear
{
    int year;
    public void findLeapYear()
    {

        Console.WriteLine("Enter Four Digit Number:");

        year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("{0} is a Leap Year", year);
        }
        else
        {
            Console.WriteLine("{0} is not Leap Year", year);
        }

    }
}