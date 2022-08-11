// Лекция 2
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 1112335;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33231;
// int a3 = 13;
// int b3 = 23;
// int c3 = 2313;

// // int max1 = Max(a1, b1, c1);
// // int max2 = Max(a2, b2, c2);
// // int max3 = Max(a3, b3, c3);
// // int max = Max(max1, max2, max3);

// int max = Max(
//     Max(a1, b1, c1),
//     Max(a2, b2, c2),
//     Max(a3, b3, c3));

// Console.WriteLine(max);


int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//              0    1   2   3  4  5  6  7  8
int[] array = { 1111, 142, 324, 445, 52, 67, 75, 28, 19 };
// array [0] = 12; // можно присвоить первому (нулевому) элементу новое значение
// Console.WriteLine(array[4]); печатаем элемен 4-й

int result = Max(
     Max(array[0], array[1], array[2]),
     Max(array[3], array[4], array[5]),
     Max(array[6], array[7], array[8])
     );
 Console.WriteLine(result);