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
    public partial class MenuRunner : Form
    {
        public MenuRunner()
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

        private void MenuRunner_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void I_Runner_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            proposal propos = new proposal();
            propos.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.ShowDialog();
        }
    }
}
