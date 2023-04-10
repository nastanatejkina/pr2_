using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_
{
    internal class DB
    {
        internal List<Semestr> Semestrs { get; private set; }
        internal List<Успеваемость> УспеваемостьЕ { get; private set; }
        public void Initialize()
        {
            Semestrs = new List<Semestr>
            {
                new Semestr (9, Attestacia.Зачет, new Student("Ангелина Волошикова"), new Group("ИС(ПРО)")),
                new Semestr(10, Attestacia.Зачет, new Student("Ира Новоселова"), new Group("ИС(ВП)")),
                new Semestr(4, Attestacia.Незачет, new Student("Алина Алинова"), new Group("ИС(АБД)")),
                new Semestr(3, Attestacia.Незачет, new Student("Даниил Даниилов"), new Group("ИС(ВП)")),
                new Semestr(4, Attestacia.Незачет, new Student("Настя Настова"), new Group("ИС(ПРО)")),
                new Semestr(6, Attestacia.Зачет, new Student("Маша Мишин"), new Group("ИС(ПРО)")),
                new Semestr(7, Attestacia.Зачет, new Student("Карина Каринова"), new Group("ИС(ПРО)")),
                new Semestr(8, Attestacia.Зачет, new Student("Дмитрий Дмитров"), new Group("ИС(АБД)")),
                new Semestr(10, Attestacia.Зачет, new Student("Артём Артемов"), new Group("ИС(ПРО)"))
            };
            УспеваемостьЕ = new List<Успеваемость>
            {
                new Успеваемость (Удовлетворенность.Отлично, new Student("Ангелина Волошикова")),
                new Успеваемость(Удовлетворенность.Отлично, new Student("Ира Новоселова")),
                new Успеваемость(Удовлетворенность.Удовлетворительно, new Student("Алина Алинова")),
                new Успеваемость(Удовлетворенность.Удовлетворительно, new Student("Даниил Даниилов")),
                new Успеваемость(Удовлетворенность.Хорошо, new Student("Настя Настова")),
                new Успеваемость(Удовлетворенность.Хорошо, new Student("Маша Мишин")),
                new Успеваемость(Удовлетворенность.Удовлетворительно, new Student("Карина Каринова")),
                new Успеваемость(Удовлетворенность.Отлично, new Student("Дмитрий Дмитров")),
                new Успеваемость(Удовлетворенность.Отлично, new Student("Артём Артемов"))
            };
        
        }
    }
}
