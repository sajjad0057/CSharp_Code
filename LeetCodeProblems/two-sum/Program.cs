

int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> dict = new();
    for (int i = 0; i < nums.Length; i++)
    {
        int temp = target - nums[i];
        if (dict.ContainsKey(temp))
            return new int[] { dict[temp], i };
        dict.TryAdd(nums[i], i);
    }

    return Array.Empty<int>();
}


var x = TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11);

foreach(int i in x)
{
    Console.WriteLine(i);
}







