namespace MaxBachat2
{
    partial class ChildForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectRowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectColumnToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.calculateSuggestedOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dOSViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthtlyViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DG = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowToolStripMenuItem,
            this.deselectToolStripMenuItem,
            this.toolStripSeparator1,
            this.calculateSuggestedOrderToolStripMenuItem,
            this.toolStripSeparator3,
            this.removeItemToolStripMenuItem,
            this.removeAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.dOSViewToolStripMenuItem,
            this.monthtlyViewToolStripMenuItem,
            this.toolStripSeparator4,
            this.editItemToolStripMenuItem,
            this.setDOSToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 226);
            // 
            // rowToolStripMenuItem
            // 
            this.rowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.deselectRowToolStripMenuItem1,
            this.deleToolStripMenuItem});
            this.rowToolStripMenuItem.Image = global::MaxBachat21.Properties.Resources.add_row_241;
            this.rowToolStripMenuItem.Name = "rowToolStripMenuItem";
            this.rowToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.rowToolStripMenuItem.Text = "Select Row";
            this.rowToolStripMenuItem.Click += new System.EventHandler(this.rowToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::MaxBachat21.Properties.Resources.add_row_24;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.selectAllToolStripMenuItem.Text = "Select All Rows";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click_1);
            // 
            // deselectRowToolStripMenuItem1
            // 
            this.deselectRowToolStripMenuItem1.Image = global::MaxBachat21.Properties.Resources.delete_row_24;
            this.deselectRowToolStripMenuItem1.Name = "deselectRowToolStripMenuItem1";
            this.deselectRowToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.deselectRowToolStripMenuItem1.Text = "Deselect Row";
            this.deselectRowToolStripMenuItem1.Click += new System.EventHandler(this.deselectRowToolStripMenuItem1_Click);
            // 
            // deleToolStripMenuItem
            // 
            this.deleToolStripMenuItem.Image = global::MaxBachat21.Properties.Resources.delete_row_24;
            this.deleToolStripMenuItem.Name = "deleToolStripMenuItem";
            this.deleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.deleToolStripMenuItem.Text = "Deselect All Rows";
            this.deleToolStripMenuItem.Click += new System.EventHandler(this.deleToolStripMenuItem_Click);
            // 
            // deselectToolStripMenuItem
            // 
            this.deselectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deselectColumnToolStripMenuItem2,
            this.deselectAllColumnToolStripMenuItem});
            this.deselectToolStripMenuItem.Image = global::MaxBachat21.Properties.Resources.add_column_48;
            this.deselectToolStripMenuItem.Name = "deselectToolStripMenuItem";
            this.deselectToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deselectToolStripMenuItem.Text = "Select Column";
            this.deselectToolStripMenuItem.Click += new System.EventHandler(this.deselectToolStripMenuItem_Click);
            // 
            // deselectColumnToolStripMenuItem2
            // 
            this.deselectColumnToolStripMenuItem2.Image = global::MaxBachat21.Properties.Resources.delete_column_24;
            this.deselectColumnToolStripMenuItem2.Name = "deselectColumnToolStripMenuItem2";
            this.deselectColumnToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.deselectColumnToolStripMenuItem2.Text = "Deselect Column";
            this.deselectColumnToolStripMenuItem2.Click += new System.EventHandler(this.deselectColumnToolStripMenuItem2_Click);
            // 
            // deselectAllColumnToolStripMenuItem
            // 
            this.deselectAllColumnToolStripMenuItem.Image = global::MaxBachat21.Properties.Resources.delete_column_24;
            this.deselectAllColumnToolStripMenuItem.Name = "deselectAllColumnToolStripMenuItem";
            this.deselectAllColumnToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deselectAllColumnToolStripMenuItem.Text = "Deselect All Columns";
            this.deselectAllColumnToolStripMenuItem.Click += new System.EventHandler(this.deselectAllColumnToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // calculateSuggestedOrderToolStripMenuItem
            // 
            this.calculateSuggestedOrderToolStripMenuItem.Image = global::MaxBachat21.Properties.Resources.calculator_24;
            this.calculateSuggestedOrderToolStripMenuItem.Name = "calculateSuggestedOrderToolStripMenuItem";
            this.calculateSuggestedOrderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.calculateSuggestedOrderToolStripMenuItem.Text = "Calculate Suggested";
            this.calculateSuggestedOrderToolStripMenuItem.Click += new System.EventHandler(this.calculateSuggestedOrderToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Image = global::MaxBachat21.Properties.Resources.delete_row_24;
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Image = global::MaxBachat21.Properties.Resources.erase_24;
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.removeAllToolStripMenuItem.Text = "Remove All";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.removeAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // dOSViewToolStripMenuItem
            // 
            this.dOSViewToolStripMenuItem.Image = global::MaxBachat21.Properties.Resources.dos_copyrighted_24;
            this.dOSViewToolStripMenuItem.Name = "dOSViewToolStripMenuItem";
            this.dOSViewToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dOSViewToolStripMenuItem.Text = "DOS View";
            this.dOSViewToolStripMenuItem.Click += new System.EventHandler(this.dOSViewToolStripMenuItem_Click);
            // 
            // monthtlyViewToolStripMenuItem
            // 
            this.monthtlyViewToolStripMenuItem.Enabled = false;
            this.monthtlyViewToolStripMenuItem.Image = global::MaxBachat21.Properties.Resources.calendar_24;
            this.monthtlyViewToolStripMenuItem.Name = "monthtlyViewToolStripMenuItem";
            this.monthtlyViewToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.monthtlyViewToolStripMenuItem.Text = "Monthtly View";
            this.monthtlyViewToolStripMenuItem.Click += new System.EventHandler(this.monthtlyViewToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Image = global::MaxBachat21.Properties.Resources.edit_row_48;
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.editItemToolStripMenuItem.Text = "&Edit Item / Delete";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // setDOSToolStripMenuItem
            // 
            this.setDOSToolStripMenuItem.Image = global::MaxBachat21.Properties.Resources.report_card_48;
            this.setDOSToolStripMenuItem.Name = "setDOSToolStripMenuItem";
            this.setDOSToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.setDOSToolStripMenuItem.Text = "&Set DOS";
            this.setDOSToolStripMenuItem.Click += new System.EventHandler(this.setDOSToolStripMenuItem_Click);
            // 
            // DG
            // 
            this.DG.Appearance.AnyCell.Clickable = true;
            this.DG.Appearance.AnyCell.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            this.DG.Appearance.AnyCell.ReadOnly = true;
            this.DG.Appearance.ColumnHeaderCell.AutoSize = true;
            this.DG.Appearance.ColumnHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.ActiveCaption);
            this.DG.BackColor = System.Drawing.SystemColors.Window;
            this.DG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG.Location = new System.Drawing.Point(0, 0);
            this.DG.Name = "DG";
            this.DG.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.DG.Size = new System.Drawing.Size(685, 388);
            this.DG.TabIndex = 1;
            this.DG.Text = "gridGroupingControl1";
            this.DG.UseRightToLeftCompatibleTextBox = true;
            this.DG.VersionInfo = "15.3460.0.26";
            this.DG.TableControlCurrentCellValidating += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCancelEventHandler(this.DG_TableControlCurrentCellValidating);
            this.DG.TableControlCurrentCellEditingComplete += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlEventHandler(this.DG_TableControlCurrentCellEditingComplete);
            this.DG.TableControlCellHitTest += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellHitTestEventHandler(this.DG_TableControlCellHitTest);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarHeight = 1;
            this.ClientSize = new System.Drawing.Size(685, 388);
            this.Controls.Add(this.DG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ChildForm";
            this.Text = "Order 1";
            this.Activated += new System.EventHandler(this.ChildForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChildForm_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateSuggestedOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOSViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthtlyViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl DG;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectRowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectColumnToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deselectAllColumnToolStripMenuItem;
    }
}