using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace AdventOfCode2019.Day1
{
    public class Assignment1
    {

        private static int totalFuelNeeded = 0;

        public static void FuelCounterUpper(int mass)
        {
            int fuelNeededDivided = mass / 3;
            int fuelNeeded = (int)Math.Floor((decimal)fuelNeededDivided) - 2;

            totalFuelNeeded += fuelNeeded;
        }

        public static int GetTotalFuelNeeded()
        {
            return totalFuelNeeded;
        }
    }
}
