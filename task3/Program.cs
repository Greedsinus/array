//int n = 10;
int[] array = {2, 3, 7, 9, 6, 1, 0, 8, 23, 72};
int i = 0;

while (i < array.Length) 
{
    if (array[i] %2 == 0) {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}