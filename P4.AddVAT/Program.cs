double AddVat(double price)
{
    price += price * 0.20;
    return price;
}

double[] inputPrices = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();

foreach (double price in inputPrices)
{
    Console.WriteLine($"{AddVat(price):F2}");
}