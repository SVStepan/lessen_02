Console.Clear();

// // Вид 1 метод - ничего не принимают, ничего не возвращают
// void Method1()
// {
//     Console.WriteLine("Автор Степан");
// }
// Method1(); // вариант как вызывается как этот метод


// // ВИД 2  что-то принимают, но ничего не возвращают
// void Method2(string msg)  // принимает какие-то аргументы
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "текст сообщения");

// void Method21(string msg, int count) // принимает какие-то несколько аргументов
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст", 4);
// Method21(msg: "Текст", count: 4);  // явно указываем наименование аргументов
// Method21(count: 4, msg: "новый текст"); // когда аргументы именнованные,то не обязвтельно их писать по порядку

// // Вид 3  ничего не принимают, но что-то возвращают

// int Method3()  // если что-то возвращает, то обязательно должны указать тип данных, которые мы ожидаем.
// {
//     return DateTime.Now.Year;
// }
// int Year = Method3();
// Console.WriteLine(Year);


// // Вид 4 Что-то принимают и что-то возвращают

// string Method4(int count, string Text)
// {
//     int i = 0;
//     string result = String.Empty;  // пустая строка

//     while (i < count)
//     {
//         result = result + Text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "as_df");
// Console.WriteLine(res);



// цикл for

// string Method4(int count, string Text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + Text;
//     }
//     return result;
// }
// string res = Method4(10, "as_df,");
// Console.WriteLine(res);


// цикл в цикле
// вывод таблицы умножения
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");  // интерполяция строк
//     }
//     Console.WriteLine(); // переход на новую строку
// }


// ==== Работа с текстом
//дан текст, в тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить на маленькие "с".

// Яснали задача?

string text = "-Я думаю, - сказал князь, улыбаясь, -что, "
            + "ежели бы вас послали вместо нашегомилого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             01234
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i< length; i++)
    {
        if(text[i] == oldValue) result = result+ $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replase(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'В', 'в');
Console.WriteLine(newText);




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
