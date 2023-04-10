using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_
{
    public enum Удовлетворенность
    {
        Удовлетворительно,
        Хорошо,
        Отлично
    }
    internal class Успеваемость
    {

        private Удовлетворенность _Удовлетворенность = Удовлетворенность.Отлично;
        private Student _Student;


        public Удовлетворенность Удовлетворенность
        {
            get => _Удовлетворенность;
        }

        private Student Student
        {
            get => _Student;
        }


        public string ИмяСтуденца
        {
            get { return Student != null ? Student.Name : "Не назначено"; }
        }


        public Успеваемость(Удовлетворенность Удовлетворенность, Student Student)
        {

            _Удовлетворенность = Удовлетворенность;
            _Student = Student;

        }
    }
}

