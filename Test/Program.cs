using PoductLibrary;
using Sana07;

ShoppingCart shoppingCart= new ShoppingCart();
shoppingCart.AddProduct(new Vegetable("Огiрок", "Зелений", 10, 100));
shoppingCart.AddProduct(new Gadget("Iphone 15",6,128,60000,10));
shoppingCart.AddProduct(new Furniture("Стiл","Дерево", 10000, 5));
Console.WriteLine(shoppingCart.ProductsInfo());
Console.WriteLine(shoppingCart.AllProductsSum());