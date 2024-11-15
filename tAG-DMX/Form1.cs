using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace tAG_DMX
{
    public partial class Form1 : KryptonForm
    {
        private DMXSerial _dmxController;
        private DMXwrapper _dmxWrapper;
        private DMXmain _dmxMain;

        public Form1()
        {
            InitializeComponent();
            LoadAvailablePorts();
            _dmxMain = new DMXmain(_dmxController);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadAvailablePorts()
        {
            comboBoxPorts.Items.Clear(); // Clear existing items
            string[] portNames = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(portNames);
            if (portNames.Length > 0)
            {
                comboBoxPorts.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No COM ports found.");
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string selectedPort = comboBoxPorts.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPort))
            {
                MessageBox.Show("Please select a COM port.");
                return;
            }

            _dmxController = new DMXSerial(selectedPort);
            _dmxController.Connect();

            if (_dmxController.IsConnected())
            {
                labelStatus.Text = $"Connected to {selectedPort}";
            }
            else
            {
                labelStatus.Text = $"Failed to connect to {selectedPort}";
            }

            _dmxWrapper = new DMXwrapper(_dmxController);
            _dmxWrapper.Show();

            _dmxMain.loadDMX(_dmxController);
            _dmxMain.Show();

            _dmxWrapper.FormClosed += (s, args) =>
            {
                Show();
            };

            Hide();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (_dmxController != null && _dmxController.IsConnected() && _dmxWrapper != null)
            {
                _dmxController.Disconnect();
                _dmxWrapper.Close();
                labelStatus.Text = "Disconnected";
            }


        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            LoadAvailablePorts();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (_dmxController != null && _dmxController.IsConnected() && _dmxWrapper != null)
            {
                _dmxController.Disconnect();
                labelStatus.Text = "Disconnected";
                _dmxWrapper.Close();
            }



            Application.Exit();
        }

        private void kryptonButton4_Click_1(object sender, EventArgs e)
        {
            Hide();
            FixtureEditor _fE = new FixtureEditor();
            _fE.Show();
            _fE.FormClosed += (s, args) =>
            {
                Show();
            };
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            OpenSetupAndClose();
        }

        private void OpenSetupAndClose()
        {
            string setupPath = Path.Combine(Application.StartupPath, "drivers", "setup.exe");

            if (File.Exists(setupPath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = setupPath,
                    UseShellExecute = true
                });

                Application.Exit();
            }
            else
            {
                MessageBox.Show("Setup file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
