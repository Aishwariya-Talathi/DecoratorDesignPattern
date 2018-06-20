using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
	public class CupHolder : DecoratorClass
    {
        public CupHolder(Car car) : base(car)
        {
		}
		public override void Initial_car_cost()
		{
            car.Cost += 1;
		}
	}
}
