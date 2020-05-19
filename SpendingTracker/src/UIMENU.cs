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
            List<string> mainMenuDisplayList = new List<string>(){};
            mainMenuDisplayList.Add("----------------------------");//0
            mainMenuDisplayList.Add("Welcome To SpendingTracker!!");//1
            mainMenuDisplayList.Add("         Main Menu          ");//2
            mainMenuDisplayList.Add($"{m1}: Create New List:");//3
            mainMenuDisplayList.Add($"{m2}: View Saved Lists:");//4
            mainMenuDisplayList.Add($"{m3}: Exit:");//5
            mainMenuDisplayList.Add("----------------------------");//6
		    mainMenuDisplayList.ForEach(System.Console.WriteLine);
            
            //mainMenuList UserInput
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
                    quit = true;
                    Exit();
                    break; //this exits the "while" mainMenu loop
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
            //variables
            
            var Months = new List<string>()
            {
                "January",   //Months[0]
                "Febuary",   //Months[1]
                "March",     //Months[2] 
                "April",     //Months[3]
                "May",       //Months[4]
                "June",      //Months[5]
                "July",      //Months[6]
                "August",    //Months[7]
                "September", //Months[8]
                "October",   //Months[9]
                "November",  //Months[10]
                "December"   //Months[11]
            };
            var mN = new List<int>(){1,2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20};
            int userInput2 = 0;
            string month = "";
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("Please Select A Month...");
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine($"{mN[0]}   : {Months[0]}");
            System.Console.WriteLine($"{mN[1]}   : {Months[1]}");
            System.Console.WriteLine($"{mN[2]}   : {Months[2]}");
            System.Console.WriteLine($"{mN[3]}   : {Months[3]}");
            System.Console.WriteLine($"{mN[4]}   : {Months[4]}");
            System.Console.WriteLine($"{mN[5]}   : {Months[5]}");
            System.Console.WriteLine($"{mN[6]}   : {Months[6]}");
            System.Console.WriteLine($"{mN[7]}   : {Months[7]}");
            System.Console.WriteLine($"{mN[8]}   : {Months[8]}");
            System.Console.WriteLine($"{mN[9]}   : {Months[9]}");
            System.Console.WriteLine($"{mN[10]}  : {Months[10]}");
            System.Console.WriteLine($"{mN[11]}  : {Months[11]}");
            System.Console.WriteLine("----------------------------");

            while(!quit)
            {
                if(!int.TryParse(Console.ReadLine(), out userInput2))
                {
                    Console.Clear();
                    NonValidNum();
                    
                }
                else if(userInput2 == mN[0])
                {
                    month = Months[0];
                    quit = true;
                    break;
                }
                else if(userInput2 == mN[1])
                {
                    month = Months[1];
                    quit = true;
                    break;
                }
                else if(userInput2 == mN[2])
                {
                    month = Months[2];
                    quit = true;
                    break;
                }
                else if(userInput2 == mN[3])
                {
                    month = Months[3];
                    quit = true;
                    break;
                }
                else if(userInput2 == mN[4])
                {
                    month = Months[4];
                    quit = true;
                    break;
                }
                else if(userInput2 == mN[5])
                {
                    month = Months[5];
                    quit = true;
                    break;
                }
                else if(userInput2 == mN[6])
                {
                    month = Months[6];
                    quit = true;
                    break;
                }
                else if(userInput2 == mN[7])
                {
                    month = Months[7];
                    quit = true;
                    break;
                }
                else if(userInput2 == mN[8])
                {
                    month = Months[8];
                    quit = true;
                    break;
                }
                else if(userInput2 == mN[9])
                {
                    month = Months[9];
                    quit = true;
                    break;
                }
                else if(userInput2 == mN[10])
                {
                    month = Months[10];
                    quit = true;
                    break;
                }
                else if(userInput2 == mN[11])
                {
                    month = Months[11];
                    quit = true;
                    break;
                }
                else
                {
                    mainMenu();
                }
            }
            //Create New Month List
            var ML = new MonthList();
            
        
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine($"        "+ month +"         ");
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine($"Bills   : {ML.Bills.Count}");
            System.Console.WriteLine($"Food    : {ML.Food.Count}");
            System.Console.WriteLine($"Wants   : {ML.Wants.Count}");
            System.Console.WriteLine($"GSS     : {ML.GasStationSnacks.Count}");
            System.Console.WriteLine($"WorkAVI : {ML.WorkAVI.Count}");
            System.Console.WriteLine($"Gas     : {ML.Gas.Count}");
            System.Console.WriteLine($"Other   : {ML.Other.Count}");
            System.Console.WriteLine("----------------------------");

            
        }
        public void ViewSavedLists()
        {
            //SubMenu();
            System.Console.WriteLine("Saved Lists Test");
            SubMenu();
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
            System.Console.WriteLine("Save File Test");
            SubMenu();
        }
        public void NonValidNum()
        {
        	Console.Clear();
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("Please enter a valid number.");
            System.Console.WriteLine("Press Enter To Continue...");
            System.Console.WriteLine("----------------------------");
        }
    }
}