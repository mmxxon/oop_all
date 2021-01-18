using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Device dev = new Device(2019, 1200.32f, true);
            Phone phone = new Phone();
            Console.ReadKey(); 
        }
    }
    class Device
    {
        private int yearOfProducting;
        private float price;
        protected string ipAdress;
        internal string manufacturer;
        const bool isDevice = true;
        readonly string fieldOfComercial = "Electronics";
        protected bool isWork;
        public static string typeOfElectronics = "This is device";
        public Device() : this(0, 0, true) { } //перевизначення за замовуванням
        public Device(int year, float cost, bool isWorking)
        {
            yearOfProducting = year;
            price = cost;
            isWork = isWorking;
        }
        public virtual int deviceAge() { return 0; }
        public string IP
        {  get
            {
                return this.ipAdress;
            }
            set
            {
                    this.ipAdress = value;
            }
        }
        public float Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
            }
        }
        public int Year
        {
            get { return this.yearOfProducting; }
            set
            {
                if (value > 1900)
                {
                    this.yearOfProducting = value;
                }
            }
        }
        public virtual void typeOfDevice()
        {
            Console.WriteLine(typeOfElectronics);
        }

        public void switchOn()
        {
            Console.WriteLine("Device is working");
        }
        public enum Colors {
            none,
            silver,
            grey,
            black,
            white,
            gold,
        }
    }
    class Phone : Device {
        public Phone()
        {
            Console.WriteLine("\nConstractor of the phone");
        }
        //private int year;
        new public static string typeOfElectronics = "\nThis is a Phone";
        public override int deviceAge()
        {
            return 2020 - Year;
        }
        public enum Brand
        {
            none,
            Samsung,
            Apple,
            Nokia,
            Xiomi,
            Meizu,
        }
        public override void typeOfDevice()
        {
            Console.WriteLine(typeOfElectronics);
        }
        protected Brand brandOfPhone;
        protected Colors color;
    }
    class Smartphone : Phone {
        
        private Smartphone()
        {
            Console.WriteLine("\nConstractor of the  Smartphone");
        }
        private Smartphone SmartphoneInstance { get; set; }
        public static Smartphone GetSmartphoneInstance()
        {
            if (SmartphoneInstance == null)
            {
                SmartphoneInstance = new Smartphone();
            }
            return SmartphoneInstance;

        }
        new public static string typeOfElectronics = "This is a smartphone";
        private float sizeOfDisplay;

        public float Display
        {
            get { return sizeOfDisplay; }
            set { sizeOfDisplay = value; }
        }
        public override int deviceAge()
        {
            return 2020 - Year;
        }
        public override void typeOfDevice()
        {
            Console.WriteLine(typeOfElectronics);
        }

    }
    class Computer : Device {
        new public static string typeOfElectronics = "This is a computer";
        private string processor;
        private float display;
        private int battery;
    
       public Computer(string proc, float disp, int batt)
        {
            processor = proc;
            display = disp;
            battery = batt;
        }
        public enum Brand
        {
            none,
            Samsung,
            Apple,
            Asus,
            Acer,
            Del,
            Xiomi,
        }
        public override int deviceAge()
        {
            return 2020 - Year;
        }
        public override void typeOfDevice()
        {
            Console.WriteLine(typeOfElectronics);
        }
    }

    class MP3 : Device
    {
        private string model;
        public  string Model
        {
            get { return model; }
            set { model = value; }
        }
        new public static string typeOfElectronics =  "This is a MP3";
        static MP3()
        {
            Console.WriteLine("\n Static constractor for MP3");
        }
        public override int deviceAge()
        {
            return 2020 - Year;
        }
        public override void typeOfDevice()
        {
            Console.WriteLine(typeOfElectronics);
        }
    }

}
