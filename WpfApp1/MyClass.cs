using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<MyClass> data = new ObservableCollection<MyClass>();
        public ObservableCollection<MyClass> GetData()
        {
            data.Add(new MyClass("Willa", "Cather", 18));
            data.Add(new MyClass("Isak", "Dinesen", 22));
            data.Add(new MyClass("Victor", "Hugo", 10));
            data.Add(new MyClass("Jules", "Verne", 20));

            return data;
        }
        public ObservableCollection<MyClass> Add(string name, string surname, int age)
        {
            data.Add(new MyClass(name, surname, age));
            return data;
        }
    }
}
