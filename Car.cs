using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic11
{
    internal class Car
    {
        private int speed;
        public string Model { get; set; } = "Unknown";
        public int Speed
        {
            get => speed;
            set
            {
                if (value < 0 || value > 300)
                {
                    Console.WriteLine("Скорость не может быть меньше 0 или больше 300!");
                    speed = value < 0 ? 0 : 300;
                }
                else
                {
                    speed = value;
                }
            }
        } 
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        public void Drive()
        {
            Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч");
        }
    }
}
