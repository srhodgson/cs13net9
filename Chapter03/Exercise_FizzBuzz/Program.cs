int count = 100;

for (int num = 1; num <= count; num++)
{
    if (num % 3 == 0 && num % 5 == 0)
    {
        Write("FizzBuzz");
    }
    else if (num % 5 == 0)
    {
        Write("Buzz");
    }
    else if (num % 3 == 0)
    {
        Write("Fizz");
    }
    else
    {
        Write($"{num}");
    }

    if (num < 100)
    {
        Write(", ");
    }
    else
    {
        Write(".");
    }
    
}
