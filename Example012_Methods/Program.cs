// 1-я группа методов, которая ничего не принимает и ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор ...");
}

Method1(); // вызов метода


// 2-я группа методов, которая что-то принимает и ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "Текст сообщения"); // вызов метода


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4); // вызов метода


// 3-я группа методов, которая ничего не принимает и что-то возвращает
// Если метод что-то возвращает, необходимо, в обязательнои порядке
// указать тип данных значение которого ожидается

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// 4-я группа методов, которая что-то принимает и что-то возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(5, "что"); // чтобы вызвать метод, нужно создать переменную
Console.WriteLine(res);


//4-й метод через цикл for
string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res1 = Method41(5, "что"); // чтобы вызвать метод, нужно создать переменную
Console.WriteLine(res1);

// Цикл в цикле (Пример на таблице умножения)
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

=====Работа с текстом
Дан текст. В тексте нужно все пробелы заменить чёрточками, маленькие буквы “к” заменить большими “К”,
а большие “С” маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = “qwerty”
//             012345
//s[3]//r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Метод, который упорядочивает массив
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr); 
SelectionSort(arr); 
PrintArray(arr);