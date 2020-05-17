using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Diagnostics;
using System.Windows;
using System.Collections.Generic;

namespace SpendingTracker
{
    public class MonthList
    {
        //Variables
        public string Month;

        //Main List
        public List<List<decimal>> testList;

        //Categories of List
        public List<decimal> Bills;
        public List<decimal> Food;
        public List<decimal> Wants;
        public List<decimal> GasStationSnacks;
        public List<decimal> WorkAVI;
        public List<decimal> Gas;
        public List<decimal> Random;
        

        public MonthList(string month) //Estabilsh and iniialize a new List of lists
        {
            var testList = new List<List<decimal>>();
            Bills = new List<decimal>();
            Food = new List<decimal>();
            Wants = new List<decimal>();
            GasStationSnacks = new List<decimal>();
            WorkAVI = new List<decimal>();
            Gas = new List<decimal>();
            Random = new List<decimal>();
            testList.Add(Bills);
            testList.Add(Food);
            testList.Add(Wants);
            testList.Add(GasStationSnacks);
            testList.Add(WorkAVI);
            testList.Add(Gas);
            testList.Add(Random);
            
            this.Month = month;

            //testList.ForEach(System.Console.WriteLine);
            
            
        }

        public void AddTransaction(decimal transaction) //Adds Transaction item into catogory
        {
            Bills.Add(transaction);
            System.Console.WriteLine(Bills[0]);
            
        }
        

        /*public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0m;
            result.High = decimal.MinValue;
            result.Low = decimal.MaxValue;
            result.Total = 0m;

            foreach(var item in testArray)
            {
                result.Low = Math.Min(item, result.Low);
                result.High = Math.Max(item, result.High);
                result.Average += item;
                result.Total += item;
            }
            result.Average /= testArray.Count;

            return result;
        }*/
    }
}
