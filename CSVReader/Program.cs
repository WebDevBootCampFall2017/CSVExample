using System.IO;
using System;

namespace CSVReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Open File
            FileStream fr = File.OpenRead("./Addresses.csv");

            //Step 1.5 Convert the FileStream Object into a StreamReader
            StreamReader sr = new StreamReader(fr);

            //Step 2: Loop over Lines
            string line = sr.ReadLine();
            while (line != null) {

                //Step 2.1: Print out a row
                Console.WriteLine(line);

                //Step 2.2: Split values into columns
                string[] values_array = line.Split(',');

                //Step 2.3: Loop ever and print each column value
                for (int i = 0; i < values_array.Length; i++)
                {
                    //Step 2.3.1: Print out each item
                    Console.WriteLine(values_array[i].Trim());

                }

                //Step 2.4: Read Next Line
                line = sr.ReadLine();

            }

            Console.ReadKey();
        }
    }
}