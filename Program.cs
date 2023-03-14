// Задача: Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ".-)"] -> ["2", ":-)"]  
// ["1234", "1567", "-2", "computer science"] -> ["-2"]  
// ["Russia", "Denmark", "Kazan"] -> []

System.Console.Write("Введите количество элементов массива: ");
string[] arr = InputeArray(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine("Введенный массив:");
PrintArray(arr);
System.Console.WriteLine("Сформированный массив с элементами, длина которых 3 и менее символов:");
PrintArray(OutArray(arr, GetNewSize(arr)));

string[] InputeArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("Введите значение " + (i + 1) + " элемента массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int GetNewSize(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            size++;
        }
    }
    return size;
}

string[] OutArray(string[] arrayIn, int sizeOut)
{
    string[] arrayOut = new string[sizeOut];
    int index = 0;
    for (int i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= 3)
        {
            arrayOut[index] = arrayIn[i];
            index++;
        }
    }
    return arrayOut;
}