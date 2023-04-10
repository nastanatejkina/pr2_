using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace pr2_
{
    public partial class Form1 : Form
    {
        private DB _Semestr;
        public Form1()
        {
            InitializeComponent();
            _Semestr = new DB();
            _Semestr.Initialize();

            SemestrGrid.DataSource = _Semestr.Semestrs.ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            SemestrGrid.DataSource = _Semestr.Semestrs.ToList();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SemestrGrid.DataSource = _Semestr.Semestrs.Where(u => u.ИмяСтуденца.ToLower().Contains(textBox1.Text.ToLower())).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    SemestrGrid.DataSource = _Semestr.Semestrs.Where(u => u.Аттестация == Attestacia.Незачет).ToList();
                    break;
                case 1:
                    SemestrGrid.DataSource = _Semestr.Semestrs.Where(u => u.Аттестация == Attestacia.Зачет).ToList();
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SemestrGrid.DataSource = _Semestr.Semestrs.OrderBy(u => u.СчетРабот).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f3 = new Form2();

            f3.Show();
            button1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
        }
    }
}
