using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
   public class Car
    {
        private string _brend { get; set; }
        public string Model { get; set; }
        protected string Type { get; set; }

        public Car()
        {

        }
        public Car( string brand, string model, string type)
        {
            Type = type;
            Brend = brand;
            Model = model;
        }

    }
}
