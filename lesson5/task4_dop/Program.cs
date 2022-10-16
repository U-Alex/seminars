// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] createArray(int count) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(0, 200);
    }
    return array;
}
int countSlice(int[] array, int st, int end) {
    int count = 0;
    foreach (int num in array) {
        if (num >= st && num <= end) count++;
    }
    return count;
}

int[] array = createArray(123);
int count = countSlice(array, 10, 99);

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Найдите количество элементов массива, значения которых лежат в отрезке [10,99]: {count}");
