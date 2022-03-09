int a = 0;
string s;
int y;
Console.Write("Введите число: ");
s = Console.ReadLine();
a = Convert.ToInt32(s);
while (a >= 100)
{
    a /= 10;
}
y = a % 10;
System.Console.WriteLine(y);