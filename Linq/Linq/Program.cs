using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        public class Student
        {
            public virtual string Name { get; set; }
            public virtual int Age { get; set; }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            //Querry Syntax
            IEnumerable<int> linq = from s in arr
                                    where s % 2 == 0
                                    select s;
            foreach (var item in linq)
            {
                Console.WriteLine("{0}", item);
            }

            //Method Syntax
            IEnumerable<int> linq2 = arr.Where(x => x % 2 == 0).Select(s => s);

            foreach (var item in linq2)
            {
                Console.WriteLine(item);
            }

            //Linq and Generic Type
            /*Gia tri tra ve cua Linq la IEnumerable<T> and IQueryable<T> la kieu Generic*/
            List<Student> students = new List<Student>()
            {
                new Student {Name="Dung1",Age=20 },
                new Student {Name="Dung2",Age=21 },
                new Student {Name="Dung3",Age=22 },
                new Student {Name="Dung4",Age=23 },
                new Student {Name="Dung5",Age=19 },
            };
            IEnumerable<Student> linq3 = from s in students
                                         select s;
            foreach (var item in linq3)
            {
                Console.WriteLine("Name: {0}--Age: {1}", item.Name, item.Age);
            }

            Console.ReadKey();
        }
    }
}
