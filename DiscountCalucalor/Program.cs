
Console.WriteLine("provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);

Console.WriteLine($"Your discount is: {discount} %");

double newTotal = userInput - (userInput * discount);

Console.WriteLine($"Your new total is: {newTotal}");
static double CalculateDiscount(int total)
{
    if(total > 10)
    {
        return 1;
    }
    else if(total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateDiscount(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}