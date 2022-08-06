void FillArray(int[] collection)
{
    int Lenght = collection.Length;
    int index = 0;
    while(index < Lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + "  ");
        position++;
    }
}

int[] array = new int[10];

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }        
        index++;
    }
    return position;
}

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = Index0f(array, 4);
Console.WriteLine(pos);