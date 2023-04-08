/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

string InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    return value;
}

string[] CreateFillingArray(int row)
{
    string[] array = new string[row];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputNumberWithMessage("Введите любое слово: ");
    }
    return array;
}

void PrintArrayInConsole(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == (array.Length - 1))
            System.Console.Write($"{array[i]}");
        else System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write("]");
}

string[] FindShortStringInArray(string[] array, int sizeword)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= sizeword)
        {
            count++;
        }        
    }
    string[] array1 = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= sizeword)
        {
            array1[count] = array[i];
            count++;
        }
    }


    return array1;
}

string[] array = CreateFillingArray(5);
PrintArrayInConsole(array);
System.Console.Write(" -> ");
PrintArrayInConsole(FindShortStringInArray(array, 3));