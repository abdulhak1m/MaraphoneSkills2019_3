using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaraphoneSkills_2019_3
{
    public partial class proposal : Form
    {
        public string email;
        public int value;
        public proposal()
        {
            InitializeComponent();
            LocationForm();
            close.Click += (s, e) => { Close(); };
        }
        private void LocationForm()
        {
            int move = 0, X = 0, Y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; X = e.X; Y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;
            lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона!";
        }

        private void proposal_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MenuRunner menu = new MenuRunner();
            menu.ShowDialog();
            Close();
        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                value = Convert.ToInt32(lbl_Summ.Text);
                value += 145;
                lbl_Summ.Text = value.ToString();
            }
            else
                lbl_Summ.Text = (value - 145).ToString();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                value = Convert.ToInt32(lbl_Summ.Text);
                value += 75;
                lbl_Summ.Text = value.ToString();
            }
            else
                lbl_Summ.Text = (value - 75).ToString();
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                value = Convert.ToInt32(lbl_Summ.Text);
                value += 20;
                lbl_Summ.Text = value.ToString();
            }
            else
                lbl_Summ.Text = (value - 20).ToString();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton1.Checked)
                {
                    value = int.Parse(lbl_Summ.Text);
                    value += 0;
                    lbl_Summ.Text = value.ToString();
                }
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                value = int.Parse(lbl_Summ.Text);
                value += 20;
                lbl_Summ.Text = value.ToString();
            }
            else
                lbl_Summ.Text = (value - 20).ToString();
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                value = int.Parse(lbl_Summ.Text);
                value += 45;
                lbl_Summ.Text = value.ToString();
            }
            else
                lbl_Summ.Text = (value - 45).ToString();
        }
        private async void btn_done_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmb_vz.Text) && !string.IsNullOrEmpty(lbl_Summ.Text))
            {
                if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked &&
                   !radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
                {
                    MessageBox.Show("Пожалуйста, выберите Вид Марафона и Варинат Комлекта.", "Уведолмение системы!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Connection.GetString()))
                        {
                            await connection.OpenAsync();
                            string query = $"INSERT INTO RunnerProposal ([Contribution], [Amount]) VALUES ('{cmb_vz.Text}', '{int.Parse(lbl_Summ.Text)}')";
                            SqlCommand command = new SqlCommand(query, connection);
                            await command.ExecuteNonQueryAsync();
                            pnl_done.BringToFront();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите Вид Марафона и Варинат Комлекта.", "Уведолмение системы!",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MenuRunner menuRunner = new MenuRunner();
            menuRunner.ShowDialog();
            Close();
        }
    }
}
