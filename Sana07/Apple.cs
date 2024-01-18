using Sana07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoductLibrary
{
    public class Apple : Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public Apple( string name, int price, int count) {
        Name= name;
            Price= price;
            Count= count;
        }

        public override string Display()
        {
            return $"Назва товару: {Name}; Ціна товару: {Price}; Кількість одиниць товару: {Count};";
        }
    }
}
