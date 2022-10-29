Console.WriteLine("Input five-digit number: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int numberForCheck);
if (!isNumber)
{
Console.WriteLine("Error. It's not a number");
    return;
}


bool CheckPalindrome(int number)
{
    int number1 = number;
    int check = 0;
    for (check = 0; number1 > 0;)
    {
        check = (check * 10) + (number1 % 10);
        number1 = number1 / 10;
    }
    
    return check == number;
}

Console.WriteLine($"Is it palindrome? {CheckPalindrome(numberForCheck)}");
