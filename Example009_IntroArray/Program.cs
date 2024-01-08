int Max(int arg1, int arg2, int arg3) //описывваем функцию называем её мах, и в качестве возвращаемого типа возвращаем integer
// далее наша функция возьмет 3 числа, найдет из них максимальное, затем следующие 3 числа и т.д.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// индекс        0   1   2   3   4   5   6   7   8
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };
// определили массив int[] дали ему название array и перчисляем значения в массиве в {}
// array[0] = 12; // для того чтобы обратиться к конкретному элементу, пишем имя массива и в [] используем индекс
// Console.WriteLine(array[4]);

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);