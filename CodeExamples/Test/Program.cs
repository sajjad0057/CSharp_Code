int n = int.Parse(Console.ReadLine());


List<List<int>> testcase = new List<List<int>>();

for(int i = 0; i < n; i++)
{
    List<int> list = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
    testcase.Add(list);
}

int k = 0;
int sum = 0;

for(int i = 0; i < n; i++)
{
    k = testcase[i][3];
    for(int j= 0; j < 3; j++)
    {
        sum+=testcase[i][j];
    }
    if ((sum / 3) % k == 0)
    {
        Console.WriteLine($"Case {i + 1}: Peaceful");
    }
    else {
        Console.WriteLine($"Case {i + 1}: Fight");
    }
}