using Capstone.Classes;
using System;


namespace Capstone
{
    public class Program
    {
        static void Main(string[] args)
        {

            UserInterface ui = new UserInterface();//declared new instances of classes UI & main menu 

            MainMenu mainMenu = new MainMenu(ui);
            mainMenu.Menu();//called on the main menu menu method -> takes you to main menu.menu

        //    PurchaseMenu purchaseMenu = new PurchaseMenu(ui);
        //    purchaseMenu.Menu();

        //    Inventory inventory = new Inventory();
        //    inventory.ProductList();
        }
    }
}
