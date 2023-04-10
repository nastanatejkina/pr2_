using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_
{
    internal class Group
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public Group(string name)
        {
            _name = name;
        }
    }
}
