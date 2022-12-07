Console.WriteLine("Введите номер координатной четверти");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 4 || a < 0)
{
    Console.WriteLine("Нет такой четверти");
}
else if (a == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if (a == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (a == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if (a == 4)
{
    Console.WriteLine("x > 0, y < 0");
}