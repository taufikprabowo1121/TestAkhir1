using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal2
{
    class Program
    {
        static void Main(string[] args)
        {
            int diameter;
            double phi = 3.14;
           
            Console.Write("Masukan diameter : ");
            diameter = int.Parse(Console.ReadLine());
            double radius = diameter / 2;
            double luas = phi * radius * radius;
            Console.WriteLine("--------------------------");
            Console.WriteLine("Radius : " + radius);
            Console.WriteLine("Luas dan Keliling Lingkaran :"+ luas );
            Console.WriteLine("---------------------------");

            Console.ReadKey();
        }
    }
}
