using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Electronics
    {
        public string typeOfProduct = "Electronics";
        public abstract void On();
        public abstract void Off();
    }
}