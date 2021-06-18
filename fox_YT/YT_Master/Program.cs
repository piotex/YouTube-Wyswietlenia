using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace YT_Master
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int time_to_live_s = getRandomNumberOfSeconds();
            Console.WriteLine("YT_Master! \nLiving time: " + time_to_live_s.ToString());
            */

            Task.Factory.StartNew(() => new SlaveList().Watch());


            Console.WriteLine("\n\n---Waiting For [Enter] To Break---\n\n");
            Console.ReadLine();
        }












        /*
        static int getRandomNumberOfSeconds()
        {
            int min_time_s = 1 * 60;
            //int max_time_s = 45 * 60;
            int max_time_s = 1 * 60;
            return new Random().Next(min_time_s, max_time_s);
        }
        */
    }
}
