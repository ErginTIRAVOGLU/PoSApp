using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoSApp.UI.Forms.PosForms
{
    public partial class frmQuantity : Form
    {
        public int returnQuantity { get; set; }
        public frmQuantity()
        {
            InitializeComponent();
        }

        private void frmQuantity_Load(object sender, EventArgs e)
        {

        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                int qValue = 0;
                int.TryParse(txtQuantity.Text, out qValue);
                returnQuantity = qValue;
                //e.Handled = true;
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Abort;
                e.Handled = true;
                this.Close();
            }

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
