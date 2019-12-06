using System;

namespace AdventOfCode2019.Day1
{
    public class Assignment2
    {

        private static int totalFuelNeeded = 0;

        public static void FuelCounterUpper(int mass)
        {
            int moduleFuelNeeded = TotalModuleFuelCalculator(mass);
            totalFuelNeeded += moduleFuelNeeded;
            
        }

        public static int GetTotalFuelNeeded()
        {
            return totalFuelNeeded;
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
            int fuelNeeded = (int)Math.Floor((decimal)fuelNeededDivided) - 2;

            return fuelNeeded;
        }
    }
}
