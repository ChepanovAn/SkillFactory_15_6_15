using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillFactory_15_6_15
{
    class Program
    {
        static void Main(string[] args)
            {
                var classes = new[]
                {
                    new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
                    new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
                    new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
                };
                var allStudents = GetAllStudents(classes);

                Console.WriteLine(string.Join(" ", allStudents));
            }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var studentsList = classes.SelectMany(s => s.Students).ToArray();

            return studentsList;
        }

        public class Classroom
            {
                public List<string> Students = new List<string>();

            public object Name { get; internal set; }
        }       
    
    }
}
