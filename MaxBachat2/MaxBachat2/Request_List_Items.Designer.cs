namespace MaxBachat21
{
    partial class Request_List_Items
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.InformationGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BarcodeSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroButton5);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Location = new System.Drawing.Point(5, 445);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 41);
            this.panel1.TabIndex = 9;
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.Orange;
            this.metroButton5.Enabled = false;
            this.metroButton5.Location = new System.Drawing.Point(10, 9);
            this.metroButton5.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(96, 23);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton5.TabIndex = 29;
            this.metroButton5.Text = "Delete";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseCustomForeColor = true;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.UseStyleColors = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Black;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton2.Location = new System.Drawing.Point(265, 10);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(96, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Add List..";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // InformationGrid
            // 
            this.InformationGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            this.InformationGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.InformationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InformationGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InformationGrid.BackgroundColor = System.Drawing.Color.White;
            this.InformationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InformationGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.InformationGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InformationGrid.Location = new System.Drawing.Point(5, 55);
            this.InformationGrid.MultiSelect = false;
            this.InformationGrid.Name = "InformationGrid";
            this.InformationGrid.RowHeadersVisible = false;
            this.InformationGrid.RowHeadersWidth = 60;
            this.InformationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InformationGrid.Size = new System.Drawing.Size(387, 387);
            this.InformationGrid.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.metroCheckBox1);
            this.panel2.Controls.Add(this.BarcodeSearchTextBox);
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 41);
            this.panel2.TabIndex = 8;
            // 
            // BarcodeSearchTextBox
            // 
            this.BarcodeSearchTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BarcodeSearchTextBox.Lines = new string[0];
            this.BarcodeSearchTextBox.Location = new System.Drawing.Point(27, 10);
            this.BarcodeSearchTextBox.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.BarcodeSearchTextBox.MaxLength = 32767;
            this.BarcodeSearchTextBox.Name = "BarcodeSearchTextBox";
            this.BarcodeSearchTextBox.PasswordChar = '\0';
            this.BarcodeSearchTextBox.PromptText = "Search List by Barcode...";
            this.BarcodeSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BarcodeSearchTextBox.SelectedText = "";
            this.BarcodeSearchTextBox.Size = new System.Drawing.Size(221, 23);
            this.BarcodeSearchTextBox.TabIndex = 0;
            this.BarcodeSearchTextBox.UseCustomBackColor = true;
            this.BarcodeSearchTextBox.UseCustomForeColor = true;
            this.BarcodeSearchTextBox.UseSelectable = true;
            this.BarcodeSearchTextBox.UseStyleColors = true;
            this.BarcodeSearchTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            this.BarcodeSearchTextBox.Click += new System.EventHandler(this.ProductNameTextBox_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(304, 13);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(71, 15);
            this.metroCheckBox1.TabIndex = 30;
            this.metroCheckBox1.Text = "Select All";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // Request_List_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(401, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InformationGrid);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Request_List_Items";
            this.Text = "Request List Items";
            this.Load += new System.EventHandler(this.Request_List_Items_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InformationGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridView InformationGrid;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox BarcodeSearchTextBox;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
    }
}