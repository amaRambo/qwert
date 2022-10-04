// int Prompt(string msg)
// {
//     Console.WriteLine(msg);                               //ввод
//     int Number = Convert.ToInt32(ConsoleReadLine());      //присвоение
//     return number;                                        //возврат к целому
// }


int a = new Random().Next(10, 10000);
Console.WriteLine(a);
int max = a % 10;
while (a > 0)
{
    int temp = a% 10;
    if(temp > max)
    {
        max = temp;
    }
    a = a / 10;
}
Console.WriteLine(max);