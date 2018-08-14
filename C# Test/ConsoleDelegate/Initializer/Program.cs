using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new student("dennis", "shuai");
            var student2 = new student { FirstName = "dennis", LastName = "shuai" };
            var student3 = new student { id = 100 };
            var student4 = new student("dennis", "shuai") { id = 100 };

            var pet = new { Age = 10, Name = "MiaoMiao" };
            //pet.Age = 100; //ERROR READ ONLY

            var students = new List<student> { new student { FirstName = "dennis", LastName = "shuai" }, new student { FirstName = "Li", LastName = "Lei" } };
            var studentForm = new List<StudentFrom>
            {
                new StudentFrom{ FirstName="Li",City="BeiJing"},
                new StudentFrom{ FirstName="Wang",City="shanghai"}
            };

            var joinquery = from s in students
                            join sf in studentForm on s.FirstName equals sf.FirstName
                            select new { FirstName = s.FirstName, LastName = s.LastName, City = sf.City };

            CollectionInitializer();
            Console.ReadLine();

        }
        static void CollectionInitializer()
        {
            Dictionary<int, student> dstudent = new Dictionary<int, student>{
                {111, new student("dennis", "shuai") { id = 100 }},
                {112, new student("Lei", "Li") { id = 101 } }
            };

            foreach (var ds in dstudent)
            {
                Console.WriteLine("Key:{0},Value:{1}", ds.Key, ds.Value.ToString());
            }
        }
    }


    public class StudentFrom
    {

        public string FirstName { get; set; }
        public string City { get; set; }

    }
    public class student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int id { get; set; }

        public student(string First, string Last)
        {
            FirstName = First;
            LastName = Last;
        }

        public student()
        {
            // TODO: Complete member initialization
        }
        override public string ToString()
        {
            return "FirstName:"+FirstName + ",LastName:" + LastName;
        }
    }
}
