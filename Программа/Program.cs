// Итоговая проверочная работа

// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам.

// Создание исходного массива
string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine() ?? " ";
    }
    return array;
}

// Вывод исходного массива
void ShowArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("'" + array[i] + "' ");
    }
    Console.Write("]");
}

// Вывод нового массива из строк, длина которых меньше, либо равна 3 символам
void NewArray(string[] array)
{
    string result = string.Empty;
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) Console.Write("'" + array[i] + "' ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(size);
ShowArray(array);
Console.WriteLine();
NewArray(array);


