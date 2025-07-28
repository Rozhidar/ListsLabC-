List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

string command;
bool isChanged = false;

while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command.Split();

    switch (arguments[0])
    {
        case "Add":
            inputList.Add(int.Parse(arguments[1]));
            isChanged = true;
            break;

        case "Remove":
            inputList.Remove(int.Parse(arguments[1]));
            isChanged = true;
            break;

        case "RemoveAt":
            int removeIndex = int.Parse(arguments[1]);
            inputList.RemoveAt(removeIndex);
            isChanged = true;
            break;

        case "Insert":
            int number = int.Parse(arguments[1]);
            int index = int.Parse(arguments[2]);
            inputList.Insert(index, number);
            isChanged = true;
            break;

        case "Contains":
            int checkNumber = int.Parse(arguments[1]);
            CheckIfNumberIsInTheList(inputList, checkNumber);
            break;

        case "PrintEven":
            PrintEvenNumbers(inputList);
            break;

        case "PrintOdd":
            PrintOddNumbers(inputList);
            break;

        case "GetSum":
            Console.WriteLine(SumOfAllNumbers(inputList));
            break;

        case "Filter":
            string condition = arguments[1];
            int filterNumber = int.Parse(arguments[2]);
            List<int> filtered = FilterNumbers(condition, filterNumber, inputList);
            Console.WriteLine(string.Join(" ", filtered));
            break;
    }
}

if (isChanged)
{
    Console.WriteLine(string.Join(" ", inputList));
}

static List<int> FilterNumbers(string condition, int filterNum, List<int> list)
{
    List<int> filteredList = new List<int>();

    if (condition == "<")
    {
        filteredList = list.Where(n => n < filterNum).ToList();
    }
    else if (condition == ">")
    {
        filteredList = list.Where(n => n > filterNum).ToList();
    }
    else if (condition == ">=")
    {
        filteredList = list.Where(n => n >= filterNum).ToList();
    }
    else if (condition == "<=")
    {
        filteredList = list.Where(n => n <= filterNum).ToList();
    }

    return filteredList;
}

static int SumOfAllNumbers(List<int> inputList)
{
    int sum = 0;

    for (int i = 0; i < inputList.Count; i++)
    {
        sum += inputList[i];
    }

    return sum;
}

static void PrintOddNumbers(List<int> list)
{
    List<int> listOfOddNums = new List<int>();

    foreach (int number in list)
    {
        if (number % 2 != 0)
        {
            listOfOddNums.Add(number);
        }
    }

    Console.WriteLine(string.Join(" ", listOfOddNums));
}

static void PrintEvenNumbers(List<int> list)
{
    List<int> listOfEvenNums = new List<int>();

    foreach (int number in list)
    {
        if (number % 2 == 0)
        {
            listOfEvenNums.Add(number);
        }
    }

    Console.WriteLine(string.Join(" ", listOfEvenNums));
}

static void CheckIfNumberIsInTheList(List<int> list, int number)
{
    if (list.Contains(number))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No such number");
    }
}
