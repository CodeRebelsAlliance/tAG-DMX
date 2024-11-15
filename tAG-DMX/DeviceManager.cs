using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tAG_DMX
{
    public static class DeviceManager
    {
        private static string defaultFileName = "Projekt.dmx";
        private static string currentFileName = "";
        private static string savesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "saves");

        public static void SaveData(List<Device> devices, List<SingleFunction> functions, string filePath = null, bool saveAs = false)
        {
            if (filePath == null)
            {
                if (currentFileName == "")
                {
                    filePath = Path.Combine(savesDirectory, defaultFileName);
                }
                else
                {
                    filePath = currentFileName;
                }
            }

            if (!File.Exists(filePath) && !saveAs)
            {
                SaveDataAs(devices, functions);
                return;
            }

            Directory.CreateDirectory(savesDirectory);
            var data = new { Devices = devices, Functions = functions };
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            currentFileName = filePath;
        }

        public static (List<Device> Devices, List<SingleFunction> Functions) LoadData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file does not exist.", filePath);
            }

            try
            {
                var json = File.ReadAllText(filePath);
                var data = JsonSerializer.Deserialize<DataContainer>(json);
                currentFileName = filePath;
                return (data.Devices, data.Functions);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (new List<Device>(), new List<SingleFunction>());
                currentFileName = "";
            }
        }

        public static void SaveDataAs(List<Device> devices, List<SingleFunction> functions)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "DMX files (*.dmx)|*.dmx|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "dmx";
                saveFileDialog.InitialDirectory = savesDirectory;
                saveFileDialog.FileName = defaultFileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveData(devices, functions, saveFileDialog.FileName, true);
                }
            }
        }

        public static (List<Device> Devices, List<SingleFunction> Functions) OpenData()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "DMX files (*.dmx)|*.dmx|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = savesDirectory;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFileName = openFileDialog.FileName;
                    return LoadData(openFileDialog.FileName);
                }
            }

            return (null, null);
        }

        private class DataContainer
        {
            public List<Device> Devices { get; set; }
            public List<SingleFunction> Functions { get; set; }
        }
    }
}
