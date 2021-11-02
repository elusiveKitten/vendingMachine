using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class UserInterface
    {
        public int GetIntInput(string prompt)
        {
            Console.WriteLine(prompt);
            string entry = Console.ReadLine();
            try
            {
                int entryInt = int.Parse(entry);
                return entryInt;
            }
            catch (Exception e)
            {
                throw new FormatException($"Cannot parse {entry} into an integer.");
            }
        }
        public string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            string entry = Console.ReadLine();
            return entry;
        }
        public void WriteToScreen(string output)
        {
            Console.WriteLine(output);
        }
        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}
