//Показать последнюю цифру трёхзначного числа
int a;
string s;
Console.Write("Введите число: ");
s = Console.ReadLine();
a = Convert.ToInt32(s);
while (a > 10)
{
    a %= 10;
}
Console.WriteLine(a);