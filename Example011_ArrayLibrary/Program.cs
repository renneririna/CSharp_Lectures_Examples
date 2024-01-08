// определяем массив из 10-ти элементов
// конструкция new int[10] - создай новый массив из 10-ти элементов
// по умолчание эти элементы заполняются нулями
int [] array = new int[10];

// вызываем методы
FillArray(array); 
PrintArray(array);
Console.WriteLine(); // вывод пустой строки
int pos = IndexOf(array, 4);
Console.WriteLine(pos);

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

// метод - ищем значиение по индексу в массиве из задачи Example010_MethodArray
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; 
            //если с break, выводит первую найденную заданную цифру
            //если без break, выводит последнее вхождение(последнюю в списке, если одна и та же циыфра повторяется)
        }
        index++;
    }
    return position;
}