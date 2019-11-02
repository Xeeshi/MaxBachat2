using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxBachat21
{
    public partial class SetDOS : Syncfusion.Windows.Forms.Office2010Form
    {
        public SetDOS()
        {
            InitializeComponent();
        }
        public decimal DOS { get; set; }
        public bool DialogResult_ { get; set; }

        private void SetDOS_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {

            DOS = numericUpDown1.Value;
            DialogResult_ = true;
            this.Hide();
        }
    }
}
