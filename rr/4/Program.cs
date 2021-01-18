using System;

namespace _4 {
  class Server {
    private State _state = null;

    public Server(State state) { this.TransitionTo(state); }

    public void TransitionTo(State state) {
      Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
      this._state = state;
      this._state.SetContext(this);
    }

    public void Request1() { this._state.Overload(); }

    public void Request2() { this._state.ReduceLoad(); }

    public void Request3() { this._state.Connect(); }
  }

  abstract class State {
    protected Server _context;

    public void SetContext(Server context) { this._context = context; }

    public abstract void Overload();

    public abstract void ReduceLoad();

    public abstract void Connect();
  }

  class StateNormal: State {
    public override void Overload() {
      Console.WriteLine("State switched to \"Overloaded\"");
      this._context.TransitionTo(new StateOverloaded());
    }

    public override void ReduceLoad() {
      Console.WriteLine("StateNormal tried to reduce load.");
    }

    public override void Connect() {
      Console.WriteLine("Connection successful");
    }
  }

  class StateOverloaded: State {
    public override void Overload() {
      Console.Write("StateOverloaded tried to overload.");
    }

    public override void ReduceLoad() {
      Console.WriteLine("State switched to \"Normal\"");
      this._context.TransitionTo(new StateNormal());
    }
    public override void Connect() { Console.WriteLine("Server overloaded"); }
  }

  class Program {
    static void Main(string[] args) {
      var server = new Server(new StateNormal());
      server.Request1();
      server.Request3();
      server.Request2();
      server.Request3();
    }
  }
}
