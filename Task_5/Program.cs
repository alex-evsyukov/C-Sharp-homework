//Найти максимальное из трех чисел
int a = 51;
int b = 6;
int c = 1;
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("max = " + max);