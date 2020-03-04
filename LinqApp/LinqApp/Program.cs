using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    class Student
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id} {Fio} {Age}";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Student> lst = new List<Student>();
            lst.Add(new Student() { Id = 1, Fio = "Иванов", Age = 20 });
            lst.Add(new Student() { Id = 3, Fio = "Петров", Age = 15 });
            lst.Add(new Student() { Id = 4, Fio = "Марков", Age = 26 });
            lst.Add(new Student() { Id = 2, Fio = "Сидоров", Age = 33 });
            lst.Add(new Student() { Id = 5, Fio = "Коннов", Age = 22 });


            var newlst = lst.Where(st => st.Age >= 20).OrderByDescending(st=>st.Id);


            Console.WriteLine(lst.OrderBy(st=>st.Age).LastOrDefault(st=>st.Id<6));
            Console.WriteLine("*****************");

            foreach(var st in newlst.Select(st=> new { st.Fio, st.Age }))
            {
                Console.WriteLine(st);
            }

        }
    }
}
