using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._03._2022_Task
{
    internal class Apple : Fruit
    {
        public Apple(string vitamin) : base(vitamin)
        {
        }
        public override string ToString()
        {
            return $"Apple vitamin :{Vitamin} ";
        }
    }
}
