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
using Krypton.Docking;
using Krypton.Navigator;
using Krypton.Workspace;

namespace tAG_DMX
{
    public partial class DMXmain : KryptonForm
    {
        private DMXSerial _dmx;
        private DataGridView sliderGrid;
        private SingleFunction selectedFunction;

        public DMXmain(DMXSerial _dmx)
        {
            this._dmx = _dmx;
            InitializeComponent();
            InitializeSliderGrid();
        }

        public void loadDMX(DMXSerial _load)
        {
            _dmx = _load;

        }

        private void DMXmain_Load(object sender, EventArgs e)
        {

        }

        private void InitializeSliderGrid()
        {
            sliderGrid = new DataGridView
            {
                Dock = DockStyle.Fill,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                RowHeadersVisible = false,
                ColumnHeadersVisible = false,
                BackgroundColor = Color.Black,
                ForeColor = Color.White,
                GridColor = Color.Gray
            };

            for (int i = 0; i < 512; i++)
            {
                sliderGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = $"Ch {i + 1}",
                    Width = 100,
                    DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.Black, ForeColor = Color.White }
                });
            }

            sliderGrid.Rows.Add();
            sliderGrid.Rows.Add();
            sliderGrid.Rows.Add();

            sliderGrid.Rows[0].Height = 30; // Fixed height for the first row
            sliderGrid.Rows[1].Height = 30; // Fixed height for the second row

            for (int i = 0; i < 512; i++)
            {
                sliderGrid.Rows[0].Cells[i].Value = $"Ch {i + 1}";
                sliderGrid.Rows[1].Cells[i].Value = 0;
                sliderGrid.Rows[2].Cells[i] = new DataGridViewTrackBarCell();
            }

            sliderGrid.SizeChanged += SliderGrid_SizeChanged;
            sliderGrid.CellValueChanged += SliderGrid_CellValueChanged;
            sliderGrid.CellEndEdit += SliderGrid_CellEndEdit;
            sliderPanel.Controls.Add(sliderGrid);
        }

        private void SliderGrid_SizeChanged(object sender, EventArgs e)
        {
            if (sliderGrid.Rows.Count > 2)
            {
                int availableHeight = sliderGrid.ClientSize.Height - sliderGrid.Rows[0].Height - sliderGrid.Rows[1].Height - sliderGrid.ColumnHeadersHeight;
                sliderGrid.Rows[2].Height = availableHeight;
            }
        }

        private void SliderGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 2 || e.RowIndex == 1)
            {
                int channel = e.ColumnIndex + 1;
                if (int.TryParse(sliderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out int value))
                {
                    if (e.RowIndex == 2)
                    {
                        sliderGrid.Rows[1].Cells[e.ColumnIndex].Value = value;
                    }
                    else if (e.RowIndex == 1)
                    {
                        sliderGrid.Rows[2].Cells[e.ColumnIndex].Value = value;
                    }
                    _dmx.SetChannel(channel, (byte)value);
                }
                else
                {
                    // Handle the case where the value is not a valid integer
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                }
            }
        }

        private void SliderGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 1)
            {
                int channel = e.ColumnIndex + 1;
                int value = (int)sliderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                sliderGrid.Rows[2].Cells[e.ColumnIndex].Value = value;
                _dmx.SetChannel(channel, (byte)value);
            }
        }

        public void UpdateUniverseToZero()
        {
            _dmx.SetUniverse(0);
            ResetSliderGridValues();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            UpdateUniverseToZero();
        }

        private void ResetSliderGridValues()
        {
            for (int i = 0; i < 512; i++)
            {
                sliderGrid.Rows[1].Cells[i].Value = 0;
                sliderGrid.Rows[2].Cells[i].Value = 0;
            }
        }

        private List<Device> _devices = new List<Device>();
        private List<SingleFunction> _functions = new List<SingleFunction>();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DeviceManager.SaveData(_devices, _functions);
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            DeviceManager.SaveDataAs(_devices, _functions);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            (var loadedDevices, var loadedFunctions) = DeviceManager.OpenData();
            if (loadedDevices != null)
            {
                _devices = loadedDevices;
                _functions = loadedFunctions;
                UpdateDevicesPanel();
                UpdateFunctionsPanel();
            }
        }

        private void FunctionPanel_Click(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            if (panel != null)
            {
                var function = panel.Tag as SingleFunction;
                if (function != null)
                {
                    // Highlight the selected function
                    foreach (Panel p in functionsPanel.Controls.OfType<Panel>())
                    {
                        p.BackColor = Color.Black;
                    }
                    panel.BackColor = Color.Maroon;

                    // Set the selected function
                    selectedFunction = function;
                    if (selectedFunction.Type == "Szene")
                    {
                        // Open the functionEditPanel
                        functionsEditPanel.Visible = true;
                        // Load function details into the functionEditPanel
                        LoadFunctionDetails(function);
                    }
                    else
                    {
                        functionsEditPanel.Visible = false;
                        MessageBox.Show("Only scenes are supported at the moment.");
                    }
                }
            }
        }

        private void LoadFunctionDetails(SingleFunction function)
        {
            functionEditPanel.Controls.Clear();
            txtFunctionName.Text = function.Name;
            var functionNameLabel = new Label
            {
                Text = $"Function: {function.Name}",
                Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10)
            };
            functionEditPanel.Controls.Add(functionNameLabel);

            var devicesLabel = new Label
            {
                Text = "Devices:",
                Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 40)
            };
            functionEditPanel.Controls.Add(devicesLabel);

            var devicesPanel = new FlowLayoutPanel
            {
                Location = new Point(10, 60),
                Size = new Size(280, 200),
                AutoScroll = true
            };
            functionEditPanel.Controls.Add(devicesPanel);

            foreach (var device in function.Devices)
            {
                var devicePanel = new Panel
                {
                    Width = 260,
                    Height = 150,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = device,
                    Margin = new Padding(5)
                };

                var deviceNameLabel = new Label
                {
                    Text = device.Device.Name,
                    Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                deviceNameLabel.Click += (s, e) => RemoveDeviceFromFunction(function, device);
                devicePanel.Controls.Add(deviceNameLabel);

                var channelsLabel = new Label
                {
                    Text = "Channels:",
                    Location = new Point(10, 30),
                    AutoSize = true
                };
                devicePanel.Controls.Add(channelsLabel);

                var channelsPanel = new FlowLayoutPanel
                {
                    Location = new Point(10, 50),
                    Size = new Size(240, 90),
                    AutoScroll = true
                };
                devicePanel.Controls.Add(channelsPanel);

                foreach (var channel in device.ChannelValues)
                {
                    var channelPanel = new Panel
                    {
                        Width = 220,
                        Height = 30,
                        Margin = new Padding(5)
                    };

                    var channelIcon = new PictureBox
                    {
                        Width = 20,
                        Height = 20,
                        Image = GetChannelIcon(channel.Channel.Type),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(0, 5)
                    };
                    channelPanel.Controls.Add(channelIcon);

                    var activateCheckBox = new CheckBox
                    {
                        Location = new Point(30, 5)
                    };
                    channelPanel.Controls.Add(activateCheckBox);

                    var trackBar = new TrackBar
                    {
                        Minimum = 0,
                        Maximum = 255,
                        Value = channel.Value,
                        Location = new Point(60, 0),
                        Size = new Size(100, 30)
                    };
                    trackBar.ValueChanged += (s, e) => channel.Value = trackBar.Value;
                    channelPanel.Controls.Add(trackBar);

                    var numericUpDown = new NumericUpDown
                    {
                        Minimum = 0,
                        Maximum = 255,
                        Value = channel.Value,
                        Location = new Point(170, 5),
                        Size = new Size(50, 20)
                    };
                    numericUpDown.ValueChanged += (s, e) => channel.Value = (int)numericUpDown.Value;
                    channelPanel.Controls.Add(numericUpDown);

                    channelsPanel.Controls.Add(channelPanel);
                }

                devicesPanel.Controls.Add(devicePanel);
            }

            var addDeviceButton = new Button
            {
                Text = "Add Device",
                Location = new Point(10, 270)
            };
            //addDeviceButton.Click += (s, e) => AddDeviceToFunction(function, devicesPanel);
            functionEditPanel.Controls.Add(addDeviceButton);
        }

        private Image GetChannelIcon(string channelType)
        {
            var iconPath = Path.Combine(Application.StartupPath, "assets", $"{channelType.ToLower()}.png");
            if (File.Exists(iconPath))
            {
                return Image.FromFile(iconPath);
            }
            return Properties.Resources.icons8_settings_240; // A default image if type is unknown
        }

        /*private void AddDeviceToFunction(SingleFunction function, FlowLayoutPanel devicesPanel)
        {
            var availableDevices = _devices.Except(function.Devices.Device).ToList();
            if (availableDevices.Count == 0)
            {
                MessageBox.Show("No available devices to add.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var addDeviceForm = new Form
            {
                Text = "Add Device",
                Size = new Size(300, 200)
            };

            var devicesComboBox = new ComboBox
            {
                DataSource = availableDevices,
                DisplayMember = "Name",
                Location = new Point(10, 10),
                Size = new Size(260, 20)
            };
            addDeviceForm.Controls.Add(devicesComboBox);

            var addButton = new Button
            {
                Text = "Add",
                Location = new Point(10, 40)
            };
            addButton.Click += (s, e) =>
            {
                var selectedDevice = devicesComboBox.SelectedItem as DeviceFunction;
                if (selectedDevice != null)
                {
                    function.Devices.Add(selectedDevice);
                    LoadFunctionDetails(function);
                    addDeviceForm.Close();
                }
            };
            addDeviceForm.Controls.Add(addButton);

            addDeviceForm.ShowDialog();
        }*/

        private void RemoveDeviceFromFunction(SingleFunction function, DeviceFunction device)
        {
            function.Devices.Remove(device);
            LoadFunctionDetails(function);
        }

        private void FunctionsPanel_Click(object sender, EventArgs e)
        {
            // Deselect the current function
            selectedFunction = null;

            // Reset the background color of all function panels
            foreach (Panel p in functionsPanel.Controls.OfType<Panel>())
            {
                p.BackColor = Color.Black;
            }

            functionsEditPanel.Visible = false;
            // Hide the functionEditPanel
        }

        private void UpdateFunctionsPanel()
        {
            functionsPanel.Controls.Clear();
            functionsPanel.AutoScroll = true;
            functionsPanel.WrapContents = true;
            functionsPanel.Click += FunctionsPanel_Click;
            functionsPanel.FlowDirection = FlowDirection.TopDown;
            // Group functions by type
            var groupedFunctions = _functions.GroupBy(f => f.Type).ToDictionary(g => g.Key, g => g.ToList());

            foreach (var group in groupedFunctions)
            {
                // Add a label for the function type
                var typeLabel = new Label
                {
                    Text = group.Key,
                    Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
                    AutoSize = true,
                    Margin = new Padding(10, 10, 10, 0)
                };
                functionsPanel.Controls.Add(typeLabel);

                foreach (var function in group.Value)
                {
                    var functionPanel = new Panel
                    {
                        Width = 400,
                        Height = 70,
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = function,
                        Margin = new Padding(10)
                    };

                    var functionImage = new PictureBox
                    {
                        Width = 50,
                        Height = 50,
                        Image = GetFunctionTypeImage(function.Type),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(10, 10)
                    };

                    var functionNameLabel = new Label
                    {
                        Text = function.Name,
                        Location = new Point(70, 10),
                        AutoSize = true
                    };

                    var functionTypeLabel = new Label
                    {
                        Text = function.Type,
                        Location = new Point(70, 30),
                        AutoSize = true
                    };

                    functionPanel.Controls.Add(functionImage);
                    functionPanel.Controls.Add(functionNameLabel);
                    functionPanel.Controls.Add(functionTypeLabel);

                    functionPanel.Click += FunctionPanel_Click;

                    functionsPanel.Controls.Add(functionPanel);
                }
            }
        }

        private void AddFN(string functionType)
        {
            SingleFunction newFunction = new SingleFunction();
            newFunction.Type = functionType;
            newFunction.Name = "New Function";


            using (var addFunctionForm = new AddFunction(newFunction))
            {
                if (addFunctionForm.ShowDialog() == DialogResult.OK)
                {
                    newFunction = addFunctionForm.function;
                    _functions.Add(newFunction);
                    DeviceManager.SaveData(_devices, _functions);
                    UpdateFunctionsPanel();
                }
            }
        }

        private Image GetFunctionTypeImage(string functionType)
        {
            switch (functionType.ToLower())
            {
                case "szene":
                    return Properties.Resources.icons8_scene_96;
                case "chaser":
                    return Properties.Resources.icons8_rgb_histogram_96;
                case "effekt":
                    return Properties.Resources.icons8_effect_96;
                case "musikmodus":
                    return Properties.Resources.icons8_radio_waves_96;
                case "rgb-matrix":
                    return Properties.Resources.icons8_data_matrix_code_96;
                default:
                    return Properties.Resources.icons8_settings_240; // A default image if type is unknown
            }
        }

        private void UpdateDevicesPanel()
        {
            devicesPanel.Controls.Clear();

            var groupedDevices = _devices.GroupBy(d => d.Fixture.FixtureType);

            foreach (var group in groupedDevices)
            {
                var groupLabel = new Label
                {
                    Text = group.Key,
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
                    ForeColor = Color.White
                };
                devicesPanel.Controls.Add(groupLabel);

                foreach (var device in group)
                {
                    var devicePanel = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.LeftToRight,
                        AutoSize = true,
                        Padding = new Padding(5),
                        BackColor = Color.Gray,
                        Tag = device
                    };

                    var nameLabel = new Label
                    {
                        Text = $"Name: {device.Name}",
                        AutoSize = true,
                        ForeColor = Color.White
                    };
                    var modelLabel = new Label
                    {
                        Text = $"Modell: {device.Fixture.Model}",
                        AutoSize = true,
                        ForeColor = Color.White
                    };
                    var channelLabel = new Label
                    {
                        Text = $"Kanal: {device.Channel}",
                        AutoSize = true,
                        ForeColor = Color.White
                    };
                    var fixtureTypeImage = new PictureBox
                    {
                        Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets", $"{device.Fixture.FixtureType.Replace(" ", "")}.png")),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(50, 50)
                    };

                    devicePanel.Controls.Add(nameLabel);
                    devicePanel.Controls.Add(modelLabel);
                    devicePanel.Controls.Add(channelLabel);
                    devicePanel.Controls.Add(fixtureTypeImage);

                    devicePanel.Click += DevicePanel_Click;

                    devicesPanel.Controls.Add(devicePanel);
                }
            }
        }

        private void DevicePanel_Click(object sender, EventArgs e)
        {
            var selectedPanel = sender as FlowLayoutPanel;
            if (selectedPanel != null)
            {
                foreach (FlowLayoutPanel panel in devicesPanel.Controls.OfType<FlowLayoutPanel>())
                {
                    panel.BackColor = Color.Gray;
                }
                selectedPanel.BackColor = Color.Maroon;
                selectedDevice = selectedPanel.Tag as Device;
            }
        }

        private Device selectedDevice;

        private void AddDVButton_Click(object sender, EventArgs e)
        {
            var fixtureList = FixtureManager.LoadFixtures();
            var deviceEditForm = new DeviceEditForm(fixtureList);

            if (deviceEditForm.ShowDialog() == DialogResult.OK)
            {
                var newDevice = new Device
                {
                    Name = deviceEditForm.DeviceName,
                    Fixture = deviceEditForm.SelectedFixture,
                    Channel = deviceEditForm.Channel
                };
                _devices.Add(newDevice);
                UpdateDevicesPanel();
            }
        }

        private void EditDVButton_Click(object sender, EventArgs e)
        {
            if (selectedDevice != null)
            {
                var fixtureList = FixtureManager.LoadFixtures();
                var deviceEditForm = new DeviceEditForm(fixtureList)
                {
                    DeviceName = selectedDevice.Name,
                    SelectedFixture = selectedDevice.Fixture,
                    Channel = selectedDevice.Channel
                };

                deviceEditForm.DeviceName = selectedDevice.Name;
                deviceEditForm.Channel = selectedDevice.Channel;
                deviceEditForm.SelectedFixture = selectedDevice.Fixture;
                deviceEditForm.InitializeForm(selectedDevice.Name, selectedDevice.Fixture, selectedDevice.Channel);

                if (deviceEditForm.ShowDialog() == DialogResult.OK)
                {
                    selectedDevice.Name = deviceEditForm.DeviceName;
                    selectedDevice.Fixture = deviceEditForm.SelectedFixture;
                    selectedDevice.Channel = deviceEditForm.Channel;
                    UpdateDevicesPanel();
                }
            }
            else
            {
                MessageBox.Show("Please select a device to edit.");
            }
        }

        private void RemoveDVButton_Click(object sender, EventArgs e)
        {
            if (selectedDevice != null)
            {
                _devices.Remove(selectedDevice);
                selectedDevice = null;
                UpdateDevicesPanel();
            }
            else
            {
                MessageBox.Show("Please select a device to remove.");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void functionEditPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            AddFN("Szene");
        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            AddFN("Chaser");
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            AddFN("Effekt");
        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            AddFN("RGB-Matrix");
        }

        private void kryptonButton12_Click(object sender, EventArgs e)
        {
            AddFN("Musikmodus");
        }

        private void txtFunctionName_TextChanged(object sender, EventArgs e)
        {
            selectedFunction.Name = txtFunctionName.Text;

        }

        private void functionSave_Click(object sender, EventArgs e)
        {
            DeviceManager.SaveData(_devices, _functions);
            UpdateFunctionsPanel();
            selectedFunction = null;

            // Reset the background color of all function panels
            foreach (Panel p in functionsPanel.Controls.OfType<Panel>())
            {
                p.BackColor = Color.Black;
            }
            functionsEditPanel.Visible = false;
        }
    }
}
