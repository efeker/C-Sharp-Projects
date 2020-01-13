namespace PolyMorphism
{

    class Program
    {
        //Run Time Polymorphism Example. Method Overriding.
        static void Main(string[] args)
        {
            var b = new BaseClass();
            b.GetInfo();
            var d = new DerivedClass();
            d.GetInfo();
        }
    }
}