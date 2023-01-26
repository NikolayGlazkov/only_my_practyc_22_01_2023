// В Указанном массиве вещественных чисел найдите  максимальное и минимальное значение элементом


int [] array = {1, 2, 3, 4, 5, 9, 4, -1, -2, -5};
int max = array[0];
int min = array[0];

int otvet = 0;

for (int i = 0; i < array.Length ; i++)
{
    if ( array[i] > max)
    max = array[i];

    if( array[i]< min)
    min = array[i];
}

otvet = (max - min);

Console.WriteLine("разница между большим и ментщим равна: "+otvet);