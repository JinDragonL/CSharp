using CSharp.LINQ.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LINQ
{
    public class JoiningAndGroup
    {
        //JOIN, GROUP

        public void Execute()
        {

            var grades = Grade.GetAll();
            var students = Student.GetAll();

            //INNER JOIN

            //var data = from student in students
            //           join grade in grades on student.Class equals grade.Id
            //           select new
            //           {
            //               StudentId = student.StudentId,
            //               Fullname = student.FirstName + " " + student.LastName,
            //               ClassName = grade.Name
            //           };

            var data2 = students.Join(grades, x => x.Class, 
                                             y => y.Id, 
                                             (student, grade) => new StudentClassModel
                                             {
                Id  = student.StudentId,
                Fullname = student.FirstName + " " + student.LastName,
                ClassName = grade.Name
            });

            //foreach (var item in data2)
            //{
            //    Console.WriteLine($"{item.Id} - {item.Fullname} at {item.ClassName}");
            //}


            //LEFT  JOIN

            var leftData = from grade in grades
                           join student in students on grade.Id equals student.Class into studentGrade
                           from student in studentGrade.DefaultIfEmpty()
                           select new StudentClassModel
                           {
                               Id = student?.StudentId ?? 0,
                               Fullname = $"{student?.FirstName}  {student?.LastName}",
                               ClassName = grade.Name
                           };

            foreach (var item in leftData)
            {
                Console.WriteLine($"{item.Id} - {item.Fullname} at {item.ClassName}");
            }

            var leftData2 = grades.GroupJoin(students, x => x.Id, y => y.Class,
                                    (grade, studentGrade) => new
                                    {
                                        ClassName = grade.Name,
                                        Student = studentGrade.DefaultIfEmpty()
                                    })
                                    .SelectMany(x => x.Student, (grade, student) => new StudentClassModel
                                    {
                                        Id = student?.StudentId ?? 0,
                                        Fullname = $"{student?.FirstName}  {student?.LastName}",
                                        ClassName = grade.ClassName
                                    });
        }

        public void ExecuteGroupBy()
        {
            var games = Game.GetAllGames();

            var groupedGames = from x in games
                               group x by new { x.Platforms, x.Rating } into groupedElements
                               select groupedElements;

                                   //var maxPlatform = groupedGames.OrderByDescending(x => x.Count).First();

                                   //var groupedGames = games.GroupBy(x => new { x.Platforms, x.Rating })
                                   //                        .Select(x => new { 
                                   //                            PlatformName = x.Key.Platforms, 
                                   //                            Rating = x.Key.Rating,
                                   //                            Count = x.Count() 
                                   //                        });

            //foreach (var game in groupedGames)
            //{
            //    Console.WriteLine($"{game.Key.Platforms} and {game.Key.Rating}");

            //    foreach (var child in game)
            //    {
            //        Console.WriteLine($"-----{child.Title} and {child.Genre}");
            //    }
            //}

            //Lambda

            var groupedMark = from game in games
                                   group new
                                   {
                                       Title = game.Title,
                                       Genre = game.Genre
                                   } by game.Mark > 80 into groupedElements
                                   select groupedElements;

            foreach (var group in groupedMark)
            {
                Console.WriteLine($"-----{(group.Key ? "> 80" : "<80")}");

                foreach (var child in group)
                {
                    Console.WriteLine($"-----{child.Title} and {child.Genre}");
                }
            }
        }
    }
}
