//Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.

int[] createArray(int count) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(-1000, 1000);
    }
    return array;
}
void printArray(int[] array) {
    Console.Write("[" + string.Join(", ", array) + "]");
}

printArray(createArray(8));