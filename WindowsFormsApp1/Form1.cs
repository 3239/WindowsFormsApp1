using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            {
                MessageBox.Show("Введите ФИО!");
            }
            else
            {
                if (textBox1.Text == "admin")
                {
                    Form3 f = new Form3();
                    f.Show();
                }
                else
                {
                    Form2 f = new Form2();
                    f.Show();
                }
            }
        }
    }
}
