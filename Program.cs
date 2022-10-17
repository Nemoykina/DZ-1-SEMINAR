// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("Первое число " + numberA + " больше чем второе " + numberB);
}
else
{
    Console.WriteLine("Второе число " + numberB + " больше чем первое " + numberA);
}

     

//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите три числа: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if (number2 > max)
{
   max = number2;
}
if (number3 > max)
{
    max = number3;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);



//Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 1)
{
   Console.WriteLine("Число " + number + " является: НЕЧЁТНЫМ");
}
else
{
   Console.WriteLine("Число " + number + "является: ЧЁТНЫМ");
}



//Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int i = 1;
Console.WriteLine("Чётные числа от 1 до " + number);
while (i <= number)
{
if (i % 2 != 1)
{
    Console.Write(i + ", ");
}
i++;
}

if (not)
{
   Console.WriteLine("Нет чётных чисел!");
}

