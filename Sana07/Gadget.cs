using Sana07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoductLibrary
{
    internal class Gadget : Product
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
            get { return price; }
            set
            {
                if ((value >= 0))
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
                if ((value >= 0))
                    price = value;
                else throw new Exception("Кількість товару має бути більшою або дорівнювати нулю");
            }
        }
        protected int rem;
        public int Rem
        {
            get { return rem; }
            set
            {
                if ((value > 0))
                    rem = value;
                else throw new Exception("Оперативної пам'яті не може бути менше 0");
            }
        }
        protected int memory;
        public int Memory
        {
            get { return memory; }
            set
            {
                if ((value > 0))
                    memory = value;
                else throw new Exception("Оперативної пам'яті не може бути менше 0");
            }
        }
        public Gadget(string name, int rem, int memory, int price, int count)
        {
            this.name = name;
            this.rem = rem;
            this.memory = memory;
            this.price = price;
            this.count = count;

        }
        public override string Display()
        {
            return $"Назва гаджету: {name}; Кількість оперативної пам'яті гаджету: {rem}; Кількість пам'яті гаджету: {memory}; Ціна товару: {price}; Кількість одиниць товару: {count};";
        }
    }
}
