// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []




void ShowArray(string[] array)
{
Console.WriteLine("массив ->:");
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
Console.WriteLine();
}
Console.WriteLine();
}

int CountArray(string[] array, int fri)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= fri) 
        count= count+1;
    }
    return count;
}



string[] NewArray(string[] myArray, int num, int fri)
{
    string[] FinArray = new string[num];
    int j = 0;

    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= fri)
        {
            FinArray[j] = myArray[i];
            j=j+1;
        }
    }
    return FinArray;
}

string[] myArray = new string[] { };
Console.Write("Введите количество элементов массива" + " ");
int n = Convert.ToInt32(Console.ReadLine());
myArray = new string[n];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($" Введите {i + 1} строку: ");
    myArray[i] = Console.ReadLine();
}

ShowArray(myArray);

Console.Write("Введите максимальную длинну элементов нового массива" + " ");
int length = Convert.ToInt32(Console.ReadLine());

int num = CountArray(myArray, length);

ShowArray(NewArray(myArray, num, length));
