/*Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine());

int sq = number * number;

int pow = Convert.ToInt32(Math.Pow(number, 2));

System.Console.WriteLine("Квадрат числа равен: " +sq);

System.Console.WriteLine("Квадрат числа равен: " + pow);*/
/* Задача 1 
Console.WriteLine("Введите число: a ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: b ");
int number2 = int.Parse(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine("число " + number1 + " больше" );
}
else
{
    Console.WriteLine("число " + number2 + " больше" );
} */
/* Задача 2

Console.WriteLine("Введите число: a ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: b ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: с ");
int number3 = int.Parse(Console.ReadLine());
if (number1>number2)
{
    if (number1>number3)
    {
        Console.WriteLine("Самое большое число " + number1);
    }
    else
    {
        Console.WriteLine("Самое большое число " + number3);
    }
}
else    
{
     if (number2>number3)
    {
        Console.WriteLine("Самое большое число " + number2);
    }
    else
    {
        Console.WriteLine("Самое большое число " + number3);
    }
}

Задача 3 
Console.WriteLine("Введите число: a ");
int number = int.Parse(Console.ReadLine());
int n = number % 2 ;
if ( n <= 0 )
{
Console.WriteLine("Данное число является четным");
}
else
{
Console.WriteLine("Данное число не является четным");
}*/
/*Задача 4*/


Console.WriteLine("Введите число: a ");
int number = int.Parse(Console.ReadLine());
for (int i = 2; i <= number; i=i+2)
{
    Console.WriteLine( i + " ");
}
