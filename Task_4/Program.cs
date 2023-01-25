//Подсчитать сумму цифр в числе

int a = int.Parse(Console.ReadLine());
int sum = 0;
while(a > 0)
{
    int LastDigit = a %10;
    sum += LastDigit;
    a = a/10;
}

Console.WriteLine(sum);