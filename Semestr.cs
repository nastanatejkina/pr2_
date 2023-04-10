using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_
{
    public enum Attestacia
    {
        Зачет,
        Незачет
    }
    internal class Semestr
    {
        private double _score = 1 - 10;
        private Attestacia _Attestacia = Attestacia.Зачет;
        private Student _Student;
        private Group _Group;

        public double СчетРабот
        {
            set { _score = value; }
            get => _score;
        }
        public Attestacia Аттестация
        {
            get => _Attestacia;
        }

        private Student Student
        {
            get => _Student;
        }

        private Group Group
        {
            get => _Group;
        }
        public string ИмяСтуденца
        {
            get { return Student != null ? Student.Name : "Не назначено"; }
        }

        public string ГруппаСтуденцов
        {
            get { return Group != null ? Group.Name : "Не назначено"; }
        }
        public Semestr(double score, Attestacia attestacia, Student student, Group Group)
        {
            _score = score;
            _Attestacia = attestacia;
            _Student = student;
            _Group = Group;
        }
    }
}
