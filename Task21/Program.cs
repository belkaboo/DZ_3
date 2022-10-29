Console.WriteLine("Input first coordinate: ");
Console.Write("X = ");
bool isParsedx1 = int.TryParse(Console.ReadLine(), out int x1);
Console.Write("Y = ");
bool isParsedy1 = int.TryParse(Console.ReadLine(), out int y1);
Console.Write("Z = ");
bool isParsedz1 = int.TryParse(Console.ReadLine(), out int z1);


Console.WriteLine("Input second coordinate: ");
Console.Write("X = ");
bool isParsedx2= int.TryParse(Console.ReadLine(), out int x2);
Console.Write("Y = ");
bool isParsedy2 = int.TryParse(Console.ReadLine(), out int y2);
Console.Write("Z = ");
bool isParsedz2 = int.TryParse(Console.ReadLine(), out int z2);

if (!isParsedx1 | !isParsedy1 | !isParsedz1 |!isParsedx2 |!isParsedy2|!isParsedz2 )
{
    Console.WriteLine("Error. Coordinates are incorrect");
    return;
}

int[] dot1arr = {x1,y1,z1}; //на лекции говорили, что вроде как нехорошо больше 5 параметров для метода. Не придумал, как пихнуть в метод.
int[] dot2arr = {x2,y2,z2};

double GetRange3D(int[] array1, int[] array2)
{
    double range3D = Math.Sqrt(Math.Pow((array2[0] - array1[0]), 2) + Math.Pow((array2[1] - array1[1]), 2) + Math.Pow((array2[2] - array1[2]), 2));
    return range3D;
}

Console.WriteLine($"Range is {GetRange3D(dot1arr,dot2arr)}");
