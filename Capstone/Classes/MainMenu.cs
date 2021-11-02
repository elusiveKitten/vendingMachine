using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes  
{
    public class MainMenu 
    {
      
        public void Menu()//holds the display method 
        {
            Display();
        }
        
        public UserInterface UserInterface { get; }//properties 

        public MainMenu(UserInterface ui)//constructor ^^same name as class 
        {
            UserInterface = ui; 
        }
        public void Display()
        {
            Inventory inventory = new Inventory();//declares instances of inventory, purchase menu
            PurchaseMenu purchaseMenu = new PurchaseMenu(UserInterface);
            string mainInput = "";//bucket to hold input from user 


            while (mainInput != "3")//if they type in 3 it will close the program, so while input is not 3....
            {
                //MainMenu displayed to customer 
                Console.WriteLine("Welcome to the Vendo-Matic 800");
                Console.WriteLine("Main Menu:");
                Console.WriteLine("(1) Display Vending Machine Items");//all this is displayed to user 
                Console.WriteLine("(2) Purchase");
                Console.WriteLine("(3) Exit");

                mainInput = Console.ReadLine();//this puts something in our input bucket 


                if (mainInput == "1")//if they type in a one it will display the items w quantity remaining 
                {
                    inventory.ProductList();//goes to inventory class, productlist method 

                }
                else if (mainInput == "2")//if they type in 2 it takes them to the purchase menu 
                {
                    purchaseMenu.SecondMenu();//goes to purchase menu class, second menu method 
                }
                else if (mainInput == "3")
                {
                    UserInterface.ClearScreen();//works  3)Exit - should clear out program 
                     // Environment.Exit(0);//works
                }
                else
                {
                    Console.WriteLine("You did not make a valid choice. Please try again.");//if they don't enter a valid number 1-3, maybe says "not a valid input" and redisplays the main menu 
                }
            }
           
            
            
            
            

        }


        
    }
}
