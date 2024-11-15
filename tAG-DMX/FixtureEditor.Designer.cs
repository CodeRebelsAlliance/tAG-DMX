namespace tAG_DMX
{
    partial class FixtureEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixtureEditor));
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton8 = new Krypton.Toolkit.KryptonButton();
            kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            label2 = new Label();
            lstFixtures = new Krypton.Toolkit.KryptonListView();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonButton1);
            kryptonPanel1.Controls.Add(kryptonButton8);
            kryptonPanel1.Controls.Add(kryptonButton6);
            kryptonPanel1.Controls.Add(kryptonButton5);
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(978, 41);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel1.TabIndex = 3;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Dock = DockStyle.Right;
            kryptonButton1.Location = new Point(937, 0);
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
            // kryptonButton8
            // 
            kryptonButton8.Dock = DockStyle.Left;
            kryptonButton8.Location = new Point(250, 0);
            kryptonButton8.Name = "kryptonButton8";
            kryptonButton8.Size = new Size(41, 41);
            kryptonButton8.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton8.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton8.StateCommon.Back.Image = Properties.Resources.icons8_x_240;
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
            kryptonButton8.Click += RemoveFixtureButton_Click;
            // 
            // kryptonButton6
            // 
            kryptonButton6.Dock = DockStyle.Left;
            kryptonButton6.Location = new Point(209, 0);
            kryptonButton6.Name = "kryptonButton6";
            kryptonButton6.Size = new Size(41, 41);
            kryptonButton6.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton6.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton6.StateCommon.Back.Image = Properties.Resources.icons8_edit_96;
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
            kryptonButton6.TabIndex = 12;
            kryptonButton6.Values.Text = "";
            kryptonButton6.Click += EditFixtureButton_Click;
            // 
            // kryptonButton5
            // 
            kryptonButton5.Dock = DockStyle.Left;
            kryptonButton5.Location = new Point(168, 0);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.Size = new Size(41, 41);
            kryptonButton5.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton5.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton5.StateCommon.Back.Image = Properties.Resources.icons8_add_96;
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
            kryptonButton5.TabIndex = 11;
            kryptonButton5.Values.Text = "";
            kryptonButton5.Click += AddFixtureButton_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 41);
            label2.TabIndex = 10;
            label2.Text = "Fixtures";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstFixtures
            // 
            lstFixtures.BackColor = Color.Black;
            lstFixtures.Dock = DockStyle.Fill;
            lstFixtures.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstFixtures.ForeColor = Color.White;
            lstFixtures.GridLines = true;
            lstFixtures.ItemCornerRoundingRadius = 15F;
            lstFixtures.ItemStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            lstFixtures.Location = new Point(0, 41);
            lstFixtures.Name = "lstFixtures";
            lstFixtures.OwnerDraw = true;
            lstFixtures.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            lstFixtures.Size = new Size(978, 573);
            lstFixtures.StateCommon.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            lstFixtures.StateCommon.Item.Border.Rounding = 15F;
            lstFixtures.StateCommon.Item.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            lstFixtures.StateCommon.Item.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lstFixtures.StateCommon.Item.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lstFixtures.TabIndex = 4;
            lstFixtures.TileSize = new Size(248, 30);
            lstFixtures.View = View.SmallIcon;
            // 
            // FixtureEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(978, 614);
            CloseBox = false;
            Controls.Add(lstFixtures);
            Controls.Add(kryptonPanel1);
            CornerRoundingRadius = 15F;
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FixtureEditor";
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
            Text = "tAG-DMX | Fixture-Editor";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButton8;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Label label2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonListView lstFixtures;
    }
}