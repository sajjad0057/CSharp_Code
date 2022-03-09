// Practice Array :

/*
 c# have two types of array : 
    1. Single dimension array.
    2. Multidimension or jagged array.
 */



Console.WriteLine($"\n Practice  Array : \n" +
    $"-----------------------------------------------------------------\n");

var x = new[] { 1, 2, 3, 4, 5, 6, 6 };

foreach (var x2 in x)
{
    int i = 0;
    Console.WriteLine($"x[i] = {x2}");
    i++;
}


// Practice 2 D array : 

Console.WriteLine($"\n Practice 2 D Array : \n" +
    $"-----------------------------------------------------------------\n");


int[,] a2d = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

/*
Array.GetLength(Int32) Method is used to find the total number of elements present in the 
specified dimension of the Array.  
 */

for (int i = 0; i < a2d.GetLength(0); i++)
{
    for (int j = 0; j < a2d.GetLength(1); j++)
    {
        Console.WriteLine($"a2d[{i},{j}] = {a2d[i, j]}");
    }
}



// Practice jagged array :  using jagged array for memory optimization .

Console.WriteLine($"\n Practice jagged  Array  using forloop : \n" +
    $"-----------------------------------------------------------------\n");

int[][] ja = new int[3][];
ja[0] = new int[3] { 1, 2, 3 };
ja[1] = new int[2] { 4, 5 };
ja[2] = new int[1] { 7 };

/*
Array.GetLength(Int32) Method is used to find the total number of elements present in the 
specified dimension of the Array.  
 */


for (int i = 0; i < ja.GetLength(0); i++)
{
    for (int j = 0; j < ja[i].Length; j++)
    {
        Console.WriteLine($"ja[{i}][{j}] = {ja[i][j]}");
    }
}


// Another Example for Access jagged Array :

Console.WriteLine($"\n Practice jagged  Array  using foreach : \n" +
    $"-----------------------------------------------------------------\n");


foreach (int[] j in ja)    // we can declare array type variable also ;
{
    int m = 0;
    int n = 0;
    foreach (var v in j)
    {
        Console.WriteLine($"ja[{m}][{n}] = {v}");
        n++;
    }
    m++;
}



Console.WriteLine($"\nPractice multidimensional array \n" +
 $"==============================================");

int[,,] arr = new int[3, 2, 3] { { { 2, 4, 3 }, { 34, 5, 3 } }, { { 3, 4, 5 }, { 3, 3, 3 } }, { { 2, 3, 4 }, { 4, 4, 4 } } };

//Or
//int[,,] arr = new int[,,] { { { 2, 4, 3 }, { 34, 5, 3 } }, { { 3, 4, 5 }, { 3, 3, 3 } }, { { 2, 3, 4 }, { 4, 4, 4 } } };

Console.WriteLine(arr.Rank); //Return dimension off array.
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            Console.WriteLine($"arr[{i},{j},{k}]={arr[i, j, k]}");
        }
    }
}

Console.WriteLine($"\nPractice prblm three --- jagged array practice more! \n" +
    $"=================================================================");

int[][,] jaggedArray4 = new int[][,]
 {
      new int[,] { {1,3}, {5,7} },
      new int[,] { {0,2}, {4,6}, {8,10} },
      new int[,] { {11,22}, {99,88}, {0,9} }
 };


//Console.WriteLine(jaggedArray4.GetLength(0));

////Console.WriteLine(jaggedArray4.GetLength(1)); //thats throw an exceptions 

//Console.WriteLine(jaggedArray4[0].GetLength(0));
//Console.WriteLine(jaggedArray4[1].GetLength(0));


Console.WriteLine("Rank of the array : "+jaggedArray4[1].Rank); // Rank return dimension of array . 



for (int i = 0; i < jaggedArray4.GetLength(0); i++)
{
    for (int j = 0; j < jaggedArray4[i].GetLength(0); j++)
    {
        for (int k = 0; k < jaggedArray4[j].Rank; k++)
        {
            Console.WriteLine($"jaggedArray4[{i}][{j},{k}]={jaggedArray4[i][j, k]}");
        }

    }
}