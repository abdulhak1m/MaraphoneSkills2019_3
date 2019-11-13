namespace MaraphoneSkills_2019_3
{
    partial class MenuRunner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.pnl_Timer = new System.Windows.Forms.Panel();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.I_sponsor = new System.Windows.Forms.Button();
            this.I_Runner = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Timer.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topPanel.Controls.Add(this.close);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(968, 25);
            this.topPanel.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 64);
            this.panel1.TabIndex = 4;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Info.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Info.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Info.Location = new System.Drawing.Point(336, 16);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(296, 32);
            this.lbl_Info.TabIndex = 0;
            this.lbl_Info.Text = "MaraphoneSkills 2019";
            this.lbl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Timer
            // 
            this.pnl_Timer.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_Timer.Controls.Add(this.lbl_Timer);
            this.pnl_Timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Timer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnl_Timer.ForeColor = System.Drawing.Color.White;
            this.pnl_Timer.Location = new System.Drawing.Point(0, 406);
            this.pnl_Timer.Name = "pnl_Timer";
            this.pnl_Timer.Size = new System.Drawing.Size(968, 44);
            this.pnl_Timer.TabIndex = 20;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Timer.Location = new System.Drawing.Point(0, 0);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(968, 44);
            this.lbl_Timer.TabIndex = 0;
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // I_sponsor
            // 
            this.I_sponsor.BackColor = System.Drawing.Color.RoyalBlue;
            this.I_sponsor.FlatAppearance.BorderSize = 0;
            this.I_sponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.I_sponsor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.I_sponsor.ForeColor = System.Drawing.Color.White;
            this.I_sponsor.Location = new System.Drawing.Point(295, 198);
            this.I_sponsor.Name = "I_sponsor";
            this.I_sponsor.Size = new System.Drawing.Size(378, 67);
            this.I_sponsor.TabIndex = 21;
            this.I_sponsor.Text = "Редактирвовать профиль";
            this.I_sponsor.UseVisualStyleBackColor = false;
            // 
            // I_Runner
            // 
            this.I_Runner.BackColor = System.Drawing.Color.RoyalBlue;
            this.I_Runner.FlatAppearance.BorderSize = 0;
            this.I_Runner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.I_Runner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.I_Runner.ForeColor = System.Drawing.Color.White;
            this.I_Runner.Location = new System.Drawing.Point(295, 114);
            this.I_Runner.Name = "I_Runner";
            this.I_Runner.Size = new System.Drawing.Size(378, 67);
            this.I_Runner.TabIndex = 22;
            this.I_Runner.Text = "Регистрация на Марафон";
            this.I_Runner.UseVisualStyleBackColor = false;
            this.I_Runner.Click += new System.EventHandler(this.I_Runner_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(295, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 67);
            this.button1.TabIndex = 21;
            this.button1.Text = "Контакты";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::MaraphoneSkills_2019_3.Properties.Resources.icons8_shutdown_16;
            this.close.Location = new System.Drawing.Point(943, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.TabIndex = 2;
            this.close.UseVisualStyleBackColor = false;
            // 
            // MenuRunner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.I_sponsor);
            this.Controls.Add(this.I_Runner);
            this.Controls.Add(this.pnl_Timer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenuRunner_Load);
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Timer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Panel pnl_Timer;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button I_sponsor;
        private System.Windows.Forms.Button I_Runner;
    }
}