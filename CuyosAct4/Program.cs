using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a 2D Array of Sports type 3 by 3
            Sports[,] sportsArray = new Sports[3,3];

            Console.ForegroundColor = ConsoleColor.Yellow;
            // Populate the Array with Basketball Objects
            sportsArray[0,0] = new Basketball(" COLLEGE OF COMPUTER STUDIES", "Louis Aian Cuyos", "24-2002943", 43);
            sportsArray[0,1] = new Basketball(" COLLEGE OF ARTS AND PEDEALOGY", "Ryan Carl Salvo", "24-2002227", 13);
            sportsArray[0,2] = new Basketball(" COLLEGE OF EDUCATION", "John Mark Sarmiento", "22-9002562", 27);


            // Populate the Array with Arnis Objects
            sportsArray[1,0] = new Arnis(" COLLEGE OF BUSINESS MANAGEMENT", "Carls Kevin Belleza", "22-9002562", 15);
            sportsArray[1,1] = new Arnis(" COLLEGE OF NURSING", "John Rhaezel Atillo", "22-9002562", 20);
            sportsArray[1,2] = new Arnis(" COLLEGE OF ENGINEERING", "Mark Anthony Dela Cruz", "22-9002562", 18);


            // Nested loops to iterate through the 2D array and display information
            for (int i = 0; i < sportsArray.GetLength(0); i++)
            {
                for (int j = 0; j < sportsArray.GetLength(1); j++)
                {
                   
                    sportsArray[i, j]?.DisplayInfo();
                }
            }

            Console.ReadKey();
        }
    }
}
