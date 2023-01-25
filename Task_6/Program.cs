// Показать кубы чисел, заканчивающихся на четную цифру
int num = int.Parse(Console.ReadLine());
int stepen = 3;
for (int i = 1; i < num;i++)
{
    int a = (int)Math.Pow(i,stepen);
    if (a%2 == 0)
    Console.WriteLine(a);
}