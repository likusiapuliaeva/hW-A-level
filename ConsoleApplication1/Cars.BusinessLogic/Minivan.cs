using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.BusinessLogic
{
    public class Minivan : Car,IStoring
    {
        public int Capacity { get; set; }



        public override double Discont()
        {
            if (DateTime.Now.Month > 2 && DateTime.Now.Month < 5)
            {
                return price - (price * 0.4);
            }
            else
            {
                return price;
            }

        }
        public int GetStoringTerm()
        {
            return 6;
        }
    }
 }



