using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

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
        private bool Check()
        {
            if (txt_Password.Text != "Введите Пароль!" || txt_Password.Text != "" &&
                txt_ConfirmPassword.Text != "Подтвердите Пароль!" || txt_ConfirmPassword.Text == "")
            {
                if (txt_ConfirmPassword.Text != txt_Password.Text)
                {
                    lbl_Error.Text = "Внимание, пароли не совпадают!";
                    return false;
                }
                else
                {
                    lbl_Error.Text = "";
                    return true;
                }
            }
            else
                return false;
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
        OpenFileDialog file = new OpenFileDialog();
        // метод выбора изображения
        private void Open()
        {
            file.InitialDirectory = @"C:\Users\magom\Pictures";
            file.Filter = "Image Files (*.BMP; *.PNG;*.JPG;*.GIF)|*.BMP;*.PNG;*.JPG;*.GIF| All Files (*.*)|*.*";
            file.FilterIndex = 2;
            if(file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                lbl_PictureName.Text = file.SafeFileName.ToString();
            }
        }
        private async void btn_done_Click(object sender, EventArgs e)
        {
            if (!Check())
                return;
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();

                if (txt_Email.Text == "Введите Email!" && txt_Password.Text == "Введите Пароль!" &&
                    txt_Name.Text == "Введите Имя!" && txt_Surname.Text == "Введите Фамилию!" &&
                    cmb_Sex.SelectedIndex == 0 && cmb_County.SelectedIndex == 0)
                {
                    MessageBox.Show("Чтобы зарегистрироваться в системе, необходимо" +
                        " заполнить все поля, пожалуйста заполните" +
                        " поля надлежащим образом и повторите попытку регистрации!",
                        "Заполните поля!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    Regex emailRegex = new Regex(@"\w{2,10}@\w{2,10}.\w{2,10}");
                    Match emailMatch = emailRegex.Match(txt_Email.Text);
                    if (emailMatch.Value == "")
                        MessageBox.Show("Некорректный формат Email!",
                            "Увдомление системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        bool digit = false;
                        bool lowChar = false;
                        bool spec = false;

                        for (int i = 0; i < txt_Password.TextLength; i++)
                        {
                            if (char.IsDigit(txt_Password.Text[i]))
                            {
                                digit = true;
                                break;
                            }
                        }
                        for(int i = 0; i < txt_Password.TextLength; i++)
                        {
                            if (char.IsLower(txt_Password.Text[i]))
                            {
                                lowChar = true;
                                break;
                            }
                        }
                        for(int i = 0; i < txt_Password.TextLength; i++)
                        {
                            if(txt_Password.Text[i] == '#' || txt_Password.Text[i] == '$' ||
                               txt_Password.Text[i] == '%' || txt_Password.Text[i] == '^' || 
                               txt_Password.Text[i] == '!' || txt_Password.Text[i] == '@')
                            {
                                spec = true;
                                break;
                            }
                        }
                        if(txt_Password.TextLength < 6 || !spec || !digit || !lowChar)
                            MessageBox.Show("Некорректный формат пароля! Длина пароля " +
                                "должно быть не менее 6-ти символов, из которых " +
                                "должна быть, как минимум одна буква нижнего регистра одна цифра" +
                                " и одна из следующих символов #,$,%,^,!,@");
                        DateTime dateOfBirh = Convert.ToDateTime(dateTimePicker1.Value);
                        if (DateTime.Now.Year - dateOfBirh.Year < 10)
                        {
                            MessageBox.Show("Внимание! На момент регистрации Бегуна," +
                                " его возраст должен составлять не менее 10-ти лет.",
                                "Уведомление системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            using (SqlConnection sql = new SqlConnection(Connection.GetString()))
                            {
                                await sql.OpenAsync();
                                string query = "INSERT INTO Runner VALUES (@email, @password, @name, @surname, @sex, @img_name, @img, @country)";
                                SqlCommand command = new SqlCommand(query, sql);
                                command.Parameters.AddWithValue("@email", txt_Email.Text);
                                command.Parameters.AddWithValue("@password", txt_Password.Text);
                                command.Parameters.AddWithValue("@name", txt_Name.Text);
                                command.Parameters.AddWithValue("@surname", txt_Surname.Text);
                                command.Parameters.AddWithValue("@sex", cmb_Sex.Text);
                                command.Parameters.AddWithValue("@img_name", lbl_PictureName.Text);
                                command.Parameters.AddWithValue("@img", a);
                                command.Parameters.AddWithValue("@country", cmb_County.Text);
                                await command.ExecuteNonQueryAsync();
                                MessageBox.Show("Вы успешно зарегистрировались в системе!", "Уведомление системы!",
                                    MessageBoxButtons.OK ,MessageBoxIcon.Information);
                                ActiveForm.Hide();
                                proposal prop = new proposal();
                                prop.ShowDialog();
                                Close();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Уведомления системы!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
             Open();
        }
    }
}
