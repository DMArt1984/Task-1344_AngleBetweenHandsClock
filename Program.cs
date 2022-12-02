using System;

namespace Task1344_AngleBetweenHandsClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1344");
            Console.WriteLine(AngleClock(12,30));
            Console.WriteLine(AngleClock(3, 30));
            Console.WriteLine(AngleClock(3, 15));
            Console.ReadKey();
        }

        // 1344. Angle Between Hands of a Clock
        // Given two numbers, hour and minutes, return the smaller angle (in degrees) formed between the hour and the minute hand.
        // Answers within 10-5 of the actual value will be accepted as correct.

        static public double AngleClock(int hour, int minutes)
        {
            double hourAngle = (hour * 30 + minutes * 0.5) % 360;
            double minutesAngle = minutes * 6 % 360;
            double x = Math.Min(Math.Abs(hourAngle - minutesAngle), Math.Abs(minutesAngle - hourAngle));

            if (x > 180)
            {
                x = 360 - x;
            }
            return x;
        }
    }
}
