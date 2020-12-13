using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalFormsAndRandomNumber
{
    public class Student
    {
        private string name;
        private List<Grade> grades = new List<Grade>();

        public Student(string name, Grade grade)
        {
            this.name = name;
            this.grades.Add(grade);
        }

        public string GetName()
        {
            return this.name;
        }

        public List<Grade> GetGrades()
        {
            return grades;
        }
        
        public void AddGrade(Grade grade)
        {
            grades.Add(grade);
        }
    }
}
