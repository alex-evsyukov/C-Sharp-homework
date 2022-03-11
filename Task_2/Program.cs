// По двум заданным числам проверять является ли первое квадратом
double a, b;
string s = string.Empty;

System.Console.WriteLine("Введите первое число: ");
s = Console.ReadLine();
a = Convert.ToDouble(s);

System.Console.WriteLine("Введите второе число: ");
s = Console.ReadLine();
b = Convert.ToDouble(s);

if (a == Math.Pow(b, 2))
{
    System.Console.WriteLine("Первое число является квадратом второго");
}
if (a != Math.Pow(b, 2))
{
    System.Console.WriteLine("Первое число НЕ является квадратом второго");
}