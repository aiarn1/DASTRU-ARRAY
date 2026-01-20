using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_act5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Louis Aian Cuyos
            // ACTIVITY 5: Customize a User-Input Method

            // Call the method to register athletes
            Sports[,] sportsArray = RegisterAthletes();

            Console.Clear();
            Console.WriteLine("\n--- FINAL REGISTERED ATHLETES LIST ---");

            // Display information of all registered athletes
            foreach (var sport in sportsArray)
            {
                sport.DisplayInfo();
                Console.WriteLine("--------------------------------");
            }
            Console.ReadKey();
        }
        // Method to register athletes
        static Sports[,] RegisterAthletes()
 {
     // Create a 2D array to hold Sports objects
     Sports[,] sportsArray = new Sports[2, 3];
     Console.ForegroundColor = ConsoleColor.Yellow;
     // Loop to gather user input for each athlete
     for (int i = 0; i < sportsArray.GetLength(0); i++)
     {
         // Prompt user to choose sport
         Console.Write("\n\tChoose Sport: [1] Basketball [2] Arnis: ");
         string choice = Console.ReadLine();
         Console.WriteLine("\n\tSelection: " + (choice == "1" ? "Basketball" : "Arnis"));
         // Inner loop to gather details for each athlete
         for (int j = 0; j < sportsArray.GetLength(1); j++)
         {
             // Choose Department
             Console.WriteLine("\tAvailable Department --- CCS, CBM, CN, CASP ---");
             Console.Write("\tDept: "); string dept = Console.ReadLine();
             Console.Write("\tName: "); string name = Console.ReadLine();
             Console.Write("\tID  : "); string id = Console.ReadLine();
             if (choice == "1") // Basketball
             {
                 Console.Write("\tPts : ");
                 int pts = int.Parse(Console.ReadLine());
                 sportsArray[i, j] = new Basketball(dept, name, id, pts);
             }
             else // Arnis
             {
                 Console.Write("\tMatches Won : ");
                 int matchesWon = int.Parse(Console.ReadLine());
                 sportsArray[i, j] = new Arnis(dept, name, id, matchesWon);
             }
             Console.WriteLine("\tAdded successfully.\n");
         }
     }
     return sportsArray;
 }



