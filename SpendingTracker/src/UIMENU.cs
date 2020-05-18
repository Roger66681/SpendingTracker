using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Diagnostics;
using System.Windows;
using System.Collections.Generic;

namespace SpendingTracker
{
    class UIMenus
    {
        //Variables
        int userInput = 0;
        int m1 = 1;
        int m2 = 2;
        int m3 = 3;
        int loop = -1;
        
        bool quit = false;
        public void mainMenu()
        { 
            //mainMenuList
            List<string> mainMenuList = new List<string>(){};
            mainMenuList.Add("----------------------------");//0
            mainMenuList.Add("Welcome To SpendingTracker!!");//1
            mainMenuList.Add("         Main Menu          ");//2
            mainMenuList.Add($"{m1}: Create New List:");//3
            mainMenuList.Add($"{m2}: View Saved Lists:");//4
            mainMenuList.Add($"{m3}: Exit:");//5
            mainMenuList.Add("----------------------------");//6

            var M1 = mainMenuList[3];
            var M2 = mainMenuList[4];
            var M3 = mainMenuList[5];

            mainMenuList.ForEach(System.Console.WriteLine);
            
            while(loop < userInput)
            {
                if(!int.TryParse(Console.ReadLine(), out userInput)) //returns false if the user doesn't enter a number
                {
                    Console.Clear();
                    NonValidNum();
                    Console.ReadLine();
                    Console.Clear();
                    mainMenu();
                }
                else if(userInput == m1)
                {
                    Console.Clear();
                    CreateNewList();
                    break;
                }
                else if(userInput == m2)
                {
                    Console.Clear();
                    ViewSavedLists();
                    break;
                }
                else if(userInput == m3)
                {
                    Exit();
                    quit = true;
                    break; //this exits the "while" loop
                }
                if(quit)
                {
                    break;
                }
            }
        }

        public void SubMenu()
        {
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("       :Sub Menu:        ");
            System.Console.WriteLine($"{m1}: Main Menu");
            System.Console.WriteLine($"{m2}: Save File");
            System.Console.WriteLine($"{m3}: Exit");
            System.Console.WriteLine("----------------------------");

            
            while(loop < userInput)
            {

                if(!int.TryParse(Console.ReadLine(), out userInput)) //returns false if the user doesn't enter a number
                {
                    Console.Clear();
                    NonValidNum();
                    Console.ReadLine();
                    Console.Clear();
                    SubMenu();
                }
                else if(userInput == m1)
                {
                    Console.Clear();
                    mainMenu();
                    break;
                }
                else if(userInput == m2)
                {
                    Console.Clear();
                    SaveFile();
                    break;
                }
                else if(userInput == m3)
                {
                    Exit();
                    quit = true;
                    break; //this exits the "while" loop
                }
                if(quit)
                {
                    break;
                }
            }
        }
        public void CreateNewList()
        {
            //SubMenu();
            
            var ML = new MonthList("January");
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine($"        :January:         ");
            System.Console.WriteLine($"Bills   : {ML.Bills.Count}");
            System.Console.WriteLine($"Food    : {ML.Food.Count}");
            System.Console.WriteLine($"Wants   : {ML.Wants.Count}");
            System.Console.WriteLine($"GSS     : {ML.GasStationSnacks.Count}");
            System.Console.WriteLine($"WorkAVI : {ML.WorkAVI.Count}");
            System.Console.WriteLine($"Gas     : {ML.Gas.Count}");
            System.Console.WriteLine($"Random  : {ML.Random.Count}");
            System.Console.WriteLine("----------------------------");
            //ML.AddTransaction(Convert.ToDecimal(Console.ReadLine()));
        }
        public void ViewSavedLists()
        {
            SubMenu();
            System.Console.WriteLine("Saved Lists Test");
        }
        public void Exit()
        {
            Console.Clear();
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("Quiting System");
            System.Console.WriteLine("Press enter to continue...");
            System.Console.WriteLine("----------------------------");
            Console.ReadLine();
        }
        public void SaveFile()
        {
            SubMenu();
            System.Console.WriteLine("Save File Test");
        }
        public void NonValidNum()
        {
            System.Console.WriteLine("----------------------------");
            Console.WriteLine("Please enter a valid number.");
            Console.WriteLine("Press Enter To Continue...");
            System.Console.WriteLine("----------------------------");
        }
    }
}