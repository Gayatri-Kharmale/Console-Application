using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Accounts>acntlist=new List<Accounts>();
    }
    public class Accounts
    {
        public string AccountType { get; set; }
        public int Id { get; set; }
        public List<Loan1> loanlist=new List<Loan1>();
    }
    public class Loan1
    {
        public string LoanType { get; set; }
    }
    class X
    {
        static void Main(string[]args)
        {
            List <Customer> list = new List<Customer>();
            {
                new Customer
                {
                    Id = 5,
                    Name = "hju",
                    acntlist = { new Accounts { Id = 4, AccountType = "Saving", loanlist = { new Loan1 { LoanType = "Home Loan" } } } }
                };
                foreach(Customer c in list)
                {
                    Console.WriteLine($"{c.Id},{c.Name}");
                    foreach(Accounts a in c.acntlist)
                    {
                        Console.WriteLine($"\t {a.Id} {a.AccountType}");
                        foreach(Loan1 l in a.loanlist)
                        {
                            Console.WriteLine($"\t {l.LoanType}");
                        }
                    }
                }
            }
        }
    }
}
