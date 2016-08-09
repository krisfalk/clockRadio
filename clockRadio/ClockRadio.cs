using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clockRadio
{
    public class clockRadio
    {
        public string setTimePrint()
        {
            Console.WriteLine("Please enter the time: \r\n Hours:");
            int Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Minutes:");
            int Minutes = Convert.ToInt32(Console.ReadLine());
            return Hours + ":" + Minutes;
            //Console.WriteLine("Clock time is " + Hours + ":" + Minutes);
        }
        public double setStationPrint()
        {
            Console.WriteLine("Please enter radio station: (ex.101.5)");
            double station = Convert.ToDouble(Console.ReadLine());
            return station;
            //Console.WriteLine("Your current radio station is " + station);
        }
        public int setVolumePrint()
        {
            Console.WriteLine("Please enter volume: (1-20)");
            int volume = Convert.ToInt32(Console.ReadLine());
            return volume;
            //Console.WriteLine("Volume is currently set at {0} [0-20]", Volume);
        }
    }
}
