// work with 3D array .

Console.WriteLine("Give the dimension of three dimensional array or 3D cube (Like 3 1 1) : ");

string[] dimension = Console.ReadLine().Split(' ');

int x = int.Parse(dimension[0]);
int y = int.Parse(dimension[1]);
int z = int.Parse(dimension[2]);

int[,,] cube = new int[x, y, z];

/*
 If 3D array dimension 2x3x2 ; the this 3D array might be store 2x3x2 = 12 times of value;
 */


for (int i = 0;i<x; i++)
{
    for (int j = 0; j < y ; j++)
    {
        for (int k = 0;k<z; k++)
        {
            Console.WriteLine($"Insert the value of cube[{i},{j},{k}] : ");
            string[] zValue = Console.ReadLine().Split(' ');
            for (int l = 0; l< zValue.Length && l < z; l++)
            {
                cube[i, j, k] = int.Parse(zValue[l]);
            }

        }

    }

}



// Finding (x,y) cordinates, where ,there have most valueable items along the z axis

Console.WriteLine("Finding (x,y) cordinates, where ,there have most valueable items along the z axis");

int x_axis = 0;
int y_axis = 0;
int z_axis_value = 0;


for (int i = 0; i < x && i < cube.GetLength(0); i++)
{
    for (int j = 0; j < y && j < cube.GetLength(1); j++)
    {
        for (int k = 0; k < z && k < cube.GetLength(2); k++)
        {           
            if (cube[i, j, k] > z_axis_value)
            {
                x_axis = i;
                y_axis = j;
                z_axis_value = cube[i, j, k];
            }
        }
    }
}


Console.WriteLine($"Expected cordinates of (x,y) = ({x_axis},{y_axis})");