using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    class Dog : Animal
    {
        public void Test2()
        {
            Protected(); //상속된 자식에서는 protected 접근 가능
            Public();
        }

        public string Color { get; set; }

        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }

    }
}
