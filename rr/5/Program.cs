using System;

namespace _5
{
    abstract class Command
    {
        public abstract void Save();
        public abstract void TrailingSave();
        public abstract void ArchiveSave();
    }
    // конкретная команда
    class ConcreteCommand : Command
    {
        Receiver receiver;
        public ConcreteCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Save()
        {
            receiver.Save();
        }

        public override void TrailingSave()
        {
            receiver.Trail();
            receiver.Save();
        }
        public override void ArchiveSave()
        {
            receiver.Archieve();
            receiver.Save();
        }
    }

    // получатель команды
    class Receiver
    {
        public void Save()
        {
            Console.WriteLine("Saved");
        }
        public void Trail()
        {
            Console.WriteLine("Trailed spaces");
        }
        public void Archieve()
        {
            Console.WriteLine("Archiving text");
        }
    }
    // инициатор команды
    class Invoker
    {
        Command command;
        public void SetCommand(Command c)
        {
            command = c;
        }
        public void Save()
        {
            command.Save();
        }
        public void TrailingSave()
        {
            command.TrailingSave();
        }
        public void ArchiveSave()
        {
            command.ArchiveSave();
        }
    }
    class Program
    {
        static void Main()
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);
            invoker.SetCommand(command);
            invoker.Save();
            Console.WriteLine("---");
            invoker.TrailingSave();
            Console.WriteLine("---");
            invoker.ArchiveSave();
        }
    }
}
