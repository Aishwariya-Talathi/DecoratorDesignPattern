using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
	public class SpareTire : DecoratorClass
	{
        public SpareTire(Car car) : base(car)
        {
		}
		public override void Initial_car_cost()
		{
			car.Cost += 400;
		}
	}
}
