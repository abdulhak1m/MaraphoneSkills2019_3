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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LocationForm();
            PasswordBox();
            close.Click += (s, e) => { Close(); };

            txt_Email.Text = "Введите Email!";
            txt_Email.ForeColor = Color.SteelBlue;

            txt_Password.Text = "Введите Пароль!";
            txt_Password.UseSystemPasswordChar = false;
            txt_Password.ForeColor = Color.SteelBlue;
        }

        // приватный ввод пароля
        private void PasswordBox()
        {
            txt_Password.TextChanged += (s, e) => { txt_Password.UseSystemPasswordChar = true; };
            btn_Show.MouseDown += (s, e) => { txt_Password.UseSystemPasswordChar = false; };
            btn_Show.MouseUp += (s, e) => 
            { 
                if(txt_Password.Text == "Введите Пароль!")
                    txt_Password.UseSystemPasswordChar = false;
                else
                    txt_Password.UseSystemPasswordChar = true; 
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

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void txt_Email_Enter(object sender, EventArgs e)
        {
            if(txt_Email.Text == "Введите Email!")
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
            if(txt_Password.Text == "Введите Пароль!")
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите покинуть окно Авторизации?", "Уведомление системы!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                ActiveForm.Hide();
                StartPosition start = new StartPosition();
                start.ShowDialog();
                Close();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                btn_Login.PerformClick();
        }
    }
}
