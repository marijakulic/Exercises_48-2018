using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_48_2018
{
    class ExerciseResult
    {
        public ExerciseResult(int id, string studentName, string studentIndeks, int points)
        {
            Id = id;
            StudentName = studentName;
            StudentIndeks = studentIndeks;
            Points = points;
        }

        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentIndeks { get; set; }
        public int Points { get; set; }
        public override string ToString()
        {
            return Id + " " + StudentName + " " + StudentIndeks + " " + Points;
        }
    }
}
