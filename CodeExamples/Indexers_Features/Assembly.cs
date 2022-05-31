using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_Features
{
    public class Assembly
    {
        public List<Person> People = new List<Person>();
        public Person this[string name]
        {
            get
            {
               return (from p in People where p.Name == name select p).FirstOrDefault();
            }
            set
            {
                int index =  People.FindIndex(x => x.Name == name);
                People[index] = value;

            }
        }
    }
}
