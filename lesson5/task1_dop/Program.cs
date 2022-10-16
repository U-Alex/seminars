// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int[] createArray(int count) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}
int[] sumElem(int[] array) {
    int pos = 0, neg = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0) pos += array[i];
        if (array[i] < 0) neg += array[i];
    }
    return new int[2]{pos, neg};
}

int[] array = createArray(12);
int[] sum = sumElem(array);

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"сумма положительных и отрицательных элементов: {sum[0]}, {sum[1]}");
