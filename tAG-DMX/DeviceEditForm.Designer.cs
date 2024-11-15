namespace tAG_DMX
{
    partial class DeviceEditForm
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceEditForm));
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonButton8 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            label2 = new Label();
            label1 = new Label();
            dvName = new Krypton.Toolkit.KryptonTextBox();
            label3 = new Label();
            dvChannel = new Krypton.Toolkit.KryptonNumericUpDown();
            label4 = new Label();
            cmbFixture = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFixture).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonButton8);
            kryptonPanel1.Controls.Add(kryptonButton1);
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(595, 41);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel1.TabIndex = 7;
            // 
            // kryptonButton8
            // 
            kryptonButton8.Dock = DockStyle.Right;
            kryptonButton8.Location = new Point(513, 0);
            kryptonButton8.Name = "kryptonButton8";
            kryptonButton8.Size = new Size(41, 41);
            kryptonButton8.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton8.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton8.StateCommon.Back.Image = Properties.Resources.icons8_save_96;
            kryptonButton8.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton8.StateCommon.Border.Color1 = Color.White;
            kryptonButton8.StateCommon.Border.Color2 = Color.White;
            kryptonButton8.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton8.StateCommon.Border.Rounding = 53F;
            kryptonButton8.StateCommon.Border.Width = 4;
            kryptonButton8.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton8.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton8.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton8.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton8.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton8.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton8.TabIndex = 8;
            kryptonButton8.Values.Text = "";
            kryptonButton8.Click += saveBTN;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Dock = DockStyle.Right;
            kryptonButton1.Location = new Point(554, 0);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(41, 41);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton1.StateCommon.Back.Image = Properties.Resources.icons8_exit_96;
            kryptonButton1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton1.StateCommon.Border.Color1 = Color.White;
            kryptonButton1.StateCommon.Border.Color2 = Color.White;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 53F;
            kryptonButton1.StateCommon.Border.Width = 4;
            kryptonButton1.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton1.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton1.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton1.TabIndex = 13;
            kryptonButton1.Values.Text = "";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(215, 41);
            label2.TabIndex = 10;
            label2.Text = "Gerät bearbeiten";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 19;
            label1.Text = "Name:";
            // 
            // dvName
            // 
            dvName.CueHint.Color1 = Color.Gray;
            dvName.CueHint.CueHintText = "Gerätename eingeben";
            dvName.CueHint.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dvName.Location = new Point(118, 44);
            dvName.Name = "dvName";
            dvName.Size = new Size(469, 42);
            dvName.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            dvName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dvName.StateCommon.Border.Rounding = 15F;
            dvName.StateCommon.Border.Width = 4;
            dvName.StateCommon.Content.Color1 = Color.White;
            dvName.StateCommon.Content.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dvName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(127, 37);
            label3.TabIndex = 20;
            label3.Text = "Channel:";
            // 
            // dvChannel
            // 
            dvChannel.CornerRoundingRadius = 15F;
            dvChannel.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            dvChannel.Location = new Point(145, 92);
            dvChannel.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            dvChannel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            dvChannel.Name = "dvChannel";
            dvChannel.Size = new Size(442, 41);
            dvChannel.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            dvChannel.StateCommon.Border.Color1 = Color.White;
            dvChannel.StateCommon.Border.Color2 = Color.White;
            dvChannel.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dvChannel.StateCommon.Border.Rounding = 15F;
            dvChannel.StateCommon.Border.Width = 4;
            dvChannel.StateCommon.Content.Color1 = Color.White;
            dvChannel.StateCommon.Content.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dvChannel.TabIndex = 21;
            dvChannel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 139);
            label4.Name = "label4";
            label4.Size = new Size(114, 37);
            label4.TabIndex = 22;
            label4.Text = "Fixture:";
            // 
            // cmbFixture
            // 
            cmbFixture.CornerRoundingRadius = 15F;
            cmbFixture.DropDownWidth = 381;
            cmbFixture.IntegralHeight = false;
            cmbFixture.Location = new Point(132, 139);
            cmbFixture.Name = "cmbFixture";
            cmbFixture.Size = new Size(455, 41);
            cmbFixture.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(15, 15, 15);
            cmbFixture.StateCommon.ComboBox.Border.Color1 = Color.White;
            cmbFixture.StateCommon.ComboBox.Border.Color2 = Color.White;
            cmbFixture.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFixture.StateCommon.ComboBox.Border.Rounding = 15F;
            cmbFixture.StateCommon.ComboBox.Border.Width = 4;
            cmbFixture.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbFixture.StateCommon.ComboBox.Content.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFixture.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbFixture.StateCommon.DropBack.Color1 = Color.Black;
            cmbFixture.StateCommon.DropBack.Color2 = Color.Black;
            cmbFixture.StateCommon.Item.Back.Color1 = Color.FromArgb(15, 15, 15);
            cmbFixture.StateCommon.Item.Back.Color2 = Color.FromArgb(15, 15, 15);
            cmbFixture.StateCommon.Item.Border.Color1 = Color.White;
            cmbFixture.StateCommon.Item.Border.Color2 = Color.White;
            cmbFixture.StateCommon.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFixture.StateCommon.Item.Border.Rounding = 15F;
            cmbFixture.StateCommon.Item.Border.Width = 4;
            cmbFixture.StateCommon.Item.Content.ShortText.Color1 = Color.White;
            cmbFixture.StateCommon.Item.Content.ShortText.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFixture.TabIndex = 23;
            // 
            // DeviceEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(595, 193);
            CloseBox = false;
            Controls.Add(cmbFixture);
            Controls.Add(label4);
            Controls.Add(dvChannel);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dvName);
            Controls.Add(kryptonPanel1);
            CornerRoundingRadius = 15F;
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeviceEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.Black;
            StateCommon.Back.Color2 = Color.Black;
            StateCommon.Border.Color1 = Color.White;
            StateCommon.Border.Color2 = Color.White;
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 15F;
            StateCommon.Border.Width = 4;
            StateCommon.Header.Back.Color1 = Color.Black;
            StateCommon.Header.Back.Color2 = Color.Black;
            StateCommon.Header.Border.Color1 = Color.Black;
            StateCommon.Header.Border.Color2 = Color.Black;
            StateCommon.Header.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Header.Content.ShortText.Color1 = Color.White;
            StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StateCommon.Header.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Text = "tAG-DMX | Gerät bearbeiten";
            TopMost = true;
            Load += DeviceEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cmbFixture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButton8;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Label label2;
        private Label label1;
        private Krypton.Toolkit.KryptonTextBox dvName;
        private Label label3;
        private Krypton.Toolkit.KryptonNumericUpDown dvChannel;
        private Label label4;
        private Krypton.Toolkit.KryptonComboBox cmbFixture;
    }
}