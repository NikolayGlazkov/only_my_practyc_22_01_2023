// Возведите число А в натуральную степень B используя цикл
int a = int.Parse(Console.ReadLine()); //число
int b = int.Parse(Console.ReadLine()); //степнь
int stepen = 1;

for (int i =1; i<b+1;i++)
{
stepen = stepen * a;
}

Console.WriteLine(stepen);