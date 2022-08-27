// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} -> {num%100/10}");



// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число:");
// int Num = Convert.ToInt32(Console.ReadLine());
// string NumText = Convert.ToString(Num);

// if (NumText.Length > 2)
// {
//   Console.WriteLine($"{Num} -> {NumText[2]}");
// }
// else {
//   Console.WriteLine($"{Num} -> третьей цифры нет");
// }


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Понедельник - 1");
// Console.WriteLine("Вторник - 2");
// Console.WriteLine("Среда - 3");
// Console.WriteLine("Четверг - 4");
// Console.WriteLine("Пятница - 5");
// Console.WriteLine("Суббота - 6");
// Console.WriteLine("Воскресенье - 7");
// Console.WriteLine("Введите число от 1 до 7:");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day >=6)
// {
//     Console.WriteLine($"{day} -> да");
// }
// else
// {
//     Console.WriteLine($"{day} -> нет");
// }

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 1й способ

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 0)
// {
//     num = num * -1;
// }
// if (num > 0 && num < 100)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else 
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     int thirdNum = num % 10;
//     Console.Write("Третья цифра: " + thirdNum);
// }

// 2й способ

// Console.Write("Input random number: ");
// int num = int.Parse(Console.ReadLine());

// if(Math.Abs(num) < 100)
// {
//     Console.WriteLine("There is no third digit");
// }
// else{
//     while (num >= 1000)
//     {
//         num = num / 10;
//     }
//     Console.WriteLine("Third digit is:" + Math.Abs(num%10));
// }