/*При открытие программы он справшивает:
Выберите действие:
a) Показать список продуктов
b) Добавить новый продукт
с) Продать продукт

Если a:
Выводите в консол список продуктов
Если b:
Вводите имя
Вводите количество
Добавьте новый продукт в файл
Если продукт существует, увеличте количество
Если c:
Вводите имя
Вводите количество
Уменьшить количество продукта*/

using System.Linq.Expressions;
using System.Text;
while (true)
{
    Console.WriteLine("Выберите действие:\r\n a) Показать список продуктов\r\n b) Добавить новый продукт\r\n с) Продать продукт");

    string[] products = File.ReadAllLines("store.txt", Encoding.UTF8);
    /*string newlyadded = "Себ1";
    int count = 10;*/

    string textFromConsole = Console.ReadLine();

    switch (textFromConsole)
    {
        case "a":
            for (int i = 0; i < products.Length; i++)
            {
                string product = products[i];
                var splitted = product.Split(' ');

                string productName = splitted[0];
                int countOfProduct = int.Parse(splitted[1]);
                Console.WriteLine($"{productName} {countOfProduct}");
            }
            break;
        //case==b;
        case "b":
            Console.WriteLine("Enter a new productName");
            string newPruductName = Console.ReadLine();

            Console.WriteLine("Enter the new product count");
            int newPruductCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < products.Length; i++)
            {
                string product = products[i];
                var splitted = product.Split(' ');

                string productName = splitted[0];
                int countOfProduct = int.Parse(splitted[1]);
                if (productName == newPruductName)
                {
                    countOfProduct += newPruductCount;
                }
                products[i] = $"{productName} {countOfProduct}";
            }
            string[] added = new string[products.Length + 1];
            for (int i = 0; i < products.Length; i++)
            {
                added[i] = products[i];
            }
            //    added[products.Length] = $"{newPruductName} {newPruductCount}";

            File.WriteAllLines("store.txt", added, Encoding.UTF8);
            break;
        //case == c;
        case "c":
            Console.Write("Enter the productName: ");
            string productName1 = Console.ReadLine();

            Console.Write("Enter the count of product:");
            int productCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < products.Length; i++)
            {
                string product = products[i];
                var splitted = product.Split(' ');

                string productName = splitted[0];
                int countOfProduct = int.Parse(splitted[1]);
                if (productName == productName1)
                {
                    countOfProduct -= productCount;
                }

                products[i] = $"{productName} {countOfProduct}";
            }
            File.WriteAllLines("store.txt", products, Encoding.UTF8);

            break;
        default:
            Console.WriteLine("You can only use \"a,b,c\".");
            break;
    } //swisch
}