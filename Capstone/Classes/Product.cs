using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Product
    {//properties
        public const int StartingInventory = 5;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public int Inventory { get; set; }
        public string SlotLocation { get; set; }
        public UserInterface UserInterface { get; }

        //do we need to change this to the same order as the file? Location|Name|Price|Type
        public Product(string slotLocation, string name, decimal price, string type)//constructor
        {
            SlotLocation = slotLocation;
            Name = name;
            Price = price;
            Type = type;
            Inventory = StartingInventory;
        }

        public Product()
        {
        }

        public void DecreaseInventory()
        {
            if (Inventory > 0)
            {
                Inventory--;
            }
            else
            {
                Console.WriteLine("Out of Stock");
            }
        }
       
        //counter to decrement the inventory 
        //public abstract string OutputMessage();//if statement for each product type 
    }
}
