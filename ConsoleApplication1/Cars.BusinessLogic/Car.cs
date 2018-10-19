using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.BusinessLogic
{
    public class Car : IDiscont
    {
        public string name { get; set; }
        public string color { get; set; }
        public double price;
        public double Discount;
        


        public double Price
        {
            get
            {
                return Discont();
            }
            set
            {
                price = value;
            }
        }

        public virtual double Discont()
        {
            return price - (price * 0.2);
        }
    }
}
