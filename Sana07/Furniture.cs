using Sana07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoductLibrary
{
    public class Furniture : Product
    {
        protected string material;
        public string Material
        {
            get { return material; }
            set
            {
                if (value != null)
                    material = value;
                else throw new Exception($"Вкажіть з якого матеріалу виготовлено цей виріб: {name}");
            }
        }
        public Furniture(string name, string material, int price, int count)
            : base(name,price,count)
        {
            this.material = material;
        }
        public override string Display()
        {
            return $"Назва товару: {name};\nМатеріал з якого виготовлено товар: {material};" +
                $"\nЦіна товару: {price} UAH;\nКількість одиниць товару: {count};\n";
        }
    }
}
