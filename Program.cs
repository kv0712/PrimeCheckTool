Console.Write("enter number for check ");
if (int.TryParse(Console.ReadLine(), out int num))
{
    if (int.TryParse(Console.ReadLine(), out int x))
    {
        if (int.TryParse(Console.ReadLine(), out int y))
        {
            List<int> numbers = [];


            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    bool isPrime = false;
                    if (i == j)
                        isPrime = true;
                    else if (i % j == 0)
                        break;
                    if (isPrime)
                        numbers.Add(i);
                }

            }
            bool isPrime_x = false;
            bool isPrime_y = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (x == numbers[i])
                    isPrime_x = true;
                if (y == numbers[i])
                    isPrime_y = true;
                
            }
            if (isPrime_x)
            {
                if (isPrime_y)
                {
                    int count = 0;
                    for (int i = 1; i < num; i++)
                    {
                        if (i % x == 0 && i % y == 0)
                            count++;
                    }
                    System.Console.WriteLine(count);
                }
                else Console.WriteLine($"num of {y} is not prime");
            }
            else Console.WriteLine($"num of {x} is not prime");

        }
        else Console.WriteLine("your enter is not number");
    }
    else Console.WriteLine("your enter is not number");
}
else Console.WriteLine("your enter is not number");

