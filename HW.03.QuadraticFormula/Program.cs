double a, b, c, d, x, x1, x2;

Console.WriteLine("Введите значение а");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение c");
c = Convert.ToDouble(Console.ReadLine());

d = b * b - 4 * a * c;

if (d == 0)
    {
        x = (-b / 2 * a);
        Console.WriteLine($"В уравнении один корень: x = {x}");
    } 
else if (d > 0)
{
    x1 = (-b + Math.Sqrt(b * b - 4 * a * c) / 2 * a);
    x2 = (-b - Math.Sqrt(b * b - 4 * a * c) / 2 * a);

    Console.WriteLine($"В уравнении два корня: x1 = {x1}, x2 = {x2}");
}
else
{
    Console.WriteLine("Уравнение не имеет корней");
}



