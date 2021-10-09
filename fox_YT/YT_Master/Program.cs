using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using YT_Master.v2.Factory;

namespace YT_Master
{
    class Program
    {
        static void Main(string[] args)
        {
            //rec_funck();
            start();
            Console.WriteLine("\n\n---Waiting For [Enter] To Break---\n\n");
            Console.ReadLine();
        }
        static void start()
        {
            new ManagerFactoryYoutube().StartWatchingVideo();
            Console.ReadLine();
        }




















        /*
        static void rec_funck()
        {
            try
            {
                Console.WriteLine("\n\n---Here we are again xD---\n\n");

                Task.Factory.StartNew(() => new SlaveLink().Watch());
                Task.Factory.StartNew(() => new SlaveList().Watch());
            }
            catch (Exception exx)
            {
                Console.WriteLine("*\n*\n*\n*\n*\n");
                Console.WriteLine("Error: "+exx.Message);
                Console.WriteLine("*\n*\n*\n*\n*\n");
                kill_firefox();
                rec_funck();
            }
        }
        static void kill_firefox()
        {
            Process[] AllProcesses = Process.GetProcesses();
            foreach (var process in AllProcesses)
            {
                if (process.MainWindowTitle != "")
                {
                    string s = process.ProcessName.ToLower();
                    if (s == "firefox")                                                //  s == "iexplore" || s == "iexplorer" || s == "chrome" ||
                        process.Kill();
                }
            }
        }
        */
    }
}
