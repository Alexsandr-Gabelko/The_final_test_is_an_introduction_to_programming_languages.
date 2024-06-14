// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



void NewArray(string[] array, int quantityElements, int elements)
{
   string[] newArray = new string[elements];

int j = 0;
for (int i = 0; i < quantityElements; i++)
{
  if (array[i].Length <= 3) 
    {
        newArray[j] = array[i];  
        j++ ;
    }
} 
System.Console.WriteLine("Задgанный массив");
Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine("Новый массива ");
Console.WriteLine("[{0}]", string.Join(", ", newArray));

// foreach(string i in newArray) 
// Console.Write("{0} ",i);

}

int AmountOfElements(string[] array)
{
    int col = 0;
    foreach (string i in array)
{
    System.Console.WriteLine(i);
    if (i.Length <= 3) 
    col ++;
}
    return col;
}

string[] ArrayInput(int quantityElements)
{
    int num = 1;
    string[] array = new string[quantityElements];
    for (int i = 0; i < quantityElements; i++)
    {
     Console.WriteLine("Введите элемент массива " + num);
     array[i] = Console.ReadLine()!; 
     num ++;  
    }
    return array;
}



Console.Clear();
Console.Write("Введите колличество элементов массива - ");
int quantityElements = int.Parse(Console.ReadLine()!);
Console.WriteLine("Колличество элементов массива = " + quantityElements);
string[] array = ArrayInput(quantityElements);
int elements = AmountOfElements(array);
System.Console.WriteLine("Колличество элементов нового массива = " + elements);
NewArray(array, quantityElements, elements);



