using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.assignment6
{
    public class ManagerStudent
    {
        private List<Student> listStudent = new List<Student>();
        private int GenerateID()
        {
            int max = 1;
            if (listStudent != null && listStudent.Count > 0)
            {
                max = listStudent[0].Id;
                foreach (Student sv in listStudent)
                {
                    if (max < sv.Id)
                    {
                        max = sv.Id;
                    }
                }
                max++;
            }
            return max;
        }

        public int CountStudent()
        {
            int Count = 0;
            if (listStudent != null)
            {
                Count = listStudent.Count;
            }
            return Count;
        }
        private void AverageScore(Student sv)
        {
            double DiemTB = (sv.ScoreMath + sv.ScorePhysic + sv.ScoreChemistry) / 3;
            sv.ScoreMedium = Math.Round(DiemTB, 2, MidpointRounding.AwayFromZero);
        }

        
        // Hàm xếp loại học lực cho sinh vien
       
        private void RankedAcademic(Student sv)
        {
            if (sv.ScoreMedium >= 8)
            {
                sv.AcademicAbility = "Gioi";
            }
            else if (sv.ScoreMedium >= 6.5)
            {
                sv.AcademicAbility = "Kha";
            }
            else if (sv.ScoreMedium >= 5)
            {
                sv.AcademicAbility = "Trung Binh";
            }
            else
            {
                sv.AcademicAbility = "Yeu";
            }
        }
        private Student FindStudentByID(int id)
        {
            Student studentFind = null;
            if (listStudent != null && listStudent.Count > 0)
            {
                foreach (Student student in listStudent)
                {
                    if (student.Id == id)
                    {
                        studentFind = student;
                    }
                }
            }
            return studentFind;
        }
        public void AddStudent()
        {
            // Khởi tạo một sinh viên mới
            Student sv = new Student();
            sv.Id = GenerateID();
            Console.Write("Nhap ten sinh vien: ");
            sv.Name = Console.ReadLine();

            Console.Write("Nhap gioi tinh sinh vien: ");
            sv.Gender = Console.ReadLine();

            Console.Write("Nhap tuoi sinh vien: ");
            sv.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap diem toan: ");
            sv.ScoreMath = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem ly: ");
            sv.ScorePhysic = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem hoa: ");
            sv.ScoreChemistry = Convert.ToDouble(Console.ReadLine());

            AverageScore(sv);
            RankedAcademic(sv);

            listStudent.Add(sv);
        }
        public void UpdateStudent(int id)
        {
            Student st = FindStudentByID(id);
            if (st != null)
            {
                Console.Write("Nhap ten sinh vien: ");
                string name = Console.ReadLine();
                if (name != null && name.Length > 0) {
                    st.Name = name;
                }

                Console.Write("Nhap gioi tinh sinh vien: ");
                string gender = Console.ReadLine();
                if (gender != null && gender.Length > 0)
                {
                    st.Gender = gender;
                }

                Console.Write("Nhap tuoi sinh vien: ");
                string ageStr = Console.ReadLine();
                if (ageStr != null && ageStr.Length > 0)
                {
                    st.Age = Convert.ToInt32(ageStr);
                }

                Console.Write("Nhap diem toan: ");
                string scoremath = Console.ReadLine();
                if (scoremath != null && scoremath.Length > 0)
                {
                    st.ScoreMath = Convert.ToDouble(scoremath);
                }

                Console.Write("Nhap diem ly: ");
                string scorephysic = Console.ReadLine();
                if (scorephysic != null && scorephysic.Length > 0)
                {
                    st.ScorePhysic = Convert.ToDouble(scorephysic);
                }

                Console.Write("Nhap diem hoa: ");
                string scorechemistry = Console.ReadLine();
                if (scorechemistry != null && scorechemistry.Length > 0)
                {
                    st.ScoreChemistry = Convert.ToDouble(scorechemistry);
                }
                AverageScore(st);
                RankedAcademic(st);
            } else
            {
                Console.WriteLine("Sinh vien co ID = "+id+" khong ton tai.");
            }
        }
        public void DeleteStudent(int id)
        {
            Student st = FindStudentByID(id);
            if (st != null)
            {
                listStudent.Remove(st);
            }
            else
            {
                Console.WriteLine("Sinh vien co ID = " + id + " khong ton tai.");
            }
        }
        public List<Student> FindStudentByName(string name)
        {
            List<Student> students = new List<Student>();
            if (listStudent != null && listStudent.Count > 0)
            {
                foreach (Student student in listStudent)
                {
                    if (student.Id.Equals(name))
                    {
                        students.Add(student);
                    }
                }
            }
            return students;
        }
        public void SortStudentByMediumScore()
        {
            listStudent.Sort(delegate (Student st1, Student st2)
            {
                return st1.ScoreMedium.CompareTo(st2.ScoreMedium);
            });
        }
        public void SortStudentByName()
        {
            listStudent.Sort(delegate (Student st1, Student st2)
            {
                return st1.Name.CompareTo(st2.Name);
            });
        }
        public void SortStudentByID()
        {
            listStudent.Sort(delegate (Student st1, Student st2)
            {
                return st1.Id.CompareTo(st2.Id);
            });
        }
        public void ShowStudent(List<Student> listSV)
        {
            // hien thi tieu de cot
            Console.WriteLine("ID \t Name \t Gender \t  Age \t Math \t Physic \t Chemistry \t MediumScore \t AcademicAbility");
            // hien thi danh sach sinh vien
            if (listSV != null && listSV.Count > 0)
            {
                foreach (Student sv in listSV)
                {
                    Console.WriteLine(sv.Id +" \t " + sv.Name + " \t " + sv.Gender + " \t \t " + sv.Age + " \t " + sv.ScoreMath + " \t " + sv.ScorePhysic + " \t \t \t " + sv.ScoreChemistry + " \t \t " + sv.ScoreMedium + " \t " + sv.AcademicAbility);
                }
            }
            Console.WriteLine();
        }
        public List<Student> getListSinhVien()
        {
            return listStudent;
        }
    }
}
