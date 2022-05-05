using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class Cource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
    }

    class M
    { 
      static void Main(string[]args)
        {
            List<Cource> list = new List<Cource>()
            {
                new Cource{Id=1, Name="Testing",Fees=30000},
                new Cource{Id=2, Name="Devoloper",Fees=78000},
                new Cource{Id=3, Name="SAP",Fees=40000},
                new Cource{Id=4, Name="Music",Fees=30000},
                new Cource{Id=5, Name="Games",Fees=20000}
            };
            var result1 =//from c in list
                         //where c.Fees>45000
                         //select c;

                //from c in list
                //orderby c.Name
                //select c;


                from c in list
                where c.Name.Contains("Games")
                select c;

                //from c in list
                //where c.Name.Contains("Music")
                //select c;
                //from c in list
                //orderby c.Fees descending
                //select c;

                //from c in list
                //where c.Name.StartsWith('d') || c.Name.StartsWith('T')
                //select c;

            //               from e in list
            //                where e.City.Contains("Pune") || e.Salary<35000
            //                select e;
                foreach (Cource c in result1)
            {
                Console.WriteLine($"{c.Name} {c.Id} {c.Fees} ");
            }
        }

    }

}
