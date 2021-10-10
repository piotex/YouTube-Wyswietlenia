using System;
using System.Collections.Generic;
using System.IO;

namespace FileGenerator
{
    class Program
    {
        static int average_watch_time = 7*60;                                           //number of seconds of yt video - need to be edited for different videos
        static void Main(string[] args)
        {
            long sum = 0;
            long sum_time = 0;

            int x_seconds = average_watch_time;
            List<int> y_watchTime = getWatchTime(x_seconds);
            List<int> finalValues = new List<int>();

            for (int i = 0; i < y_watchTime.Count; i++)
            {
                sum += y_watchTime[i];
                for (int j = 0; j < y_watchTime[i]; j++)
                {
                    int time = Add_Corection_To_Function(i);
                    if (time == 0)
                    {
                        time =1;
                    }
                    sum_time += time;
                    finalValues.Add(time);
                }
            }
            Shuffle(ref finalValues);

            using (StreamWriter writer = new StreamWriter(@"..\..\..\..\YT_Master\Files\WatchingTimesSumary.txt"))
            {
                for (int i = 0; i < y_watchTime.Count; i++)
                {
                    writer.WriteLine(y_watchTime[i]);
                }
            }
            using (StreamWriter writer = new StreamWriter(@"..\..\..\..\YT_Master\Files\WatchingTimes.txt"))
            {
                for (int i = 0; i < finalValues.Count; i++)
                {
                    writer.WriteLine(finalValues[i]);
                }
            }
            Console.WriteLine("Czas Wyswietlen: " + sum_time + "[s] = " + sum_time/60 + "[min] = " + sum_time/60/60 + "[h] = " + sum_time/60/60/24 + "[days]");
            Console.WriteLine("Suma Wyswietlen: " + sum);


        }





















        static List<int> getWatchTime(int x)
        {
            List<int> y_watchTime = new List<int>();

            for (int i = 0; i < x; i++)
            {
                int val = getValueOfBaseFunction(i);
                val = Add_White_Noise_To_Function(val);
                y_watchTime.Add(val);
            }
            return y_watchTime;
        }
        static int power(int x)
        {
            return x * x;
        }
        static int Add_White_Noise_To_Function(int y)
        {
            return y + (new Random().Next(0, 5));
        }
        static int Add_Corection_To_Function(int y)
        {
            int minLevelOfCorrection = 10; //[s]
            int maxLevelOfCorrection = 30; //[s]
            return y + new Random().Next(minLevelOfCorrection,maxLevelOfCorrection);
        }
        static int getValueOfBaseFunction(int x)
        {
            int correction = 3000;                                          //reduce values for big numbers
            int move_up = 5;                                               //inportant for small variables
            int shift = average_watch_time;
            return power(x-shift) / correction + move_up;
        }
        public static void Shuffle(ref List<int> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = new Random().Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
