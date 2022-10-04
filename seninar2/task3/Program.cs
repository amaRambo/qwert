Console.WriteLine("ВВедите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b % a == 0)
{
    Console.WriteLine($"{b} кратно {a}");
    
}
else
{
    Console.WriteLine(b % a);
}
