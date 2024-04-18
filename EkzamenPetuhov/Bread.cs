using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EkzamenPetuhov
{
    internal class Bread
    {
        public int VesHelba { get; set; }
        public int CenaHleba { get; set; }
        public int PriceForKilo(int Ves, int Cena)
        {
            return Ves * Cena;
        }
    }
}
