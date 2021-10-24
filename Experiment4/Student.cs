using System;

namespace CSharp.Experiemnt4
{
    class Student
    {
        private int _id;
        public int id { get => _id; private set => _id = value; }
        private string _name;
        public string name { get => _name; private set => _name = value; }
        private double _chinese;
        public double chinese { get => _chinese; private set => _chinese = value; }
        private double _math;
        public double math { get => _math; private set => _math = value; }
        private double _english;
        public double english { get => _english; private set => _english = value; }
        public double totalScore { get => chinese + math + english; }

        public Student(int id, string name, double chinese, double math, double english)
        {
            this.id = id;
            this.name = name;
            this.chinese = chinese;
            this.math = math;
            this.english = english;
        }

    }
}