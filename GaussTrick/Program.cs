List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

int originalCount = numbers.Count;

for (int i = 0; i < originalCount / 2; i++)
{
    numbers[i] += numbers[numbers.Count - 1];
    numbers.RemoveAt(numbers.Count - 1);
}

Console.WriteLine(string.Join(" ", numbers));