void FillArrayStrings (string[]words)
{
Console.WriteLine("Введите элементы массива");
    for (int i = 0; i < words.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива:");
        words[i] = Console.ReadLine();
    }
}

void PrintArray(string[]words)
{
    for (int i = 0; i < words.Length; i++)
    {
    Console.Write($"{words[i]} ");
    }
}

int CountStrings (string[]words, int n)
{
int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3) count++;
    }
return count;
}

void FillNewArrayFromArray (string[]words, string[] newWords)
{
int j = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3)
        {
            newWords[j] = words[i];
            j++;
        }
    }
}

Console.Clear();
Console.Write("Введите кол-во строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());
string[] array = new string [str];
FillArrayStrings(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Введите условия для отбора строк (кол-во элементов): ");
int n = Convert.ToInt32(Console.ReadLine());

int count = CountStrings(array, n);
string[] arrayNew = new string [count];
FillNewArrayFromArray(array, arrayNew);
Console.WriteLine($"Массив из строк, состоящих из <={n} символов:");
PrintArray(arrayNew);