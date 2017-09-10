using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assignment3
{
    // this class stores data in text file. 
    class StockData
    {
         private const string dir = @"F:\CSU LONG BEACH\summer 2017\dotnet\";
         const string path = dir + "Brokers.txt";
     
    // default constructor.
        public StockData()
        {}
    
    // method to write all the values displayed on console on text.
        public static void writeFile(string output)
        {
            using (StreamWriter outputFile = new StreamWriter(new FileStream(path, FileMode.Append)))
            {
                outputFile.WriteLine(output);
            }
        }
    }
}
