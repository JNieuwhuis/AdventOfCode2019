using System;
using System.IO;

public class Assignment1
{
	public Assignment1()
	{
	}

    public static void Main()
    {
        try
        {
            using (StreamReader sr = new StreamReader("Input.txt"))
            {
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }

    public void ReadInput()
    {

    }

    public void FuelCounterUpper()
    {

    }
}
