namespace MaxBachat21
{
    partial class Request_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request_List));
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.InformationGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductNameTextBox = new MetroFramework.Controls.MetroTextBox();
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
            this.panel1.Location = new System.Drawing.Point(14, 411);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 41);
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
            this.metroButton2.Enabled = false;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton2.Location = new System.Drawing.Point(697, 9);
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
            // 
            // InformationGrid
            // 
            this.InformationGrid.AllowUserToAddRows = false;
            this.InformationGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.InformationGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InformationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InformationGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InformationGrid.BackgroundColor = System.Drawing.Color.White;
            this.InformationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InformationGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.InformationGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InformationGrid.Location = new System.Drawing.Point(14, 50);
            this.InformationGrid.MultiSelect = false;
            this.InformationGrid.Name = "InformationGrid";
            this.InformationGrid.ReadOnly = true;
            this.InformationGrid.RowHeadersVisible = false;
            this.InformationGrid.RowHeadersWidth = 60;
            this.InformationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InformationGrid.Size = new System.Drawing.Size(798, 358);
            this.InformationGrid.TabIndex = 10;
            this.InformationGrid.DoubleClick += new System.EventHandler(this.InformationGrid_DoubleClick);
            this.InformationGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InformationGrid_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ProductNameTextBox);
            this.panel2.Location = new System.Drawing.Point(14, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 41);
            this.panel2.TabIndex = 8;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductNameTextBox.Lines = new string[0];
            this.ProductNameTextBox.Location = new System.Drawing.Point(27, 10);
            this.ProductNameTextBox.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.ProductNameTextBox.MaxLength = 32767;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.PasswordChar = '\0';
            this.ProductNameTextBox.PromptText = "Search List by ID...";
            this.ProductNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductNameTextBox.SelectedText = "";
            this.ProductNameTextBox.Size = new System.Drawing.Size(740, 23);
            this.ProductNameTextBox.TabIndex = 0;
            this.ProductNameTextBox.UseCustomBackColor = true;
            this.ProductNameTextBox.UseCustomForeColor = true;
            this.ProductNameTextBox.UseSelectable = true;
            this.ProductNameTextBox.UseStyleColors = true;
            this.ProductNameTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            // 
            // Request_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(824, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InformationGrid);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(836, 496);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(836, 496);
            this.Name = "Request_List";
            this.Text = "Request List";
            this.Load += new System.EventHandler(this.Request_List_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InformationGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridView InformationGrid;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox ProductNameTextBox;
    }
}