namespace MaxBachat21
{
    partial class Edit_Item
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.buttonAdv1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(135, 32);
            this.buttonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(729, 18);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.buttonAdv1.Size = new System.Drawing.Size(135, 32);
            this.buttonAdv1.TabIndex = 1;
            this.buttonAdv1.Text = "&Apply Changes";
            this.buttonAdv1.UseVisualStyle = false;
            this.buttonAdv1.UseVisualStyleBackColor = false;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(163, 32);
            this.buttonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(218, 18);
            this.buttonAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.buttonAdv2.Size = new System.Drawing.Size(163, 32);
            this.buttonAdv2.TabIndex = 2;
            this.buttonAdv2.Text = "&Delete Vendor Mapping";
            this.buttonAdv2.UseVisualStyle = false;
            this.buttonAdv2.UseVisualStyleBackColor = false;
            this.buttonAdv2.Click += new System.EventHandler(this.ButtonAdv2_Click);
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.buttonAdv3.BackColor = System.Drawing.Color.Green;
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(163, 32);
            this.buttonAdv3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv3.ForeColor = System.Drawing.Color.White;
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.Location = new System.Drawing.Point(28, 18);
            this.buttonAdv3.MetroColor = System.Drawing.Color.Lime;
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.buttonAdv3.Size = new System.Drawing.Size(163, 32);
            this.buttonAdv3.TabIndex = 3;
            this.buttonAdv3.Text = "&Add Vendor Mapping";
            this.buttonAdv3.UseVisualStyle = false;
            this.buttonAdv3.UseVisualStyleBackColor = false;
            this.buttonAdv3.Click += new System.EventHandler(this.ButtonAdv3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1066, 511);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAdv3);
            this.panel1.Controls.Add(this.buttonAdv1);
            this.panel1.Controls.Add(this.buttonAdv2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 71);
            this.panel1.TabIndex = 5;
            // 
            // Edit_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.Blue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientSize = new System.Drawing.Size(1066, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Edit_Item";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Item";
            this.Load += new System.EventHandler(this.Edit_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}