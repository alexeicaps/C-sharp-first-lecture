int[] array = {1, 2, 54, 51, 84, 87, 63, 11, 87};

int n = array.Length;
int find = 87;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}