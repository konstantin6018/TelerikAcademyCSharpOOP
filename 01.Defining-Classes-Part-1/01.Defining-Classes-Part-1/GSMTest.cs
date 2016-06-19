namespace _01.Defining_Classes_Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSMTest
    {

        static void Main(string[] args)
        {
            GSMOutput();
            CallHistoryTest();
        }
        static void GSMOutput()
        {
            GSM[] phones = new GSM[]
         {
           new GSM("S5", "Samsung", 1000, "Gosho",
                    new Battery("G2", 50, 5, BatteryType.Li_Ion), new Display(5, 500000)),
           new GSM("5X", "Nexus", 3000, "Ivan",
                    new Battery("Z3", 422, 134, BatteryType.NiMH), new Display(7, 213123)),
           new GSM("Z5", "Sony", 3000, "Pesho",
                    new Battery("BR2", 444, 155, BatteryType.NiCd), new Display(12, 122314))
         };
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine("================================================================");
                Console.WriteLine(phones[i]);
            }
            Console.WriteLine("================================================================");
            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine();
        }
        static void CallHistoryTest()
        {
            Console.WriteLine("===================Call History Test===================");

            GSM lg = new GSM("G4", "LG", 1000, "Petkan", new Battery("G2", 50, 5, BatteryType.Li_Ion), new Display(5, 60000));
            lg.AddCall(new Calls("28/04/2016", "14:46", "0886723987", 144));
            lg.AddCall(new Calls("15/03/2015", "13:42", "0885885937", 751));
            lg.AddCall(new Calls("01/06/2016", "18:13", "0883946721", 451));

            for (int i = 0; i < lg.CallHistory.Count; i++)
            {
                Console.WriteLine(lg.CallHistory[i]);
            }
            Console.WriteLine("Calls Price: {0:f2}", lg.GetTotalCallPrice(0.37m));

            Calls longestCall = lg.CallHistory[0];
            foreach (var call in lg.CallHistory)
            {
                if (call.Duration > longestCall.Duration)
                {
                    longestCall = call;
                }
            }
            lg.DeleteCall(longestCall);
            Console.WriteLine("Calls Price without longest: {0:f2}", lg.GetTotalCallPrice(0.37m));
            lg.ClearCallHistory();
            Console.WriteLine("Call history cleared!");
        }
    }
}

