using Krypton.Toolkit;
using System.Windows.Forms;

namespace tAG_DMX
{
    partial class ChannelEditForm : KryptonForm
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
            kryptonPanel1 = new KryptonPanel();
            kryptonButton8 = new KryptonButton();
            kryptonButton1 = new KryptonButton();
            label2 = new Label();
            label1 = new Label();
            txtChannelName = new KryptonTextBox();
            label3 = new Label();
            cmbChannelType = new KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbChannelType).BeginInit();
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
            kryptonPanel1.Size = new Size(592, 41);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel1.TabIndex = 6;
            // 
            // kryptonButton8
            // 
            kryptonButton8.Dock = DockStyle.Right;
            kryptonButton8.Location = new Point(510, 0);
            kryptonButton8.Name = "kryptonButton8";
            kryptonButton8.Size = new Size(41, 41);
            kryptonButton8.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton8.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton8.StateCommon.Back.Image = Properties.Resources.icons8_save_96;
            kryptonButton8.StateCommon.Back.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton8.StateCommon.Border.Color1 = Color.White;
            kryptonButton8.StateCommon.Border.Color2 = Color.White;
            kryptonButton8.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton8.StateCommon.Border.Rounding = 53F;
            kryptonButton8.StateCommon.Border.Width = 4;
            kryptonButton8.StateCommon.Content.LongText.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton8.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton8.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton8.StateCommon.Content.ShortText.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton8.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButton8.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButton8.TabIndex = 8;
            kryptonButton8.Values.Text = "";
            kryptonButton8.Click += btnSave_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Dock = DockStyle.Right;
            kryptonButton1.Location = new Point(551, 0);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(41, 41);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton1.StateCommon.Back.Image = Properties.Resources.icons8_exit_96;
            kryptonButton1.StateCommon.Back.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton1.StateCommon.Border.Color1 = Color.White;
            kryptonButton1.StateCommon.Border.Color2 = Color.White;
            kryptonButton1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 53F;
            kryptonButton1.StateCommon.Border.Width = 4;
            kryptonButton1.StateCommon.Content.LongText.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StateCommon.Content.ShortText.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton1.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButton1.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
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
            label2.Text = "Kanal bearbeiten";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 17;
            label1.Text = "Name:";
            // 
            // txtChannelName
            // 
            txtChannelName.CueHint.Color1 = Color.Gray;
            txtChannelName.CueHint.CueHintText = "Kanalnamen eingeben";
            txtChannelName.CueHint.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChannelName.Location = new Point(118, 44);
            txtChannelName.Name = "txtChannelName";
            txtChannelName.Size = new Size(469, 42);
            txtChannelName.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            txtChannelName.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtChannelName.StateCommon.Border.Rounding = 15F;
            txtChannelName.StateCommon.Border.Width = 4;
            txtChannelName.StateCommon.Content.Color1 = Color.White;
            txtChannelName.StateCommon.Content.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChannelName.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(71, 37);
            label3.TabIndex = 19;
            label3.Text = "Typ:";
            // 
            // cmbChannelType
            // 
            cmbChannelType.AutoCompleteCustomSource.AddRange(new string[] { "Intensität", "Rot", "Grün", "Blau", "Weiß", "Amber", "UV", "Hellblau", "Lila", "Prisma", "Fokus", "Strobo", "Geschwindigkeit", "Farbmakro", "Pan", "Pan Fine", "Tilt", "Tilt Fine", "Einstellungen", "Gobo", "Farbrad", "Benutzerdefiniert" });
            cmbChannelType.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbChannelType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbChannelType.CornerRoundingRadius = 15F;
            cmbChannelType.DropDownWidth = 381;
            cmbChannelType.IntegralHeight = false;
            cmbChannelType.Items.AddRange(new object[] { "Intensität", "Rot", "Grün", "Blau", "Weiß", "Amber", "UV", "Hellblau", "Lila", "Prisma", "Fokus", "Strobo", "Geschwindigkeit", "Farbmakro", "Pan", "Pan Fine", "Tilt", "Tilt Fine", "Einstellungen", "Gobo", "Farbrad", "Benutzerdefiniert" });
            cmbChannelType.Location = new Point(89, 94);
            cmbChannelType.Name = "cmbChannelType";
            cmbChannelType.Size = new Size(498, 41);
            cmbChannelType.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(15, 15, 15);
            cmbChannelType.StateCommon.ComboBox.Border.Color1 = Color.White;
            cmbChannelType.StateCommon.ComboBox.Border.Color2 = Color.White;
            cmbChannelType.StateCommon.ComboBox.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbChannelType.StateCommon.ComboBox.Border.Rounding = 15F;
            cmbChannelType.StateCommon.ComboBox.Border.Width = 4;
            cmbChannelType.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbChannelType.StateCommon.ComboBox.Content.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbChannelType.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            cmbChannelType.StateCommon.DropBack.Color1 = Color.Black;
            cmbChannelType.StateCommon.DropBack.Color2 = Color.Black;
            cmbChannelType.StateCommon.Item.Back.Color1 = Color.FromArgb(15, 15, 15);
            cmbChannelType.StateCommon.Item.Back.Color2 = Color.FromArgb(15, 15, 15);
            cmbChannelType.StateCommon.Item.Border.Color1 = Color.White;
            cmbChannelType.StateCommon.Item.Border.Color2 = Color.White;
            cmbChannelType.StateCommon.Item.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbChannelType.StateCommon.Item.Border.Rounding = 15F;
            cmbChannelType.StateCommon.Item.Border.Width = 4;
            cmbChannelType.StateCommon.Item.Content.ShortText.Color1 = Color.White;
            cmbChannelType.StateCommon.Item.Content.ShortText.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbChannelType.TabIndex = 20;
            cmbChannelType.Text = "Intensität";
            // 
            // ChannelEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(592, 152);
            CloseBox = false;
            Controls.Add(cmbChannelType);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtChannelName);
            Controls.Add(kryptonPanel1);
            CornerRoundingRadius = 15F;
            ForeColor = Color.White;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChannelEditForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StateCommon.Back.Color1 = Color.Black;
            StateCommon.Back.Color2 = Color.Black;
            StateCommon.Border.Color1 = Color.White;
            StateCommon.Border.Color2 = Color.White;
            StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 15F;
            StateCommon.Border.Width = 4;
            StateCommon.Header.Back.Color1 = Color.Black;
            StateCommon.Header.Back.Color2 = Color.Black;
            StateCommon.Header.Border.Color1 = Color.Black;
            StateCommon.Header.Border.Color2 = Color.Black;
            StateCommon.Header.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            StateCommon.Header.Content.ShortText.Color1 = Color.White;
            StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StateCommon.Header.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            Text = "tAG-DMX | Kanal bearbeiten";
            TopMost = true;
            Load += ChannelEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cmbChannelType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonPanel kryptonPanel1;
        private KryptonButton kryptonButton8;
        private KryptonButton kryptonButton1;
        private Label label2;
        private Label label1;
        private KryptonTextBox txtChannelName;
        private Label label3;
        private KryptonComboBox cmbChannelType;
    }
}