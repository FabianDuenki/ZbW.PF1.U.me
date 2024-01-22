using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB04.HandtaschenBeispiel
{
    public class Handtasche
    {
        private string _name;
        private double _price;
        public Handtasche() { }
        public Handtasche(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name
        {
            get{return this._name;}
            set{this._name = value;}
        }
        public double Price
        {
            get { return this._price;}
            set { this._price = value;}
        }
        //public override string ToString()
        //{
        //    return this.Name+ "\t" + this.Price;
        //}
    }

}
