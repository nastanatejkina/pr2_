using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr2_
{
    public partial class Form2 : Form
    {
        private DB _Предмет;
        public Form2()
        {
            InitializeComponent();
            _Предмет = new DB();
            _Предмет.Initialize();

            Предмет.DataSource = _Предмет.УспеваемостьЕ.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
