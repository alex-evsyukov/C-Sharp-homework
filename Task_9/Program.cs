// Показать четные числа от 1 до N
System.Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int a = 0;
while (a < N)
{
    a++;
    if (a % 2 == 0)
    {
        System.Console.WriteLine(a);
    }
}