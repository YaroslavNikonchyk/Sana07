using Sana07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoductLibrary
{
    public class Vegetable : Product
    {

        protected string sort;
        public string Sort
        {
            get { return sort; }
            set
            {
                if (value != null)
                    sort = value;
                else throw new Exception($"Задайте сорт цього овочу: {name}");
            }
        }
        public Vegetable(string name, string sort, int price, int count) 
            : base(name, price, count)
        {
            this.sort = sort;
        }
        public override string Display()
        {
            return $"Назва овочу: {name};\nСорт: {sort};\nЦіна за одну одиницю: {price} UAH;\nКількість одиниць товару: {count};\n";
        }
    }
}
