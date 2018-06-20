using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class V12Engine : DecoratorClass
    {
        public V12Engine(Car car) : base(car)
        {
            
        }
		public override void Initial_car_cost()
		{
			car.Cost += getEngineCost();
		}

		private int getEngineCost()
		{
            if (car.Model == "E" || car.Model == "CS")
			{
				return 6000;
			}
			else
			{
				Error = "V-12 not available on " + car.Model;
			}
			return 0;
		}
    }
}
