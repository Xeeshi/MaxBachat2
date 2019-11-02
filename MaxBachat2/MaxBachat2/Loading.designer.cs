using NavigationDrawer_2010;

namespace Admin
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OnlineLabel = new System.Windows.Forms.Label();
            this.LocalLabel = new System.Windows.Forms.Label();
            this.LocalRadioButton = new System.Windows.Forms.RadioButton();
            this.InternetradioButton = new System.Windows.Forms.RadioButton();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DBConTestingTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.PasswordTextBox);
            this.panel2.Controls.Add(this.NotificationLabel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.UserNameTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 280);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(87, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Version: 2.2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-8, 276);
            this.progressBar1.Maximum = 40;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(253, 11);
            this.progressBar1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OnlineLabel);
            this.groupBox1.Controls.Add(this.LocalLabel);
            this.groupBox1.Controls.Add(this.LocalRadioButton);
            this.groupBox1.Controls.Add(this.InternetradioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 70);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login via";
            // 
            // OnlineLabel
            // 
            this.OnlineLabel.AutoSize = true;
            this.OnlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.OnlineLabel.ForeColor = System.Drawing.Color.Black;
            this.OnlineLabel.Location = new System.Drawing.Point(113, 42);
            this.OnlineLabel.Name = "OnlineLabel";
            this.OnlineLabel.Size = new System.Drawing.Size(73, 16);
            this.OnlineLabel.TabIndex = 20;
            this.OnlineLabel.Text = "Checking...";
            // 
            // LocalLabel
            // 
            this.LocalLabel.AutoSize = true;
            this.LocalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LocalLabel.ForeColor = System.Drawing.Color.Black;
            this.LocalLabel.Location = new System.Drawing.Point(113, 15);
            this.LocalLabel.Name = "LocalLabel";
            this.LocalLabel.Size = new System.Drawing.Size(73, 16);
            this.LocalLabel.TabIndex = 19;
            this.LocalLabel.Text = "Checking...";
            // 
            // LocalRadioButton
            // 
            this.LocalRadioButton.AutoSize = true;
            this.LocalRadioButton.ForeColor = System.Drawing.Color.Black;
            this.LocalRadioButton.Location = new System.Drawing.Point(11, 19);
            this.LocalRadioButton.Name = "LocalRadioButton";
            this.LocalRadioButton.Size = new System.Drawing.Size(51, 17);
            this.LocalRadioButton.TabIndex = 1;
            this.LocalRadioButton.Text = "Local";
            this.LocalRadioButton.UseVisualStyleBackColor = true;
            this.LocalRadioButton.CheckedChanged += new System.EventHandler(this.LoginRadioButton_CheckedChanged);
            // 
            // InternetradioButton
            // 
            this.InternetradioButton.AutoSize = true;
            this.InternetradioButton.ForeColor = System.Drawing.Color.Black;
            this.InternetradioButton.Location = new System.Drawing.Point(11, 42);
            this.InternetradioButton.Name = "InternetradioButton";
            this.InternetradioButton.Size = new System.Drawing.Size(61, 17);
            this.InternetradioButton.TabIndex = 0;
            this.InternetradioButton.Text = "Internet";
            this.InternetradioButton.UseVisualStyleBackColor = true;
            this.InternetradioButton.CheckedChanged += new System.EventHandler(this.InternetradioButton_CheckedChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(77, 134);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(143, 20);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameTextBox_KeyDown);
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.BackColor = System.Drawing.Color.Transparent;
            this.NotificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.NotificationLabel.ForeColor = System.Drawing.Color.Maroon;
            this.NotificationLabel.Location = new System.Drawing.Point(74, 157);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(45, 16);
            this.NotificationLabel.TabIndex = 13;
            this.NotificationLabel.Text = "label3";
            this.NotificationLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "&Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(77, 108);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.UserNameTextBox.TabIndex = 7;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            this.UserNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // DBConTestingTimer
            // 
            this.DBConTestingTimer.Interval = 30000;
            this.DBConTestingTimer.Tick += new System.EventHandler(this.DBConTestingTimer_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.Gainsboro;
            this.BorderThickness = 6;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientSize = new System.Drawing.Size(245, 280);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(350, 250);
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.Black;
            this.MinimizeBox = false;
            this.Name = "Loading";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MAX BACHAT";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LocalRadioButton;
        private System.Windows.Forms.RadioButton InternetradioButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label OnlineLabel;
        private System.Windows.Forms.Label LocalLabel;
        private System.Windows.Forms.Timer DBConTestingTimer;
        private System.Windows.Forms.Label label3;
    }
}