using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba15_dop
{
    [Serializable]
    class Kotiksi
    {
        string name;
        string color;

        public Kotiksi(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
    }
}
