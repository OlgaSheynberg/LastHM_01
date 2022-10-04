Console.Clear();
Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());
string[] Array = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите элемент массива: ");
    Array[i] = Console.ReadLine();
}
Console.WriteLine("Введенный массив: " + string.Join(", ", Array));

int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length < 4)
    {
        count++;
    }
}

string[] Array2 = new string[count];
int j = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length < 4)
    {
        Array2[j] = Array[i];
        j++;
    }
}
Console.WriteLine("Новый массив: " + string.Join(", ", Array2));