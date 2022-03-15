using System;

namespace _16._03._2022_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("C1");
            Pineapple pineapple = new Pineapple("C");
            Lemon lemon = new Lemon("A1");
            BasketList<Fruit> fruits = new BasketList<Fruit>();

            fruits.Add(lemon);
            fruits.Add(apple);
            fruits.Add(pineapple);

            foreach (Fruit item in fruits.GetArray())
            {
                Console.WriteLine(item);
            }
        }
    }
}
