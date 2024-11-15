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
    public partial class DMXwrapper : KryptonForm
    {
        private const int ChannelCount = 512;
        private byte[] _dmxValues = new byte[ChannelCount];
        private DMXSerial _dmxController;

        public DMXwrapper(DMXSerial _dmxcontroller)
        {
            InitializeComponent();
            InitializeGrid();
            this._dmxController = _dmxcontroller;
        }

        private void InitializeGrid()
        {
            dataGridViewChannels.ColumnCount = 2;
            dataGridViewChannels.Columns[0].Name = "Channel";
            dataGridViewChannels.Columns[1].Name = "Value";

            for (int i = 0; i < ChannelCount; i++)
            {
                _dmxValues[i] = 0;
                dataGridViewChannels.Rows.Add(i + 1, _dmxValues[i]);
            }
        }

        private void buttonUpdateAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ChannelCount; i++)
            {
                if (byte.TryParse(dataGridViewChannels.Rows[i].Cells[1].Value.ToString(), out byte value))
                {
                    _dmxValues[i] = value;
                    _dmxController.SetChannel(i + 1, value); // Update DMX channel
                }
                else
                {
                    MessageBox.Show($"Invalid value at channel {i + 1}");
                    return;
                }
            }
            UpdateGrid();
            MessageBox.Show("All channels updated.");
        }

        private void buttonUpdateChannel_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxChannel.Text, out int channel) && channel >= 1 && channel <= ChannelCount)
            {
                if (byte.TryParse(textBoxValue.Text, out byte value))
                {
                    _dmxValues[channel - 1] = value;
                    dataGridViewChannels.Rows[channel - 1].Cells[1].Value = value;
                    _dmxController.SetChannel(channel, value); // Update DMX channel
                    MessageBox.Show($"Channel {channel} updated.");
                }
                else
                {
                    MessageBox.Show("Invalid value. Please enter a number between 0 and 255.");
                }
            }
            else
            {
                MessageBox.Show("Invalid channel. Please enter a number between 1 and 512.");
            }
        }

        private void DMXwrapper_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            for (int i = 0; i < ChannelCount; i++)
            {
                dataGridViewChannels.Rows[i].Cells[1].Value = _dmxValues[i];
            }
        }
    }
}