using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
	public class SunRoof : DecoratorClass
	{
		public SunRoof(Car car) : base(car)
        {
            
		}

		public override void Initial_car_cost()
		{
			car.Cost += getSunRoofCost();
		}

        private int getSunRoofCost()
		{
            if (car.Model == "C")
            {
                return 1900;
            }
            else if (car.Model == "E")
            {
                return 2200;
            }
            else return 3000; //For Model : CS
		}
	}
}
