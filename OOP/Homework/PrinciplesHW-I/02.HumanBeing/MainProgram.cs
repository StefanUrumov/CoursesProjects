using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HumanBeing
{
    class MainProgram
    {
        static void Main()
        {
            //students task
            List<Student> students = new List<Student>()
          { 
              new Student( "Ivancho","Ivanov", 9 ),
              new Student( "Shrek","Monster", 7 ),
              new Student( "Blade","One", 3 ),
              new Student( "Vader","Star", 4 ),
              new Student( "Bai","Ganio", 5 ),
              new Student( "Petkan","Divaka", 8 ),
              new Student( "Sofia","Bulgaria", 2 ),
              new Student( "Tokio","Japan", 1 ),
              new Student( "Some","Friend", 10 ),
              new Student( "Last","Student", 6 )
          };

            students = students.OrderBy(student => student.Grade).ToList();


            Console.WriteLine("----Students Sorted----");
            foreach (var item in students)
            {
                Console.WriteLine(item.Name + " " + item.LastName + "- Grade = " + item.Grade);
            }


            //workers task
            List<Worker> workers = new List<Worker>()
            {
                new Worker("bot1","NoName", 160.0m, 8.0m),
                new Worker("bot2","NoName", 110.0m, 18.0m),
                new Worker("bot3","NoName", 60.0m, 3.0m),
                new Worker("bot4","NoName", 165.0m, 5.0m),
                new Worker("bot5","NoName", 260.0m, 8.0m),
                new Worker("bot6","NoName", 360.0m, 18.0m),
                new Worker("bot7","NoName", 90.0m, 5.0m),
                new Worker("bot8","NoName", 10.0m, 1.0m),
                new Worker("bot9","NoName", 1160.0m, 8.0m),
                new Worker("bot10","NoName", 120.0m, 9.0m)
            };


            workers = workers.OrderBy(worker => worker.MoneyPerHour()).ToList();

            Console.WriteLine("----Workers Sorted----");
            foreach (var item in workers)
            {
                Console.WriteLine(item.Name + "- Money per hour = " + item.MoneyPerHour());
            }

            Console.WriteLine("----Merged lists and sorted----");
            
            var mergedLists = workers.Concat<Human>(students).ToList();
            mergedLists = mergedLists.OrderBy(list => list.Name).ThenBy(list => list.LastName).ToList();

            foreach (var item in mergedLists)
            {
                Console.WriteLine(item.Name + " " + item.LastName);
            }







        }
    }
}
