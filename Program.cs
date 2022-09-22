// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

if(first > second)
{
    Console.WriteLine("max = " + first);
    Console.WriteLine("min = " + second);
}
else
{
    Console.WriteLine("max = " + second);
    Console.WriteLine("min = " + first);
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int third = Convert.ToInt32(Console.ReadLine());

int max = first;
if(second > max) max = second;
if(third > max) max = third;

Console.WriteLine("Максимальное из трех чисел: " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Число " + number + " четное!");
}
else
{
    Console.WriteLine("Число " + number + " нечетное!");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int start = 2;

while(start <= number)
{
    Console.Write(start);
    if(start != number && start != (number - 1))
    {
        Console.Write(", ");
    }
    start += 2;
}