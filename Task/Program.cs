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
        if (words[i].Length <= n) count++;
    }
return count;
}

void FillNewArrayFromArray (string[]words, string[] newWords, int n)
{
int j = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= n)
        {
            newWords[j] = words[i];
            j++;
        }
    }
}

Console.Clear();
Console.Write("Введите кол-во строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());
while (str < 1)
{
Console.Write("Кол-во строк в массиве не может быть меньше 1, введите натуральное число: ");
str = Convert.ToInt32(Console.ReadLine());
}
string[] array = new string [str];
FillArrayStrings(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Введите условия для отбора строк (меньше, какого кол-ва символов): ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1)
{
Console.Write("Кол-во символов не может быть меньше 1, введите натуральное число: ");
n = Convert.ToInt32(Console.ReadLine());
}

int count = CountStrings(array, n);
string[] arrayNew = new string [count];
FillNewArrayFromArray(array, arrayNew, n);
Console.WriteLine($"Массив из строк, состоящих из {n} символов и меньше:");
PrintArray(arrayNew);