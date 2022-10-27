//Task19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Input five-digit number: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);
if (!isNumber)
{
Console.WriteLine("Error. It's not a number");
    return;
}

int Digits(int number)
{
    int dig = 0;
    for (dig = 0; number > 0; dig++)
    {
        number = number / 10;
    }

    return dig;

}

void FillArray(int[] inputArray, int num)
{
    int i = (inputArray.Length)- 1;
    while (i >= 0)
    {
        inputArray[i] = num % 10;
        num = num / 10;
        i--;
    }
}

bool CheckPolynDrom (int checkNumber)
{
    int[] array = new int[Digits(number)];
    FillArray(array, number);
    return array[0] == array[4] && array[1] == array[3];

}

bool check = CheckPolynDrom(number);
if (check)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

