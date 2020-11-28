using System;

public class PowerOfTwo
{
    public void powerOfTwo()
    {

        int value;

        Console.WriteLine("Enter the Number for finding power of 2");

        value = Convert.ToInt32(Console.ReadLine());

        double powValues = Math.Pow(value, 2);

        Console.WriteLine("{0} root of given number : ", powValues);

    }
}
