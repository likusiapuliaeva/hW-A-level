using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз11
{
    public class Igrok:IHod
    {
        public string name { get; set;}
        public int corzinaI;

        public int CorzinoI
        {
            get
            {
                return Hod();
            }
            set
            {
                corzinaI = value;
            }
        }

        public virtual int Hod()
        {
            Random random = new Random();
            return random.Next(40, 140);
        }
    }
}
