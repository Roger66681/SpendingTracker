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
        CreateNewList CNL = new CreateNewList();
        //Variables
        decimal userInput = 0m;
        decimal m1 = 1m;
        decimal m2 = 2m;
        decimal m3 = 3m;
        decimal loop = -1m; 
        bool quit = false;
        public void mainMenu()
        { 
        	//Console.Clear();
            //mainMenuDisplayList
            var MMDL = new List<string>()
            {
            "----------------------------",//0
            "Welcome To SpendingTracker!!",//1
            "         Main Menu          ",//2
            $"{m1}: Create New List:",//3
            $"{m2}: View Saved Lists:",//4
            $"{m3}: Exit:",//5
            "----------------------------"//6
            };
		    MMDL.ForEach(System.Console.WriteLine);
            //mainMenuList UserInput
            MMLUserInput();
        }

        public void SubMenu()
        {
            //SubMenuDisplayList
            var SMDL = new List<string>()
            {
            "----------------------------",
            "       :Sub Menu:        ",
            $"{m1}: Main Menu",
            $"{m2}: Save File",
            $"{m3}: Exit",
            "----------------------------"
            };
            SMDL.ForEach(System.Console.WriteLine);
            //SubMenuUserInput
            SMUserInput();
        }
        
        public void ViewSavedLists()
        {
            System.Console.WriteLine("Saved Lists Test");
            SubMenu();
        }
        public void Exit()
        {
            Console.Clear();
            var EDL = new List<string>()
            {
            "----------------------------",
            "Quiting System",
            "Press enter to continue...",
            "----------------------------"
            };
            EDL.ForEach(System.Console.WriteLine);
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
            var NVND = new List<string>()
            {
            "----------------------------",
            "Please enter a valid number.",
            "----------------------------"
            };
            NVND.ForEach(System.Console.WriteLine);
        }
        public void MMLUserInput()
        {
            while(loop < userInput)
            {
                if(!decimal.TryParse(Console.ReadLine(), out userInput)) //returns false if the user doesn't enter a number
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
                    CNL.NewCreateNewList();
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
        public void SMUserInput()
        {
            while(loop < userInput)
            {

                if(!decimal.TryParse(Console.ReadLine(), out userInput)) //returns false if the user doesn't enter a number
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
                    quit = true;
                    Exit();
                    break; //this exits the "while" loop
                }
                if(quit)
                {
                    break;
                }
            }
        }
    }
}