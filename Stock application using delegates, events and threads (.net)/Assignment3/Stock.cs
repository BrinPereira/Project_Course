using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Assignment3
{
    class Stock
    {
        string stock_name;
        int stock_intialValue;
        int stock_currentValue;
        int stock_maxChange;
        int notification_threshold;
        int num_Changes = 0;
        Thread stock_thread;
    
     // event handler. 
        public event EventHandler<EventData> Notify;
     // EventData property.
        private EventData stock_Event;

     // constructor of Class Stock.
        public Stock(string name, int intialValue, int maxChange, int threshold)
        {
            this.stock_name = name;
            this.stock_intialValue = intialValue;
            stock_currentValue = stock_intialValue;
            this.stock_maxChange = maxChange;
            this.notification_threshold = threshold;

    // Thread intializing and starting of thread for every new broker. 
            stock_thread = new Thread(new ThreadStart(Activate));
            stock_thread.Start();
        }
        
    // EventData property accessor.
        public EventData Stock_Event { get => stock_Event; set => stock_Event = value; }
    
    // Activate method to start the program.
        public void Activate()
        {
            for (int i = 0; i < 15; i++)
            {
                Thread.Sleep(500);
                ChangeStockValue();
            }
        }
    
    // method for change in stock value after a threshold is reached. Event is raised when threshold is reached to notify the broker. 
        public void ChangeStockValue()
        {
            Random num_random = new Random();
            stock_currentValue += num_random.Next(1, stock_maxChange);
            if ((stock_currentValue - stock_intialValue) > notification_threshold)
            {
                num_Changes++;
                EventData args = new EventData(stock_name, stock_currentValue, num_Changes);
                OnNotify(args);
            }
        }

    // Event is started.
        protected virtual void OnNotify(EventData e)
        {
    // There are two methods of raising and invoking the events. 
    // method 1:          
           /*
            EventHandler<EventData> handler = Notify;
            if (handler != null)
            {
                handler(this, e);
            }            */    // method 2: 
            Notify?.Invoke(this, e);
        }
    }
}
