// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива


int[] array = new int[12];
for (int i = 0; i < 12; i++) 
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i]);
}

// для проверки подсчета отрицательных чисел раскомментировать следующие две сстроки
// array[2] = -5;
// array[9] = -4;

int sumPositive = 0;
int sumNegative = 0;

for (int j = 0; j < 12; j++) 
{
    if (array[j] > 0) {sumPositive += array[j]; }
    else if (array[j] < 0) {sumNegative += array[j]; }
}

Console.WriteLine("Сумма положительных элементов равна: " + sumPositive);
Console.WriteLine("Сумма отрицательных элементов равна: " + sumNegative);
