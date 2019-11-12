using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaraphoneSkills_2019_3
{
    public partial class New_Runner : Form
    {
        public New_Runner()
        {
            InitializeComponent();
            LocationForm();
            close.Click += (s, e) => { Close(); };
            PasswordBox(txt_Password, btn_Show);
            PasswordBox(txt_ConfirmPassword, btn_show0);

            txt_Email.Text = "Введите Email!";
            txt_Email.ForeColor = Color.SteelBlue;

            txt_Password.Text = "Введите Пароль!";
            txt_Password.UseSystemPasswordChar = false;
            txt_Password.ForeColor = Color.SteelBlue;


            txt_ConfirmPassword.Text = "Подтвердите Пароль!";
            txt_ConfirmPassword.UseSystemPasswordChar = false;
            txt_ConfirmPassword.ForeColor = Color.SteelBlue;

            txt_Name.Text = "Введите Имя!";
            txt_Name.ForeColor = Color.SteelBlue;

            txt_Surname.Text = "Введите Фамилию!";
            txt_Surname.ForeColor = Color.SteelBlue;

            cmb_Sex.SelectedIndex = 0;
            cmb_County.SelectedIndex = 0;

        }
        private void PasswordBox(TextBox text, Button btn)
        {
            text.TextChanged += (s, e) => { text.UseSystemPasswordChar = true; };
            btn.MouseDown += (s, e) => { text.UseSystemPasswordChar = false; };
            btn.MouseUp += (s, e) =>
            {
                if (text.Text == "Введите Пароль!" || text.Text == "Подтвердите Пароль!")
                    text.UseSystemPasswordChar = false;
                else
                    text.UseSystemPasswordChar = true;
            };
        }
        // передвижение формы
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

        private void New_Runner_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void txt_Email_Enter(object sender, EventArgs e)
        {
            if (txt_Email.Text == "Введите Email!")
            {
                txt_Email.Text = "";
                txt_Email.ForeColor = Color.Black;
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if(txt_Email.Text == "")
            {
                txt_Email.Text = "Введите Email!";
                txt_Email.ForeColor = Color.SteelBlue;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Введите Пароль!")
            {
                txt_Password.Text = "";
                txt_Password.UseSystemPasswordChar = false;
                txt_Password.ForeColor = Color.Black;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if(txt_Password.Text == "")
            {
                txt_Password.Text = "Введите Пароль!";
                txt_Password.UseSystemPasswordChar = false;
                txt_Password.ForeColor = Color.SteelBlue;
            }
        }

        private void txt_ConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txt_ConfirmPassword.Text == "Подтвердите Пароль!")
            {
                txt_ConfirmPassword.Text = "";
                txt_ConfirmPassword.UseSystemPasswordChar = false;
                txt_ConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void txt_ConfirmPassword_Leave(object sender, EventArgs e)
        {
            if(txt_ConfirmPassword.Text == "")
            {
                txt_ConfirmPassword.Text = "Подтвердите Пароль!";
                txt_ConfirmPassword.UseSystemPasswordChar = false;
                txt_ConfirmPassword.ForeColor = Color.SteelBlue;
            }
        }

        private void txt_Name_Enter(object sender, EventArgs e)
        {
            if (txt_Name.Text == "Введите Имя!")
            {
                txt_Name.Text = "";
                txt_Name.ForeColor = Color.Black;
            }
        }

        private void txt_Name_Leave(object sender, EventArgs e)
        {
            if(txt_Name.Text == "")
            {
                txt_Name.Text = "Введите Имя!";
                txt_Name.ForeColor = Color.SteelBlue;
            }
        }

        private void txt_Surname_Enter(object sender, EventArgs e)
        {
            if(txt_Surname.Text == "Введите Фамилию!")
            {
                txt_Surname.Text = "";
                txt_Surname.ForeColor = Color.Black;
            }
        }

        private void txt_Surname_Leave(object sender, EventArgs e)
        {
            if(txt_Surname.Text == "")
            {
                txt_Surname.Text = "Введите Фамилию!";
                txt_Surname.ForeColor = Color.SteelBlue;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите покинуть окно Регистрации?", "Уведомление системы!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                ActiveForm.Hide();
                StartPosition start = new StartPosition();
                start.ShowDialog();
                Close();
            }
        }
    }
}
