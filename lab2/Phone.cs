using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2 {
  class Phone: Device, ISMS, IRinging, IDownload {
    protected string message;
    public string Message {
      set {
        if (value.Length > 0 && value.Length <= 30)
          message = value;
        else
          throw new OverLengthError(new ExceptionArgs(value, 30));
      }
      get { return message; }
    }
    public void reaction(Device d) {
      Console.WriteLine("It is working mood: ", d.modeDevice);
    }

    public void DownloadProgram(string name) {
      Console.WriteLine("Program " + name + " is downloaded successfuly");
    }
    void ISMS.notification() { Console.WriteLine($"Notification from SMS"); }
    void IRinging.notification() {
      Console.WriteLine($"Notification from Ringing");
    }
    public void WriteMessageTo(string abonent, string message) {
      Console.WriteLine($"You have written {abonent}: {message}");
    }
    public void ReadMessageFrom(string abonent) {
      Console.WriteLine($"You have read message from {abonent}");
    }
    public bool isCallStarted { get; set; }
    public void Call(string number) {
      Console.WriteLine($"You are calling to {number}");
    }
  }
}
