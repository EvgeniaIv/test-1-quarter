string[] array = { "hello", "2", "world", ":)" };

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.WriteLine(array[i] + "]");
    }
    Console.WriteLine();
}
PrintArray(array);

string[] ChangeArray(string[] array)
{
    int size = array.Length;
    string[] res = new string[size];
    int count = 0;
    int index = 0;
    while (count < size)
    {
        if (array[index].Length <= 3)
        {
            array[index] = array[count];
            index++;
        }
    }
    return array;
}
ChangeArray(array);

