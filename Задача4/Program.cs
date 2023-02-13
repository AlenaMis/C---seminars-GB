// Напишите программу, которая на вход принимает одно число (N)
// а на выходе показывает все числа в промежутке  от -N до N
// 4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 -> -2, -1, 0, 1, 2

Console.Clear();

int N = 4;
        
int currentIndex = -N; // -N это тоже самое, что -1*N

while (currentIndex <= N)
{
    Console.Write(currentIndex + " ");
    currentIndex = currentIndex + 1;
}
