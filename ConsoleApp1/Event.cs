using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Event
    {
        public string Date { get; set; }
        public string Desc { get; set; }
        private string SecretKey { get; set; }
        public List<User> Participants { get; set; }
    }
}
