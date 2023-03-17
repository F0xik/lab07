
Console.WriteLine("Введите число:");
int input = Convert.ToInt32(Console.ReadLine());

bool simply0(int input)
{
    if (input > 1)
    {
        for (int i = 2; i < input; i++)
            if (input % i == 0)
                 return false;
        
        return true;
    }
    else return false; 

}

Console.WriteLine(simply0(input));

Console.WriteLine(" ");
Console.WriteLine("На 4");
Console.WriteLine(" ");
Console.WriteLine("Введите минимальное значение диапазона:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение диапазона:");
int max = Convert.ToInt32(Console.ReadLine());
for (; min <= max; min++)
{
    bool simply1(int min)
    {
        for (int i = 2; i < min; i++)
        {
            if (min % i == 0)
                return false;
        }
        return true;
    }
    if (simply1(min)) 
    { 
        Console.WriteLine(min); 
    }
}

Console.WriteLine(" ");
Console.WriteLine("На 5");
Console.WriteLine(" ");
Console.WriteLine("Введите составное число:");
int num = Convert.ToInt32(Console.ReadLine());
bool simply2(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}
if (simply2(num)) { Console.WriteLine("Число простое. На множители не делится"); }
else
{
    for (int h = 2; h < num + 1; h++)
    {
        if (num % h == 0)
        {
            num /= h; Console.WriteLine(h);
            h = 1;
        };
    };
}

