using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Diagnostics;
using System.Windows;
using System.Collections.Generic;

namespace SpendingTracker
{
    public class CreateNewList
    {
        MonthList ML = new MonthList();
        //variables
        decimal userInput = 0m; //UserInputDecimalIntial
        int IndexSelector = 0;
        string month = "";
        string category = "";
        List<decimal> categorySelector;
        List<decimal> mN = new List<decimal>()//MenuNumbers
            {
                1m,2m,3m,4m,
                5m,6m,7m,8m,
                9m,10m,11m,12m,
                13m,14m,15m,16m,
                17m,18m,19m,20m,
                21m,22m,23m,24m,
                25m,26m,27m,28m,
                29m,30m,31m,32m,
                33m,34m,35m,36m,
                37m,38m,39m,40m,
                41m,42m,43m,44m,
                45m,46m,47m,48m,
                49m,50m,51m,52m,
                53m,54m,55m,56m,
                57m,58m,59m,60m,
                61m,62m,63m,64m,
                65m,66m,67m,68m,
                69m,70m,71m,72m,
                73m,74m,75m,76m,
                77m,78m,79m,80m,
                81m,82m,83m,84m,
                85m,86m,87m,88m,
                89m,90m,91m,92m,
                93m,94m,95m,95m,
                96m,97m,98m,99m,
                100m
            };
        List<string> Months = new List<string>()//MonthsList
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
        List<string> categoryList = new List<string>()//CategoryStrings
            {
                "Bills",   //categoryList[0]
                "Food",   //categoryList[1]
                "Wants",     //categoryList[2] 
                "Gas Station Snacks",//categoryList[3]
                "WorkAVI",       //categoryList[4]
                "Gas",      //categoryList[5]
                "Other",      //categoryList[6]
            };            
        bool quit = false;
        bool Exit = false;
        public void NewCreateNewList()
        {
            MonthSelectionDisplay();
            MonthSelectorListUserInput();
            Console.Clear();
            CategorySelectionDisplay();
            categorySelectorUserInput();
            Console.Clear();
            while(!Exit)
            {
                CategoryDisplay();
                CategoryUserInput();
            }
        }
        public void MonthSelectionDisplay()
        {
            var MSD = new List<string>()
            {
            "----------------------------",
            "Please Select A Month...",
            "----------------------------",
            $"{mN[0]}   : {Months[0]}",
            $"{mN[1]}   : {Months[1]}",
            $"{mN[2]}   : {Months[2]}",
            $"{mN[3]}   : {Months[3]}",
            $"{mN[4]}   : {Months[4]}",
            $"{mN[5]}   : {Months[5]}",
            $"{mN[6]}   : {Months[6]}",
            $"{mN[7]}   : {Months[7]}",
            $"{mN[8]}   : {Months[8]}",
            $"{mN[9]}   : {Months[9]}",
            $"{mN[10]}  : {Months[10]}",
            $"{mN[11]}  : {Months[11]}",
            "----------------------------"
            };
            MSD.ForEach(System.Console.WriteLine);
        }
        public void MonthSelectorListUserInput()
        {
            UIMenus UI = new UIMenus();
            
            //Variables
            while(!quit)
            {
                if(!decimal.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.Clear();
                    UI.NonValidNum();
                }
                else if(userInput == mN[0])
                {
                    month = Months[0];
                    quit = true;
                    break;
                }
                else if(userInput == mN[1])
                {
                    month = Months[1];
                    quit = true;
                    break;
                }
                else if(userInput == mN[2])
                {
                    month = Months[2];
                    quit = true;
                    break;
                }
                else if(userInput == mN[3])
                {
                    month = Months[3];
                    quit = true;
                    break;
                }
                else if(userInput == mN[4])
                {
                    month = Months[4];
                    quit = true;
                    break;
                }
                else if(userInput == mN[5])
                {
                    month = Months[5];
                    quit = true;
                    break;
                }
                else if(userInput == mN[6])
                {
                    month = Months[6];
                    quit = true;
                    break;
                }
                else if(userInput == mN[7])
                {
                    month = Months[7];
                    quit = true;
                    break;
                }
                else if(userInput == mN[8])
                {
                    month = Months[8];
                    quit = true;
                    break;
                }
                else if(userInput == mN[9])
                {
                    month = Months[9];
                    quit = true;
                    break;
                }
                else if(userInput == mN[10])
                {
                    month = Months[10];
                    quit = true;
                    break;
                }
                else if(userInput == mN[11])
                {
                    month = Months[11];
                    quit = true;
                    break;
                }
                else
                {
                    Console.Clear();
                    UI.NonValidNum();
                }
                if(quit)
                {
                    break;
                }
            }
            quit = false;
        }
        public void CategorySelectionDisplay()
        {
            var CSD = new List<string>()
            {
        	"----------------------------",
        	"  Please Select a category...",
        	"----------------------------",
        	$"{mN[0]} : Main Menu"        ,
            "----------------------------",
            $"        "+ month +"         ",
            "----------------------------",
            $"{mN[1]} : "+categoryList[0]+$"  : ${ML.Bills.Count}",
            $"{mN[2]} : "+categoryList[1]+$"  : ${ML.Food.Count}",
            $"{mN[3]} : "+categoryList[2]+$"  : ${ML.Wants.Count}",
            $"{mN[4]} : "+categoryList[3]+$"  : ${ML.GasStationSnacks.Count}",
            $"{mN[5]} : "+categoryList[4]+$"  : ${ML.WorkAVI.Count}",
            $"{mN[6]} : "+categoryList[5]+$"  : ${ML.Gas.Count}",
            $"{mN[7]} : "+categoryList[6]+$"  : ${ML.Other.Count}",
            "----------------------------"
            };
            CSD.ForEach(System.Console.WriteLine);
            
        }
        public void categorySelectorUserInput()
        {
            UIMenus UI = new UIMenus();
            while(!quit)
            {
                if(!decimal.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.Clear();
                    UI.NonValidNum();
                    
                }
                else if(userInput == mN[0])
                {
                	Console.Clear();
                    UI.mainMenu();
                    quit = true;
                    break;
                }
                else if(userInput == mN[1])
                {
                    category = categoryList[0];
                    categorySelector = ML.Bills;
                    quit = true;
                    break;
                }
                else if(userInput == mN[2])
                {
                    category = categoryList[1];
                    categorySelector = ML.Food;
                    quit = true;
                    break;
                }
                else if(userInput == mN[3])
                {
                    category = categoryList[2];
                    categorySelector = ML.Wants;
                    quit = true;
                    break;
                }
                else if(userInput == mN[4])
                {
                    category = categoryList[3];
                    categorySelector = ML.GasStationSnacks;
                    quit = true;
                    break;
                }
                else if(userInput == mN[5])
                {
                    category = categoryList[4];
                    categorySelector = ML.WorkAVI;
                    quit = true;
                    break;
                }
                else if(userInput == mN[6])
                {
                    category = categoryList[5];
                    categorySelector = ML.Gas;
                    quit = true;
                    break;
                }
                else if(userInput == mN[7])
                {
                    category = categoryList[6];
                    categorySelector = ML.Other;
                    quit = true;
                    break;
                }
                else
                {
                	UI.mainMenu();
                    quit = true;
                    break;
                }
                if(quit)
                {
                	break;
                }
                quit = false;
            }
            
        }
        
        public void CategoryDisplay()
        {
        	Console.Clear();
            var CDL = new List<string>
            {
        	"-------------------------------",
        	$"{mN[0]}:Add Transaction:",
            $"{mN[1]}:Remove Transaction:",
            $"{mN[2]}:Exit:",
        	"-------------------------------",
            $"        "+ category +"        ",
            "-------------------------------",
            };
            CDL.ForEach(System.Console.WriteLine);
            CategoryTransactionDisplay();//Transaction Display
            Console.WriteLine(CDL[0]);
        }
        public void CategoryTransactionDisplay()//TransactionDisplay
        {
            decimal TCounter = 1m;
            foreach(decimal transaction in categorySelector) //So every item(transaction) in the list selected...
            {
                System.Console.WriteLine($"transaction {TCounter++} : ${transaction}");//Display it to the console in this fashion,
            }                                                                       //and only if there is one to display
        }
        public void CategoryUserInput()
        {
            quit = false;
            UIMenus UI = new UIMenus();
            while(!quit)
            {
                if(!decimal.TryParse(Console.ReadLine(), out userInput)) //returns false if the user doesn't enter a number
                {
                    Console.Clear();
                    UI.NonValidNum();
                }
                else if(userInput == mN[0])
                {
                    Console.Clear();
                    AddTransactionUserInput();
                    quit = true;
                    break;
                }
                else if(userInput == mN[1])
                {
                    Console.Clear();
                    RemoveTransactionUserInput();
                    quit = true;
                    break;
                }
                else if(userInput == mN[2])
                {
                    Exit = true;
                    quit = true;
                    break;
                }
                else
                {
                    //Do nothing or wait...
                }
                if(quit)
                {
                    break;
                }
            }
            quit = false;
        }
        public void AddTransactionDisplay()
        {
            var ATDL = new List<string>()
            {
            "-------------------------------",
        	"   Please Enter A Transaction  ",
        	"-------------------------------",
            };
            ATDL.ForEach(System.Console.WriteLine);
        }
        public void AddTransactionUserInput()
        {
            AddTransactionDisplay();
            quit = false;
            UIMenus UI = new UIMenus();
            decimal transaction;

            while(!quit)
            {
                if(!decimal.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.Clear();
                    UI.NonValidNum();
                    Console.ReadLine();
                    Console.Clear();
                    AddTransactionDisplay();
                }
                else
                {
                    transaction = userInput;
                    ML.AddTransaction(categorySelector, transaction);
                    quit = true;
                    break;
                }
                if(quit)
                {
                    break;
                }
            }
            quit = false;
        }
        public void RemoveTransactionDisplay()
        {
            var RTDL = new List<string>()
            {
            "-------------------------------",
        	"Select A Transaction To Remove...",
        	"-------------------------------",
            };
            RTDL.ForEach(System.Console.WriteLine);
            CategoryTransactionDisplay();
            Console.WriteLine(RTDL[0]);
        }
        public void RemoveTransactionUserInput()
        {
            quit = false;
            int userInput2 = 0;
            RemoveTransactionDisplay();
            UIMenus UI = new UIMenus();

            foreach (var transaction in categorySelector)
            {
                if(!int.TryParse(Console.ReadLine(), out userInput2))
                {
                    Console.Clear();
                    UI.NonValidNum();
                    Console.ReadLine();
                    Console.Clear();
                    RemoveTransactionDisplay();
                }
                else if(userInput2 == transaction)
                {
                    ML.RemoveTransaction(categorySelector, userInput2);
                    break;
                }
                else
                {
                    //Do nothing...
                }
            }
        } 
    }
}