using System;
using System.Collections.Generic;
using System.Text;

namespace Bibs
{
    class GSM
    {
        public string Model;
        public string Manufacturer;
        public double Price;
        public string Owner;
        public GSM()
        {
            this.Model = null;
            this.Manufacturer = null;
            this.Price = 0;
            this.Owner = null;

        }
        public GSM(string model)
        {
            this.Model = model;
            this.Manufacturer = null;
            this.Price = 0;
            this.Owner = null;
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = 0;
            this.Owner = null;
        }

        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        public string getModel
        {
            get { return Model; }
            set { Model = value; }
        }

        public string getmanufacturer
        {
            get { return Manufacturer; }
            set { Manufacturer = value; }
        }

        public double getprice
        {
            get { return Price; }
            set { Price = value; }
        }

        public string getOwner
        {
            get { return Owner; }
            set { Owner = value; }
        }
        public static string NokiaN95 = "NOKIA N95 Best phone UWU";    

        public void DisInfo()
        {
            Console.WriteLine("Model: "+ Model);
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Owner: " + Owner);
        }
    }

    
}
