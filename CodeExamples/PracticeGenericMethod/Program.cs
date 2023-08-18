using PracticeGenericMethod;
using System.Dynamic;
using System.Text.Json;

Student student1 = new Student();
ClassInfo classInfo1 = new ClassInfo();

void ObjInitializer<T>(T obj) where T : class
{
    Type type = typeof(T);
    Console.WriteLine(type.Name);
    dynamic obj1 = Activator.CreateInstance(type);
    obj1.Id = 1;
    obj1.Name = "sajjad";

    Console.WriteLine(JsonSerializer.Serialize(obj1));
    Console.WriteLine("---------------------------------");

}

ObjInitializer<Student>(student1);
ObjInitializer<ClassInfo>(classInfo1);
Console.WriteLine();


IList<string> list = new List<string> { "a", "b", "c", "d" };

Array listMethod(IList<string> list)
{
    return list.ToArray();
}


foreach(string str in listMethod(list))
{
    Console.WriteLine(str);
}
