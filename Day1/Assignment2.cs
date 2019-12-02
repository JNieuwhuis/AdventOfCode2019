using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace AdventOfCode2019.Day1
{
    public class Assignment2
    {
        
        private static int totalFuelNeeded = 0;

        public static void Main()
        {
            ReadInput();
        }

        public static void ReadInput()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\jan\Source\Repos\AdventOfCode2019\Day1\Input.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        String line = sr.ReadLine();
                        int totalModuleFuelNeeded = TotalModuleFuelCalculator(Int32.Parse(line));
                        FuelCounterUpper(totalModuleFuelNeeded);
                    }
                    
                    Console.WriteLine("Total fuel needed: " + totalFuelNeeded);
                    Console.ReadKey();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static int TotalModuleFuelCalculator(int mass)
        {
            int moduleFuelNeeded = 0;
            int remainingMass = mass;

            while (!(CalculateFuel(remainingMass) <= 0))
            {
                int answer = CalculateFuel(remainingMass);
                moduleFuelNeeded += answer;
                remainingMass = answer;
            }

           //Console.WriteLine("The fuel needed for this module is: " + moduleFuelNeeded);
            return moduleFuelNeeded;
        }

        public static int CalculateFuel(int mass)
        {
            int fuelNeededDivided = mass / 3;
            int fuelNeeded = (int)Math.Floor((decimal) fuelNeededDivided) -2;

            return fuelNeeded;
        }

        public static void FuelCounterUpper(int totalModuleFuelNeeded)
        {
            totalFuelNeeded += totalModuleFuelNeeded;
        }
    }
}
