/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с
клавиатуры, либо задать на старте выполнения алгоритма.
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

int GetUserData (string message)
{
    Console.WriteLine (message);
    int data = int.Parse(Console.ReadLine()!);
    return data;
}

string [] CreateAndFillArray (int length)
{
    string [] array = new string [length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine ($"Введите элемент {i+1}:");
        array[i] = Console.ReadLine ();
    }
    return array;
}

int GetNewArrayLength (string [] array)
{
    int newArrayLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i].Length <= 3)
        {
            newArrayLength = newArrayLength + 1;
        }
    }
    return newArrayLength;
}

string [] GetFilteredArray (string [] array, int length)
{
    string [] filteredArray = new string [length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i].Length <=3)
        {
            filteredArray [j] = array [i];
            j = j + 1;
        }
    }
    return filteredArray;
}

void PrintArray (string [] array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write ($"'{array[i]}', ");
    }
    Console.WriteLine ($"'{array[array.Length-1]}']");
}

Console.Clear();
int arrayLength = GetUserData ("Введите количество элементов массива:");
if (arrayLength > 0)
{
    string [] array = CreateAndFillArray (arrayLength);
    Console.WriteLine ("Первоначальный массив:");
    PrintArray (array);
    int lengthOfNewArray = GetNewArrayLength (array);
    if (lengthOfNewArray > 0)
    {
        string [] filtredArray = GetFilteredArray (array, lengthOfNewArray);
        Console.WriteLine ("Элементы, длина которых меньше или равна 3 символам:");
        PrintArray (filtredArray);
    }
    else 
    {
        Console.WriteLine ("Элементы, длина которых меньше или равна 3 символам отсутствуют.");
    }
}
else  Console.WriteLine ("Ошибка! Введите число больше 0.");