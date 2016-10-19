using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Discipline
    {
        string _name;
        int _year;
        string _profName;
        int[] _gradeExam;
        int[] _gradeLab;
        int _attendance;
        int _type;  //distributed( 0 ) or final exam( 1 )
        double _k; //ratio to calculate the average
        int nr_credite;

        public Discipline(string name, int year, string professorName, int type)
        {
            this._name = name;
            this._year = year;
            this._profName = professorName;
            this._type = type;
        }

        public void setNr_credite(int nr_credite)
        {
            this.nr_credite = nr_credite;
        }
        public double getNr_credite()
        {
            return nr_credite;
        }

        public void setRatio(double ratio)
        {
            this._k = ratio;
        }
        public double getRatio()
        {
            return _k;
        }
        public int getDisciplineType()
        {
            return this._type;
        }
        public void setGradeExam(int first, int second)
        {
            this._gradeExam[0] = first;
            this._gradeExam[1] = second;
        }
        public void setGradeLab(int grade)
        {
            int i = 0;
            while (_gradeLab[i] != 0)
            { i++; }
            this._gradeLab[i] = grade;
        }
        public void setAttendance(int a)
        {
            _attendance = a;
        }
        public double getExamGrade()
        {
            if (_gradeExam[1] != 0)
            {
                return (_gradeExam[0] + _gradeExam[1]) / 2;
            }
            else
            {
                return _gradeExam[0];
            }
        }
        public double getDisciplineGrade()
        {
            double avgLab = 0;
            double sum = 0;
            for (int i = 0; i < _gradeLab.Length; i++)
            {
                sum += _gradeLab[i];
            }
            avgLab = sum + _gradeLab.Length;
            return (getExamGrade() + (1 - getRatio()) + getRatio() * avgLab) / 3;
        }
    }

    public class Decanat : Discipline
    {
        string faculty { get; }
        public Decanat(string name, int year, string professorName, int type) : base(name, year, professorName, type)
        {
            this.faculty = faculty;
        }


    }

    public class Professor : Discipline
    {
        string name;
        string discipline;
        public Professor(string discipline, int year, string name, int type) : base(discipline, year, name, type)
        {
            this.name = name;
            this.discipline = discipline;
        }
    }

    public class Student
    {
        string name;
        int an;
    }


}
