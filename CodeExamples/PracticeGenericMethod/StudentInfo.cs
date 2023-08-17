namespace PracticeGenericMethod;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class ClassInfo
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<Student> Students { get; set; }
}
