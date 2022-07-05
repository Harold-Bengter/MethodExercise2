static int Add(int x, int y)
{
    return x + y;
}
int result = Add(16, 9);

Console.WriteLine(result);

static int Multiply(int x, int y)
{
    return x * y;
}
int result2 = Multiply(2, 4);

Console.WriteLine(result2);


static int Substract(int x, int y)
{
    return x - y;
}
int result3 = Substract(8, 6);

Console.WriteLine(result3);

static int Divide(int x, int y)
{
    return x / y;
}
int result4 = Divide(18, 9);

Console.WriteLine(result4);

static int Add1(int x, int y)
{
    return x + y;
}
Console.WriteLine("Please pick a number.");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Great, now please pick another number.");
Console.WriteLine("Those numbers addeed together are.");
int y = Convert.ToInt32(Console.ReadLine());
int result5 = Add1(x, y);

Console.WriteLine(result5);