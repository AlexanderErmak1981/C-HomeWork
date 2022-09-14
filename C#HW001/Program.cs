// Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Write("Input number 1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 2");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 < number2)
{
    Console.WriteLine($"Max number is {number2}. Min number is {number1}");
}
else
{
    Console.WriteLine($"Max number is {number1}. Min number is {number2}");
}


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input number1 ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number2 ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number3 ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(max < number2)
{
    max = number2;
} 

if(max < number3)
{
    max = number3;
} 

Console.WriteLine($"Max number is {max}");
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2==0)
{
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine("Number is not even");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
 Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= number)
{
    if(current %2==0)
    {
        Console.WriteLine(current);
    }
    current ++;
    
} */
