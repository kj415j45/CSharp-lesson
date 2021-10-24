using System.Collections.Generic;
using System.Linq;

namespace CSharp.Experiemnt4
{
    class Grade
    {
        public List<Student> Students;

        public Grade()
        {
            this.Students = new List<Student>();
        }

        public void addStudent(Student student)
        {
            this.Students.Add(student);
        }

        public Student getStudentByName(string name)
        {
            return this.Students.Find(student => student.name.Equals(name));
        }

        public Dictionary<string, double> getAverageScore()
        {
            Dictionary<string, double> result = new Dictionary<string, double>();
            result.Add("chinese", 0);
            result.Add("math", 0);
            result.Add("english", 0);

            this.Students.ForEach(student =>
            {
                result["chinese"] += student.chinese;
                result["math"] += student.math;
                result["english"] += student.english;
            });

            result["chinese"] /= this.Students.Count;
            result["math"] /= this.Students.Count;
            result["english"] /= this.Students.Count;

            return result;
        }

        public double getMaxScoreOf(string subject)
        {
            return subject switch //C# 8.0 特性
            {
                "chinese" => this.Students.Max(student => student.chinese), //Linq 为 List 提供的扩展方法
                "math" => this.Students.Max(student => student.math),
                "english" => this.Students.Max(student => student.english),
                _ => 0,
            };
        }


        public List<Student> getBest3()
        {
            return this.Students
            .OrderByDescending(student => student.totalScore).Take(3) // 取前3，Linq 为 List 提供的扩展方法
            .ToList();
        }

        public List<Student> getFailureOn(string subject)
        {
            return subject switch
            {
                "chinese" => this.Students.Where(student => student.chinese < 60).ToList(),  //Linq 为 List 提供的扩展方法
                "math" => this.Students.Where(student => student.math < 60).ToList(),
                "english" => this.Students.Where(student => student.english < 60).ToList(),
                _ => new List<Student>(),
            };
        }

        //[科目名 => [分数段名 => 百分比]]
        public Dictionary<string, Dictionary<string, double>> getScoreStatistics()
        {
            Dictionary<string, Dictionary<string, double>> result = new Dictionary<string, Dictionary<string, double>>();
            //有点长，不写了（
            return result;
        }

    }
}