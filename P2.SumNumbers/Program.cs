
int Sum (List<int> numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}

List<int> inputNumbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
Console.WriteLine(inputNumbers.Count);
Console.WriteLine($"{Sum(inputNumbers)}");

