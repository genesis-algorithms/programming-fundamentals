/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 14:
|
|     Write a class GSMTest, which has to test the functionality
|     of class GSM. Create few objects of the class and store them
|     into an array. Display information about the created objects.
|     Display information about the static field nokiaN95.
|
| Solutions and Guidelines:
|
|     Add a method PrintInfo() in class GSM.
|
*/

using System;

namespace Program
{
    public class GSM
    {
        private string model = null;
        private string manufacturer = null;
        private double price = 0;
        private string owner = null;
        private static string nokia95 = "Nokia95";

        public string Model { get => model; set => model = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public double Price { get => price; set => price = value; }
        public string Owner { get => owner; set => owner = value; }

        public GSM()
            : this(null) { }

        public GSM(string model)
            : this(model, null) { }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0) { }

        public GSM(string model, string manufacturer, double price)
            : this(model, manufacturer, price, null) { }

        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        public static void DisplayNokia95Info()
        {
            Console.WriteLine(nokia95);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Model: " + this.Model + "\nManufacturer: " + this.Manufacturer + "\nPrice: " +
                this.Price + "$" + "\nOwner: " + this.Owner + "\n");
        }

        public override string ToString()
        {
            return "Model: " + this.model + "\nManufacturer: " + this.manufacturer + "\nPrice: " +
                this.price + "$" + "\nOwner: " + this.owner + "\n";
        }
    }

    public class Battery
    {
        private string model = null;
        private double idleTime = 0;
        private double talkHours = 0;
        public enum BatteryTypes { None, LiIon, NiMH, NiCd, LiPol }
        private BatteryTypes batteryType;

        public string Model { get => model; set => model = value; }
        public double IdleTime { get => idleTime; set => idleTime = value; }
        public double TalkHours { get => talkHours; set => talkHours = value; }
        public BatteryTypes BatteryType { get => batteryType; set => batteryType = value; }

        public Battery()
            : this(null) { }

        public Battery(string model)
            : this(model, 0) { }

        public Battery(string model, double idleTime)
            : this(model, idleTime, 0) { }

        public Battery(string model, double idleTime, double talkHours)
            : this(model, idleTime, talkHours, BatteryTypes.None) { }

        public Battery(string model, double idleTime, double talkHours, BatteryTypes battery)
        {
            this.Model = model;
            this.IdleTime = idleTime;
            this.TalkHours = talkHours;
            this.BatteryType = battery;
        }
    }

    public class Display
    {
        private double size;
        private double colors;

        public double Size { get => size; set => size = value; }
        public double Colors { get => colors; set => colors = value; }

        public Display()
            : this(0) { }

        public Display(double size)
            : this(size, 0) { }

        public Display(double size, double colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
    }

    public class GSMTest
    {
        public static void Main(string[] args)
        {
            GSM[] GSMArray = new GSM[3];
            GSMArray[0] = new GSM(); ;
            GSMArray[1] = new GSM("6t", "OnePlus", 400); ;
            GSMArray[2] = new GSM("Poccophone", "Xiaomi", 250, "Chewbacca", "Coolness"); ;

            foreach (GSM gsm in GSMArray)
                gsm.PrintInfo();

            GSM.DisplayNokia95Info();
        }
    }
}