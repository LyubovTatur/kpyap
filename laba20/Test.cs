using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba20
{
    class Test
    {
        double progress;
        double currentResult;
        public Test()
        {
            Progress = 0;
            CurrentResult = 0;
        }

        public double CurrentResult { get => currentResult; set => currentResult = value; }
        public double Progress { get => progress; set => progress = value; }
    }
}
