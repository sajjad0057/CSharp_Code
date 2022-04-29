public class Problem
{
    static void main(string[] args)
    {

    }
}

public interface INode<T> where T : class, INode<T>
{
    void Add<T>(T item) where T : class;
    void Remove<T>(T item) where T : class;
}
public abstract class Nodebase<T> : Node<T>, INode<T> where T : class, INode<T>
{
    public void Add<T1>(T1 item) where T1 : class
    {

    }

    public void Remove<T1>(T1 item) where T1 : class
    {

    }
}
public class Node<T> where T : class, INode<T>
{

}



