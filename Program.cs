// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Add first numbers: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add second numbers: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 == num_2)
{
    Console.WriteLine("Ваши числа равны");
}
if (num_1 > num_2)
{
    Console.WriteLine("Первое число больше второго");
}
if (num_1 < num_2)
{
    Console.WriteLine("Второе число больше первого");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Задайте первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте третье число: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2 & num_1 > num_3)
{
    Console.WriteLine("Максимальное число " + num_1);
}
if (num_2 > num_1 & num_2 > num_3)
{
    Console.WriteLine("Максимальное число " + num_2);
}
if (num_3 > num_1 & num_3 > num_2)
{
    Console.WriteLine("Максимальное число " + num_3);
}
if (num_1 == num_2 & num_2 == num_3)
{
    Console.WriteLine("Ваши числа равны");
}

//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Ваше число чётное");
}
if (num % 2 != 0)
{
    Console.WriteLine("Ваше число нечётное");
}


// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 2;

while (num > 0 & index <= num)
{
    Console.Write(index + ", ");
    index = index + 2;
    
}
if (num <= 0)
{
    Console.WriteLine("Вы ввели неверные значения!");
}