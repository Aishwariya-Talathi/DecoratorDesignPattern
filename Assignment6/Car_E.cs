using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Car_E : Car
    {
        public Car_E()
        {
            Model = "E";
        }
        public override void Initial_car_cost()
        {
            Cost = 41000;
        }
    }
}
