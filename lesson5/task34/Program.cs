// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] createArray(int count) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
int sumEven(int[] array) {
    int count = 0;
    foreach (int num in array) {
        if (num % 2 == 0) count++;
    }
    return count;
}

int[] array = createArray(30);
int count = sumEven(array);

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"количество чётных чисел в массиве: {count}");
