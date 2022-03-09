int[][,] jaggedArray4 = new int[][,]
 {
      new int[,] { {1,3}, {5,7} },
      new int[,] { {0,2}, {4,6}, {8,10} },
      new int[,] { {11,22}, {99,88}, {0,9} }
 };


//Console.WriteLine(jaggedArray4.GetLength(0));
//Console.WriteLine(jaggedArray4.GetLength(1)); //that's throw an exception.

//Console.WriteLine(jaggedArray4[0].Rank);
//Console.WriteLine(jaggedArray4[0].GetLength(0));
//Console.WriteLine(jaggedArray4[1].GetLength(0));


//Console.WriteLine(jaggedArray4[1].Rank); // "Rank" return the dimension of array. 

Console.WriteLine("Print The value of jaggedArray4 : ");
Console.WriteLine();

for (int i = 0; i < jaggedArray4.GetLength(0); i++)
{
    for (int j = 0; j < jaggedArray4[i].GetLength(0); j++)
    {
        for (int k = 0; k < jaggedArray4[j].Rank; k++)
        {
            Console.WriteLine($"jaggedArray4[{i}][{j},{k}] = {jaggedArray4[i][j,k]}");
        }

    }
}
