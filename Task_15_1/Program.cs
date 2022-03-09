//Дано число. Проверить кратно ли оно 7 и 23
int a;
string s;
System.Console.Write("Введите число: ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

if (a % 7 != 0)
{
    System.Console.WriteLine("Число не кратно 7");
}
else
{
    System.Console.WriteLine("Число кратно 7");
}
if (a % 23 != 0)
{
    System.Console.WriteLine("Число не кратно 23");
}
else
{
    System.Console.WriteLine("Число кратно 23");
}