using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace AdventOfCode2019.Day1
{
    public class Assignment1
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
                        FuelCounterUpper(line);
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

        public static void FuelCounterUpper(string massValue)
        {
            int mass = Int32.Parse(massValue);
            int fuelNeeded = (mass / 3) - 2;
            //Console.WriteLine("Fuel needed: " + fuelNeeded);
            totalFuelNeeded += fuelNeeded;
        }
    }
}
