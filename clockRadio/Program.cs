using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clockRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            string time;
            double radioStation;
            int volume;

            Console.WriteLine("Welcome to my clock radio!");
            clockRadio clockRadio = new clockRadio();

            time = clockRadio.setTimePrint();
            radioStation = clockRadio.setStationPrint();
            volume = clockRadio.setVolumePrint();

            Console.WriteLine("My clock radio is set at: \r\n The Time is " + time + "\r\n Current radio station is on " + radioStation + "\r\n Volume is set at " + volume);
            Console.ReadLine();

            //Console.WriteLine("Please enter the time:");
            //Console.WriteLine("Hour:");
            //hours = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Minutes:");
            //minutes = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter the radio station: (ex. 101.5)");
            //radioStation = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("What volume do you want the radio at: (0-20)");
            //volume = Convert.ToInt32(Console.ReadLine());

            //Console.ReadLine();

            //Console.WriteLine("My clock radio is set at:");

            //clockRadio clockRadio = new clockRadio();
            //clockRadio.setTimePrint(hours, minutes);
            //clockRadio.setStationPrint(radioStation);
            //clockRadio.setVolumePrint(volume);

            //Console.ReadLine();
        }
    }
}
