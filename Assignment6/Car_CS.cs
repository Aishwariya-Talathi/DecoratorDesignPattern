using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Car_CS : Car
    {
        public Car_CS()
        {
            Model = "CS";
        }
        public override void Initial_car_cost()
        {
            Cost = 54000;
        }
    }
}
