using PoductLibrary;
using Sana07;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Product cucumber = new Vegetable("Огiрок", "Зелений", 10, 100);
Product table = new Furniture("Стiл", "Дерево", 10000, 5);
Product phone = new Gadget("Iphone 15", 6, 128, 60000, 10);
ShoppingCart shoppingCart= new ShoppingCart();

Console.WriteLine(cucumber.Display());
Console.WriteLine(table.Display());
Console.WriteLine(phone.Display());

shoppingCart.AddProduct(cucumber);
shoppingCart.AddProduct(table);
shoppingCart.AddProduct(phone);

Console.WriteLine(shoppingCart.ProductsInfo());
Console.WriteLine(shoppingCart.AllProductsSum());