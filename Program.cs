//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int a =int.Parse(Console.ReadLine());

while (a < 100 || a >= 1000)
{
    Console.WriteLine("Введите трезначное число");
    a = int.Parse(Console.ReadLine());
}

int num1 = a / 10;
int num2 = num1%10;

Console.WriteLine("Вторая цифра числа - " + num2);


/* //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введитие число");
int a = int.Parse(Console.ReadLine());
string num=a.ToString();
if(a<100)
{
    Console.WriteLine(a + " -> нет третьей цифры");
}
else if (a>99)
{
    Console.WriteLine(a+ " -> третья цифра -> " + num[2]);
} */

/* //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7,обозначающую день недели, чтобы узнать является ли этотдень выходным");
int a = int.Parse(Console.ReadLine());

while (a<1 || a>7)
{
    Console.WriteLine("Введите цифру от 1 до 7");
    a = int.Parse(Console.ReadLine());
}

if (a>0 && a<6)
{
    Console.WriteLine(a + " - > рабочий");
}
else
{
    Console.WriteLine(a + " - > выходной");
} */