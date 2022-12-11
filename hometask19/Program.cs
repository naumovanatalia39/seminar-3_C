Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 10000 || a > 99999)
{
    Console.WriteLine("Число не пятизначное");
}
else if (a == (a % 10) * 10000 + ((a / 10) % 10) * 1000 + 
((a / 100) % 10) * 100 + ((a / 1000) % 10) * 10 + ((a / 10000)))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}