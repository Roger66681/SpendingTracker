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
            
        }
    }
    
}

