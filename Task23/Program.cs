Console.Write("Input number = ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int N);
if (!isParsedN)
{
    Console.WriteLine("It's not a number");
    return;
}

int[] CubeArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = Convert.ToInt32(Math.Pow(i + 1, 3));


    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] cube = CubeArray(N);
CubeArray(N);
PrintArray(cube);
