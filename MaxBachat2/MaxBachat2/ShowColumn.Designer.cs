namespace MaxBachat21
{
    partial class ShowColumn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HiddenlistBox = new System.Windows.Forms.ListBox();
            this.ShownlistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.buttonAdv3);
            this.panel1.Controls.Add(this.buttonAdv2);
            this.panel1.Controls.Add(this.buttonAdv1);
            this.panel1.Controls.Add(this.HiddenlistBox);
            this.panel1.Controls.Add(this.ShownlistBox);
            this.panel1.Location = new System.Drawing.Point(7, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 355);
            this.panel1.TabIndex = 0;
            // 
            // HiddenlistBox
            // 
            this.HiddenlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.HiddenlistBox.FormattingEnabled = true;
            this.HiddenlistBox.ItemHeight = 20;
            this.HiddenlistBox.Location = new System.Drawing.Point(5, 6);
            this.HiddenlistBox.Name = "HiddenlistBox";
            this.HiddenlistBox.Size = new System.Drawing.Size(290, 344);
            this.HiddenlistBox.TabIndex = 5;
            // 
            // ShownlistBox
            // 
            this.ShownlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ShownlistBox.FormattingEnabled = true;
            this.ShownlistBox.ItemHeight = 20;
            this.ShownlistBox.Location = new System.Drawing.Point(384, 6);
            this.ShownlistBox.Name = "ShownlistBox";
            this.ShownlistBox.Size = new System.Drawing.Size(290, 344);
            this.ShownlistBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hidden Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shown Column";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.buttonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(303, 161);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv1.TabIndex = 6;
            this.buttonAdv1.Text = "Add >>";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.UseVisualStyleBackColor = false;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.buttonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(303, 190);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv2.TabIndex = 7;
            this.buttonAdv2.Text = "<< Remove";
            this.buttonAdv2.UseVisualStyle = true;
            this.buttonAdv2.UseVisualStyleBackColor = false;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.buttonAdv3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.Location = new System.Drawing.Point(303, 327);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv3.TabIndex = 8;
            this.buttonAdv3.Text = "<Default>";
            this.buttonAdv3.UseVisualStyle = true;
            this.buttonAdv3.UseVisualStyleBackColor = false;
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // ShowColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowColumn";
            this.ShowIcon = false;
            this.Text = "Configuration Column";
            this.Load += new System.EventHandler(this.ShowColumn_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ShownlistBox;
        private System.Windows.Forms.ListBox HiddenlistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
    }
}