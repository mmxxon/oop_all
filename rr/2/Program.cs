using System;

namespace _2 {

  public interface Interface {
    void FormDocs();
  }

  class Accounting: Interface {
    public void FormDocs() { Console.WriteLine("Accounting: Forming docs."); }
  }

  class Proxy: Interface {
    private Accounting _real_accounting;

    public Proxy(Accounting realSubject) {
      this._real_accounting = realSubject;
    }
    public void FormDocs() {
      if (this.CheckPayment()) {
        this._real_accounting.FormDocs();
        this.LogAccess();
      }
    }

    public bool CheckPayment() {

      Console.WriteLine("Proxy: Checking payment.");

      return true;
    }

    public void LogAccess() {
      Console.WriteLine("Proxy: Logging the time of request.");
    }
  }

  public class Client {

    public void ClientCode(Interface subject) { subject.FormDocs(); }
  }

  class Program {

    static void Main(string[] args) {
      Client client = new Client();

      Console.WriteLine("Without proxy");
      Accounting realSubject = new Accounting();
      client.ClientCode(realSubject);

      Console.WriteLine();

      Console.WriteLine("With proxy");
      Proxy proxy = new Proxy(realSubject);
      client.ClientCode(proxy);
    }
  }
}
