//Задача 3: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели");
int A = int.Parse(Console.ReadLine());
if ( A > 0 && A < 8 )
    if ( A > 5 && A < 8 )
        Console.WriteLine("этот день выходной");
    else 
        Console.WriteLine("Это рабочий день");
else 
    Console.WriteLine("Это не день недели");
