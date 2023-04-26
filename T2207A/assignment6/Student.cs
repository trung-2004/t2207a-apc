using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.assignment6
{
    public class Student
    {
        private int id;
        private string name;
        private string gender;
        private int age;
        private double scoreMath;
        private double scorePhysic;
        private double scoreChemistry;
        private double scoreMedium;
        private string academicAbility;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double ScoreMath
        {
            get { return scoreMath; }
            set
            {
                scoreMath = value;
            }
        }
        public double ScorePhysic
        {
            get { return scorePhysic; }
            set
            {
                scorePhysic = value;
            }
        }
        public double ScoreChemistry
        {
            get { return scoreChemistry; }
            set
            {
                scoreChemistry = value;
            }
        }
        public double ScoreMedium
        {
            get { return scoreMedium; }
            set
            {
                scoreMedium = value;
            }
        }
        public string AcademicAbility
        {
            get { return academicAbility; }
            set
            {
                academicAbility = value;
            }
        }
        public Student()
        {

        }
        public Student(int id, string name, string gender, int age, double scoreMath, double scorePhysic, double scoreChemistry, double scoreMedium, string academicAbility)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
            ScoreMath = scoreMath;
            ScorePhysic = scorePhysic;
            ScoreChemistry = scoreChemistry;
            ScoreMedium = scoreMedium;
            AcademicAbility = academicAbility;
        }
    }
}
