namespace MaraphoneSkills_2019_3
{
    partial class StartPosition
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPosition));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.pnl_Timer = new System.Windows.Forms.Panel();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_main = new System.Windows.Forms.Panel();
            this.About = new System.Windows.Forms.Button();
            this.I_sponsor = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.I_Runner = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.pnl_Timer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topPanel.Controls.Add(this.close);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(863, 25);
            this.topPanel.TabIndex = 0;
            // 
            // pnl_Timer
            // 
            this.pnl_Timer.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_Timer.Controls.Add(this.lbl_Timer);
            this.pnl_Timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Timer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnl_Timer.ForeColor = System.Drawing.Color.White;
            this.pnl_Timer.Location = new System.Drawing.Point(0, 447);
            this.pnl_Timer.Name = "pnl_Timer";
            this.pnl_Timer.Size = new System.Drawing.Size(863, 44);
            this.pnl_Timer.TabIndex = 2;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Timer.Location = new System.Drawing.Point(0, 0);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(863, 44);
            this.lbl_Timer.TabIndex = 0;
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 100);
            this.panel1.TabIndex = 3;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Info.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Info.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Info.Location = new System.Drawing.Point(283, 34);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(296, 32);
            this.lbl_Info.TabIndex = 0;
            this.lbl_Info.Text = "MaraphoneSkills 2019";
            this.lbl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.About);
            this.pnl_main.Controls.Add(this.I_sponsor);
            this.pnl_main.Controls.Add(this.btn_Login);
            this.pnl_main.Controls.Add(this.I_Runner);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 125);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(863, 322);
            this.pnl_main.TabIndex = 4;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.RoyalBlue;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Location = new System.Drawing.Point(242, 208);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(378, 67);
            this.About.TabIndex = 2;
            this.About.Text = "Я хочу узнать больше о событии";
            this.About.UseVisualStyleBackColor = false;
            // 
            // I_sponsor
            // 
            this.I_sponsor.BackColor = System.Drawing.Color.RoyalBlue;
            this.I_sponsor.FlatAppearance.BorderSize = 0;
            this.I_sponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.I_sponsor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.I_sponsor.ForeColor = System.Drawing.Color.White;
            this.I_sponsor.Location = new System.Drawing.Point(242, 124);
            this.I_sponsor.Name = "I_sponsor";
            this.I_sponsor.Size = new System.Drawing.Size(378, 67);
            this.I_sponsor.TabIndex = 2;
            this.I_sponsor.Text = "Я хочу стать спонсором";
            this.I_sponsor.UseVisualStyleBackColor = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(762, 272);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(89, 44);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Войти";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // I_Runner
            // 
            this.I_Runner.BackColor = System.Drawing.Color.RoyalBlue;
            this.I_Runner.FlatAppearance.BorderSize = 0;
            this.I_Runner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.I_Runner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.I_Runner.ForeColor = System.Drawing.Color.White;
            this.I_Runner.Location = new System.Drawing.Point(242, 40);
            this.I_Runner.Name = "I_Runner";
            this.I_Runner.Size = new System.Drawing.Size(378, 67);
            this.I_Runner.TabIndex = 2;
            this.I_Runner.Text = "Я хочу стать бегуном";
            this.I_Runner.UseVisualStyleBackColor = false;
            this.I_Runner.Click += new System.EventHandler(this.I_Runner_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::MaraphoneSkills_2019_3.Properties.Resources.icons8_shutdown_16;
            this.close.Location = new System.Drawing.Point(838, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = false;
            // 
            // StartPosition
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 491);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Timer);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartPosition_Load);
            this.topPanel.ResumeLayout(false);
            this.pnl_Timer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel pnl_Timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button I_Runner;
        private System.Windows.Forms.Button I_sponsor;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button btn_Login;
    }
}

