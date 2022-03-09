Console.Write("Give the dimension of (n x n) 2D array : ");

/*
 If n = 3 ; then input values are might be : 

4 3 2
2 3 1
4 1 0
 
 */

var size = int.Parse(Console.ReadLine());

string[,] grid = new string[size, size];


for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Insert the no. of row {i + 1} : ");
    var row = Console.ReadLine().Split(" ");
    for (int j = 0; j < row.Length && j < size; j++)
    {
        grid[i, j] = row[j];

    }
}


Console.Write("Give the number of rotations : ");

int n = int.Parse(Console.ReadLine());

string[,] grid2 = new string[size, size];


for(int t = 1; t <= n; t++)
{
    if (t % 2 == 1)
    {

        for (int i = 0; i < size; i++)
        {
            for (int j = 0, k = size - 1; j < size; j++, k--)
            {
                grid2[i, j] = grid[k, i];

            }
        }
        Array.Clear(grid);
    }
    else
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0, k = size - 1; j < size; j++, k--)
            {
                grid[i, j] = grid2[k, i];

            }
        }
        Array.Clear(grid2);
    }


}

Console.WriteLine($"After {n} times rotations , 2D array : ");
Console.WriteLine();


if (n % 2 == 1)
{
    for (int i = 0; i < grid.GetLength(0) && i < size; i++)
    {
        for (int j = 0; j < grid.GetLength(1) && j < size; j++)
        {
            Console.Write(grid2[i, j] + " ");
        }
        Console.WriteLine();
    }
}
else
{
    for (int i = 0; i < grid.GetLength(0) && i < size; i++)
    {
        for (int j = 0; j < grid.GetLength(1) && j < size; j++)
        {
            Console.Write(grid[i, j] + " ");
        }
        Console.WriteLine();
    }
}
