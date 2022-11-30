// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, 
// какое число большее, а какое меньшее.

Console.WriteLine("Введите 1-е число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("max = " + number1);
    Console.WriteLine("min = " + number2);
}
if (number1 < number2)
{
    Console.WriteLine("max = " + number2);
    Console.WriteLine("min = " + number1);
}
if (number1 == number2)
{
    Console.WriteLine("Числа равны");
}