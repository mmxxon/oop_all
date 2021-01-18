using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2 {
  public delegate void ModeDelegate();
  class Program {
    static void Main(string[] args) {
      Device dev = new Device();
      Phone phone = new Phone();
      dev.workingMode += phone.reaction;
      dev.Mode();

      try {
        phone.Message =
          "SOOOOOMETHING with really long text for sms texting. For example, this text that more then 30 symbols sooooo";
      } catch (OverLengthError e) { Console.WriteLine(e.err); }

      Console.ReadKey();
    }
  }

}
