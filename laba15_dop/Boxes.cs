using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba15_dop
{
    [Serializable]
    class Boxes
    {
        int number;
        string made_of;
        Kotiksi[] kotiksi;
        public Boxes(int number, string made_of, Kotiksi[] kotiksi)
        {
            this.number = number;
            this.made_of = made_of;
            this.kotiksi = kotiksi;
        }
    }
}
