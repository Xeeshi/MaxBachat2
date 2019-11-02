namespace MaxBachat21
{
    partial class My_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(My_List));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToOrderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.InformationGrid = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ProductNameTextBox);
            this.panel2.Location = new System.Drawing.Point(13, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 41);
            this.panel2.TabIndex = 1;
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
            this.ProductNameTextBox.PromptText = "Search List by Name...";
            this.ProductNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductNameTextBox.SelectedText = "";
            this.ProductNameTextBox.Size = new System.Drawing.Size(343, 23);
            this.ProductNameTextBox.TabIndex = 0;
            this.ProductNameTextBox.UseCustomBackColor = true;
            this.ProductNameTextBox.UseCustomForeColor = true;
            this.ProductNameTextBox.UseSelectable = true;
            this.ProductNameTextBox.UseStyleColors = true;
            this.ProductNameTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            this.ProductNameTextBox.Click += new System.EventHandler(this.ProductNameTextBox_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToOrderListToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 26);
            // 
            // addToOrderListToolStripMenuItem
            // 
            this.addToOrderListToolStripMenuItem.Name = "addToOrderListToolStripMenuItem";
            this.addToOrderListToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addToOrderListToolStripMenuItem.Text = "&Add to Order List";
            this.addToOrderListToolStripMenuItem.Click += new System.EventHandler(this.addToOrderListToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroButton5);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Location = new System.Drawing.Point(13, 413);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 41);
            this.panel1.TabIndex = 2;
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.Orange;
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
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Black;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton2.Location = new System.Drawing.Point(290, 9);
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
            this.InformationGrid.BackgroundColor = System.Drawing.Color.White;
            this.InformationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InformationGrid.Location = new System.Drawing.Point(13, 53);
            this.InformationGrid.Name = "InformationGrid";
            this.InformationGrid.RowHeadersVisible = false;
            this.InformationGrid.Size = new System.Drawing.Size(401, 357);
            this.InformationGrid.TabIndex = 3;
            this.InformationGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InformationGrid_CellContentClick);
            // 
            // My_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(429, 459);
            this.Controls.Add(this.InformationGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(441, 496);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(441, 496);
            this.Name = "My_List";
            this.Text = "My List";
            this.Load += new System.EventHandler(this.My_List_Load);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InformationGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox ProductNameTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToOrderListToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.DataGridView InformationGrid;
    }
}