using System;

namespace PolyMorphism
{
    //Compile Time Polymorphism Example. Method Overloading.
    public class Calculate
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("a+b = {0}", a + b);
        }

        public void AddNumbers(int a, int b, int c)
        {
            Console.WriteLine("a+b+c = {0}", a + b + c);
        }
    }
}
