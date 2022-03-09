// По двум заданным числам проверять является ли одно квадратом другого
string s;
int a,b;
System.Console.WriteLine("Введите 1 число: ");
s= Console.ReadLine();
a= Convert.ToInt32(s);

System.Console.WriteLine("Введите 2 число: ");
s= Console.ReadLine();
b= Convert.ToInt32(s);

if (a == Math.Pow(b,2)) 
{
System.Console.WriteLine("Первое число является квадратом второго!");
}
if (b == Math.Pow(a,2))
{
    System.Console.WriteLine("Второе число является квадратом первого!");
}
if (a != Math.Pow(b,2) && b != Math.Pow(a,2))
 System.Console.WriteLine("Ни одно из чисел не является квадратом другого");