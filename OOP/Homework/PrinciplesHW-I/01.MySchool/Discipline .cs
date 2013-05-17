using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MySchool
{
    class Discipline // :ICommentable
    {
        private string name;
        private int lectureHours;
        private int exerciseHours;
        public List<string> Comments { get; set; }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int LectureHours
        {
            get { return this.lectureHours; }
            private set { this.lectureHours = 10; } // = value
        }

        public int ExerciseHours
        {
            get { return this.ExerciseHours = exerciseHours; }
            private set { this.exerciseHours = 20; }
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

    }
}
