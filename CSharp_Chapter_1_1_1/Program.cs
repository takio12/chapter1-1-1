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
           
            Product dorayaki = new Product(98,"どら焼き",210);
            var doratax = dorayaki.GetTax();
            Console.WriteLine($"{doratax}円");
            //C#6.0visual studio2015からドルマークを書くことで、直接変数を記入できるように

            Console.ReadKey();
        }
    }

}
