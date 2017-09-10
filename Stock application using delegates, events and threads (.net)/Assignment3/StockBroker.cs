using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Assignment3
{
    class StockBroker
    {
        string broker_name;
        List<Stock> stock_list = new List<Stock>();
        public string Broker_name { get => broker_name; set => broker_name = value; }

    // static readonly object to lock one process at a time for synchronization of threads.
        private static readonly System.Object lockThis = new System.Object();
 
    // Constructor of StockBroker. 
        public StockBroker(string name)
        {
            this.broker_name = name;
        }
       
    // Method for adding Broker list.
        public void AddStock(Stock s)
        {
            stock_list.Add(s);
    
    // Synchronizaion of Notify events. 
            s.Notify += c_notify;
        }

    // method to write the output to the console and store data in text file. 
    // lock for threading is used so that multithreading is achieved in synchronization manner. 
        public void c_notify(Object sender, EventData e)
        {
    
    // lock used for synchronization of various threads. 
            lock (lockThis)
            {
                string output = broker_name.PadRight(10) + e.Event_Sname.PadRight(10) + "     " + e.Event_currentValue + "        " + e.Event_numberChange;
                Console.WriteLine(output);
                StockData.writeFile(output);
            }
        }       
    }
}
