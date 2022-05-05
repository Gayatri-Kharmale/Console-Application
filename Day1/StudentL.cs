using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int per { get; set; }
        public string Branch { get; set; }
    }
    class P
    {
        static void Main(string[]args)
        {
            List<Student> list = new List<Student>()
            {
                new Student{Id=1,Name="Chitra",per=45,Branch="IT"},
                new Student{Id=2,Name="itra",per=67,Branch="CS"},
                new Student{Id=3,Name="tra",per=87,Branch="VG"},
                new Student{Id=4,Name="Chi",per=37,Branch="NJ"},
                new Student{Id=5,Name="Ch",per=87,Branch="IT"},
                
            };
            var result1 =//from s in list
                         //where s.per>45
                         //select s;

                //from s in list
                //orderby s.Name
                //select s;


                from s in list
                where s.Name.Contains("Chitra")
                select s;
            //from s in list
            //where s.Name.Contains("Mitra")
            //select s;
            //from s in list
            //orderby s.per descending
            //select s;

            //from s in list
            //where s.Name.StartsWith('m') || c.Name.StartsWith('c')
            //select s;

            //               from esin list
            //                where s.Branch.Contains("CS") || s.per<56
            //                select s;
            foreach(Student s in result1)
            {
                Console.WriteLine($"{s.Name} {s.Id} {s.per} {s.Branch} ");
            }

        }
    }
}
