using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgCA4
{
    public class Bet
    {
        public string RaceCourse { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }

        public Bet() { }
        

        public Bet(string raceCourse, DateTime date, decimal amount, string status)
        {
            RaceCourse = raceCourse;
            Date = date;
            Amount = amount;
            Status = status;
        }

    }
}
