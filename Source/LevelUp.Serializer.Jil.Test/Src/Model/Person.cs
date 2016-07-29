using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUp.Serializer.Jil.Test.Model
{
    public class Person
    {
        public String Name { get; set; }
        public Int32 Age { get; set; }

        public Person()
        {
            
        }

        public Person(String name, Int32 age)
            :this()
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
