using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._03._2022_Task
{
    internal class BasketList<T>
    {
        private T[] array;

        public BasketList()
        {
            array = new T[0];
        }
        public void Add(T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
        }

        public T[] GetArray()
        {
            return array;
        }
    }
}
