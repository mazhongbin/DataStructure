using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    public class Student
    {
        private String name;
        private Int32 score;

        public Student(String studentName,Int32 studentScore)
        {
            name = studentName;
            score = studentScore;
        }

        public override string ToString()
        {
            return $"Student Name: {name}; Score:{score}";
        }
    }
}
