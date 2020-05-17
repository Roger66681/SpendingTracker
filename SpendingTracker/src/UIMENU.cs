using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Diagnostics;
using System.Windows;
using System.Collections.Generic;

namespace SpendingTracker
{
    class MainMenu
    {
        int userInput = 0;
        public void mainMenu()
        {
            Console.Clear();
            //variables
            int m1 = 1;
            int m2 = 2;
            int m3 = 3;
            int loop = -1;
            

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
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine("Press Enter To Continue...");
                    Console.ReadLine();
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
                    Console.Clear();
                    Exit();
                    break;
                }
            }
        }

        public void SubMenu()
        {
            int m1 = 1;
            int m2 = 2;
            int m3 = 3;
            int loop = -1;
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine($"{m1}: Main Menu");
            System.Console.WriteLine($"{m2}: Save File");
            System.Console.WriteLine($"{m3}: Exit");
            System.Console.WriteLine("----------------------------");

            
            while(loop < userInput)
            {

                if(!int.TryParse(Console.ReadLine(), out userInput)) //returns false if the user doesn't enter a number
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine("Press Enter To Continue...");
                    Console.ReadLine();
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
                    Console.Clear();
                    Exit();
                    break;
                }
            }
        }
        public void CreateNewList()
        {
            SubMenu();
            var ML = new MonthList("January");
            ML.AddTransaction(79.80m);
            Console.WriteLine($"${ML.testList[0]}");
        }
        public void ViewSavedLists()
        {
            SubMenu();
            System.Console.WriteLine("Saved Lists Test");
        }
        public void Exit()
        {
            System.Console.WriteLine("Exit Test");
            SubMenu();
            
            
            
        }
        public void SaveFile()
        {
            SubMenu();
            System.Console.WriteLine("Save File Test");
        }
    }
}