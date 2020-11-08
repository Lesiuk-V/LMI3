using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace WpfApp1
{
    public class MyClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public MyClass(string name = "unknow", string surname = "unknow", int age = 0)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
