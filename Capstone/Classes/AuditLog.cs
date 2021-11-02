using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    public class AuditLog
    {
      
       public void LogInformation(decimal moneyIn, decimal newBalance)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter("log.txt",true))
                {
                    sw.WriteLine(DateTime.Now.ToString("G") + " FEED MONEY: " + "$" + moneyIn.ToString("0.00") + " $" + newBalance.ToString("0.00"));//yesssssss

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //file writer same file for both methods 

        }

        public void LogProductInfo(Product product, decimal startingBalance, decimal endingBalance)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter("log.txt", true))//true is there to append to end of doc instead of overwriting.
                {
                    sw.WriteLine(DateTime.Now.ToString("G") + " " + product.Name + " " + product.SlotLocation + " $" + startingBalance.ToString("0.00") + " $" + endingBalance.ToString("0.00"));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void LogEndingInformation(decimal endingBalance, decimal machineBalance)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter("log.txt", true))//true is there to append to end of doc instead of overwriting.
                {
                    sw.WriteLine(DateTime.Now.ToString("G") + " " + "GIVE CHANGE: " + "$" + endingBalance.ToString("0.00") + " $" + machineBalance.ToString("0.00"));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //FormatIME  MM/DD/YYYY TAM/PM TYPE OF TRANSACTION MONEY IN  BALANCE
        //format for purchase    PURCHASE ITEM AND LOCATION STARTING BAL   BAL AFTER PURCHASE 
        //can't figure out how to do it with just two methods - not sure how to change the writeline msg based on what is needed so created LogEndingInformation

        
        //if we end up doing sales report it would pull from here, too
    }
}
