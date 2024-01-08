// определяем массив из 10-ти элементов
// конструкция new int[10] - создай новый массив из 10-ти элементов
// по умолчание эти элементы заполняются нулями
int [] array = new int[10];

// вызываем методы
FillArray(array); 
PrintArray(array);

// метод void - наполняет массив случайными числами
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// метод void - печатает массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
