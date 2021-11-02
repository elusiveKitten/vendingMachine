using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    public class Inventory
    {
        
        //public Dictionary<string, Product> ProductList
        //{
        //    get
        //    {
        //        return ProductList();
        //    }

        //}
        public Product Product { get; }
        public Dictionary<string, Product> ProductList()
        {
            //get current directory and file path not hard coded 
            string directory = Environment.CurrentDirectory;
            string filename = "vendingmachine.csv";//had to be creative here, hope it doesn't bite us -___-
            string fullpath = Path.Combine(directory, filename);

            if (!File.Exists(fullpath))
            {
                throw new FileNotFoundException();//is working - if files doesnt exist, throw exception 
            }


            //templist was to display the product name 
            Dictionary<string, Product> tempList = new Dictionary<string, Product>();//key value pairs so we can track items, declared an instance of our list

                using (StreamReader sr = new StreamReader(fullpath))
                {
                    while (!sr.EndOfStream) //Order is Slot Location| Item Name | Price | Item Type 
                    {

                    string name = sr.ReadLine();
                    
                    string[] splitArray = new string[4];//declaring our array, specifying how many elements are in it 
                    splitArray = name.Split('|');//telling sr to split on the pipes 
                    Product product = new Product(splitArray[0], splitArray[1], decimal.Parse(splitArray[2]), splitArray[3]);
                    tempList.Add(splitArray[1], product);//adding to this list just the name at index 1 and then pulling from product to get the inventory below
                    Console.WriteLine(splitArray[1].PadRight(20) + " | Quantity Remaining: " + product.Inventory);//i made it pretty at least!

                }
                return tempList;
                }


        }
        public Dictionary<string, Product> FullList()
        {
            
            string directory = Environment.CurrentDirectory;
            string filename = "vendingmachine.csv";
            string fullpath = Path.Combine(directory, filename);

            if (!File.Exists(fullpath))
            {
                throw new FileNotFoundException();//is working 
            }

            Dictionary<string, Product> listItems = new Dictionary<string, Product>();//key value pairs so we can track items 

            using (StreamReader sr = new StreamReader(fullpath))
            {
                while (!sr.EndOfStream) //Order is Slot Location| Item Name | Price | Item Type 
                {

                    string name = sr.ReadLine();
                    string[] itemArray = new string[4];
                    itemArray = name.Split('|');
                    Product product = new Product(itemArray[0], itemArray[1], decimal.Parse(itemArray[2]), itemArray[3]);
                    Console.WriteLine(itemArray[0].PadRight(5) + itemArray[1].PadRight(20) + itemArray[2].PadRight(8) + itemArray[3]);//all looks good w this displaying 

                }
                return listItems;
            }


        }
    }
}


