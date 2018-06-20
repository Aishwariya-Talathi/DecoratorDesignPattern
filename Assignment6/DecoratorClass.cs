using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public abstract class DecoratorClass : Car
    {
        protected Car car;
        public DecoratorClass(Car car)
        {
            this.car = car;
        }

        public override void Initial_car_cost()
        {
            car.Initial_car_cost();
        }
    }
}
