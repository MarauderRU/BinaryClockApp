using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class BinaryClock //conver time to binary nums in strings
        {
            private DateTime dt;
            public byte hour, min, sec;

            public BinaryClock()
            {
                dt = DateTime.Now;
            }

            public string GetTime(int gmt)
            {
                dt = DateTime.UtcNow;
                dt = dt.AddHours(gmt);

                hour = (byte)dt.Hour;
                min = (byte)dt.Minute;
                sec = (byte)dt.Second;

                return Convert.ToString(hour, 2).PadLeft(8, '0') + ":"
                            + Convert.ToString(min, 2).PadLeft(8, '0') + ":"
                            + Convert.ToString(sec, 2).PadLeft(8, '0');
            }

            public string GetHour()
            {
                return Convert.ToString(hour, 2).PadLeft(8, '0');
            }

            public string GetMin()
            {
                return Convert.ToString(min, 2).PadLeft(8, '0');
            }

            public string GetSec()
            {
                return Convert.ToString(sec, 2).PadLeft(8, '0');
            }

        }

        static void Main(string[] args)
        {
            BinaryClock clock = new BinaryClock();

            while (true)
            {
                Console.Write(clock.GetTime(3) + "\r");
            }//while
        }
    }
}