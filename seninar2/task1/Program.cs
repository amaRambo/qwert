Console.WriteLine("ВВедите трехзначное число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 99 && n < 1000) 
{
    Console.WriteLine("Число не трехзначное");
}
else
{
    int ost = n % 10;
    Console.WriteLine(ost);
}

