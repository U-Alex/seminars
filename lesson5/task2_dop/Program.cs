// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] createArray(int count) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

bool numExists(int[] array, int num) {
    foreach (int el in array) {
        if (el == Math.Abs(num)) return true;
    }
    return false;
}

int[] array = createArray(30);
int num = new Random().Next(-9, 20);
bool ok = numExists(array, num);

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"число {num} {((!ok) ? "НЕ " : "")}присутствует в массиве {(num < 0 ? "(по модулю)" : "")}");
