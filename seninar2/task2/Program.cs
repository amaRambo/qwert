﻿int a = new Random().Next(10, 100);
Console.WriteLine(a);
if (a%10 > a / 10)
{
    Console.WriteLine($"{a%10} нибольшее число");
}
else
{
    Console.WriteLine($"{a/10} нибольшее число");
}