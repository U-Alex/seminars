// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] createArray(int count) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
int[] find_max_min(int[] array) {
    int max = array[0], min = array[0];
    for (int i = 1; i < array.Length; i++) {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return new int[2]{max, min};
}

int[] array = createArray(40);
int[] diff = find_max_min(array);

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"разница между максимальным и минимальным элементом: {diff[0]} - {diff[1]} = {diff[0] - diff[1]}");
