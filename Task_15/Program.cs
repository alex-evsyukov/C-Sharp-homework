// Найти третью цифру числа или сообщить, что её нет
string s;
int a;
System.Console.WriteLine("Введите  число: ");
s = Console.ReadLine();
a = s.Length;

if (a >= 3)
{
    System.Console.WriteLine($"Третья цифра числа {s}: " + s[2]);
}
else
{
    System.Console.WriteLine("Третья цифра отсутствует");
}