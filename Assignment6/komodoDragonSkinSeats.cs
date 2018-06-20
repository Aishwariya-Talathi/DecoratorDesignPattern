using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
	public class komodoDragonSkinSeats : DecoratorClass
	{
        public komodoDragonSkinSeats(Car car) : base(car)
        {
		}
		public override void Initial_car_cost()
		{
			car.Cost += getSeatCost();
		}

		private int getSeatCost()
		{
			if (car.Model == "CS")
			{
				return 12000;
			}
			else
			{
				Error= "komodo Dragon Skin Seats not available on " + car.Model;
			}
			return 0;
		}
	}
}
