using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("BMW", 150);
            myCar.Drive();
            myCar.Speed = 400;
            myCar.Drive(); 
            myCar.Speed = -50;
            myCar.Drive();
        }
    }
}
