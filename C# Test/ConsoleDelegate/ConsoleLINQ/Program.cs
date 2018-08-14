using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace ConsoleLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5,15,18,20,7, 8, 9, 10,4 ,12};
            var newquery = from num in nums
                           where num % 2 == 1 && num % 3 == 1
                           orderby num descending
                           select num;
            var query2 = nums.Where(n => n % 2 == 0).OrderByDescending(n => n) ;
            int numCount = query2.Count();
            query2.ToList();
            query2.ToArray();

            foreach( var nq in newquery)
            {
                Console.WriteLine(nq);
            }

            foreach (var nq in query2)
            {
                Console.WriteLine(nq);
            }


            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { Name = "Jack", City = "BeiJing" });
            customers.Add(new Customer() { Name = "Tim", City = "BeiJing" });
            customers.Add(new Customer() { Name = "Hook", City = "Shanghai" });

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Name = "Jack",id= 101 });
            employees.Add(new Employee() { Name = "Duke", id = 102 });

            
            var queryCustmer =  from c in customers
                                group c by c.City  ;
            foreach (var cg in queryCustmer)
            {
                Console.WriteLine(cg.Key );
                foreach (var c in cg)
                {
                    Console.WriteLine(" {0}",c.Name );
                }
            }

            var queryCustmer2 = from c in customers
                                group c by c.City into cusgroup
                                where cusgroup.Count() >= 2
                                select new { City = cusgroup.Key, number = cusgroup.Count() };

            foreach (var qc in queryCustmer2)
            {
                Console.WriteLine("City:{0},Count:{1}", qc.City, qc.number);
            }

            var queryjoin = from c in customers
                            join e in employees on c.Name equals e.Name
                            select new { PersonName = c.Name, PersonCity = c.City, PersonId = e.id };



            foreach (var qj in queryjoin)
            {
                Console.WriteLine("id:{0},Name:{1},City:{2}",qj.PersonId, qj.PersonName, qj.PersonCity);
            }

            string[] strings = { "Hello jikexueyuan.", "This is Friday!", "Are you happy?" };
            var stringQuery = from s in strings
                              let words = s.Split(' ')
                              from word in words
                              let w = word.ToUpper()
                              select w;
            foreach( var sq in stringQuery)
            {
                Console.WriteLine(sq);
            }
            Console.ReadLine();

        }
    }
    class Customer
    {
        public string Name { get; set; } 
        public string City { get;set; } 
    }
    class Employee
    {
        public string Name { get; set; }
        public int id { get; set; }
    }
}
