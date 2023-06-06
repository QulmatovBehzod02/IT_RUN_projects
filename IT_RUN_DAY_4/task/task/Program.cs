using StoreDay1;

string filePath = "store.txt";
Store store = new Store("banan",5);

Store.SaveToFile(filePath, store);

/*
Product[] products = Store.GetProducts(filePath);
Console.WriteLine("Количество продуктов: " + products.Length);*/

bool productExists = Store.ProductExists("Product1", filePath);
Console.WriteLine("Продукт существует: " + productExists);

Console.ReadLine();

