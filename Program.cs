// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Введите Первое число!: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите Второе число!: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 >= num2)
{
    Console.WriteLine($"Больше число: " + num1);
}
else
{
    Console.WriteLine($"Больше число: " + num2);
}
*/

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Введите первое число!: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число!: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число!: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int Max(int num1, int num2, int num3)
{
    int result = num1;
    if(num2 > result ) result = num2;
    if(num3 > result ) result = num3;
    return result;
}

int max1 = Max(num1, num2, num3);

Console.WriteLine(max1);
*/

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Введите число!: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 % 2 == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
*/

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 0;

while (current <= num)
{
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
        
    }

    current++;
}
*/



// ДОМАШНЕЕ ЗАДАНИЕ 2 СЕМИНАРА:

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int twoNum(int num)
{
    int sot = num / 100;
    int doz = num % 100;
    int ed = num % 10;

    int result = doz / 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int nNum = twoNum(num);

Console.WriteLine(nNum);
*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void dayNum(int num)
{
    if (num == 6 || num == 7 )
    {
        Console.WriteLine("Выходной день");
    }
    else if (num < 1 || num > 7)
    {
        Console.WriteLine("В неделе 7 дней, введите от 1 до 7");
    }

    else Console.WriteLine("Будний день");
}

Console.Write("Введите число дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

dayNum(num);
