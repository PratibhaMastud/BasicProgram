using System;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1.Sum Of Two\n 2. powerOfTwo\n 3.Leap Year");

                Console.WriteLine("Enter your choice:");

                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        SumOfNum sumNum = new SumOfNum();
                        sumNum.sumOfTwo();
                        break;
                    case 2:
                         PowerOfTwo powerTwo = new PowerOfTwo();
                         powerTwo.powerOfTwo();
                         break;
                    case 3:
                        LeapYear leap = new LeapYear();                     
                        leap.findLeapYear();
                        break;
                    default:
                        Console.WriteLine("Invalid option..");
                        break;
                }
            
           
         }
  
       
        
    }
}
    