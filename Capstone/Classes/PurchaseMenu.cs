using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Capstone.Classes
{
    public class PurchaseMenu
    {
        public Inventory Inventory { get; }
        public MainMenu MainMenu { get; set; }
        public UserInterface UserInterface { get; }
        public Product Product { get; set; }
        public PurchaseMenu(UserInterface ui)
        {
            UserInterface = ui;
        }


        public string CustSelection { get; set; }
        public decimal CustomerBalance { get; set; }
        public decimal FeedMoney(decimal moneyIn, decimal newBalance)//works as intended
        {
            AuditLog audLog = new AuditLog();//declared so it writes a line 
            CustomerBalance += moneyIn;
            newBalance = CustomerBalance;
            audLog.LogInformation(moneyIn, newBalance);
            return CustomerBalance;
        }

        public void SecondMenu()
        {
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Purchase Menu:");//this menu comes up so this path is working
            Console.WriteLine("(1) Feed Money");
            Console.WriteLine("(2) Select Product");
            Console.WriteLine("(3) Finish Transaction");
            Console.WriteLine();
            Console.WriteLine($"Current Money Provided: $ {CustomerBalance.ToString("0.00")}");//works!
            string purchaseInput = Console.ReadLine();
            decimal userBal = 0;

            if (purchaseInput == "1")
            {
                decimal userMoney = UserInterface.GetIntInput("Please enter a whole dollar amount: $");
                FeedMoney(userMoney, userBal);
                Display();//this brings it back to purchase menu after money goes in, prior it was going back to mainmenu

            }
            else if (purchaseInput == "2")
            {

                //Console.WriteLine("you pressed 2");- works so routing is correct
                Purchase();
                //SelectProduct();
                Display();
            }
            else if (purchaseInput == "3")
            {
                //Console.WriteLine("you pressed 3"); - works so routing is correct
                //need a finish transaction method that will call on Change() 
                //has to write to log
            }
            else
            {
                //Console.WriteLine("you pressed a number other than 1, 2 or 3"); - works so routing is correct
                MainMenu mainMenu = new MainMenu(UserInterface);//does take you back to main menu
                mainMenu.Menu();
            }
        }
        public string SelectProduct()
        {
            Inventory inventory = new Inventory();
            inventory.FullList(); //show the list of items with all the product info in the csv
            AuditLog audLog = new AuditLog();
            Product product = new Product();
            CustSelection = UserInterface.GetStringInput("Please enter the slot location of the item you want.");
            
            decimal startingBalance = CustomerBalance;//coming up as 5 and 5, so this is right 
            decimal endingBalance = startingBalance - product.Price;//null reference exception thrown 
            audLog.LogProductInfo(Product, startingBalance, endingBalance);
            Cart cart = new Cart();
            
            //cart;
            return CustSelection;
            
            //should go back to purchase menu after hitting 2 so they can either select again or hit 3 to finish
            //cart will increase by choice 


        }
        

        //2a) select product() (will loop til user hits 3 to finish transaction) - if else loop
        //shows list of available products (pipe delimited)
        //verifies they entered enough money for their selection, throw insufficient funds exception
        //if slot code does not exist, inform user and return to purchase menu
        //if slot code sold out, inform user and return to purchase menu
        //if valid choice, it is dispensed
        //writes a line to the log.txt




        //public void Dispense()

        //prints out item name, cost, money remaining and an output message
        //updates the quantity for the item
        //updates users balance remaining


        //3a)finish transaction()

        //returns change in least amt of coins possible - call the Change()
        //machines current balance is updated to $0
        //writes a line to the log.txt
        //goes back to main menu

        private vendingmachine pvm;

        public void Purchase()
        {
            Inventory inventory = new Inventory();
            inventory.FullList();
            Console.WriteLine("Which slot location do you like? Or press R to return to the Purchase Menu.");

            while (true)
            {
                
                string slotlocation = Console.ReadLine();//not taking into consideration inventory, not decrementing 
                if (slotlocation.ToUpper().Equals("R"))
                {
                    //break;
                    Display();
                }
                try
                {
                    vendingmachine.Purchase(slotlocation);

                    if(slotlocation.ToLower().StartsWith("a"))
                    {
                        Console.WriteLine("Crunch Crunch, Yum!");
                    }
                    else if(slotlocation.ToLower().StartsWith("b"))
                    {
                        Console.WriteLine("Munch Munch, Yum!");
                    }
                    else if(slotlocation.ToLower().StartsWith("c"))
                    {
                        Console.WriteLine("Glug Glug, Yum!");
                    }
                    else if(slotlocation.ToLower().StartsWith("d"))
                    {
                        Console.WriteLine("Chew Chew, Yum!");
                    }
                       
                   // Console.WriteLine(pvm.Product[slotlocation].OutputMessage());
                }
                catch (InvalidSelectionException)
                {
                    Console.WriteLine("Invalid Selection.");
                    Console.WriteLine("Please try again.");
                }
                catch (NotEnoughMoneyException)
                {
                    Console.WriteLine("Insufficient funds");
                }
                catch (OutOfStockException)
                {
                    Console.WriteLine("Sorry that item is currently out of stock");
                }
                Console.WriteLine("Please select again or press R to return to the Purchase Menu.");
            }
        }

        private class vendingmachine
        {
            internal static void Purchase(string slotlocation)
            {
                //throw new NotImplementedException();
            }
        }
    }


}
