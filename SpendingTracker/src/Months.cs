using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Diagnostics;
using System.Windows;
using System.Collections.Generic;

namespace SpendingTracker
{
    public class Months : List<string>
    {
        public string January = "January";
        public string Febuary{get; }
        public string March{get; }
        public string April{get; }
        public string May{get; }
        public string June{get; }
        public string July{get; }
        public string August{get; }
        public string September{get; }
        public string October{get; }
        public string November{get; }
        public string December{get; }
        public void SelectMonth()
        {
            List<Months> CycleList = new List<Months>();
        }
    }



}