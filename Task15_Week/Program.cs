//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void DayOfWeek(int num)
{
if (num > 7 || num < 1)

    Console.WriteLine("Такого дня недели не существует");  

else if(num == 6 || num == 7)

    Console.WriteLine("Сегодня выходной день");

else

    Console.WriteLine("Сегодня будний день");
}

Console.Write("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
DayOfWeek(num);