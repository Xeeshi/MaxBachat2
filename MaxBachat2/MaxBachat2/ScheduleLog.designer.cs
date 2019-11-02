namespace MaxBachat21
{
    partial class ScheduleLog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ProductNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.DG2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.DG2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.ProductNameTextBox);
            this.panel2.Controls.Add(this.metroButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 45);
            this.panel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(419, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductNameTextBox.Lines = new string[0];
            this.ProductNameTextBox.Location = new System.Drawing.Point(14, 10);
            this.ProductNameTextBox.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.ProductNameTextBox.MaxLength = 32767;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.PasswordChar = '\0';
            this.ProductNameTextBox.PromptText = "Enter Vendor ID";
            this.ProductNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductNameTextBox.SelectedText = "";
            this.ProductNameTextBox.Size = new System.Drawing.Size(307, 23);
            this.ProductNameTextBox.TabIndex = 0;
            this.ProductNameTextBox.UseCustomBackColor = true;
            this.ProductNameTextBox.UseCustomForeColor = true;
            this.ProductNameTextBox.UseSelectable = true;
            this.ProductNameTextBox.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Black;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Location = new System.Drawing.Point(679, 10);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 1;
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
            this.DG2.Location = new System.Drawing.Point(3, 48);
            this.DG2.Name = "DG2";
            this.DG2.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.DG2.Size = new System.Drawing.Size(794, 399);
            this.DG2.TabIndex = 34;
            this.DG2.Text = "gridGroupingControl1";
            this.DG2.UseRightToLeftCompatibleTextBox = true;
            this.DG2.VersionInfo = "15.3460.0.26";
            // 
            // ScheduleLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ScheduleLog";
            this.Text = "ScheduleLog";
            this.Load += new System.EventHandler(this.ScheduleLog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroTextBox ProductNameTextBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        public Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl DG2;
    }
}