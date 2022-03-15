using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._03._2022_Task
{
    internal class Lemon : Fruit
    {
        public Lemon(string vitamin) : base(vitamin)
        {
        }
        public override string ToString()
        {
            return $"Lemon vitamin :{Vitamin} ";
        }
    }
}
