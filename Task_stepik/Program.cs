int a = int.Parse(Console.ReadLine());//первое число
string input = Console.ReadLine();
char c = input[0];
int b = int.Parse(Console.ReadLine());//вторе число

int result = 0;
int result1 = 0;

while(result > 0)
{
switch (c)
    {
        case '+':
            result1 = a + b;
        break;

        case '-':
            result = a - b;
        break;

        case '*':
            result = a * b;
        break;

         case '/':
            result = a / b;
        break;

    }
    Console.WriteLine(result);
}
