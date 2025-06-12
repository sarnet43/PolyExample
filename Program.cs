using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    class Program
    {
        public void TestC()
        {
            Dog dog = new Dog();
            dog.Public();
        }
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                 new Dog(), new Dog(), new Dog(),
                 new Cat(), new Cat(), new Cat()
            };
           
            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                
                if(item is Dog)
                {
                    ((Dog)item).Bark();
                }

                Cat cat = item as Cat;
                if(cat != null)
                {
                    cat.Meow();
                }
            }

        }
    }
}
