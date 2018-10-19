using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.BusinessLogic
{
    public class Gruzovik : Car
    {
        public int Gruzodjemnost { get; set;}

        public override double Discont()
        {
            return price - (price * 0.5);

        }
    }


 
}
