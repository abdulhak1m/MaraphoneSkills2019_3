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
    public partial class SelectTypeRunner : Form
    {
        public SelectTypeRunner()
        {
            InitializeComponent();
            LocationForm();
            close.Click += (s, e) => { Close(); };
        }

        // передвижение формы
        private void LocationForm()
        {
            int move = 0, X = 0, Y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; X = e.X; Y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }

        private void btn_Runner_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;
            lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона!";
        }

        private void SelectTypeRunner_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            StartPosition start = new StartPosition();
            start.ShowDialog();
            Close();
        }

        private void btn_New_Runner_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            New_Runner new_Runner = new New_Runner();
            new_Runner.ShowDialog();
            Close();
        }
    }
}
