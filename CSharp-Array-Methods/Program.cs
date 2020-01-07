using System;

namespace ArrayExercises
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ArrayFunctions numbers = new ArrayFunctions(length: 3);
            numbers.Insert(item: 10);
            numbers.Insert(item: 20);
            numbers.Insert(item: 30);
            numbers.Insert(item: 40);
            numbers.Insert(item: 40);

            //numbers.RemoveAt(index:3); 
            //numbers.Print();
            //Console.WriteLine(numbers.IndexOf(40));
            //Console.WriteLine(numbers.FindMax());
            //numbers.FindIntersect();
            //numbers.ReverseArray();
            //numbers.InsertAt(2, 5);
        }
    }
}
