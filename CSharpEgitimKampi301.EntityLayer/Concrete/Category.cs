using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}
/*
        bir değişken yapısı;
        Property -> get ve set değerlerini alırsa 
        field -> class içinde kullanılırsa
        variable -> methodların içinde kullanılırsa
        */