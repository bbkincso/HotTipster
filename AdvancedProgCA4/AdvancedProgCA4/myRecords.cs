using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgCA4
{
    public class myRecords
    {
        public static List<Bet> LoadMyRecords()
        {
          Bet bet = new Bet();
          List<Bet> output = new List<Bet>();
            
            output.Add(new Bet { RaceCourse = "Aintree", Date = Convert.ToDateTime("12/05/2017"), Amount = 11.58m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Punchestown", Date = Convert.ToDateTime("22/12/2016"), Amount = 122.52m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Sandown", Date = Convert.ToDateTime("17/11/2016"), Amount = 20.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Ayr", Date = Convert.ToDateTime("03/11/2016"), Amount = 25.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Fairyhouse", Date = Convert.ToDateTime("02/12/2016"), Amount = 65.75m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Ayr", Date = Convert.ToDateTime("11/03/2017"), Amount = 12.05m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Doncaster", Date = Convert.ToDateTime("02/12/2017"), Amount = 10.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Towcester", Date = Convert.ToDateTime("12/03/2016"), Amount = 50.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Goodwood", Date = Convert.ToDateTime("07/10/2017"), Amount = 525.74m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Kelso", Date = Convert.ToDateTime("13/09/2016"), Amount = 43.21m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Punchestown", Date = Convert.ToDateTime("05/07/2017"), Amount = 35.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Ascot", Date = Convert.ToDateTime("04/02/2016"), Amount = 23.65m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Kelso", Date = Convert.ToDateTime("02/08/2017"), Amount = 30.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Towcester", Date = Convert.ToDateTime("01/05/2017"), Amount = 104.33m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Ascot", Date = Convert.ToDateTime("21/06/2017"), Amount = 25.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Bangor", Date = Convert.ToDateTime("22/12/2016"), Amount = 30.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Ayr", Date = Convert.ToDateTime("22/05/2017"), Amount = 11.50m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Ascot", Date = Convert.ToDateTime("23/06/2017"), Amount = 30.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Ascot", Date = Convert.ToDateTime("23/06/2017"), Amount = 374.27m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Goodwood", Date = Convert.ToDateTime("05/10/2016"), Amount = 34.12m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Dundalk", Date = Convert.ToDateTime("09/11/2016"), Amount = 20.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Haydock", Date = Convert.ToDateTime("12/11/2016"), Amount = 87.00m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Perth", Date = Convert.ToDateTime("20/01/2017"), Amount = 15.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "York", Date = Convert.ToDateTime("11/11/2017"), Amount = 101.25m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Punchestown", Date = Convert.ToDateTime("22/12/2016"), Amount = 11.50m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Chester", Date = Convert.ToDateTime("14/08/2016"), Amount = 10.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Kelso", Date = Convert.ToDateTime("18/09/2016"), Amount = 10.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Kilbeggan", Date = Convert.ToDateTime("03/03/2017"), Amount = 20.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Fairyhouse", Date = Convert.ToDateTime("11/03/2017"), Amount = 55.50m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Punchestown", Date = Convert.ToDateTime("15/11/2016"), Amount = 10.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Towcester", Date = Convert.ToDateTime("08/05/2016"), Amount = 16.55m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Punchestown", Date = Convert.ToDateTime("23/05/2016"), Amount = 13.71m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Cork", Date = Convert.ToDateTime("30/11/2016"), Amount = 20.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Punchestown", Date = Convert.ToDateTime("25/04/2016"), Amount = 13.45m, Status = "true" });
            output.Add(new Bet { RaceCourse = "Bangor", Date = Convert.ToDateTime("23/01/2016"), Amount = 10.00m, Status = "false" });
            output.Add(new Bet { RaceCourse = "Sandown", Date = Convert.ToDateTime("07/08/2017"), Amount = 25.00m, Status = "false" });
            return output;
        }
    }
}
