//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Введите значение N ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(N);
void PrintNaturalNumbers(int number)
{
    if (number >=1)
    {
        Console.WriteLine(number);
        PrintNaturalNumbers(number - 1);
    }
}

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.Write("Введите значение М ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N ");
int N = Convert.ToInt32(Console.ReadLine());
if (M<=N)
{
    int sum = Sum(M,N);
    Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");
}
else
{
    Console.WriteLine("Ошибка. Проверьте введенные числа");
}
int Sum(int start, int end)
{
    if (start > end)
    {
        return 0;
    }
    else
    {
        return start + Sum(start + 1, end);
    }
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите значение m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n ");
int n = Convert.ToInt32(Console.ReadLine());
int result = AkkerFunc(m, n);
Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} {result}");
int AkkerFunc(int m, int n)
{ 
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n==0)
    {
        return AkkerFunc(m-1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AkkerFunc(m-1, AkkerFunc(m, n-1));
    }
    else
    {
        return 0;
    }
}

