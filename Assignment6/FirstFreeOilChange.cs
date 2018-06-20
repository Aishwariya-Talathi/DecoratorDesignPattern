using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
	public class FirstFreeOilChange : DecoratorClass
	{
        public FirstFreeOilChange(Car car) : base(car)
        {
		}
		public override void Initial_car_cost()
		{
			car.Cost += 75;
		}
	}
}
