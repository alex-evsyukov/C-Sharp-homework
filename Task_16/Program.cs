// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
string s;
int a;
System.Console.WriteLine("Введите число");
s = Console.ReadLine();
a = Convert.ToInt32(s);
if (a <= 5)
{
    System.Console.WriteLine("Будний день");
}
if(a==6 | a==7)
{
    System.Console.WriteLine("Выходной день");
}
else System.Console.WriteLine("Ошибка");