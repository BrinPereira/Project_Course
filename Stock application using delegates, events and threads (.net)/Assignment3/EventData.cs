using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class EventData : EventArgs
    {
        public string event_Sname;
        public int event_currentValue;
        public int event_numberChange;
 
    // class constructor      
        public EventData(string name, int currentValue, int numberchange)
        {
            this.event_Sname = name;
            this.event_currentValue = currentValue;
            this.event_numberChange = numberchange;
        }

        public string Event_Sname { get => event_Sname; set => event_Sname = value; }
        public int Event_currentValue { get => event_currentValue; set => event_currentValue = value; }
        public int Event_numberChange { get => event_numberChange; set => event_numberChange = value; }
    }
}

