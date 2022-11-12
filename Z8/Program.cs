//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int  a = Convert.ToInt32(Console.ReadLine());
int  b = 1;

Console.Write(a + " -> ");

if (a > 0)
{
    while (b <= a )
    {       if (b%2==0)
        {
        Console.Write (b);
        Console.Write(", ");
        }
    
    b = b + 1; 
    }
}
else {Console.Write("Число отрицательное");}
