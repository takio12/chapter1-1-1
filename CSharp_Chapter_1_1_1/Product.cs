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

        public int GetTax()
        {
            return (int)(Price * 0.08);
        }
    }
}