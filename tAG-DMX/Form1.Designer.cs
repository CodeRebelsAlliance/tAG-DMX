namespace tAG_DMX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBoxPorts = new Krypton.Toolkit.KryptonComboBox();
            labelStatus = new Krypton.Toolkit.KryptonLabel();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            label1 = new Label();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)comboBoxPorts).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxPorts
            // 
            comboBoxPorts.CornerRoundingRadius = 30F;
            comboBoxPorts.DropDownWidth = 121;
            comboBoxPorts.IntegralHeight = false;
            comboBoxPorts.Location = new Point(12, 300);
            comboBoxPorts.Name = "comboBoxPorts";
            comboBoxPorts.Size = new Size(612, 67);
            comboBoxPorts.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(15, 15, 15);
            comboBoxPorts.StateCommon.ComboBox.Border.Color1 = Color.White;
            comboBoxPorts.StateCommon.ComboBox.Border.Color2 = Color.White;
            comboBoxPorts.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            comboBoxPorts.StateCommon.ComboBox.Border.Rounding = 30F;
            comboBoxPorts.StateCommon.ComboBox.Border.Width = 4;
            comboBoxPorts.StateCommon.ComboBox.Content.Color1 = Color.White;
            comboBoxPorts.StateCommon.ComboBox.Content.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPorts.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboBoxPorts.StateCommon.DropBack.Color1 = Color.Black;
            comboBoxPorts.StateCommon.DropBack.Color2 = Color.FromArgb(15, 15, 15);
            comboBoxPorts.StateCommon.DropBack.ColorAngle = 45F;
            comboBoxPorts.StateCommon.Item.Back.Color1 = Color.FromArgb(30, 30, 30);
            comboBoxPorts.StateCommon.Item.Back.Color2 = Color.FromArgb(30, 30, 30);
            comboBoxPorts.StateCommon.Item.Border.Color1 = Color.White;
            comboBoxPorts.StateCommon.Item.Border.Color2 = Color.White;
            comboBoxPorts.StateCommon.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            comboBoxPorts.StateCommon.Item.Border.Rounding = 15F;
            comboBoxPorts.StateCommon.Item.Border.Width = 2;
            comboBoxPorts.StateCommon.Item.Content.ShortText.Color1 = Color.White;
            comboBoxPorts.StateCommon.Item.Content.ShortText.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPorts.TabIndex = 0;
            comboBoxPorts.Text = "Wähle deinen DMX Adapter";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = false;
            labelStatus.Dock = DockStyle.Fill;
            labelStatus.Location = new Point(0, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(693, 50);
            labelStatus.StateCommon.ShortText.Color1 = Color.White;
            labelStatus.StateCommon.ShortText.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStatus.TabIndex = 1;
            labelStatus.Values.Text = "Warte auf Verbindung...";
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(630, 300);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(67, 67);
            kryptonButton3.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton3.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton3.StateCommon.Back.Image = Properties.Resources.icons8_refresh_240;
            kryptonButton3.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton3.StateCommon.Border.Color1 = Color.White;
            kryptonButton3.StateCommon.Border.Color2 = Color.White;
            kryptonButton3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton3.StateCommon.Border.Rounding = 53F;
            kryptonButton3.StateCommon.Border.Width = 4;
            kryptonButton3.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton3.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton3.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton3.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton3.TabIndex = 4;
            kryptonButton3.ToolTipValues.Description = "Lädt die Liste der DMX Adapter neu";
            kryptonButton3.ToolTipValues.EnableToolTips = true;
            kryptonButton3.ToolTipValues.Heading = "Geräteliste neu laden";
            kryptonButton3.ToolTipValues.Image = Properties.Resources.icons8_refresh_240;
            kryptonButton3.Values.Text = "";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // kryptonButton5
            // 
            kryptonButton5.Location = new Point(703, 300);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.Size = new Size(67, 67);
            kryptonButton5.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton5.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton5.StateCommon.Back.Image = Properties.Resources.icons8_check_240;
            kryptonButton5.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton5.StateCommon.Border.Color1 = Color.White;
            kryptonButton5.StateCommon.Border.Color2 = Color.White;
            kryptonButton5.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton5.StateCommon.Border.Rounding = 53F;
            kryptonButton5.StateCommon.Border.Width = 4;
            kryptonButton5.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton5.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton5.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton5.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton5.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton5.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton5.TabIndex = 6;
            kryptonButton5.ToolTipValues.Description = "Startet tAG-DMX";
            kryptonButton5.ToolTipValues.EnableToolTips = true;
            kryptonButton5.ToolTipValues.Heading = "Programm starten";
            kryptonButton5.ToolTipValues.Image = Properties.Resources.icons8_check_240;
            kryptonButton5.Values.Text = "";
            kryptonButton5.Click += buttonConnect_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(776, 300);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(67, 67);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton1.StateCommon.Back.Image = Properties.Resources.icons8_x_240;
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
            kryptonButton1.TabIndex = 7;
            kryptonButton1.ToolTipValues.Description = "Trennt die Verbindung zum DMX Adapter";
            kryptonButton1.ToolTipValues.EnableToolTips = true;
            kryptonButton1.ToolTipValues.Heading = "Trennen";
            kryptonButton1.ToolTipValues.Image = Properties.Resources.icons8_x_240;
            kryptonButton1.Values.Text = "";
            kryptonButton1.Click += buttonDisconnect_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Dock = DockStyle.Right;
            kryptonButton2.Location = new Point(793, 0);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(50, 50);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton2.StateCommon.Back.Image = Properties.Resources.icons8_exit_96;
            kryptonButton2.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton2.StateCommon.Border.Color1 = Color.White;
            kryptonButton2.StateCommon.Border.Color2 = Color.White;
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.Rounding = 53F;
            kryptonButton2.StateCommon.Border.Width = 4;
            kryptonButton2.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton2.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton2.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton2.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton2.TabIndex = 8;
            kryptonButton2.ToolTipValues.Description = "Beendet das Programm";
            kryptonButton2.ToolTipValues.EnableToolTips = true;
            kryptonButton2.ToolTipValues.Heading = "Beenden";
            kryptonButton2.ToolTipValues.Image = Properties.Resources.icons8_exit_96;
            kryptonButton2.Values.Text = "";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 15, 15);
            panel1.Controls.Add(labelStatus);
            panel1.Controls.Add(kryptonButton6);
            panel1.Controls.Add(kryptonButton4);
            panel1.Controls.Add(kryptonButton2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 373);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 50);
            panel1.TabIndex = 9;
            // 
            // kryptonButton6
            // 
            kryptonButton6.Dock = DockStyle.Right;
            kryptonButton6.Location = new Point(693, 0);
            kryptonButton6.Name = "kryptonButton6";
            kryptonButton6.Size = new Size(50, 50);
            kryptonButton6.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton6.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton6.StateCommon.Back.Image = Properties.Resources.icons8_software_installer_96;
            kryptonButton6.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton6.StateCommon.Border.Color1 = Color.White;
            kryptonButton6.StateCommon.Border.Color2 = Color.White;
            kryptonButton6.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton6.StateCommon.Border.Rounding = 53F;
            kryptonButton6.StateCommon.Border.Width = 4;
            kryptonButton6.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton6.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton6.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton6.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton6.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton6.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton6.TabIndex = 13;
            kryptonButton6.ToolTipValues.Description = "Installiert den Treiber für den ENTTEC DMX USB PRO Adapter";
            kryptonButton6.ToolTipValues.EnableToolTips = true;
            kryptonButton6.ToolTipValues.Heading = "Treiber installieren";
            kryptonButton6.ToolTipValues.Image = Properties.Resources.icons8_software_installer_96;
            kryptonButton6.Values.Text = "";
            kryptonButton6.Click += kryptonButton6_Click;
            // 
            // kryptonButton4
            // 
            kryptonButton4.Dock = DockStyle.Right;
            kryptonButton4.Location = new Point(743, 0);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new Size(50, 50);
            kryptonButton4.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton4.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton4.StateCommon.Back.Image = Properties.Resources.icons8_source_four_par_96;
            kryptonButton4.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton4.StateCommon.Border.Color1 = Color.White;
            kryptonButton4.StateCommon.Border.Color2 = Color.White;
            kryptonButton4.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton4.StateCommon.Border.Rounding = 53F;
            kryptonButton4.StateCommon.Border.Width = 4;
            kryptonButton4.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton4.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton4.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton4.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton4.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton4.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton4.TabIndex = 12;
            kryptonButton4.ToolTipValues.Description = "Öffnet den Fixture-Editor";
            kryptonButton4.ToolTipValues.EnableToolTips = true;
            kryptonButton4.ToolTipValues.Heading = "Fixture-Editor";
            kryptonButton4.ToolTipValues.Image = Properties.Resources.icons8_source_four_par_96;
            kryptonButton4.Values.Text = "";
            kryptonButton4.Click += kryptonButton4_Click_1;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Dock = DockStyle.Top;
            kryptonPictureBox1.Image = Properties.Resources.tAG_DMX_logo;
            kryptonPictureBox1.Location = new Point(0, 0);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(843, 194);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 10;
            kryptonPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 194);
            label1.Name = "label1";
            label1.Size = new Size(843, 30);
            label1.TabIndex = 11;
            label1.Text = "(c) TechnikAG 2024 - Version 0.1 ALPHA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 252);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(276, 42);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.Yellow;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 12;
            kryptonLabel1.Values.Text = "Starteinstellungen:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(843, 423);
            Controls.Add(kryptonLabel1);
            Controls.Add(label1);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(panel1);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonButton5);
            Controls.Add(kryptonButton3);
            Controls.Add(comboBoxPorts);
            CornerRoundingRadius = 15F;
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
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
            Text = "tAG-DMX | Verbinden";
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)comboBoxPorts).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox comboBoxPorts;
        private Krypton.Toolkit.KryptonLabel labelStatus;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Panel panel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Label label1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
    }
}
