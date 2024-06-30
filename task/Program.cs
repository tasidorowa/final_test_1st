string[] CreateArray(int size)
{
    string[] chars = new string[size];
    for (int i = 0; i < size; i++)
    {
        chars[i] = Console.ReadLine();
    }
    return chars;
}

void PrintArray(string[] array)
{
    foreach (string item in array)
    {
        Console.Write($"{item} ");
    }
}

int GetShortElements(string[] array)
{
    int count = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3) count++;
    }
    return count;
}

string[] CreateNewArray(string[] array, int size)
{
    string[] newChars = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newChars[j] = array[i];
            j++;
        }
    }
    return newChars;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите массив: ");
string[] chars = CreateArray(size);

Console.WriteLine("");
string[] newChars = CreateNewArray(chars, GetShortElements(chars));
PrintArray(newChars);


