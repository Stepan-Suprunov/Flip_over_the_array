// Перевернуть массив

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
       Console.Write(collection[i] + " ");
    }
Console.WriteLine();
}

void FlipOver(int[] Collection)
{
    int save;
    for (int i = 0; i < array.Length/2; i++)
    {
        save =  array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = save;
    }
}

PrintArray(array);
FlipOver(array);
PrintArray(array);