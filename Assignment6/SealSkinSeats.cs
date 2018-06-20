using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
	public class SealSkinSeats : DecoratorClass
	{
        public SealSkinSeats(Car car) : base(car)
        {
		}

		public override void Initial_car_cost()
		{
			car.Cost += getSeatCost();
		}

		private int getSeatCost()
		{
			if (car.Model == "C")
			{
				return 5600;
			}
			else
			{
				Error= "Seal Skin Seats not available on " + car.Model;
			}
			return 0;
		}
	}
}
