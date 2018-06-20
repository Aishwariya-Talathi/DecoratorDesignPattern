using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
	public class PumaSkinSeats : DecoratorClass
	{
        public PumaSkinSeats(Car car) : base(car)
        {
		}
		public override void Initial_car_cost()
		{
			car.Cost += getSeatCost();
		}

		private int getSeatCost()
		{
			if (car.Model == "E")
			{
				return 7000;
			}
			else
			{
				Error = "Puma skin Seats not available on " + car.Model;
			}
			return 0;
		}
	}
}
