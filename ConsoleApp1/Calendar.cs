using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calendar
    {
        private List<Event> events = new List<Event>();
        public void AddEvent(Event e)
        {
            events.Add(e);
        }
        public void DisplayEvents()
        {
            foreach (Event e in events)
            {
                Console.WriteLine($"Подія о {e.Date}: {e.Desc}");
            }
        }
    }
}