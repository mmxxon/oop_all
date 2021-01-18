using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main()
        {
            Teacher director = new Teacher("Director: ");
            Teacher dephead1 = new Teacher("Deputy Head 1: ");
            director.Add(dephead1);
            Teacher dephead2 = new Teacher("Deputy Head 2: ");
            director.Add(dephead2);
            Teacher teacher1 = new Teacher("Teacher 1: ");
            Teacher teacher2 = new Teacher("Teacher 2: ");
            Teacher teacher3 = new Teacher("Teacher 3: ");
            dephead1.Add(teacher1);
            dephead1.Add(teacher2);
            dephead2.Add(teacher3);
            Parent parent1_1 = new Parent("Parent 1: ");
            Parent parent2_1 = new Parent("Parent 1: ");
            Parent parent2_2 = new Parent("Parent 2: ");
            Parent parent3_1 = new Parent("Parent 1: ");
            teacher1.Add(parent1_1);
            teacher2.Add(parent2_1);
            teacher2.Add(parent2_2);
            teacher3.Add(parent3_1);
            director.GetCash();
            director.Display(2);
        }
    }
    abstract class Human
    {
        protected string name;
        protected int mula;
        // Constructor
        public Human(string name)
        {
            this.name = name;
        }
        public abstract void Add(Human c);
        public abstract void Remove(Human c);
        public abstract int GetCash();
        public abstract void Display(int depth);
    }
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    class Teacher : Human
    {
        private List<Human> _children = new List<Human>();
        // Constructor
        public Teacher(string name) : base(name)
        {
            this.mula = 0;
        }
        public override void Add(Human component)
        {
            _children.Add(component);
        }
        public override void Remove(Human component)
        {
            _children.Remove(component);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " " + this.mula.ToString());
            // Recursively display child nodes
            foreach (Human component in _children)
                component.Display(depth + 2);
        }
        public override int GetCash()
        {
            this.mula = 0;
            foreach (Human component in _children)
                this.mula += component.GetCash();
            return this.mula;
        }
    }
    class Parent : Human
    {
        public Parent(string name) : base(name)
        {
            Random rnd = new Random();
            this.mula = rnd.Next(150);
        }
        public override void Add(Human c)
        {
            Console.WriteLine("Impossible operation");
        }
        public override void Remove(Human c)
        {
            Console.WriteLine("Impossible operation");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " " + mula.ToString());
        }
        public override int GetCash()
        {
            return this.mula;
        }
    }
}
