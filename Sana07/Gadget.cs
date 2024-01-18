using Sana07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoductLibrary
{
    public class Gadget : Product
    {
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
            : base (name, price,count)
        {
            this.rem = rem;
            this.memory = memory;
        }
        public override string Display()
        {
            return $"Назва гаджету: {name};\nКількість оперативної пам'яті гаджету: {rem};" +
                $"\nКількість пам'яті гаджету: {memory};\nЦіна товару: {price} UAH;" +
                $"\nКількість одиниць товару: {count};\n";
        }
    }
}
