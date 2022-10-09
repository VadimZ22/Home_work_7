/*Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.*/

Console.Clear();

Console.Write("Введите количество элементов последовательности: ");
int n = Convert.ToInt32(Console.ReadLine()!);

Fibonacci(n);

void Fibonacci(int n)
{
    int current = 0;
    int preview;
    int next = 1;

    for (int i = 0; i < n; i++)
    {
        Console.Write(current + " ");
        preview = current;
        current = next;
        next = preview + current;
    }
}
