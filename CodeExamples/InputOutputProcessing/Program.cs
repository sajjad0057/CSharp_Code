Console.WriteLine("Give an String : ");

string input = Console.ReadLine();

var parts = input.Split(" ");  // split return an array 

foreach (var part in parts)
{
    if (part != "")
    {
        Console.WriteLine(part);
    }
}

Console.WriteLine("=================================================");

Console.WriteLine("Give the dimension of two dimensional array for storing value : ");

var size = Console.ReadLine().Split(" ");

int x = 0;
int y = 0;

if(int.TryParse(size[0], out x) && int.TryParse(size[1],out y))
{
    string[,] grid = new string[x,y];
    for(int i = 0; i < x; i++)
    {
        Console.WriteLine($"Insert the no. of row {i+1} : ");
        var row = Console.ReadLine().Split(" ");
        for(int j = 0; j<row.Length && j<y; j++)
        {
            grid[i,j] = row[j];

        }
    }

    Console.WriteLine();
    Console.WriteLine("=======================================");
    Console.WriteLine("The assinged array value : ");

    for(int i = 0; i < grid.GetLength(0) && i<x; i++)
    {
        for(int j = 0;j<grid.GetLength(1) && j<y ; j++)
        {
            Console.Write(grid[i, j] + " ");
        }
        Console.WriteLine();
    }

}
