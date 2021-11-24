using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koshka
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Барсик", new DateTime(2015, 8, 22));
            Cat cat1 = new Cat("Маруся", new DateTime(2010, 4, 15));
            cat.makenoise();
            Console.WriteLine($"знакомьтесь, {cat.Name}, ему уже {cat.getage()} лет");
            cat.Hungrystatus = 150;
            Console.WriteLine("Hungry = " + cat.Hungrystatus + "\n");
            cat.getstatus();
            cat.HungryStatusChanged += Cat_HungryStatusChanged;
            cat1.makenoise();
            Console.WriteLine($"знакомьтесь, {cat1.Name}, ей уже {cat1.getage()} лет");
            cat1.Hungrystatus = 150;
            Console.WriteLine("Hungry = " + cat.Hungrystatus + "\n");
            cat1.getstatus();
            Console.ReadLine();
            cat1.HungryStatusChanged += Cat_HungryStatusChanged;

        }

        private static void Cat_HungryStatusChanged(object sender, EventArgs e)
        {

        }
    }
}
