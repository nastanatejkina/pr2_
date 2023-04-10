using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_
{
    class Student
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public Student(string name)
        {
            _name = name;
        }
    }
}
