using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyosact3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Create an Array of Sports Objects
            Sports[] sportsArray = new Sports[4];

            Console.ForegroundColor = ConsoleColor.Yellow;
            // Populate the Array with Basketball and Objects
            sportsArray[0] = new Basketball(" COLLEGE OF COMPUTER STUDIES", "Louis Aian Cuyos", "24-2002943", 43);
            sportsArray[1] = new Basketball(" COLLEGE OF ARTS AND PEDEALOGY", "Ryan Carl Salvo", "24-2002227", 13);


            // Populate the Array with Arnis Objects
            sportsArray[2] = new Arnis(" COLLEGE OF BUSINESS MANAGEMENT", "Carls Kevin Belleza", "22-9002562", 15);
            sportsArray[3] = new Arnis(" COLLEGE OF NURSING", "John Rhaezel Atillo", "22-9002562", 20);


            // Looping Stucture to display information
            foreach (Sports sport in sportsArray)
            {
                // Display Information
                sport.DisplayInfo();
            }

            Console.ReadKey();





        }
    }
}
