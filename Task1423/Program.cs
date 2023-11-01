using System;
using System.Linq;

namespace Task1423
{
    class Program
    {
        static void Main()
        {

            List<Student> students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            // Список курсов
            var coarses = new List<Coarse>
            {
                new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
                new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };

           

            var youngStudentApplications = from s in students
                where s.Age < 27 
                let birthYear = DateTime.Now.Year - s.Age 
                select new Application()
                {
                    Name = s.Name,
                    YearOfBirth = birthYear
                };

            foreach (var studApplication in youngStudentApplications)
                Console.WriteLine(studApplication.Name + ", " + studApplication.YearOfBirth);

            var studentsWithCoarses = from stud in students
                where stud.Age < 29 
                where stud.Languages.Contains("английский") 
                let birthYear = DateTime.Now.Year - stud.Age 
                from coarse in coarses
                where coarse.Name.Contains("C#") 
                select new 
                {
                    Name = stud.Name,
                    BirthYear = birthYear,
                    CoarseName = coarse.Name
                };


            foreach (var stud in studentsWithCoarses)
                Console.WriteLine($"Студент {stud.Name} ({stud.BirthYear}) добавлен курс {stud.CoarseName}");

        }
    }




}
