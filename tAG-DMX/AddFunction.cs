using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tAG_DMX
{
    public partial class AddFunction : Form
    {
        public SingleFunction function;

        public AddFunction(SingleFunction function)
        {
            InitializeComponent();
            this.function = function;
            label3.Text = function.Type;
        }

        private void AddFunction_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            if (txtFNname.Text != "")
            {
                function.Name = txtFNname.Text;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
