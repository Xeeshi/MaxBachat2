namespace MaxBachat21
{
    partial class AddNewScheduleVendor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhoneTextboxTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.VendorId_Name_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddmetroButton = new MetroFramework.Controls.MetroButton();
            this.TargetradioButton = new System.Windows.Forms.RadioButton();
            this.DOSradioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SUNcheckBox = new System.Windows.Forms.CheckBox();
            this.MoncheckBox = new System.Windows.Forms.CheckBox();
            this.SATcheckBox = new System.Windows.Forms.CheckBox();
            this.FRIcheckbox = new System.Windows.Forms.CheckBox();
            this.TuecheckBox = new System.Windows.Forms.CheckBox();
            this.ThucheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WedcheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DOMcomboBox = new System.Windows.Forms.ComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Totallabel = new System.Windows.Forms.Label();
            this.Targetlabel = new System.Windows.Forms.Label();
            this.DOSlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SetTargetbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhoneTextboxTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.VendorId_Name_combo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendor Details";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // PhoneTextboxTextBox
            // 
            this.PhoneTextboxTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhoneTextboxTextBox.Lines = new string[0];
            this.PhoneTextboxTextBox.Location = new System.Drawing.Point(107, 63);
            this.PhoneTextboxTextBox.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.PhoneTextboxTextBox.MaxLength = 32767;
            this.PhoneTextboxTextBox.Name = "PhoneTextboxTextBox";
            this.PhoneTextboxTextBox.PasswordChar = '\0';
            this.PhoneTextboxTextBox.PromptText = "03001234567";
            this.PhoneTextboxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PhoneTextboxTextBox.SelectedText = "";
            this.PhoneTextboxTextBox.Size = new System.Drawing.Size(305, 25);
            this.PhoneTextboxTextBox.TabIndex = 34;
            this.PhoneTextboxTextBox.UseCustomBackColor = true;
            this.PhoneTextboxTextBox.UseCustomForeColor = true;
            this.PhoneTextboxTextBox.UseSelectable = true;
            this.PhoneTextboxTextBox.UseStyleColors = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Vendor Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Use Semicolon ( ;) to seperate multiple email addresses.";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailTextBox.Lines = new string[0];
            this.EmailTextBox.Location = new System.Drawing.Point(107, 102);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.EmailTextBox.MaxLength = 32767;
            this.EmailTextBox.Multiline = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.PromptText = "Enter Email";
            this.EmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.Size = new System.Drawing.Size(305, 43);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.UseCustomBackColor = true;
            this.EmailTextBox.UseCustomForeColor = true;
            this.EmailTextBox.UseSelectable = true;
            this.EmailTextBox.UseStyleColors = true;
            // 
            // VendorId_Name_combo
            // 
            this.VendorId_Name_combo.FormattingEnabled = true;
            this.VendorId_Name_combo.Location = new System.Drawing.Point(107, 32);
            this.VendorId_Name_combo.Name = "VendorId_Name_combo";
            this.VendorId_Name_combo.Size = new System.Drawing.Size(305, 21);
            this.VendorId_Name_combo.TabIndex = 0;
            this.VendorId_Name_combo.SelectedIndexChanged += new System.EventHandler(this.VendorId_Name_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Vendor Name";
            // 
            // AddmetroButton
            // 
            this.AddmetroButton.BackColor = System.Drawing.Color.YellowGreen;
            this.AddmetroButton.Location = new System.Drawing.Point(96, 440);
            this.AddmetroButton.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.AddmetroButton.Name = "AddmetroButton";
            this.AddmetroButton.Size = new System.Drawing.Size(111, 36);
            this.AddmetroButton.Style = MetroFramework.MetroColorStyle.Green;
            this.AddmetroButton.TabIndex = 13;
            this.AddmetroButton.Text = "Add";
            this.AddmetroButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddmetroButton.UseCustomBackColor = true;
            this.AddmetroButton.UseCustomForeColor = true;
            this.AddmetroButton.UseSelectable = true;
            this.AddmetroButton.UseStyleColors = true;
            this.AddmetroButton.Click += new System.EventHandler(this.MetroButton5_Click_1);
            // 
            // TargetradioButton
            // 
            this.TargetradioButton.AutoSize = true;
            this.TargetradioButton.ForeColor = System.Drawing.Color.Maroon;
            this.TargetradioButton.Location = new System.Drawing.Point(84, 27);
            this.TargetradioButton.Name = "TargetradioButton";
            this.TargetradioButton.Size = new System.Drawing.Size(56, 17);
            this.TargetradioButton.TabIndex = 3;
            this.TargetradioButton.TabStop = true;
            this.TargetradioButton.Text = "Target";
            this.TargetradioButton.UseVisualStyleBackColor = true;
            this.TargetradioButton.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // DOSradioButton
            // 
            this.DOSradioButton.AutoSize = true;
            this.DOSradioButton.Checked = true;
            this.DOSradioButton.ForeColor = System.Drawing.Color.Maroon;
            this.DOSradioButton.Location = new System.Drawing.Point(18, 27);
            this.DOSradioButton.Name = "DOSradioButton";
            this.DOSradioButton.Size = new System.Drawing.Size(48, 17);
            this.DOSradioButton.TabIndex = 2;
            this.DOSradioButton.TabStop = true;
            this.DOSradioButton.Text = "DOS";
            this.DOSradioButton.UseVisualStyleBackColor = true;
            this.DOSradioButton.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(78, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Order Time";
            // 
            // SUNcheckBox
            // 
            this.SUNcheckBox.AutoSize = true;
            this.SUNcheckBox.Location = new System.Drawing.Point(320, 25);
            this.SUNcheckBox.Name = "SUNcheckBox";
            this.SUNcheckBox.Size = new System.Drawing.Size(45, 17);
            this.SUNcheckBox.TabIndex = 6;
            this.SUNcheckBox.Text = "Sun";
            this.SUNcheckBox.UseVisualStyleBackColor = true;
            // 
            // MoncheckBox
            // 
            this.MoncheckBox.AutoSize = true;
            this.MoncheckBox.Location = new System.Drawing.Point(19, 25);
            this.MoncheckBox.Name = "MoncheckBox";
            this.MoncheckBox.Size = new System.Drawing.Size(47, 17);
            this.MoncheckBox.TabIndex = 0;
            this.MoncheckBox.Text = "Mon";
            this.MoncheckBox.UseVisualStyleBackColor = true;
            // 
            // SATcheckBox
            // 
            this.SATcheckBox.AutoSize = true;
            this.SATcheckBox.Location = new System.Drawing.Point(272, 25);
            this.SATcheckBox.Name = "SATcheckBox";
            this.SATcheckBox.Size = new System.Drawing.Size(42, 17);
            this.SATcheckBox.TabIndex = 5;
            this.SATcheckBox.Text = "Sat";
            this.SATcheckBox.UseVisualStyleBackColor = true;
            // 
            // FRIcheckbox
            // 
            this.FRIcheckbox.AutoSize = true;
            this.FRIcheckbox.Location = new System.Drawing.Point(229, 25);
            this.FRIcheckbox.Name = "FRIcheckbox";
            this.FRIcheckbox.Size = new System.Drawing.Size(37, 17);
            this.FRIcheckbox.TabIndex = 4;
            this.FRIcheckbox.Text = "Fri";
            this.FRIcheckbox.UseVisualStyleBackColor = true;
            // 
            // TuecheckBox
            // 
            this.TuecheckBox.AutoSize = true;
            this.TuecheckBox.Location = new System.Drawing.Point(72, 25);
            this.TuecheckBox.Name = "TuecheckBox";
            this.TuecheckBox.Size = new System.Drawing.Size(45, 17);
            this.TuecheckBox.TabIndex = 1;
            this.TuecheckBox.Text = "Tue";
            this.TuecheckBox.UseVisualStyleBackColor = true;
            // 
            // ThucheckBox
            // 
            this.ThucheckBox.AutoSize = true;
            this.ThucheckBox.Location = new System.Drawing.Point(178, 25);
            this.ThucheckBox.Name = "ThucheckBox";
            this.ThucheckBox.Size = new System.Drawing.Size(45, 17);
            this.ThucheckBox.TabIndex = 3;
            this.ThucheckBox.Text = "Thu";
            this.ThucheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Days of Month";
            // 
            // WedcheckBox
            // 
            this.WedcheckBox.AutoSize = true;
            this.WedcheckBox.Location = new System.Drawing.Point(123, 25);
            this.WedcheckBox.Name = "WedcheckBox";
            this.WedcheckBox.Size = new System.Drawing.Size(49, 17);
            this.WedcheckBox.TabIndex = 2;
            this.WedcheckBox.Text = "Wed";
            this.WedcheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DOMcomboBox);
            this.groupBox2.Controls.Add(this.SATcheckBox);
            this.groupBox2.Controls.Add(this.WedcheckBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ThucheckBox);
            this.groupBox2.Controls.Add(this.TuecheckBox);
            this.groupBox2.Controls.Add(this.FRIcheckbox);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.MoncheckBox);
            this.groupBox2.Controls.Add(this.SUNcheckBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 113);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordering Schedule";
            // 
            // DOMcomboBox
            // 
            this.DOMcomboBox.FormattingEnabled = true;
            this.DOMcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DOMcomboBox.Location = new System.Drawing.Point(95, 65);
            this.DOMcomboBox.Name = "DOMcomboBox";
            this.DOMcomboBox.Size = new System.Drawing.Size(77, 21);
            this.DOMcomboBox.TabIndex = 7;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.OrangeRed;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(260, 440);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(111, 36);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Cancel";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.Totallabel);
            this.groupBox3.Controls.Add(this.Targetlabel);
            this.groupBox3.Controls.Add(this.DOSlabel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.SetTargetbutton);
            this.groupBox3.Controls.Add(this.DOSradioButton);
            this.groupBox3.Controls.Add(this.TargetradioButton);
            this.groupBox3.Location = new System.Drawing.Point(10, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 100);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordering Method";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "EDIT ITEMS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.Location = new System.Drawing.Point(364, 17);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(15, 16);
            this.Totallabel.TabIndex = 24;
            this.Totallabel.Text = "0";
            // 
            // Targetlabel
            // 
            this.Targetlabel.AutoSize = true;
            this.Targetlabel.Location = new System.Drawing.Point(379, 66);
            this.Targetlabel.Name = "Targetlabel";
            this.Targetlabel.Size = new System.Drawing.Size(13, 13);
            this.Targetlabel.TabIndex = 23;
            this.Targetlabel.Text = "0";
            // 
            // DOSlabel
            // 
            this.DOSlabel.AutoSize = true;
            this.DOSlabel.Location = new System.Drawing.Point(379, 44);
            this.DOSlabel.Name = "DOSlabel";
            this.DOSlabel.Size = new System.Drawing.Size(13, 13);
            this.DOSlabel.TabIndex = 22;
            this.DOSlabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Target Set For:";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "DOS Set For:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(278, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total Items:";
            // 
            // SetTargetbutton
            // 
            this.SetTargetbutton.Location = new System.Drawing.Point(8, 61);
            this.SetTargetbutton.Name = "SetTargetbutton";
            this.SetTargetbutton.Size = new System.Drawing.Size(132, 23);
            this.SetTargetbutton.TabIndex = 1;
            this.SetTargetbutton.Text = "SET DOS";
            this.SetTargetbutton.UseVisualStyleBackColor = true;
            this.SetTargetbutton.Click += new System.EventHandler(this.SetTargetbutton_Click);
            // 
            // AddNewScheduleVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 499);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AddmetroButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewScheduleVendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Vendor Ordering Schedule";
            this.Load += new System.EventHandler(this.AddNewScheduleVendor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox EmailTextBox;
        private System.Windows.Forms.RadioButton TargetradioButton;
        private System.Windows.Forms.ComboBox VendorId_Name_combo;
        private System.Windows.Forms.RadioButton DOSradioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox SUNcheckBox;
        private System.Windows.Forms.CheckBox MoncheckBox;
        private System.Windows.Forms.CheckBox SATcheckBox;
        private System.Windows.Forms.CheckBox FRIcheckbox;
        private System.Windows.Forms.CheckBox TuecheckBox;
        private System.Windows.Forms.CheckBox ThucheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox WedcheckBox;
        private MetroFramework.Controls.MetroButton AddmetroButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox DOMcomboBox;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SetTargetbutton;
        private System.Windows.Forms.Label Targetlabel;
        private System.Windows.Forms.Label DOSlabel;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox PhoneTextboxTextBox;
        private System.Windows.Forms.Label label9;
    }
}