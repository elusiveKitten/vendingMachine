using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Cart
    {
        public Product Product { get; set; }
        Inventory inventory = new Inventory();

       

        //has to be a bucket for the items user is purchasing, so has to access purchase menu 
        //should list what they chose and price/total?
        //should go away after they finish the transaction 

    }
}
