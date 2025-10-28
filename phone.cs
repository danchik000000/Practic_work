using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone
{
    internal class Phone
    {
        private int battery;
        public int BatteryLevel
        {
            get { return battery; }
            set
            {
                if (value < 0)
                    battery = 0;
                else if (value > 100)
                {
                    Console.WriteLine("Заряд не может превышать 100!");
                    battery = 100;
                }
                else
                    battery = value;
            }
        }

        public string Brand { get; private set; }

        public Phone(string brand, int initialBattery)
        {
            Brand = brand;
            BatteryLevel = initialBattery; 
        }
        public void Use()
        {
            if (battery - 10 < 0)
            {
                battery = 0;
            }
            else
            {
                battery -= 10;
            }
            Console.WriteLine($"{Brand}: заряд {battery}%.");
        }
    }
}
