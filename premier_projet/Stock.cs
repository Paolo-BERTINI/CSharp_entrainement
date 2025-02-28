using System;

namespace App
{
    public class Stock // abstract, abstract y partial no entendi Marce. Static tampoco
    {
        private int Capacity;
        public Stock()
        {
            Capacity = 10;
        }
        public Stock(int capacity)
        {
            Capacity = capacity;
        }
        public override string ToString() => $"Capacité du stock égal à {Capacity}";
    }
}
