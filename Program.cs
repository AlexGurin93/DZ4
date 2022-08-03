// 25 задача
/*Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);
*/
// 27 задача
/*
Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
*/
//29 задача
int size = 8;
int [] array = new int[size];
Random rand= new Random ();

for (int i = 0; i < size; i++)
{
    array[i] = rand.Next(0,12);
}

for (int i = 0; i < size; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < size - 1; i++)
{
    int minPosition = i;
    for ( int j = i + 1; j < size; j ++)
    {
        if (array[j]< array[minPosition]) minPosition =j;
    }
    int temporary = array[i];
    array[i] = array [minPosition];
    array [minPosition] = temporary;
}
// как это всё совместить,я не понимаю...