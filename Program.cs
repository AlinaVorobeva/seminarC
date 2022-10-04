// задача №4 : напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел .

int a, b, c ;
a = new Random().Next(100) ;
b = new Random().Next(100) ;
c = new Random().Next(100) ;
int max = a ;
Console.Write($"{a} {b} {c}") ;

if (b > max) max = b;
if (c > max) max = c;

Console.Write($" Максимальное число = {max}") ;

