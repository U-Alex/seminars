// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] createArray(int count) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}
int[] replace1(int[] array) {
    for (int i = 0; i < array.Length; i++) array[i] *= -1;
    return array;
}
int[] replace2(int[] array) {
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++) array2[i] = -array[i];
    return array2;
}

int[] array = createArray(20);

Console.WriteLine("[" + string.Join(", ", array) + "]");

int[] array2 = replace2(array);

Console.WriteLine("[" + string.Join(", ", array) + "]");

Console.WriteLine("[" + string.Join(", ", array2) + "]");
