// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] ArrayInput(int quantityElements)
{
    string[] array = new string[quantityElements];
    for (int i = 0; i < quantityElements; i++)
    {
     Console.WriteLine("Введите элементов массива = " + i);
     array[i] = Console.ReadLine()!;   
    }
    return array;
}


Console.Clear();
Console.Write("Введите колличество элементов массива - ");
int quantityElements = int.Parse(Console.ReadLine()!);
Console.WriteLine("Колличество элементов массива = " + quantityElements);
ArrayInput(quantityElements);


