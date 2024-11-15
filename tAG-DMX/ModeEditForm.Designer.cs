using Krypton.Toolkit;
using System.Windows.Forms;

namespace tAG_DMX
{
    partial class ModeEditForm : KryptonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeEditForm));
            kryptonPanel1 = new KryptonPanel();
            kryptonButton8 = new KryptonButton();
            kryptonButton1 = new KryptonButton();
            label2 = new Label();
            kryptonPanel2 = new KryptonPanel();
            kryptonButton4 = new KryptonButton();
            kryptonButton3 = new KryptonButton();
            kryptonButton2 = new KryptonButton();
            label5 = new Label();
            lstChannels = new KryptonListView();
            label1 = new Label();
            txtModeName = new KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
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
            kryptonPanel1.Size = new Size(598, 41);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel1.TabIndex = 5;
            // 
            // kryptonButton8
            // 
            kryptonButton8.Dock = DockStyle.Right;
            kryptonButton8.Location = new Point(516, 0);
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
            kryptonButton1.Location = new Point(557, 0);
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
            label2.Text = "Modus bearbeiten";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonButton4);
            kryptonPanel2.Controls.Add(kryptonButton3);
            kryptonPanel2.Controls.Add(kryptonButton2);
            kryptonPanel2.Location = new Point(129, 359);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(458, 41);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel2.StateCommon.Color2 = Color.FromArgb(15, 15, 15);
            kryptonPanel2.TabIndex = 18;
            // 
            // kryptonButton4
            // 
            kryptonButton4.Dock = DockStyle.Left;
            kryptonButton4.Location = new Point(41, 0);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new Size(41, 41);
            kryptonButton4.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton4.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton4.StateCommon.Back.Image = Properties.Resources.icons8_edit_96;
            kryptonButton4.StateCommon.Back.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton4.StateCommon.Border.Color1 = Color.White;
            kryptonButton4.StateCommon.Border.Color2 = Color.White;
            kryptonButton4.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton4.StateCommon.Border.Rounding = 53F;
            kryptonButton4.StateCommon.Border.Width = 4;
            kryptonButton4.StateCommon.Content.LongText.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton4.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton4.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton4.StateCommon.Content.ShortText.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton4.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButton4.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButton4.TabIndex = 16;
            kryptonButton4.Values.Text = "";
            kryptonButton4.Click += btnEditChannel_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Dock = DockStyle.Left;
            kryptonButton3.Location = new Point(0, 0);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(41, 41);
            kryptonButton3.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton3.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton3.StateCommon.Back.Image = Properties.Resources.icons8_add_96;
            kryptonButton3.StateCommon.Back.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton3.StateCommon.Border.Color1 = Color.White;
            kryptonButton3.StateCommon.Border.Color2 = Color.White;
            kryptonButton3.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton3.StateCommon.Border.Rounding = 53F;
            kryptonButton3.StateCommon.Border.Width = 4;
            kryptonButton3.StateCommon.Content.LongText.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton3.StateCommon.Content.ShortText.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton3.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButton3.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButton3.TabIndex = 15;
            kryptonButton3.Values.Text = "";
            kryptonButton3.Click += btnAddChannel_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Dock = DockStyle.Right;
            kryptonButton2.Location = new Point(417, 0);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(41, 41);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton2.StateCommon.Back.Image = Properties.Resources.icons8_x_240;
            kryptonButton2.StateCommon.Back.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton2.StateCommon.Border.Color1 = Color.White;
            kryptonButton2.StateCommon.Border.Color2 = Color.White;
            kryptonButton2.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.Rounding = 53F;
            kryptonButton2.StateCommon.Border.Width = 4;
            kryptonButton2.StateCommon.Content.LongText.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton2.StateCommon.Content.ShortText.ImageStyle = PaletteImageStyle.Stretch;
            kryptonButton2.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButton2.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButton2.TabIndex = 14;
            kryptonButton2.Values.Text = "";
            kryptonButton2.Click += btnRemoveChannel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 92);
            label5.Name = "label5";
            label5.Size = new Size(111, 37);
            label5.TabIndex = 17;
            label5.Text = "Kanäle:";
            // 
            // lstChannels
            // 
            lstChannels.BackColor = Color.FromArgb(15, 15, 15);
            lstChannels.CornerRoundingRadius = 15F;
            lstChannels.ForeColor = Color.White;
            lstChannels.ItemCornerRoundingRadius = 15F;
            lstChannels.ItemStyle = ButtonStyle.ListItem;
            lstChannels.Location = new Point(129, 92);
            lstChannels.Name = "lstChannels";
            lstChannels.OwnerDraw = true;
            lstChannels.PaletteMode = PaletteMode.ProfessionalSystem;
            lstChannels.Size = new Size(458, 261);
            lstChannels.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            lstChannels.StateCommon.Border.Rounding = 15F;
            lstChannels.StateCommon.Item.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            lstChannels.StateCommon.Item.Border.Rounding = 15F;
            lstChannels.StateCommon.Item.Content.ShortText.MultiLine = InheritBool.True;
            lstChannels.StateCommon.Item.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
            lstChannels.StateCommon.Item.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            lstChannels.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 15;
            label1.Text = "Name:";
            // 
            // txtModeName
            // 
            txtModeName.CueHint.Color1 = Color.Gray;
            txtModeName.CueHint.CueHintText = "Modusnamen eingeben";
            txtModeName.CueHint.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtModeName.Location = new Point(118, 44);
            txtModeName.Name = "txtModeName";
            txtModeName.Size = new Size(469, 42);
            txtModeName.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            txtModeName.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtModeName.StateCommon.Border.Rounding = 15F;
            txtModeName.StateCommon.Border.Width = 4;
            txtModeName.StateCommon.Content.Color1 = Color.White;
            txtModeName.StateCommon.Content.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtModeName.TabIndex = 14;
            // 
            // ModeEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(598, 412);
            CloseBox = false;
            Controls.Add(kryptonPanel2);
            Controls.Add(label5);
            Controls.Add(lstChannels);
            Controls.Add(label1);
            Controls.Add(txtModeName);
            Controls.Add(kryptonPanel1);
            CornerRoundingRadius = 15F;
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModeEditForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
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
            StateCommon.Header.Content.ShortText.Color2 = Color.White;
            StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StateCommon.Header.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            Text = "tAG-DMX | Modus bearbeiten";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonPanel kryptonPanel1;
        private KryptonButton kryptonButton8;
        private KryptonButton kryptonButton1;
        private Label label2;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kryptonButton4;
        private KryptonButton kryptonButton3;
        private KryptonButton kryptonButton2;
        private Label label5;
        private KryptonListView lstChannels;
        private Label label1;
        private KryptonTextBox txtModeName;
    }
}