using DataStructures.Structures.BinarySearch.Example;
using System;

namespace DataStructures.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[9] { 5,5,5,5,5,5,5,5,9};
            IntBynarySearch bs = new IntBynarySearch();
            var value = bs.GetIndex(array,9);

            Console.WriteLine(value);
            Console.Read();
        }
    }
}
