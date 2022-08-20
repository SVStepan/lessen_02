// Реккурсия
//Факториал 5! = 5*4*3*2*1
// 5! = 5*4!
//    4! = 4*3!

// int Factorial(int n)
// double Factorial(int n)  // Проблему переполнения решаем int меняем на double
// {
//     // 1! = 1  и 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n-1);
// } 
//     //  Console.WriteLine(Factorial(3)); // 3! = 1*2*3 = 6
//     //  чем больше значение n тем вероятнее наличие проблем (переполнение, сложность вычисление в плане медлительность)
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// Фибоначи 

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)


// double fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;  // || - или
//     else return fibonacci(n-1) + fibonacci(n-2);  // return возвращаем значение
// }

// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({i}) = {fibonacci(i)}");
// }
