int[] TwoSum(int[] nums, int target)
{
    for(int i = 0; i < nums.Length; i++)
    {
        for(int j =i+1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
                return new int[] { i, j };
        }
    }

    return new int[] {};
}


var x = TwoSum(new int[] { 2, 5, 5, 11 }, 10);

foreach(int i in x)
{
    Console.WriteLine(i);
}







