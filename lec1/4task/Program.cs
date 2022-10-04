void FillArray(int[] collection) // метод void(этот метод ничего не возвращает) наименование_метода (тип[] аргумент)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; // создай 10 элементов, и по умолчанию он заполнен нулями

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);