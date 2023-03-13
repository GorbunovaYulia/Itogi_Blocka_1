string[] GetArray(int length)
{
    string[] arr = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Введите строку");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[] GetNewArray(string[] array)
{
    string[] newarr = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newarr[j] = array[i];
            j++;
        }
    }
    return newarr;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null)
        {
            Console.Write($"'{array[i]}' ");
        }
    }
    Console.Write("]");
}

string[] array = GetArray(4);
string[] newarr = GetNewArray(array);
PrintArray(array);
Console.Write("  ->  ");
PrintArray(newarr);