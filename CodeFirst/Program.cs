using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student = new Student() {Name = "Fabio Scapel"};
                var mathSubject = new Subject() {Name = "math"};
                var scienceSubj = new Subject() {Name = "Data Structures"};

                student.Subjects.Add(mathSubject);
                student.Subjects.Add(scienceSubj);

                db.Students.Add(student);
                db.SaveChanges();

                
            }
        }
    }


    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }
        public virtual List<Subject> Subjects { get; set; }

        public Student()
        {
            this.Subjects = new List<Subject>();
        }
    }


    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }

        
        public virtual Student student { get; set; }
    }


    class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }

}
