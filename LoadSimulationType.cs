using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stresstest
{
        public enum LoadSimulationType
        {
            RampConstant = 0,
            KeepConstant = 1,
            RampPerSec = 2,
            InjectPerSec = 3,
        }  
}
