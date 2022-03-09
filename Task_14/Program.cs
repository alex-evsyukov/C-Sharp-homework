// Выяснить, кратно ли число заданному, если нет, вывести остаток.
string s;
int a, b;
System.Console.Write("Введите 1 число: ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

System.Console.Write("Введите 2 число: ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

if (a % b == 0)
{
    System.Console.WriteLine(a + " кратно " + b);
}
else System.Console.WriteLine("Остаток от деления числа " + a + " на число " + b + " равен " + a % b);
