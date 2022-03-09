Console.WriteLine("Give the dimension of 2D  array (x y) : ");

var size = Console.ReadLine().Trim().Split(" ");

int x = 0;
int y = 0;

//for 3 3  2d diagonal positions ,  input value might be :
/*

1 2 3
4 5 6
7 8 9
 
*/

// Output for is values ,here sum of the all numbers = 45;


if (int.TryParse(size[0], out x) && int.TryParse(size[1], out y))
{
    string[,] grid = new string[x, y];
    for (int i = 0; i < x; i++)
    {
        Console.WriteLine($"Insert the values of row {i + 1} : ");

        var row = Console.ReadLine().Split(" ");

        for (int j = 0; j < row.Length && j < y; j++)
        {
            grid[i, j] = row[j];

        }
    }
    Console.WriteLine();

    int sum = 0;

    for (int i = 0; i < grid.GetLength(0) && i < x; i++)
    {
        for (int j = 0; j < grid.GetLength(1) && j < y; j++)
        {

            sum = sum + int.Parse(grid[i, j]); 

        }
    }

    Console.WriteLine($"Sum of the numbers that are in the 2 diagonal positions is : {sum}");

}