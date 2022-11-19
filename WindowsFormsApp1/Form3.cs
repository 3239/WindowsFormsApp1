using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public SQLiteConnection SQLiteConn;
        public Form3()
        {
            InitializeComponent();
            queshon();
        }

        public void queshon()
        {
            string baseName = @"D:\\Program Files\\DB Browser for SQLite\\тест по психологии.db";
            SQLiteConn = new SQLiteConnection();

            SQLiteConn.ConnectionString = "Data Source = " + baseName;
            SQLiteCommand command = new SQLiteCommand("select вопросы from тест", SQLiteConn);
            SQLiteConn.Open();
            SQLiteDataReader reade = command.ExecuteReader();
            SQLiteDataReader reader = reade;
            
            while (reader.Read())
            {
                comboBox1.Items.Add((string)reader["вопросы"]);
            }
        }

        public void zamena()
        {
            SQLiteCommand command = SQLiteConn.CreateCommand();
            string name = $"update тест set[вопрос] = '{textBox9.Text.ToString()}' where вопросы = '{comboBox1.SelectedItem.ToString()}'";
            command.CommandText = name;
            command.ExecuteNonQuery();
        }

        public void zamena1()
        {
            SQLiteCommand command = SQLiteConn.CreateCommand();
            string name = $"update тест set[ответ1] = '{textBox1.Text.ToString()}' where вопросы = '{comboBox1.SelectedItem.ToString()}'";
            command.CommandText = name;
            command.ExecuteNonQuery();
        }

        public void zamena2()
        {
            SQLiteCommand command = SQLiteConn.CreateCommand();
            string name = $"update тест set[ответ2] = '{textBox8.Text.ToString()}' where вопросы = '{comboBox1.SelectedItem.ToString()}'";
            command.CommandText = name;
            command.ExecuteNonQuery();
        }

        public void zamena3()
        {
            SQLiteCommand command = SQLiteConn.CreateCommand();
            string name = $"update тест set[ответ3] = '{textBox7.Text.ToString()}' where вопросы = '{comboBox1.SelectedItem.ToString()}'";
            command.CommandText = name;
            command.ExecuteNonQuery();
        }

        public void zamena4()
        {
            SQLiteCommand command = SQLiteConn.CreateCommand();
            string name = $"update тест set[ответ4] = '{textBox6.Text.ToString()}' where вопросы = '{comboBox1.SelectedItem.ToString()}'";
            command.CommandText = name;
            command.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Выберете вопрос на замену!");
            }
            else
            {
                if (textBox6.Text == "" || textBox7.Text == "" || textBox1.Text == "" || textBox9.Text == "" || textBox8.Text == "")
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    zamena();
                    zamena1();
                    zamena2();
                    zamena3();
                    zamena4();
                }
            }
        }
    }
}
