using System.Runtime.InteropServices;

int number = 1;

while (number <= 100)
{
    if (number % 3 == 0 && number % 5 == 0)
    {
        Write("FizzBuzz");
    }
    else if (number % 5 == 0)
    {
        Write("Buzz");
    }
    else if (number % 3 == 0)
    {
        Write("Fizz");
    }
    else
    {
        Write(number);
    }
    
    if (number < 100)
        Write(", ");
    number++;
}