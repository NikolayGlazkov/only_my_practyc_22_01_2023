// Написать программу вычисления произведения чисел от 1 до N

int a = int.Parse(Console.ReadLine());
int fak = 1;
while(a > 0)
{
    int LastDigit = a %10;
    fak *= LastDigit;
    a = a/10;
}

Console.WriteLine(fak);
