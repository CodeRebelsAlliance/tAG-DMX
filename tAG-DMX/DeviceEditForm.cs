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
    public partial class DeviceEditForm : KryptonForm
    {
        public string DeviceName { get; set; }
        public Fixture SelectedFixture { get; set; }
        public int Channel { get; set; } = 1;

        private List<Fixture> fixtures;

        public DeviceEditForm(List<Fixture> fixtures)
        {
            InitializeComponent();
            this.fixtures = fixtures;
            cmbFixture.DataSource = fixtures;
            cmbFixture.DisplayMember = "Model";
        }

        public void InitializeForm(string _selDVname, Fixture _selDVficture, int _selDVchannel)
        {
            dvName.Text = _selDVname;
            cmbFixture.SelectedItem = _selDVficture;
            dvChannel.Value = _selDVchannel;
            DeviceName = _selDVname;
            SelectedFixture = _selDVficture;
            Channel = _selDVchannel;

        }

        private void DeviceEditForm_Load(object sender, EventArgs e)
        {

        }

        private void saveBTN(object sender, EventArgs e)
        {
            DeviceName = dvName.Text;
            SelectedFixture = (Fixture)cmbFixture.SelectedItem;
            Channel = (int)dvChannel.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
