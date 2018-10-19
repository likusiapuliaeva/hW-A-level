using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз11
{
    public class Igrok_bloknot:Igrok, IHod
    {

        public override int Hod()
        {
            Random random = new Random();
            return random.Next(40, 140);
        }
    }
}
