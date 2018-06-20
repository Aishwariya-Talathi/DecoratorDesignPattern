using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public abstract class Car
    {
        private String Car_Model;
        private int Car_Cost;
        private String Error_msg = "";
        public abstract void Initial_car_cost();
        public int Cost
        {
            get {
                return Car_Cost;
            }
            set {
                Car_Cost = value;
            }
        }
        public String Model
        {
            get {
                return Car_Model;
            }
            set {
                Car_Model = value;
            }
        }
        public String Error
        {
            get {
                return Error_msg;
            }
            set {
                Error_msg = value;
            }
        }
    }
}
