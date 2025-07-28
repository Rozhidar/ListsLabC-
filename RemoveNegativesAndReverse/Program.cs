List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

for (int i = inputList.Count - 1; i >= 0; i--)
{
    if (inputList[i] < 0)
    {
        inputList.RemoveAt(i);
    }
}

inputList.Reverse();

if (inputList.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", inputList));
}