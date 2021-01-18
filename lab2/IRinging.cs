using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    interface IRinging
    {
        bool isCallStarted { get; set; }
        void notification();
        void Call(string number);
        
    }
}
