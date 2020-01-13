namespace PolyMorphism
{
    partial class Program
    {
        //Compile Time Polymorphism Example. Method Overloading.
        static void Main(string[] args)
        {
            var c = new Calculate();
            c.AddNumbers(1, 2);
            c.AddNumbers(1, 2, 3);
        }
    }
}
