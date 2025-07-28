List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

int maxCount = list1.Count > list2.Count ? list1.Count : list2.Count;
List<int> resultList = new List<int>();

for (int i = 0; i < maxCount; i++)
{
    if (list1.Count > i)
    {
        resultList.Add(list1[i]);
    }

    if (list2.Count > i)
    {
        resultList.Add(list2[i]);
    }
}

Console.WriteLine(string.Join(" ", resultList));