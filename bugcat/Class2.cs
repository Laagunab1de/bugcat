using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koshka
{
    internal class CatSmartHouse
    {

        List<Cat> cats = new List<Cat>();
        public int foodResourse;

        public int FoodResoure
        {
            get { return foodResourse; }
            set { foodResourse = 1000; }
        }
        public void addcat(object sender, Cat cat)
        {

            var Cat = (Cat)sender;
            if (cat.hungrystatus <= 20 && foodResourse > 0)
            {

                byte needFood = (byte)(100 - cat.hungrystatus);
                if (foodResourse > needFood)
                    foodResourse -= needFood;
                else
                {
                    needFood = (byte)foodResourse;
                    foodResourse = 0;
                }
                cat.Feed(needFood);
                Console.WriteLine($"Покормлена кошка: {cat.Name}\nОстаток еды в вольере: {foodResourse}");
            }
        }
    }
}
