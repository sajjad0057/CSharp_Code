

/*
                              For Knowing More About Expression follow this link -

                              ***  https://tyrrrz.me/blog/expression-trees ***
 
*/

using System.Linq.Expressions;

Expression<Func<int, int, int>> sum = (a, b) => a + b;

Func<int,int,int> a = sum.Compile();

int r = a(1, 3);
Console.WriteLine(r);
