using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Car_C : Car
    {
        public Car_C()
        {
            Model = "C";
        }

        public override void Initial_car_cost()
        {
            Cost = 28000;
        }
    }
}
