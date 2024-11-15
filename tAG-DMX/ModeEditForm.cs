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
    public partial class ModeEditForm : KryptonForm
    {
        private Mode _mode;

        public ModeEditForm(Mode mode)
        {
            InitializeComponent();
            _mode = mode;
            LoadModeDetails();
        }

        private void LoadModeDetails()
        {
            txtModeName.Text = _mode.Name;

            foreach (var channel in _mode.Channels)
            {
                var channelItem = new ListViewItem(channel.Type);
                channelItem.SubItems.Add(channel.Name);
                lstChannels.Items.Add(channelItem);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _mode.Name = txtModeName.Text;

            // Save the mode
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddChannel_Click(object sender, EventArgs e)
        {
            var channel = new Channel { Type = "intensity", Name = "New Channel" };
            _mode.Channels.Add(channel);
            var channelItem = new ListViewItem(channel.Type);
            channelItem.SubItems.Add(channel.Name);
            lstChannels.Items.Add(channelItem);
        }

        private void btnEditChannel_Click(object sender, EventArgs e)
        {
            if (lstChannels.SelectedItems.Count > 0)
            {
                var selectedChannel = _mode.Channels[lstChannels.SelectedItems[0].Index];
                var channelEditForm = new ChannelEditForm(selectedChannel);
                if (channelEditForm.ShowDialog() == DialogResult.OK)
                {
                    lstChannels.SelectedItems[0].SubItems[0].Text = selectedChannel.Type;
                    lstChannels.SelectedItems[0].SubItems[1].Text = selectedChannel.Name;
                }
            }
        }

        private void btnRemoveChannel_Click(object sender, EventArgs e)
        {
            if (lstChannels.SelectedItems.Count > 0)
            {
                var selectedChannel = _mode.Channels[lstChannels.SelectedItems[0].Index];
                _mode.Channels.Remove(selectedChannel);
                lstChannels.Items.Remove(lstChannels.SelectedItems[0]);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
