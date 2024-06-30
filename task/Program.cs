void PrintArray(string[] array)
{
    foreach (string item in array)
    {
        Console.Write($"{item} ");
    }
}

int CountSmallItems(string[] array)
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
string[] chars = new string[size];

for (int i = 0; i < size; i++)
{
    chars[i] = Console.ReadLine();
}

Console.WriteLine(CountSmallItems(chars));

