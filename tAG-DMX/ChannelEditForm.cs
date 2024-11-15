using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace tAG_DMX
{
    public partial class ChannelEditForm : KryptonForm
    {
        private Channel _channel;

        public ChannelEditForm(Channel channel)
        {
            InitializeComponent();
            _channel = channel;
            LoadChannelDetails();
        }

        private void LoadChannelDetails()
        {
            cmbChannelType.SelectedItem = _channel.Type;
            txtChannelName.Text = _channel.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _channel.Type = cmbChannelType.SelectedItem.ToString();
            _channel.Name = txtChannelName.Text;

            // Save the channel
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ChannelEditForm_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
