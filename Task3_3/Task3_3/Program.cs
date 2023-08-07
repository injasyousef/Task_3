// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number");
string input =Console.ReadLine();
int number=int.Parse(input);
if (IsPrime(number))
{
    Console.WriteLine(number+" Is Prime");
}
else
{
    Console.WriteLine(number + " Is Not Prime");
}

 bool IsPrime(int number)
{
    if (number <= 1)
        return false;
    int sqrt = (int)Math.Sqrt(number);

    for (int divisor = 2; divisor <= sqrt; divisor++)
    {
        if (number % divisor == 0)
        {
            return false;
        }
    }
    return true;
}
