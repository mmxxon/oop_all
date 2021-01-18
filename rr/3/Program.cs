using System;

namespace _3 {
  public class Box {
    public int count;
    public string type;
    public IdInfo IdInfo;

    public Box DeepCopy() {
      Box clone = (Box) this.MemberwiseClone();
      clone.IdInfo = new IdInfo(IdInfo.IdNumber);
      clone.type = String.Copy(type);
      return clone;
    }
  }

  public class IdInfo {
    public int IdNumber;

    public IdInfo(int idNumber) { this.IdNumber = idNumber; }
  }

  class Program {
    static void Main(string[] args) {
      Box p1 = new Box();
      p1.count = 42;
      p1.type = "Candy";
      p1.IdInfo = new IdInfo(666);

      Box p2 = p1.DeepCopy();

      Console.WriteLine("Original values of box1, box2: ");
      Console.WriteLine("   box1 instance values: ");
      DisplayValues(p1);
      Console.WriteLine("   box2 instance values:");
      DisplayValues(p2);

      p1.count = 32;
      p1.type = "Toy";
      p1.IdInfo.IdNumber = 7878;
      Console.WriteLine("\nValues of box1, box2 after changes to box1:");
      Console.WriteLine("   box1 values: ");
      DisplayValues(p1);
      Console.WriteLine("   box2 values: ");
      DisplayValues(p2);
    }

    public static void DisplayValues(Box p) {
      Console.WriteLine("      Count: {0:d}, Type: {1:s}", p.count, p.type);
      Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
    }
  }
}
