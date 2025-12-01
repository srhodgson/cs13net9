for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)
    {
        if (i == 100)
        {
            Write("FizzBuzz");
        }
        else
        {
            Write("FizzBuzz, ");
        }
        
    }
    else if (i % 5 == 0)
    {
        if (i == 100)
        {
            Write("Buzz");
        }
        else
        {
            Write("Buzz, ");
        }
    }
    else if (i % 3 == 0)
    {
        if (i == 100)
        {
            Write("Fizz");
        }
        else
        {
            Write("Fizz, ");
        }
    }
    else
    {
        if (i == 100)
        {
            Write($"{i}");
        }
        else
        {
            Write($"{i}, ");
        }
    }
}