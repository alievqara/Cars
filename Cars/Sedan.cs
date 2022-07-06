using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Sedan
    {

        public string Model;
        public int topSpeed;
        public string Color;
        public string Price;



        public Sedan()
        {
            //Console.WriteLine("Default");

        }

        public Sedan(string model, int topSpeed, string color, string price) : this()
        {
            Model = model;
            this.topSpeed = topSpeed;
            Color = color;
            Price = price;


            //Console.WriteLine("Custom");

        }
    }
}
