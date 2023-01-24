// Найти кубы чисел от 1 до N

int n = int.Parse(Console.ReadLine());
int stepen = 3;

for (int i = 0; i < n; i++)

    {
        Console.WriteLine(Math.Pow(i, stepen));
    }
