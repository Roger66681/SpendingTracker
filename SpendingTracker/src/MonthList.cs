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
        public List<decimal> Other;
        

        public MonthList() //Estabilsh and iniialize a new List of lists
        {
            var newList = new List<List<decimal>>();
            Bills = new List<decimal>();
            Food = new List<decimal>();
            Wants = new List<decimal>();
            GasStationSnacks = new List<decimal>();
            WorkAVI = new List<decimal>();
            Gas = new List<decimal>();
            Other = new List<decimal>();
            newList.Add(Bills);
            newList.Add(Food);
            newList.Add(Wants);
            newList.Add(GasStationSnacks);
            newList.Add(WorkAVI);
            newList.Add(Gas);
            newList.Add(Other);
        }

        public void AddTransaction(List<decimal> Category, decimal transaction) //Adds Transaction item into catogory
        {
            if(Category == Bills)
            {
                Bills.Add(transaction);
                
            }
            else if(Category == Food)
            {
                Food.Add(transaction);
            }
            else if(Category == Wants)
            {
                Wants.Add(transaction);
            }
            else if(Category == GasStationSnacks)
            {
                GasStationSnacks.Add(transaction);
            }
            else if(Category == WorkAVI)
            {
                WorkAVI.Add(transaction);
            }
            else if(Category == Gas)
            {
                Gas.Add(transaction);
            }
            else if(Category == Other)
            {
                Other.Add(transaction);
            }
            else
            {
                System.Console.WriteLine("----------------------------");
                System.Console.WriteLine("Please Select A Category!");
                System.Console.WriteLine("Press Enter To Continue...");
                System.Console.WriteLine("----------------------------");
                Console.ReadLine();
            }
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
