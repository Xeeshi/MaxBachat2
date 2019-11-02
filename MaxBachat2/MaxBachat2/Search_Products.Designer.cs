namespace MaxBachat21
{
    partial class Search_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Products));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.InformationGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxLimitTextBox = new System.Windows.Forms.TextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchItemCountLabel = new System.Windows.Forms.Label();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BarcodeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGrid)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.InformationGrid, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(182, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(730, 420);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // InformationGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.InformationGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InformationGrid.BackgroundColor = System.Drawing.Color.White;
            this.InformationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InformationGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.InformationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InformationGrid.Location = new System.Drawing.Point(4, 46);
            this.InformationGrid.MultiSelect = false;
            this.InformationGrid.Name = "InformationGrid";
            this.InformationGrid.RowHeadersVisible = false;
            this.InformationGrid.RowHeadersWidth = 60;
            this.InformationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InformationGrid.Size = new System.Drawing.Size(722, 370);
            this.InformationGrid.TabIndex = 6;
            this.InformationGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InformationGrid_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(728, 41);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.ProductNameTextBox);
            this.panel2.Controls.Add(this.metroButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 41);
            this.panel2.TabIndex = 0;
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
            this.ProductNameTextBox.PromptText = "Search Product by Product Name...";
            this.ProductNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductNameTextBox.SelectedText = "";
            this.ProductNameTextBox.Size = new System.Drawing.Size(307, 23);
            this.ProductNameTextBox.TabIndex = 0;
            this.ProductNameTextBox.UseCustomBackColor = true;
            this.ProductNameTextBox.UseCustomForeColor = true;
            this.ProductNameTextBox.UseSelectable = true;
            this.ProductNameTextBox.UseStyleColors = true;
            this.ProductNameTextBox.Click += new System.EventHandler(this.ProductNameTextBox_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Black;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Location = new System.Drawing.Point(331, 10);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Search..";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.MaxLimitTextBox);
            this.panel3.Controls.Add(this.metroButton3);
            this.panel3.Controls.Add(this.metroCheckBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(436, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 41);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Max";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaxLimitTextBox
            // 
            this.MaxLimitTextBox.Location = new System.Drawing.Point(37, 13);
            this.MaxLimitTextBox.MaxLength = 4;
            this.MaxLimitTextBox.Name = "MaxLimitTextBox";
            this.MaxLimitTextBox.Size = new System.Drawing.Size(35, 20);
            this.MaxLimitTextBox.TabIndex = 24;
            this.MaxLimitTextBox.Text = "1000";
            this.MaxLimitTextBox.TextChanged += new System.EventHandler(this.MaxLimitTextBox_TextChanged);
            this.MaxLimitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxLimitTextBox_KeyPress);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.Orange;
            this.metroButton3.Location = new System.Drawing.Point(185, 10);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(96, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton3.TabIndex = 23;
            this.metroButton3.Text = "Add Items";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(101, 16);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(71, 15);
            this.metroCheckBox1.TabIndex = 2;
            this.metroCheckBox1.Text = "Select All";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(912, 420);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.SearchItemCountLabel);
            this.panel1.Controls.Add(this.metroButton6);
            this.panel1.Controls.Add(this.metroButton4);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BarcodeRichTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 420);
            this.panel1.TabIndex = 3;
            // 
            // SearchItemCountLabel
            // 
            this.SearchItemCountLabel.AutoSize = true;
            this.SearchItemCountLabel.Location = new System.Drawing.Point(13, 401);
            this.SearchItemCountLabel.Name = "SearchItemCountLabel";
            this.SearchItemCountLabel.Size = new System.Drawing.Size(19, 13);
            this.SearchItemCountLabel.TabIndex = 24;
            this.SearchItemCountLabel.Text = "(0)";
            this.SearchItemCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchItemCountLabel.Click += new System.EventHandler(this.SearchItemCountLabel_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.Color.Black;
            this.metroButton6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton6.Location = new System.Drawing.Point(10, 362);
            this.metroButton6.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(159, 36);
            this.metroButton6.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton6.TabIndex = 27;
            this.metroButton6.Text = "Save Search";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton6.UseCustomBackColor = true;
            this.metroButton6.UseCustomForeColor = true;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.UseStyleColors = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.Orange;
            this.metroButton4.Location = new System.Drawing.Point(10, 182);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(159, 20);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton4.TabIndex = 25;
            this.metroButton4.Text = "Search";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseCustomForeColor = true;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.UseStyleColors = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Black;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton2.Location = new System.Drawing.Point(11, 158);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(159, 21);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.TabIndex = 25;
            this.metroButton2.Text = "Paste";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Barcodes:";
            // 
            // BarcodeRichTextBox
            // 
            this.BarcodeRichTextBox.Location = new System.Drawing.Point(10, 34);
            this.BarcodeRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BarcodeRichTextBox.Name = "BarcodeRichTextBox";
            this.BarcodeRichTextBox.Size = new System.Drawing.Size(159, 120);
            this.BarcodeRichTextBox.TabIndex = 18;
            this.BarcodeRichTextBox.Text = "";
            // 
            // Search_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 420);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(924, 457);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(924, 457);
            this.Name = "Search_Products";
            this.Text = "Search Products";
            this.Load += new System.EventHandler(this.Search_Products_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InformationGrid)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroTextBox ProductNameTextBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox BarcodeRichTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView InformationGrid;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.Label SearchItemCountLabel;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaxLimitTextBox;
    }
}