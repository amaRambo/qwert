﻿int Max(int arg1, int arg2, int arg3) //возрващаемый_тип имя_функции(тип_переменной имя_переменной)
{
    int result = arg1;
    if (arg1 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 1;
int b1 = 2;
int c1 = 3;

int a2 = 4;
int b2 = 5;
int c2 = 6;

int a3 = 7;
int b3 = 8;
int c3 = 9;

int max = Max(Max(a1, b1, c1),
              Max(a2, b2, c2),
              Max(a3, b3, c3));

Console.WriteLine(max);
