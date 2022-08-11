// int[] array = { 12, 21, 53, 84, 91, 75, 26, 17, 28, 91 };

// int n = array.Length;
// int find = 91;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     // index = index + 1;
//     index++;
// }

void FillArray(int[] collection)  // метод Fill заполнения массива случайными числами(данными)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1;
        index++;

    }
}

void PrintArray(int[] col)  // метод Print вывода массива 
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)  // Метод поиска положения требуемого значения
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
array[4] = 3;
array[7] = 3;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 3);
Console.WriteLine(pos);
