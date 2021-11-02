using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Change
    {
        public int Quarters { get; }
        public int Dimes { get; }
        public int Nickels { get; }
        public int Pennies { get; }

        //Need a method to make current balance into change using least number of coins
        //Make balance into pennies and calculate from there
        public Change(decimal balance)//have constructor but no method 
        {
            
            Quarters = (int)(balance / .25M);
            balance %= .25M;
            
            Dimes = (int)(balance / .10M);
            balance %= .10M;
            
            Nickels = (int)(balance / .05M);
            balance %= .05M;

            Pennies = (int)(balance / .01M);

        }
        

    }
}
