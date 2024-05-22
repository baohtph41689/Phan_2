using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productCar
{
    public class car
        
    {   
        private string name;
        private string color;
        private int power;

        //khai bao thuoc tinh properties
        public string Name { get; set; }
        public string Color { get; set; }
        public int Power {  get; set; }
        //khai bao ham khoi tao contructor
        public car(string _name , string _color) {
            this.Name = _name;
            this.Color = _color;
        }

        public car()
        {

        }

        // phuong thuc
        public void getInfor () {
            Console.WriteLine($"name:{this.name} , Color:{this.color} , power:{this.power}km/h");
        }
    }
}
