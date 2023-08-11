namespace A_Z;

public class A
{
    public int Number { get; set; }
}



public class B
{
    public A[] Assss { get; set; }
}


public class C
{
    public A[] Assss { get; set; } = new A[] { 
        new A { Number = 1 }, 
        new A { Number = 2 }, 
        new A { Number = 3 }, 
        new A { Number = 4 }, 
        new A { Number = 5 }, 
        new A { Number = 6 } 
    };
}
