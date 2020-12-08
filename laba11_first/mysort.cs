using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11_first
{
    class mysort : IComparer
    {
        public int Compare(object x, object y)
        {
            int ob1 = (int)x;
            int ob2 = (int)y;
            if ((ob1 == 10 ||ob1 == 8 || ob1 == 6) && (ob2 != 10 && ob2 != 8 && ob2 != 6))
            {
                return -1;
            }
            if((ob2 == 10 || ob2 == 8 || ob2 == 6) && (ob1 != 10 && ob1 != 8 && ob1 != 6))
            {
                return 1;
            }

            if (ob1 == 10 && (ob2 == 8 || ob2 == 6))
            {
                return -1;
            }
            if (ob2 == 10 && (ob1 == 8 || ob1 == 6))
            {
                return 1;
            }
            if(ob1 == 6 && (ob2 == 10 || ob2 == 8))
            {
                return 1;
            }
            if (ob2 == 6 && (ob1 == 10 || ob1 == 8))
            {
                return -1;
            }
            if (ob1 == 8 && ob2 == 10)
            {
                return 1;
            }
            if (ob2 == 8 && ob1 == 10)
            {
                return -1;
            }
            return 0;
        }
    }
}
