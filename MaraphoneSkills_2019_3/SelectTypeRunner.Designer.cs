namespace MaraphoneSkills_2019_3
{
    partial class SelectTypeRunner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTypeRunner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_Timer = new System.Windows.Forms.Panel();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.btn_New_Runner = new System.Windows.Forms.Button();
            this.btn_Runner = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Back = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.pnl_Timer.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 100);
            this.panel1.TabIndex = 7;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Info.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Info.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Info.Location = new System.Drawing.Point(204, 34);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(296, 32);
            this.lbl_Info.TabIndex = 0;
            this.lbl_Info.Text = "MaraphoneSkills 2019";
            this.lbl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topPanel.Controls.Add(this.close);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(705, 25);
            this.topPanel.TabIndex = 6;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_Timer
            // 
            this.pnl_Timer.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_Timer.Controls.Add(this.lbl_Timer);
            this.pnl_Timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Timer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnl_Timer.ForeColor = System.Drawing.Color.White;
            this.pnl_Timer.Location = new System.Drawing.Point(0, 394);
            this.pnl_Timer.Name = "pnl_Timer";
            this.pnl_Timer.Size = new System.Drawing.Size(705, 44);
            this.pnl_Timer.TabIndex = 8;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Timer.Location = new System.Drawing.Point(0, 0);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(705, 44);
            this.lbl_Timer.TabIndex = 0;
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.btn_Back);
            this.pnl_Main.Controls.Add(this.btn_New_Runner);
            this.pnl_Main.Controls.Add(this.btn_Runner);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 125);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(705, 269);
            this.pnl_Main.TabIndex = 9;
            // 
            // btn_New_Runner
            // 
            this.btn_New_Runner.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_New_Runner.FlatAppearance.BorderSize = 0;
            this.btn_New_Runner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New_Runner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_New_Runner.ForeColor = System.Drawing.Color.White;
            this.btn_New_Runner.Location = new System.Drawing.Point(163, 118);
            this.btn_New_Runner.Name = "btn_New_Runner";
            this.btn_New_Runner.Size = new System.Drawing.Size(378, 67);
            this.btn_New_Runner.TabIndex = 11;
            this.btn_New_Runner.Text = "Я новый участник";
            this.btn_New_Runner.UseVisualStyleBackColor = false;
            this.btn_New_Runner.Click += new System.EventHandler(this.btn_New_Runner_Click);
            // 
            // btn_Runner
            // 
            this.btn_Runner.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Runner.FlatAppearance.BorderSize = 0;
            this.btn_Runner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Runner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Runner.ForeColor = System.Drawing.Color.White;
            this.btn_Runner.Location = new System.Drawing.Point(163, 34);
            this.btn_Runner.Name = "btn_Runner";
            this.btn_Runner.Size = new System.Drawing.Size(378, 67);
            this.btn_Runner.TabIndex = 12;
            this.btn_Runner.Text = "Я учавствовал ранее";
            this.btn_Runner.UseVisualStyleBackColor = false;
            this.btn_Runner.Click += new System.EventHandler(this.btn_Runner_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(12, 225);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(86, 38);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.Text = "Назад";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::MaraphoneSkills_2019_3.Properties.Resources.icons8_shutdown_16;
            this.close.Location = new System.Drawing.Point(680, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = false;
            // 
            // SelectTypeRunner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 438);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Timer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectTypeRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectTypeRunner";
            this.Load += new System.EventHandler(this.SelectTypeRunner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.pnl_Timer.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_Timer;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Button btn_New_Runner;
        private System.Windows.Forms.Button btn_Runner;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Back;
    }
}