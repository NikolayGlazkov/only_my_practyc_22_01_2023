// Найти сумму чисел от 1 до А

int a = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i < a+1; i++)
{
    sum = i+sum;
}
Console.WriteLine(sum);
