
int[] array = new int[5];
array = [1, 3, 4, 5, 6, 7];

Console.WriteLine(array.Length);

foreach(int i in array)
{
    Console.WriteLine(i);
}

string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

void DisplayArray(string[] arr) =>  Console.WriteLine(string.Join("-",arr));


weekDays[3] = "xx";

DisplayArray(weekDays);
Console.WriteLine(array[3]);

Console.WriteLine("--------------------START MULTIDIMENSIONAL ARRAY-------------------");
int[,] array2DInitialization = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

Console.WriteLine($"{array2DInitialization.GetLength(0)}, {array2DInitialization.GetLength(1)} Rank : {array2DInitialization.Rank}");

for (int i = 0; i<array2DInitialization.GetLength(0); i++)
{
    for (int j = 0; j < array2DInitialization.GetLength(1); j++)
    {
        Console.WriteLine(array2DInitialization[i,j]);
    }
}


int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4,   5,  6 } },
                        { { 7, 8, 9 }, { 10, 11, 12 } },{ { 77, 88, 99 }, { 1010, 1111, 1212 } } };

Console.WriteLine($"{array3D.GetLength(0)}, {array3D.GetLength(1)}, {array3D.GetLength(2)} Rank : {array2DInitialization.Rank}");

for (int i = 0; i < array3D.GetLength(0); i++)
{

    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        Console.Write("[");
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            if(k == array3D.GetLength(2)-1)
                Console.Write($"{array3D[i, j, k]}");
            else
                Console.Write($"{array3D[i, j, k]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}


Console.WriteLine("-----------------------JaggedArray-------------------------");

int[][] jaggedArray = new int[3][];

jaggedArray[0] = [1, 3, 5, 7, 9];
jaggedArray[1] = [0, 2, 4, 6];
jaggedArray[2] = [11, 22];

int[][] jaggedArray2 =
[
    [1, 3, 5, 7, 9],
    [0, 2, 4, 6],
    [11, 22]
];

Console.WriteLine($"Rank of jaggedArray : {jaggedArray.Rank}");


for (int i = 0; i < jaggedArray.GetLength(0); i++)
{
    Console.Write("[");
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write($"{jaggedArray[i][j]} ");
    }
    Console.WriteLine("]");
}