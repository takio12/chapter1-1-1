using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doradora
{

    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(int code, string name,int price)
        {
            this.Code = code;
                this.Name = name;
            this.Price = price;
        }
        public int GetTax()
        {
            return (int)(Price * 0.08);
        }
    }
}