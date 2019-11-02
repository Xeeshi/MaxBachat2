namespace MaxBachat21
{
    partial class AutomaticOrderingSetting
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
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.DG2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.Orange;
            this.metroButton5.Location = new System.Drawing.Point(19, 19);
            this.metroButton5.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(154, 36);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton5.TabIndex = 31;
            this.metroButton5.Text = "Add New";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseCustomForeColor = true;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.UseStyleColors = true;
            this.metroButton5.Click += new System.EventHandler(this.MetroButton5_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Location = new System.Drawing.Point(1037, 19);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(154, 36);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 32;
            this.metroButton1.Text = "Refresh";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // DG2
            // 
            this.DG2.Appearance.AnyCell.Clickable = true;
            this.DG2.Appearance.AnyCell.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            this.DG2.Appearance.AnyCell.ReadOnly = true;
            this.DG2.Appearance.ColumnHeaderCell.AutoSize = true;
            this.DG2.Appearance.ColumnHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.ActiveCaption);
            this.DG2.BackColor = System.Drawing.SystemColors.Window;
            this.DG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG2.Location = new System.Drawing.Point(0, 0);
            this.DG2.Name = "DG2";
            this.DG2.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.DG2.Size = new System.Drawing.Size(1221, 352);
            this.DG2.TabIndex = 33;
            this.DG2.Text = "gridGroupingControl1";
            this.DG2.UseRightToLeftCompatibleTextBox = true;
            this.DG2.VersionInfo = "15.3460.0.26";
            this.DG2.TableControlCurrentCellControlDoubleClick += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlControlEventHandler(this.DG2_TableControlCurrentCellControlDoubleClick);
            this.DG2.TableControlPushButtonClick += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellPushButtonClickEventHandler(this.DG2_TableControlPushButtonClick);
            this.DG2.TableControlCellDoubleClick += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventHandler(this.DG2_TableControlCellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroButton5);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 72);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.LimeGreen;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton3.Location = new System.Drawing.Point(870, 19);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(154, 36);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton3.TabIndex = 34;
            this.metroButton3.Text = "&View Logs";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            this.metroButton3.Click += new System.EventHandler(this.MetroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.LimeGreen;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton2.Location = new System.Drawing.Point(536, 19);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(154, 36);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.TabIndex = 33;
            this.metroButton2.Text = "&Save";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Visible = false;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DG2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1221, 352);
            this.panel2.TabIndex = 35;
            // 
            // AutomaticOrderingSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AutomaticOrderingSetting";
            this.Text = "AutomaticOrderingSetting";
            this.Load += new System.EventHandler(this.AutomaticOrderingSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton1;
        public Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl DG2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}