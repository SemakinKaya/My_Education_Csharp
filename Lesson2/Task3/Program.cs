//int n = 10;
int[] arr = { 2, 3, 4, 5, 1, 6, 12, 18, 2, 3 };
int i = 0;

while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i++;
}