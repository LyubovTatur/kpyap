using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    public class MyException : Exception
    {
        // Собственное исключение имеет специальную строчку
        // и в этом её отличие.
        public string MyMessage;
        // Кроме того, в поле её базового элемента
        // также фиксируется особое сообщение.
        public MyException(string str) : base("MyException is here...")
        {
            MyMessage = str;
        }
    }
}
