//Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int  b =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c: ");
int  c =Convert.ToInt32(Console.ReadLine());
int max = 0;

if (a >=b && a >=c )
{max = a;}
else 
{ if (b >=a && b >=c)
    {max = b;}
    else 
{   if (c >=a && c >=b)
    {max = c;}
}
}
Console.Write(a + "," + b + "," + c + " -> " + max);

