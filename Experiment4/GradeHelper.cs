using System.Collections.Generic;

namespace CSharp.Experiemnt4
{
    static class GradeHelper
    {
        public static string toString(this List<Student> students){ //为List<Student>扩展方法
            string str = string.Empty;
            students.ForEach(student => str += student.name + ' ');
            str.TrimEnd();
            return str;
        }
    }
}