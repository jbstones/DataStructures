using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main Menu
            Console.WriteLine("---MAIN MENU---");
            Console.WriteLine("1. Stack");
            Console.WriteLine("2. Queue");
            Console.WriteLine("3. Dictionary");
            Console.WriteLine("4. Exit");
            Console.WriteLine();

            string mainMenuInput = Console.ReadLine();

            if (mainMenuInput == "1" || mainMenuInput == "Stack" || mainMenuInput == "stack" || mainMenuInput == "s" || mainMenuInput == "S")
            {
                Console.WriteLine("1. Add one time to Stack");
                Console.WriteLine("2. Add Huge List of Items to Stack");
                Console.WriteLine("3. Display Stack");
                Console.WriteLine("4. Delete from Stack");
                Console.WriteLine("5. Clear Stack");
                Console.WriteLine("6. Search Stack");
                Console.WriteLine("7. Return to Main Menu");
                Console.WriteLine();
            }
            else if (mainMenuInput == "2" || mainMenuInput == "Queue" || mainMenuInput == "queue" || mainMenuInput == "q" || mainMenuInput == "Q")
            {
                Console.WriteLine("1. Add one time to Queue");
                Console.WriteLine("2. Add Huge List of Items to Queue");
                Console.WriteLine("3. Display Queue");
                Console.WriteLine("4. Delete from Queue");
                Console.WriteLine("5. Clear Queue");
                Console.WriteLine("6. Search Queue");
                Console.WriteLine("7. Return to Main Menu");
                Console.WriteLine();
            }
            else if (mainMenuInput == "3" || mainMenuInput == "Dictionary" || mainMenuInput == "dictionary" || mainMenuInput == "d" || mainMenuInput == "D")
            {
                Console.WriteLine("1. Add one item to Dictionary");
                Console.WriteLine("2. Add Huge List of Items to Dictionary");
                Console.WriteLine("3. Display Dictionary");
                Console.WriteLine("4. Delete from Dictionary");
                Console.WriteLine("5. Clear Dictionary");
                Console.WriteLine("6. Search Dictionary");
                Console.WriteLine("7. Return to Main Menu");
                Console.WriteLine();
            }
            else if (mainMenuInput == "4" || mainMenuInput == "Exit" || mainMenuInput == "exit" || mainMenuInput == "e" || mainMenuInput == "E")
            {

            }
            else
            {
                Console.WriteLine("ERROR - Invalid input.");
            }

            Console.ReadLine();

            //this is a test
        }
    }
}
