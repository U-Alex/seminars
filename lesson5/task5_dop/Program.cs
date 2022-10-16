// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] createArray(int count) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(1, 11);
    }
    return array;
}
int[] pairs(int[] array) {
    int len1 = array.Length;    
    int len2 = len1 / 2;                                    //для цикла
    int len_arr2 = (int)Math.Ceiling(array.Length / 2.0);   //для нового массива
    int[] array2 = new int[len_arr2];
    for (int i = 0; i < len2; i++) {
        array2[i] = array[i] * array[len1 - i - 1];
    }
    if (len2 != len_arr2) {                                 //если не четное кол-во эл.array2
        array2[len2] = array[len2];
    }
    return array2;
}

int[] array = createArray(7);
int[] array2 = pairs(array);

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"произведение пар чисел:");
Console.WriteLine("[" + string.Join(", ", array2) + "]");
