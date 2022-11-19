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
    public partial class Form2 : Form
    {
        public SQLiteConnection SQLiteConn;
        int s = 0;
        public Form2()
        {
            InitializeComponent();
            tabPage2.Parent = null;
            tabPage3.Parent = null;
            tabPage4.Parent = null;
            tabPage5.Parent = null;
            tabPage6.Parent = null;
            tabPage7.Parent = null;
            tabPage8.Parent = null;
            tabPage9.Parent = null;
            tabPage10.Parent = null;
            tabPage11.Parent = null;
            Sql();
            
        }

        public void Sql()
        {
            string baseName = @"D:\\Program Files\\DB Browser for SQLite\\тест по психологии.db";
            SQLiteConn = new SQLiteConnection();

            string connectionString = "Data Source =" + baseName;

            string sqlExpression = "SELECT вопрос FROM тест WHERE id= 1.0";
            string sqlExpression1 = "SELECT вопрос FROM тест WHERE id= 2.0";
            string sqlExpression2 = "SELECT вопрос FROM тест WHERE id= 3.0";
            string sqlExpression3 = "SELECT вопрос FROM тест WHERE id= 4.0";
            string sqlExpression4 = "SELECT вопрос FROM тест WHERE id= 5.0";
            string sqlExpression5 = "SELECT вопрос FROM тест WHERE id= 6.0";
            string sqlExpression6 = "SELECT вопрос FROM тест WHERE id= 7.0";
            string sqlExpression7 = "SELECT вопрос FROM тест WHERE id= 8.0";
            string sqlExpression8 = "SELECT вопрос FROM тест WHERE id= 9.0";
            string sqlExpression9 = "SELECT вопрос FROM тест WHERE id= 10.0";

            string sqlExpression10 = "SELECT ответ1 FROM тест WHERE  id= 1.0";
            string sqlExpression11 = "SELECT ответ1 FROM тест WHERE  id= 2.0";
            string sqlExpression12 = "SELECT ответ1 FROM тест WHERE  id= 3.0";
            string sqlExpression13 = "SELECT ответ1 FROM тест WHERE  id= 4.0";
            string sqlExpression14 = "SELECT ответ1 FROM тест WHERE  id= 5.0";
            string sqlExpression15 = "SELECT ответ1 FROM тест WHERE  id= 6.0";
            string sqlExpression16 = "SELECT ответ1 FROM тест WHERE  id= 7.0";
            string sqlExpression17 = "SELECT ответ1 FROM тест WHERE  id= 8.0";
            string sqlExpression18 = "SELECT ответ1 FROM тест WHERE  id= 9.0";
            string sqlExpression19 = "SELECT ответ1 FROM тест WHERE  id= 10.0";

            string sqlExpression20 = "SELECT ответ2 FROM тест WHERE  id= 1.0";
            string sqlExpression21 = "SELECT ответ2 FROM тест WHERE  id= 2.0";
            string sqlExpression22 = "SELECT ответ2 FROM тест WHERE  id= 3.0";
            string sqlExpression23 = "SELECT ответ2 FROM тест WHERE  id= 4.0";
            string sqlExpression24 = "SELECT ответ2 FROM тест WHERE  id= 5.0";
            string sqlExpression25 = "SELECT ответ2 FROM тест WHERE  id= 6.0";
            string sqlExpression26 = "SELECT ответ2 FROM тест WHERE  id= 7.0";
            string sqlExpression27 = "SELECT ответ2 FROM тест WHERE  id= 8.0";
            string sqlExpression28 = "SELECT ответ2 FROM тест WHERE  id= 9.0";
            string sqlExpression29 = "SELECT ответ2 FROM тест WHERE  id= 10.0";

            string sqlExpression30 = "SELECT ответ3 FROM тест WHERE  id= 1.0";
            string sqlExpression31 = "SELECT ответ3 FROM тест WHERE  id= 2.0";
            string sqlExpression32 = "SELECT ответ3 FROM тест WHERE  id= 3.0";
            string sqlExpression33 = "SELECT ответ3 FROM тест WHERE  id= 4.0";
            string sqlExpression34 = "SELECT ответ3 FROM тест WHERE  id= 5.0";
            string sqlExpression35 = "SELECT ответ3 FROM тест WHERE  id= 6.0";
            string sqlExpression36 = "SELECT ответ3 FROM тест WHERE  id= 7.0";
            string sqlExpression37 = "SELECT ответ3 FROM тест WHERE  id= 8.0";
            string sqlExpression38 = "SELECT ответ3 FROM тест WHERE  id= 9.0";
            string sqlExpression39 = "SELECT ответ3 FROM тест WHERE  id= 10.0";

            string sqlExpression40 = "SELECT ответ4 FROM тест WHERE  id= 1.0";
            string sqlExpression41 = "SELECT ответ4 FROM тест WHERE  id= 2.0";
            string sqlExpression42 = "SELECT ответ4 FROM тест WHERE  id= 3.0";
            string sqlExpression43 = "SELECT ответ4 FROM тест WHERE  id= 4.0";
            string sqlExpression44 = "SELECT ответ4 FROM тест WHERE  id= 5.0";
            string sqlExpression45 = "SELECT ответ4 FROM тест WHERE  id= 6.0";
            string sqlExpression46 = "SELECT ответ4 FROM тест WHERE  id= 7.0";
            string sqlExpression47 = "SELECT ответ4 FROM тест WHERE  id= 8.0";
            string sqlExpression48 = "SELECT ответ4 FROM тест WHERE  id= 9.0";
            string sqlExpression49 = "SELECT ответ4 FROM тест WHERE  id= 10.0";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
                SQLiteCommand command1 = new SQLiteCommand(sqlExpression1, connection);
                SQLiteCommand command2 = new SQLiteCommand(sqlExpression2, connection);
                SQLiteCommand command3 = new SQLiteCommand(sqlExpression3, connection);
                SQLiteCommand command4 = new SQLiteCommand(sqlExpression4, connection);
                SQLiteCommand command5 = new SQLiteCommand(sqlExpression5, connection);
                SQLiteCommand command6 = new SQLiteCommand(sqlExpression6, connection);
                SQLiteCommand command7 = new SQLiteCommand(sqlExpression7, connection);
                SQLiteCommand command8 = new SQLiteCommand(sqlExpression8, connection);
                SQLiteCommand command9 = new SQLiteCommand(sqlExpression9, connection);

                SQLiteCommand command10 = new SQLiteCommand(sqlExpression10, connection);
                SQLiteCommand command11 = new SQLiteCommand(sqlExpression11, connection);
                SQLiteCommand command12 = new SQLiteCommand(sqlExpression12, connection);
                SQLiteCommand command13 = new SQLiteCommand(sqlExpression13, connection);
                SQLiteCommand command14 = new SQLiteCommand(sqlExpression14, connection);
                SQLiteCommand command15 = new SQLiteCommand(sqlExpression15, connection);
                SQLiteCommand command16 = new SQLiteCommand(sqlExpression16, connection);
                SQLiteCommand command17 = new SQLiteCommand(sqlExpression17, connection);
                SQLiteCommand command18 = new SQLiteCommand(sqlExpression18, connection);
                SQLiteCommand command19 = new SQLiteCommand(sqlExpression19, connection);

                SQLiteCommand command20 = new SQLiteCommand(sqlExpression20, connection);
                SQLiteCommand command21 = new SQLiteCommand(sqlExpression21, connection);
                SQLiteCommand command22 = new SQLiteCommand(sqlExpression22, connection);
                SQLiteCommand command23 = new SQLiteCommand(sqlExpression23, connection);
                SQLiteCommand command24 = new SQLiteCommand(sqlExpression24, connection);
                SQLiteCommand command25 = new SQLiteCommand(sqlExpression25, connection);
                SQLiteCommand command26 = new SQLiteCommand(sqlExpression26, connection);
                SQLiteCommand command27 = new SQLiteCommand(sqlExpression27, connection);
                SQLiteCommand command28 = new SQLiteCommand(sqlExpression28, connection);
                SQLiteCommand command29 = new SQLiteCommand(sqlExpression29, connection);

                SQLiteCommand command30 = new SQLiteCommand(sqlExpression30, connection);
                SQLiteCommand command31 = new SQLiteCommand(sqlExpression31, connection);
                SQLiteCommand command32 = new SQLiteCommand(sqlExpression32, connection);
                SQLiteCommand command33 = new SQLiteCommand(sqlExpression33, connection);
                SQLiteCommand command34 = new SQLiteCommand(sqlExpression34, connection);
                SQLiteCommand command35 = new SQLiteCommand(sqlExpression35, connection);
                SQLiteCommand command36 = new SQLiteCommand(sqlExpression36, connection);
                SQLiteCommand command37 = new SQLiteCommand(sqlExpression37, connection);
                SQLiteCommand command38 = new SQLiteCommand(sqlExpression38, connection);
                SQLiteCommand command39 = new SQLiteCommand(sqlExpression39, connection);

                SQLiteCommand command40 = new SQLiteCommand(sqlExpression40, connection);
                SQLiteCommand command41 = new SQLiteCommand(sqlExpression41, connection);
                SQLiteCommand command42 = new SQLiteCommand(sqlExpression42, connection);
                SQLiteCommand command43 = new SQLiteCommand(sqlExpression43, connection);
                SQLiteCommand command44 = new SQLiteCommand(sqlExpression44, connection);
                SQLiteCommand command45 = new SQLiteCommand(sqlExpression45, connection);
                SQLiteCommand command46 = new SQLiteCommand(sqlExpression46, connection);
                SQLiteCommand command47 = new SQLiteCommand(sqlExpression47, connection);
                SQLiteCommand command48 = new SQLiteCommand(sqlExpression48, connection);
                SQLiteCommand command49 = new SQLiteCommand(sqlExpression49, connection);

                string name = command.ExecuteScalar().ToString();
                string name1 = command1.ExecuteScalar().ToString();
                string name2 = command2.ExecuteScalar().ToString();
                string name3 = command3.ExecuteScalar().ToString();
                string name4 = command4.ExecuteScalar().ToString();
                string name5 = command5.ExecuteScalar().ToString();
                string name6 = command6.ExecuteScalar().ToString();
                string name7 = command7.ExecuteScalar().ToString();
                string name8 = command8.ExecuteScalar().ToString();
                string name9 = command9.ExecuteScalar().ToString();

                string name10 = command10.ExecuteScalar().ToString();
                string name11 = command11.ExecuteScalar().ToString();
                string name12 = command12.ExecuteScalar().ToString();
                string name13 = command13.ExecuteScalar().ToString();
                string name14 = command14.ExecuteScalar().ToString();
                string name15 = command15.ExecuteScalar().ToString();
                string name16 = command16.ExecuteScalar().ToString();
                string name17 = command17.ExecuteScalar().ToString();
                string name18 = command18.ExecuteScalar().ToString();
                string name19 = command19.ExecuteScalar().ToString();

                string name20 = command20.ExecuteScalar().ToString();
                string name21 = command21.ExecuteScalar().ToString();
                string name22 = command22.ExecuteScalar().ToString();
                string name23 = command23.ExecuteScalar().ToString();
                string name24 = command24.ExecuteScalar().ToString();
                string name25 = command25.ExecuteScalar().ToString();
                string name26 = command26.ExecuteScalar().ToString();
                string name27 = command27.ExecuteScalar().ToString();
                string name28 = command28.ExecuteScalar().ToString();
                string name29 = command29.ExecuteScalar().ToString();

                string name30 = command30.ExecuteScalar().ToString();
                string name31 = command31.ExecuteScalar().ToString();
                string name32 = command32.ExecuteScalar().ToString();
                string name33 = command33.ExecuteScalar().ToString();
                string name34 = command34.ExecuteScalar().ToString();
                string name35 = command35.ExecuteScalar().ToString();
                string name36 = command36.ExecuteScalar().ToString();
                string name37 = command37.ExecuteScalar().ToString();
                string name38 = command38.ExecuteScalar().ToString();
                string name39 = command39.ExecuteScalar().ToString();

                string name40 = command40.ExecuteScalar().ToString();
                string name41 = command41.ExecuteScalar().ToString();
                string name42 = command42.ExecuteScalar().ToString();
                string name43 = command43.ExecuteScalar().ToString();
                string name44 = command44.ExecuteScalar().ToString();
                string name45 = command45.ExecuteScalar().ToString();
                string name46 = command46.ExecuteScalar().ToString();
                string name47 = command47.ExecuteScalar().ToString();
                string name48 = command48.ExecuteScalar().ToString();
                string name49 = command49.ExecuteScalar().ToString();

                label2.Text = name;
                label3.Text = name1;
                label4.Text = name2;
                label5.Text = name3;
                label6.Text = name4;
                label7.Text = name5;
                label8.Text = name6;
                label9.Text = name7;
                label10.Text = name8;
                label11.Text = name9;

                radioButton2.Text = name10;
                radioButton3.Text = name20;
                radioButton4.Text = name30;
                radioButton5.Text = name40;

                radioButton6.Text = name11;
                radioButton7.Text = name21;
                radioButton8.Text = name31;
                radioButton9.Text = name41;

                radioButton10.Text = name12;
                radioButton11.Text = name22;
                radioButton12.Text = name32;
                radioButton1.Text = name42;

                radioButton13.Text = name13;
                radioButton14.Text = name23;
                radioButton15.Text = name33;
                radioButton16.Text = name43;

                radioButton17.Text = name14;
                radioButton18.Text = name24;
                radioButton19.Text = name34;
                radioButton20.Text = name44;

                radioButton21.Text = name15;
                radioButton22.Text = name25;
                radioButton23.Text = name35;
                radioButton24.Text = name45;

                radioButton25.Text = name16;
                radioButton26.Text = name26;
                radioButton27.Text = name36;
                radioButton28.Text = name46;

                radioButton29.Text = name17;
                radioButton30.Text = name27;
                radioButton31.Text = name37;
                radioButton32.Text = name47;

                radioButton33.Text = name18;
                radioButton34.Text = name28;
                radioButton35.Text = name38;
                radioButton36.Text = name48;

                radioButton37.Text = name19;
                radioButton38.Text = name29;
                radioButton39.Text = name39;
                radioButton40.Text = name49;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!radioButton6.Checked && !radioButton7.Checked && !radioButton8.Checked && !radioButton9.Checked)
            {
                MessageBox.Show("Выберете ответ!");
            }
            else
            {
                tabPage3.Parent = tabControl1;
                this.tabControl1.SelectedIndex = 2;
            }
            if (radioButton7.Checked)
            {
                s = s + 1;
            }

            if (radioButton8.Checked)
            {
                s = s + 2;
            }

            if (radioButton9.Checked)
            {
                s = s + 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked)
            {
                MessageBox.Show("Выберете ответ!");
            }
            else
            {
                tabPage2.Parent = tabControl1;
                this.tabControl1.SelectedIndex = 1;
            }
            
            if (radioButton3.Checked)
            {
                s = s + 1;
            }

            if (radioButton4.Checked)
            {
                s = s + 2;
            }

            if (radioButton5.Checked)
            {
                s = s + 3;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!radioButton10.Checked && !radioButton11.Checked && !radioButton12.Checked && !radioButton1.Checked)
            {
                MessageBox.Show("Выберете ответ!");
            }
            else
            {
                tabPage4.Parent = tabControl1;
                this.tabControl1.SelectedIndex = 3;
            }
            
            if (radioButton11.Checked)
            {
                s = s + 1;
            }

            if (radioButton12.Checked)
            {
                s = s + 2;
            }

            if (radioButton1.Checked)
            {
                s = s + 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!radioButton13.Checked && !radioButton14.Checked && !radioButton15.Checked && !radioButton16.Checked)
            {
                MessageBox.Show("Выберете ответ!");
            }
            else
            {
                tabPage5.Parent = tabControl1;
                this.tabControl1.SelectedIndex = 4;
            }

            if (radioButton14.Checked)
            {
                s = s + 1;
            }

            if (radioButton15.Checked)
            {
                s = s + 2;
            }

            if (radioButton16.Checked)
            {
                s = s + 3;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!radioButton17.Checked && !radioButton18.Checked && !radioButton19.Checked && !radioButton20.Checked)
            {
                MessageBox.Show("Выберете ответ!");
            }
            else
            {
                tabPage6.Parent = tabControl1;
                this.tabControl1.SelectedIndex = 5;
            }

            if (radioButton18.Checked)
            {
                s = s + 1;
            }

            if (radioButton19.Checked)
            {
                s = s + 2;
            }

            if (radioButton20.Checked)
            {
                s = s + 3;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!radioButton21.Checked && !radioButton22.Checked && !radioButton23.Checked && !radioButton24.Checked)
            {
                MessageBox.Show("Выберете ответ!");
            }
            else
            {
                tabPage7.Parent = tabControl1;
                this.tabControl1.SelectedIndex = 6;
            }
            if (radioButton22.Checked)
            {
                s = s + 1;
            }

            if (radioButton23.Checked)
            {
                s = s + 2;
            }

            if (radioButton24.Checked)
            {
                s = s + 3;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!radioButton25.Checked && !radioButton26.Checked && !radioButton27.Checked && !radioButton28.Checked)
            {
                MessageBox.Show("Выберете ответ!");
            }
            else
            {
                tabPage8.Parent = tabControl1;
                this.tabControl1.SelectedIndex = 7;
            }
            if (radioButton26.Checked)
            {
                s = s + 1;
            }

            if (radioButton27.Checked)
            {
                s = s + 2;
            }

            if (radioButton28.Checked)
            {
                s = s + 3;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!radioButton29.Checked && !radioButton30.Checked && !radioButton31.Checked && !radioButton32.Checked)
            {
                MessageBox.Show("Выберете ответ!");
            }
            else
            {
                tabPage9.Parent = tabControl1;
                this.tabControl1.SelectedIndex = 8;
            }
            if (radioButton30.Checked)
            {
                s = s + 1;
            }

            if (radioButton31.Checked)
            {
                s = s + 2;
            }

            if (radioButton32.Checked)
            {
                s = s + 3;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!radioButton33.Checked && !radioButton34.Checked && !radioButton35.Checked && !radioButton36.Checked)
            {
                MessageBox.Show("Выберете ответ!");
            }
            else
            {
                tabPage10.Parent = tabControl1;
                this.tabControl1.SelectedIndex = 9;
            }
            if (radioButton34.Checked)
            {
                s = s + 1;
            }

            if (radioButton35.Checked)
            {
                s = s + 2;
            }

            if (radioButton36.Checked)
            {
                s = s + 3;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!radioButton37.Checked && !radioButton38.Checked && !radioButton39.Checked && !radioButton40.Checked)
            {
                MessageBox.Show("Выберете ответ!");
            }
            else
            {
                tabPage11.Parent = tabControl1;
                this.tabControl1.SelectedIndex = 10;
            }
            string baseName = @"D:\\Program Files\\DB Browser for SQLite\\тест по психологии.db";
            SQLiteConn = new SQLiteConnection();

            string connectionString = "Data Source =" + baseName;

            string result = "SELECT результат FROM тест WHERE id= 1.0";
            string result1 = "SELECT результат FROM тест WHERE id= 2.0";
            string result2 = "SELECT результат FROM тест WHERE id= 3.0";
            string result3 = "SELECT результат FROM тест WHERE id= 4.0";
            string result4 = "SELECT результат FROM тест WHERE id= 5.0";
            
            if (radioButton38.Checked)
            {
                s = s + 1;
            }

            if (radioButton39.Checked)
            {
                s = s + 2;
            }

            if (radioButton40.Checked)
            {
                s = s + 3;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand res = new SQLiteCommand(result, connection);
                SQLiteCommand res1 = new SQLiteCommand(result1, connection);
                SQLiteCommand res2 = new SQLiteCommand(result2, connection);
                SQLiteCommand res3 = new SQLiteCommand(result3, connection);
                SQLiteCommand res4 = new SQLiteCommand(result4, connection);

                string re = res.ExecuteScalar().ToString();
                string re1 = res1.ExecuteScalar().ToString();
                string re2 = res2.ExecuteScalar().ToString();
                string re3 = res3.ExecuteScalar().ToString();
                string re4 = res4.ExecuteScalar().ToString();

                if (s < 5)
                {
                    label1.Text = re;
                }

                if (s > 4 && s < 11)
                {
                    label1.Text = re1;
                }

                if (s > 10 && s < 13)
                {
                    label1.Text = re2;
                }

                if (s > 12 && s < 16)
                {
                    label1.Text = re3;
                }

                if (s > 15)
                {
                    label1.Text = re4;
                }
            }
        }
    }
}
