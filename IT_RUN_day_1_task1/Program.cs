/*
 Программа для решение квадратных уравнений ax^2+ bx + c = 0
Вводите а
Вводите b
Вводите c
Дискриминант: xyz
x1 =
x2 =
*/
while (true)
{

    int a, b, c;
    double x1, x2, d;

    Console.WriteLine("Enter the nunber - a:");
    a = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the nunber - b:");
    b = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the nunber - c:");
    c = int.Parse(Console.ReadLine());

    d = Math.Pow(b, 2) - 4 * a * c;

    if (d > 0)
    {
        x1 = (-b - (Math.Sqrt(d))) / (2 * a);
        x2 = (-b + (Math.Sqrt(d))) / (2 * a);

        Console.WriteLine($"the equation has 2 solutions: x1 and x2");
        Console.WriteLine($"x1 equal to {x1}");
        Console.WriteLine($"x2 equal to {x2}");
    }
    else if (d == 0)
    {
        x1 = (-b / (2 * a));

        Console.WriteLine($"the equation has 1 solutions: x");
        Console.WriteLine($"x equal to {x1}");
    }
    else Console.WriteLine($"the equation does not have a solution because d<0!");

}
