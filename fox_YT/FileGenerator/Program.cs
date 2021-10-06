using System;
using System.Collections.Generic;
using System.IO;

namespace FileGenerator
{
    class Program
    {
        static int average_watch_time = 7*60;
        static void Main(string[] args)
        {
            long sum = 0;

            int x_seconds = average_watch_time;
            List<int> y_watchTime = new List<int>();

            for (int i = 0; i < x_seconds; i++)
            {
                int val = getValueOfBaseFunction(i);
                val = Add_White_Noise_To_Function(val);
                y_watchTime.Add(val);

            }

            using (StreamWriter writer = new StreamWriter(@"..\..\..\..\YT_Master\Files\WatchingTimes.txt"))
            {
                for (int i = 0; i < y_watchTime.Count; i++)
                {
                    writer.WriteLine(y_watchTime[i]);
                    sum += y_watchTime[i];
                }
            }
            Console.WriteLine("Suma Wyswietlen: " + sum);


        }






















        static int power(int x)
        {
            return x * x;
        }
        static int Add_White_Noise_To_Function(int y)
        {
            return y + (new Random().Next(0,5));
        }
        static int getValueOfBaseFunction(int x)
        {
            int correction = 3000;                                          //reduce values for big numbers
            int move_up = 5;                                               //inportant for small variables
            int shift = average_watch_time;
            return power(x-shift) / correction + move_up;
        }
    }
}
