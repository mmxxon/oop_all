using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Computer : Device, IDownload
    {
        public  void  DownloadProgram(string name)
        {
            Console.WriteLine("Program "+name+" is downloaded successfuly");
        }
    }
}
