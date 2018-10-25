/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 11:
|
|     Add an enumeration BatteryType, which contains the values
|     for type of the battery (Li-Ion, NiMH, NiCd, ...) and use it
|     as a new field for the class Battery.
|
| Solutions and Guidelines:
|
|     Use enum for the type of battery. Search in Internet for other
|     types of batteries for phones, except these in the requirements
|     and add them as value of the enumeration.
|
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class GSM
    {
        private string model = null;
        private string manufacturer = null;
        private double price = 0;
        private string owner = null;
        private string features = null;
        private static string nokia95 = "Nokia 95";

        public GSM()
        {

        }

        public GSM(string model)
            :this(model, null)
        {

        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0)
        {

        }

        public GSM(string model, string manufacturer, double price)
            : this(model, manufacturer, price, null)
        {

        }

        public GSM(string model, string manufacturer, double price, string owner)
            : this(model, manufacturer, price, owner, null)
        {

        }

        public GSM(string model, string manufacturer, double price, string owner, string features)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.features = features;
        }

        public static void DisplayNokia95Info()
        {
            Console.WriteLine(nokia95);
        }
    }

    public class Battery
    {
        private string model = null;
        private int idleTime = 0;
        private int talkHours = 0;
        public enum BatteryType { Li_Ion, NiMH, NiCd, Li_Pol }
        private BatteryType battery;

        public Battery()
        {

        }

        public Battery(string model)
            : this(model, 0)
        {

        }

        public Battery(string model, int idleTime)
            : this(model, idleTime, 0)
        {

        }

        public Battery(string model, int idleTime, double talkHours)
            : this (model, idleTime, talkHours, BatteryType.Li_Ion)
        {

        }

        public Battery(string model, int idleTime, double talkHours, BatteryType battery)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.talkHours = talkHours;
            this.battery = battery;
        }
    }

    public class Display
    {
        private double size;
        private double colors;

        public Display()
        {

        }

        public Display(double size)
            : this(size, 0)
        {

        }

        public Display(double size, double colors)
        {
            this.size = size;
            this.colors = colors;
        }
    }

    public class Tester
    {
        public static void DisplayExceptionDetails(Exception e)
        {
            Console.Write("\n\nDo you want to see error details? (Y/N): ");
            string userChoice = Console.ReadLine();
            if (userChoice == "Y" || userChoice == "y")
                Console.WriteLine("\n" + e.StackTrace);
        }

        public static void Main(string[] args)
        {
            try
            {
                GSM gsm1 = new GSM();
                GSM gsm2 = new GSM("Mi Max 3", "Xiaomi");
                GSM gsm3 = new GSM("Poccophone", "Xiaomi", 300);

            }
            catch (Exception gmsException)
            {
                Console.WriteLine("GSM class has problem.");
                DisplayExceptionDetails(gmsException);
            }

            try
            {
                Battery batter1 = new Battery("Li-Ion", 30);
                Battery battery2 = new Battery("Li-Ion", 40, 6);
                Battery battery3 = new Battery("Li-Ion", 0, 0, Battery.BatteryType.Li_Ion);
            }
            catch (Exception batteryException)
            {
                Console.WriteLine("Battery class problem.");
                DisplayExceptionDetails(batteryException);
            }

            try
            {
                Display display1 = new Display(6.44);
                Display display2 = new Display(6.44, 160.000);
            }
            catch (Exception displayException)
            {
                Console.WriteLine("Display class problem.");
                DisplayExceptionDetails(displayException);
            }
        }
    }
}