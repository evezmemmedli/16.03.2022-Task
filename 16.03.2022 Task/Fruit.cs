using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._03._2022_Task
{
    internal abstract class Fruit
    {
        private protected string Vitamin;
        public Fruit(string vitamin)
        {
            Vitamin = vitamin;
        }

        public override string ToString()
        {
            return $" Fruit vitamins : {Vitamin}";
        }
    }
}
