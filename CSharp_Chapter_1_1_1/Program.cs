using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doradora;
/// <summary>
/// </summary>
namespace CSharp_Chapter_1_1_1
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           
            Product dorayaki = new Product();
            dorayaki.Code = 98;
            dorayaki.Price = 210;
            Console.WriteLine(dorayaki.GetTax());
            Console.ReadKey();
        }
    }

}
