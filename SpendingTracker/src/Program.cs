using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Diagnostics;
using System.Windows;
using System.Collections.Generic;

namespace SpendingTracker
{
    class program
    {
        static void Main(string[] args)
        {
            //Console.Clear();
            SpendingTracker.UIMenus MM = new UIMenus();
            MM.mainMenu();


            //Console.WriteLine($"The lowest transaction is ${stats.Low:N2}");
            //Console.WriteLine($"The highest transaction is ${stats.High:N2}");
            //Console.WriteLine($"The average transaction is ${stats.Average:N2}");
            //Console.WriteLine($"The Total of the transactions is ${stats.Total:N2}");
            //M.ForEach(Console.WriteLine);

        }
    }
    
}

