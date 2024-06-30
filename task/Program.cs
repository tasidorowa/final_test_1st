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

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите массив: ");
string[] chars = CreateArray(size);
PrintArray(chars);

Console.WriteLine(GetShortElements(chars));

