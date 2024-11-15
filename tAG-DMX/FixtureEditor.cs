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
    public partial class FixtureEditor : KryptonForm
    {
        private List<Fixture> fixtures;

        public FixtureEditor()
        {
            InitializeComponent();
            LoadFixtures();
        }

        private void LoadFixtures()
        {
            fixtures = FixtureManager.LoadFixtures();
            lstFixtures.Items.Clear();
            lstFixtures.Groups.Clear();

            var groupedFixtures = fixtures.GroupBy(f => f.FixtureType);

            foreach (var group in groupedFixtures)
            {
                var listViewGroup = new ListViewGroup(group.Key, HorizontalAlignment.Left);
                lstFixtures.Groups.Add(listViewGroup);

                foreach (var fixture in group)
                {
                    var item = new ListViewItem(fixture.Model, listViewGroup);
                    item.SubItems.Add(fixture.Vendor);
                    item.SubItems.Add(fixture.FixtureType);
                    lstFixtures.Items.Add(item);
                }
            }
        }

        private void AddFixtureButton_Click(object sender, EventArgs e)
        {
            var fixture = new Fixture
            {
                Model = "New Model",
                Vendor = "New Vendor",
                FixtureType = "LED"
            };
            fixtures.Add(fixture);
            FixtureManager.SaveFixture(fixture);
            LoadFixtures();
        }

        private void EditFixtureButton_Click(object sender, EventArgs e)
        {
            if (lstFixtures.SelectedItems.Count > 0)
            {
                var selectedFixture = fixtures[lstFixtures.SelectedItems[0].Index];
                var fixtureEditForm = new FixtureEditForm(selectedFixture);
                if (fixtureEditForm.ShowDialog() == DialogResult.OK)
                {
                    FixtureManager.SaveFixture(selectedFixture);
                    LoadFixtures();
                }
            }
        }

        private void RemoveFixtureButton_Click(object sender, EventArgs e)
        {
            if (lstFixtures.SelectedItems.Count > 0)
            {
                var selectedFixture = fixtures[lstFixtures.SelectedItems[0].Index];
                fixtures.Remove(selectedFixture);
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fixtures", $"{selectedFixture.Model}.json");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                LoadFixtures();
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
