int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random() .Next(minValue, maxValue + 1);
    }

    return result;
}


int Podschet(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if( item%2==0) count++;
    }
    return count;
}
int[] arr = GetRandomArray(10, 100, 999);
Console.WriteLine(string.Join(" ", arr));
Console.WriteLine(Podschet(arr));