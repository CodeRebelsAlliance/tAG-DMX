namespace tAG_DMX
{
    partial class AddFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFunction));
            label1 = new Label();
            txtFNname = new Krypton.Toolkit.KryptonTextBox();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            label3 = new Label();
            kryptonButton8 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 20;
            label1.Text = "Name:";
            // 
            // txtFNname
            // 
            txtFNname.CueHint.Color1 = Color.Gray;
            txtFNname.CueHint.CueHintText = "Funktionsnamen eingeben";
            txtFNname.CueHint.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFNname.Location = new Point(118, 44);
            txtFNname.Name = "txtFNname";
            txtFNname.Size = new Size(469, 42);
            txtFNname.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            txtFNname.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFNname.StateCommon.Border.Rounding = 15F;
            txtFNname.StateCommon.Border.Width = 4;
            txtFNname.StateCommon.Content.Color1 = Color.White;
            txtFNname.StateCommon.Content.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFNname.TabIndex = 19;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(label3);
            kryptonPanel1.Controls.Add(kryptonButton8);
            kryptonPanel1.Controls.Add(kryptonButton1);
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(595, 41);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel1.TabIndex = 18;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(215, 0);
            label3.Name = "label3";
            label3.Size = new Size(298, 41);
            label3.TabIndex = 14;
            label3.Text = "Szene";
            label3.TextAlign = ContentAlignment.MiddleCenter;
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
            kryptonButton8.Click += kryptonButton8_Click;
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
            label2.Text = "Funktion erstellen";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddFunction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(595, 97);
            Controls.Add(label1);
            Controls.Add(txtFNname);
            Controls.Add(kryptonPanel1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddFunction";
            Text = "tAG-DMX | Funktion erstellen";
            Load += AddFunction_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Krypton.Toolkit.KryptonTextBox txtFNname;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label label3;
        private Krypton.Toolkit.KryptonButton kryptonButton8;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Label label2;
    }
}