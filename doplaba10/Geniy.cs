using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doplaba10
{
    class Geniy : Student
    {
        public Geniy(string fIO, int kolvo) : base(fIO, kolvo)
        {
        }
        public bool Zachet()
        {
            if (kolvo > TotalKolvo || kolvo < 0)
            {
                Console.WriteLine("ошибка");
            }
            
            if (kolvo > 0)
            {
                return true;
            }
            else
                return false;
            
        }
    }
}
