using System.Diagnostics.CodeAnalysis;

namespace PracticeIEualityComparer_Interface;

public class PersonEqualityComparer : IEqualityComparer<Person>
{
    public bool Equals(Person? x, Person? y)
    {
        if(x == null && y == null) return true;
        if(x == null || y == null) return false;


        ////return x.FirstName == y.FirstName && x.LastName == y.LastName && x.Id == y.Id; //// If write this then check Id when compare
        return x.FirstName == y.FirstName && x.LastName == y.LastName; //// If we do this doesnot check Id when compare
    }

    public int GetHashCode([DisallowNull] Person obj)
    {
        return (obj.FirstName + obj.LastName + obj.Id).GetHashCode();
    }
}
