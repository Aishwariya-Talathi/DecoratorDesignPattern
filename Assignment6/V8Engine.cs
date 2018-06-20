using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class V8Engine : DecoratorClass
    {
        public V8Engine(Car car) : base(car)
        {
            
        }
        public override void Initial_car_cost()
        {
            car.Cost += getEngineCost();
        }

        private int getEngineCost()
        {
            if(car.Model == "C") {
                return 4000;
            }
            else {
                Error = "V-8 not available on " + car.Model;
            }
            return 0;
        }
    }
}
