// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] createArray(int count) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}
int sumOdd(int[] array) {
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) sum += array[i];
    return sum;
}

int[] array = createArray(20);
int sum = sumOdd(array);

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");
