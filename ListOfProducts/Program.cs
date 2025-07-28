int count = Convert.ToInt32(Console.ReadLine());

List<string> productList = new List<string>();

for (int i = 0; i < count; i++)
{
    string currentProduct = Console.ReadLine();
    productList.Add(currentProduct);
}

productList.Sort();

short number = 1;
foreach (string product in productList)
{
    Console.WriteLine($"{number}.{product}");
    number++;
}