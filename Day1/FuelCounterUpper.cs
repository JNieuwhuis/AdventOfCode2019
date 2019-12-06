using System;
using System.IO;


namespace AdventOfCode2019.Day1
{
    public class FuelCounterUpper
    {
        private static int fuelFromAssignment1;
        private static int fuelFromAssignment2;

        public static void Main()
        {
            ReadInput();
            Console.WriteLine("Determining the amount of fuel needed for launch...");
            Console.WriteLine("Total fuel needed: " + fuelFromAssignment1);
            Console.WriteLine("Wait! The elves found an error with the calculation");
            Console.WriteLine("Recalculating fuel...");
            Console.WriteLine("Total fuel needed: " + fuelFromAssignment2);
            Console.ReadKey();
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
                        Assignment1.FuelCounterUpper(Int32.Parse(line));
                        Assignment2.FuelCounterUpper(Int32.Parse(line));
                    }
                }

                fuelFromAssignment1 = Assignment1.GetTotalFuelNeeded();
                fuelFromAssignment2 = Assignment2.GetTotalFuelNeeded();
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
