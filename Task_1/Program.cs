System.Console.Write("Число: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Степень: ");
int b = int.Parse(Console.ReadLine());;
Console.WriteLine($"{a}^{b} = " + Math.Pow(a, b));
