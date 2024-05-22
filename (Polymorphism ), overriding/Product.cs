using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Polymorphism____overriding
{
    public class Product
    {   
        // thuoc tinh
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        // them tu khoa virtual d khai bao 1 phuong thuc ao 
        public virtual void  getInfor()
        {
            Console.WriteLine($"Name:{Name}, Description:{Description}, price:{Price}");

        }

        public void Test()
        {
            getInfor();
        }  
    }

    public class Iphone : Product
    {
        public Iphone()
        {
            Name = "15promax";
            Description = "design by apple ram 16gb";
            Price = 2000;
        }
        // override - lap trong phuong thuc
        public override void getInfor()
        {
            Console.WriteLine($"Dien thoai Iphone:{Name}, Mo ta:{Description}, Gia Ban:{Price}");
        }
    }
}
