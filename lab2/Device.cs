using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Device : Electronics
    {
        public event ModeDelegate workingMode;
        public string modeDevice="ALARM RINGING!!!";
        public bool isWorking = true;

        public Action WorkingMode { get; internal set; }

        public override void On()
        {
            Console.WriteLine("Device is switched on");
        }
        public override void Off()
        {
            Console.WriteLine("Device is switched off");
        }

        public void Mode()
        {
            if (isWorking)
            {
                // Console.WriteLine("Working mode: on");
                if (workingMode != null)
                {
                    workingMode(this);
                }
            }
        }
        public delegate void ModeDelegate(Device d);

    }
}
