using Z9_BIND;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Z9_BIND
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName => Name + LastName;
        public DateTime Enlisting { get; set; }


    }

    public class StudentView
    {
        public StudenList List { get; set; }

        public StudentView()
        {
            List = new StudenList()
            {
                Students = new ObservableCollection<Student>()
                {
                    new Student
                    {
                        Id = 1,
                        Name = "Jan",
                        LastName = "Kowalski",
                        Enlisting = DateTime.Now
                    },
                    new Student
                    {
                        Id = 1,
                        Name = "Sebastian",
                        LastName = "Nowak",
                        Enlisting = new DateTime(2002, 1, 2)
                    },
                    new Student
                    {
                        Id = 1,
                        Name = "Michał",
                        LastName = "Młotek",
                        Enlisting = new DateTime(2013, 3, 3)
                    }
                }
            };
        }
    }
}

public class StudenList
{
    public ObservableCollection<Student> Students { get; set; }
}
