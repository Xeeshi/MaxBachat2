namespace MaxBachat21
{
    partial class Save_Search_Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Save_Search_Dialog));
            this.ListNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ListNameTextBox
            // 
            this.ListNameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListNameTextBox.Lines = new string[0];
            this.ListNameTextBox.Location = new System.Drawing.Point(91, 31);
            this.ListNameTextBox.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.ListNameTextBox.MaxLength = 32767;
            this.ListNameTextBox.Name = "ListNameTextBox";
            this.ListNameTextBox.PasswordChar = '\0';
            this.ListNameTextBox.PromptText = "Enter Your List Name";
            this.ListNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ListNameTextBox.SelectedText = "";
            this.ListNameTextBox.Size = new System.Drawing.Size(307, 23);
            this.ListNameTextBox.TabIndex = 1;
            this.ListNameTextBox.UseCustomBackColor = true;
            this.ListNameTextBox.UseCustomForeColor = true;
            this.ListNameTextBox.UseSelectable = true;
            this.ListNameTextBox.UseStyleColors = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "List Name";
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.Orange;
            this.metroButton5.Location = new System.Drawing.Point(238, 64);
            this.metroButton5.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(159, 36);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton5.TabIndex = 28;
            this.metroButton5.Text = "Save";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseCustomForeColor = true;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.UseStyleColors = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.Color.Black;
            this.metroButton6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton6.Location = new System.Drawing.Point(6, 93);
            this.metroButton6.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(80, 30);
            this.metroButton6.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton6.TabIndex = 29;
            this.metroButton6.Text = "Cancel";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton6.UseCustomBackColor = true;
            this.metroButton6.UseCustomForeColor = true;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.UseStyleColors = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // Save_Search_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(409, 135);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(421, 172);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(421, 172);
            this.Name = "Save_Search_Dialog";
            this.Text = "Save Search Dialog";
            this.Load += new System.EventHandler(this.Save_Search_Dialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox ListNameTextBox;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
    }
}