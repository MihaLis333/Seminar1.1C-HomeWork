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
