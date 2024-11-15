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
    public partial class FixtureEditForm : KryptonForm
    {
        private Fixture _fixture;

        public FixtureEditForm(Fixture fixture)
        {
            InitializeComponent();
            _fixture = fixture;
            LoadFixtureDetails();
        }

        private void LoadFixtureDetails()
        {
            txtModel.Text = _fixture.Model;
            txtVendor.Text = _fixture.Vendor;
            cmbFixtureType.SelectedItem = _fixture.FixtureType;

            foreach (var mode in _fixture.Modes)
            {
                var modeItem = new ListViewItem(mode.Name);
                modeItem.SubItems.Add(mode.NumberOfChannels.ToString());
                lstModes.Items.Add(modeItem);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_fixture == null)
            {
                MessageBox.Show("Fixture is not initialized.");
                return;
            }

            if (cmbFixtureType.SelectedItem == null)
            {
                MessageBox.Show("Please select a fixture type.");
                return;
            }

            _fixture.Model = txtModel.Text;
            _fixture.Vendor = txtVendor.Text;
            _fixture.FixtureType = cmbFixtureType.SelectedItem.ToString();

            // Save the fixture
            FixtureManager.SaveFixture(_fixture);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddMode_Click(object sender, EventArgs e)
        {
            var mode = new Mode { Name = "New Mode" };
            _fixture.Modes.Add(mode);
            var modeItem = new ListViewItem(mode.Name);
            modeItem.SubItems.Add(mode.NumberOfChannels.ToString());
            lstModes.Items.Add(modeItem);
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            if (lstModes.SelectedItems.Count > 0)
            {
                var selectedMode = _fixture.Modes[lstModes.SelectedItems[0].Index];
                var modeEditForm = new ModeEditForm(selectedMode);
                if (modeEditForm.ShowDialog() == DialogResult.OK)
                {
                    lstModes.SelectedItems[0].SubItems[0].Text = selectedMode.Name;
                    lstModes.SelectedItems[0].SubItems[1].Text = selectedMode.NumberOfChannels.ToString();
                }
            }
        }

        private void btnRemoveMode_Click(object sender, EventArgs e)
        {
            if (lstModes.SelectedItems.Count > 0)
            {
                var selectedMode = _fixture.Modes[lstModes.SelectedItems[0].Index];
                _fixture.Modes.Remove(selectedMode);
                lstModes.Items.Remove(lstModes.SelectedItems[0]);
            }
        }

        private void FixtureEditForm_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
