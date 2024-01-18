using System.ComponentModel.DataAnnotations;

namespace Sana07
{
    public abstract class Product
    {
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                    name = value;
                else throw new Exception("Введіть назву товару");
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
                    count = value;
                else throw new Exception("Кількість товару має бути більшою або дорівнювати нулю");
            }
        }
        public Product(string name, int price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public abstract string Display();
    }
}