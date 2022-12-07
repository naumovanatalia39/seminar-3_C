Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0 || a == 0)
{
    Console.WriteLine("Введите число больше 0");
}
for(int i = 1; i <= a; i++)
{
    Console.Write($"{Math.Pow(i, 2)}, ");
}