using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Copier
    {
        public T Copy<T>(object item) 

            where T : class , new()
            
        {
            Type t1 = typeof(T);                      // we can apply typeof() func on Datatype , but not on variables . 

            Type t2 = item.GetType();                 // we can apply GetType() func on variables .


            // Here, ConstructorInfo class object receive a Constructor info / Constructor according to his parameter . 

            ConstructorInfo constructor = t1.GetConstructor(new Type[] { });

            object result = constructor.Invoke( new object[] { });     // here , item was called source Object and result being called destination Object . 


            // GetProperties() return PropertyInfo[] typed list / array

            PropertyInfo[] t1properties = t1.GetProperties();

            PropertyInfo[] t2properties = t2.GetProperties();

            foreach(PropertyInfo t1Property in t1properties)
            {
                foreach (PropertyInfo t2Property in t2properties)
                {
                    if(t1Property.Name == t2Property.Name)
                    {
                        t1Property.SetValue(result, t2Property.GetValue(item));
                    }
                }
            }


            return (T)result;

        }
    }
}
