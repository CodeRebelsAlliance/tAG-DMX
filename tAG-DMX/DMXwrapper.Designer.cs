namespace tAG_DMX
{
    partial class DMXwrapper
    {
        private System.Windows.Forms.DataGridView dataGridViewChannels;
        private System.Windows.Forms.Button buttonUpdateAll;
        private System.Windows.Forms.Button buttonUpdateChannel;
        private System.Windows.Forms.TextBox textBoxChannel;
        private System.Windows.Forms.TextBox textBoxValue;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMXwrapper));
            dataGridViewChannels = new DataGridView();
            buttonUpdateAll = new Button();
            buttonUpdateChannel = new Button();
            textBoxChannel = new TextBox();
            textBoxValue = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChannels).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewChannels
            // 
            dataGridViewChannels.AllowUserToAddRows = false;
            dataGridViewChannels.AllowUserToDeleteRows = false;
            dataGridViewChannels.BackgroundColor = Color.FromArgb(15, 15, 15);
            dataGridViewChannels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChannels.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewChannels.GridColor = Color.Gray;
            dataGridViewChannels.Location = new Point(12, 12);
            dataGridViewChannels.Name = "dataGridViewChannels";
            dataGridViewChannels.ReadOnly = true;
            dataGridViewChannels.Size = new Size(240, 426);
            dataGridViewChannels.TabIndex = 0;
            // 
            // buttonUpdateAll
            // 
            buttonUpdateAll.BackColor = Color.Black;
            buttonUpdateAll.ForeColor = Color.White;
            buttonUpdateAll.Location = new Point(258, 12);
            buttonUpdateAll.Name = "buttonUpdateAll";
            buttonUpdateAll.Size = new Size(75, 23);
            buttonUpdateAll.TabIndex = 1;
            buttonUpdateAll.Text = "Update All";
            buttonUpdateAll.UseVisualStyleBackColor = false;
            buttonUpdateAll.Click += buttonUpdateAll_Click;
            // 
            // buttonUpdateChannel
            // 
            buttonUpdateChannel.BackColor = Color.Black;
            buttonUpdateChannel.ForeColor = Color.White;
            buttonUpdateChannel.Location = new Point(258, 70);
            buttonUpdateChannel.Name = "buttonUpdateChannel";
            buttonUpdateChannel.Size = new Size(75, 23);
            buttonUpdateChannel.TabIndex = 2;
            buttonUpdateChannel.Text = "Update Channel";
            buttonUpdateChannel.UseVisualStyleBackColor = false;
            buttonUpdateChannel.Click += buttonUpdateChannel_Click;
            // 
            // textBoxChannel
            // 
            textBoxChannel.BackColor = Color.Black;
            textBoxChannel.ForeColor = Color.White;
            textBoxChannel.Location = new Point(258, 41);
            textBoxChannel.Name = "textBoxChannel";
            textBoxChannel.PlaceholderText = "Channel";
            textBoxChannel.Size = new Size(75, 23);
            textBoxChannel.TabIndex = 3;
            // 
            // textBoxValue
            // 
            textBoxValue.BackColor = Color.Black;
            textBoxValue.ForeColor = Color.White;
            textBoxValue.Location = new Point(258, 99);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.PlaceholderText = "Value";
            textBoxValue.Size = new Size(75, 23);
            textBoxValue.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // DMXwrapper
            // 
            BackColor = Color.Black;
            ClientSize = new Size(345, 450);
            Controls.Add(textBoxValue);
            Controls.Add(textBoxChannel);
            Controls.Add(buttonUpdateChannel);
            Controls.Add(buttonUpdateAll);
            Controls.Add(dataGridViewChannels);
            CornerRoundingRadius = 15F;
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DMXwrapper";
            SizeGripStyle = SizeGripStyle.Hide;
            StateCommon.Back.Color1 = Color.Black;
            StateCommon.Back.Color2 = Color.Black;
            StateCommon.Border.Color1 = Color.White;
            StateCommon.Border.Color2 = Color.White;
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 15F;
            StateCommon.Border.Width = 4;
            StateCommon.Header.Back.Color1 = Color.Black;
            StateCommon.Header.Back.Color2 = Color.Black;
            StateCommon.Header.Content.ShortText.Color1 = Color.White;
            StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StateCommon.Header.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Text = "tAG-DMX | DMX Emulator";
            Load += DMXwrapper_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewChannels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
    }
}