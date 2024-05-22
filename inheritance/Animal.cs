using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Animal
    {
        public string Id {  get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Animal(string id , string name , double price) {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        
        }

        public void getInfor()
        {
            Console.WriteLine($"id:{Id},Name:{Name},Price:{Price}");
        }
    }

    public class Laptop : Animal
    {
        string Origin { get; set; }
        public Laptop(string id, string name, double price,string Origin) : base(id, name, price)
        {
            this.Origin = Origin;
        }

       
        public new void getInfor()
        {
            base.getInfor();
            Console.WriteLine($"id{Id},Name:{Name},Price:{Price},Origin:{Origin}");
        }
    }
}
