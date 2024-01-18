using Sana07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoductLibrary
{
    internal class Fruits : Product
    {
        protected string name;
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (value != null)
                    name = value;
                else throw new Exception("Введіть назву фрукту");
            }
        }
        protected int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if ((value > 0))
                    price = value;
                else throw new Exception("Ціна товару має бути більшою або дорівнювати нулю");
            }
        }
        protected int count;
        public int Count
        {
            get { return count; }
            set
            {
                if ((value > 0))
                    price = value;
                else throw new Exception("Кількість товару має бути більшою або дорівнювати нулю");
            }
        }
        public Fruits(string name,int price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }
        public override string Display()
        {
            return $"Назва товару: {Name}; Ціна товару: {Price}; Кількість одиниць товару: {Count};";
        }
    }
}
