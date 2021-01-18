using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    interface ISMS
    {
        void WriteMessageTo(string abonent, string message);
        void ReadMessageFrom(string abonent);
        void notification();
    }
}
