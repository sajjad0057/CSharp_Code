

/*
reference typed accept null value ; But value typed does not accept null value , if we want to set 
null value in value type , need to set nullable data type after valueTyped ; 

Example :

 */

// Example of nullable dataType : 

string s = null;

int? x = null;

// Check value :

if (x.HasValue)
    Console.WriteLine(x.Value);
else
    Console.WriteLine("x is null");


// null conditional operator ?.   or  ?[]

// string y = null;


string y = "sajjad";

int? l = y?.Length;   // by this if y is not null, then  Lenght Property can be invoked  otherwise null value assigned in l variable;

Console.WriteLine(l);



// null - coalesing Operator  ?? 


string i = null;

string j = i ?? "i is null";   // by this if i is not null , then i value assigned in j variable , But if i is null then, "i is null" string assigned in j variable ;

Console.WriteLine($"j check i value , i = {j}");









