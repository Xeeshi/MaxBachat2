namespace MaxBachat21
{
    partial class MyPlan
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
            this.monthView1 = new System.Windows.Forms.Calendar.MonthView();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.makeNewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthView1
            // 
            this.monthView1.ArrowsColor = System.Drawing.Color.Red;
            this.monthView1.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.monthView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.monthView1.DayBackgroundColor = System.Drawing.Color.Empty;
            this.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthView1.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.monthView1.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.monthView1.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.monthView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.monthView1.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthView1.Location = new System.Drawing.Point(0, 0);
            this.monthView1.MaxSelectionCount = 1;
            this.monthView1.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthView1.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthView1.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView1.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthView1.Name = "monthView1";
            this.monthView1.Size = new System.Drawing.Size(217, 494);
            this.monthView1.TabIndex = 5;
            this.monthView1.Text = "monthView1";
            this.monthView1.TodayBorderColor = System.Drawing.Color.Maroon;
            this.monthView1.SelectionChanged += new System.EventHandler(this.monthView1_SelectionChanged);
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Appearance.AnyCell.Clickable = true;
            this.gridGroupingControl1.Appearance.AnyCell.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            this.gridGroupingControl1.Appearance.AnyCell.ReadOnly = true;
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.AutoSize = true;
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.ActiveCaption);
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Menu;
            this.gridGroupingControl1.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2010Blue;
            this.gridGroupingControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2010Blue;
            this.gridGroupingControl1.Location = new System.Drawing.Point(217, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridGroupingControl1.ShowRowHeaders = false;
            this.gridGroupingControl1.Size = new System.Drawing.Size(589, 494);
            this.gridGroupingControl1.TabIndex = 6;
            this.gridGroupingControl1.TableDescriptor.AllowEdit = false;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.UseRightToLeftCompatibleTextBox = true;
            this.gridGroupingControl1.VersionInfo = "15.3460.0.26";
            this.gridGroupingControl1.QueryCellStyleInfo += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventHandler(this.gridGroupingControl1_QueryCellStyleInfo);
            this.gridGroupingControl1.TableControlCurrentCellActivating += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCurrentCellActivatingEventHandler(this.gridGroupingControl1_TableControlCurrentCellActivating);
            this.gridGroupingControl1.TableControlCellHitTest += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellHitTestEventHandler(this.gridGroupingControl1_TableControlCellHitTest);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeNewOrderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // makeNewOrderToolStripMenuItem
            // 
            this.makeNewOrderToolStripMenuItem.Name = "makeNewOrderToolStripMenuItem";
            this.makeNewOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeNewOrderToolStripMenuItem.Text = "Make New Order";
            this.makeNewOrderToolStripMenuItem.Click += new System.EventHandler(this.makeNewOrderToolStripMenuItem_Click);
            // 
            // MyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 494);
            this.Controls.Add(this.gridGroupingControl1);
            this.Controls.Add(this.monthView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyPlan";
            this.ShowIcon = false;
            this.Text = "MyPlan";
            this.Load += new System.EventHandler(this.MyPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Calendar.MonthView monthView1;
        public Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem makeNewOrderToolStripMenuItem;
    }
}