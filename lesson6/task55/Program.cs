// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] createArr(int a, int b) {
    int[,] array = new int[a, b];
    for (int i=0; i < array.GetLength(1); i++) {
        for (int j=0; j < array.GetLength(0); j++) {
            array[j, i] = new Random().Next(0, 10);
        }
    }
    return array;
}
void printArr(int[,] array) {
    for (int i=0; i < array.GetLength(1); i++) {
        for (int j=0; j < array.GetLength(0); j++) {
            Console.Write($"{array[j, i]}  ");
        }
        Console.WriteLine();
    }
}
double[] average(int[,] array) {
    double[] array2 = new double[array.GetLength(0)];
    double sum;
    for (int i=0; i < array.GetLength(0); i++) {
        sum = 0;
        for (int j=0; j < array.GetLength(1); j++) {
            sum += array[i, j];
        }
        array2[i] = (double)Math.Round(sum / array.GetLength(1), 2);
    }
    return array2;
}

int[,] array = createArr(8, 3);
printArr(array);
double[] sums = average(array);
Console.WriteLine("---------------");
Console.Write($"{string.Join(" ", sums)} ");

//вывести array.GetLength за цикл