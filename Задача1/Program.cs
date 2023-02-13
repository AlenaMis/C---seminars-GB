 // Напишите программу, которая на вход приниает трехзначное число 
 // и на выходе показывает вторую цифру этого числа.
 // 456 -> 5
 // 782 -> 8
 // 918 -> 1

Console.Clear();

int value;

value = 258;

if (value > 99 && value < 1000)
{
    int res;
    res = (value / 10) % 10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("ERROR");
}