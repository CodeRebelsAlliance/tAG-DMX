namespace tAG_DMX
{
    partial class DMXmain
    {
        private System.ComponentModel.IContainer components = null;
        private Krypton.Docking.KryptonDockingWorkspace kryptonDockingWorkspace1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMXmain));
            tabControl1 = new TabControl();
            fixturesPage = new TabPage();
            devicesPanel = new FlowLayoutPanel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonButton8 = new Krypton.Toolkit.KryptonButton();
            kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            label2 = new Label();
            fixtureMatrixViewPage = new TabPage();
            functionsPage = new TabPage();
            functionsPanel = new FlowLayoutPanel();
            functionsEditPanel = new Krypton.Toolkit.KryptonPanel();
            functionEditPanel = new Panel();
            kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            kryptonButton17 = new Krypton.Toolkit.KryptonButton();
            kryptonButton16 = new Krypton.Toolkit.KryptonButton();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            txtFunctionName = new Krypton.Toolkit.KryptonTextBox();
            functionSave = new Krypton.Toolkit.KryptonButton();
            label4 = new Label();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            kryptonButton15 = new Krypton.Toolkit.KryptonButton();
            kryptonButton14 = new Krypton.Toolkit.KryptonButton();
            kryptonButton13 = new Krypton.Toolkit.KryptonButton();
            kryptonButton12 = new Krypton.Toolkit.KryptonButton();
            kryptonButton11 = new Krypton.Toolkit.KryptonButton();
            kryptonButton7 = new Krypton.Toolkit.KryptonButton();
            kryptonButton9 = new Krypton.Toolkit.KryptonButton();
            kryptonButton10 = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            simpledeskPage = new TabPage();
            sliderPanel = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            livemodePage = new TabPage();
            setupPage = new TabPage();
            kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            openButton = new ToolStripButton();
            saveButton = new ToolStripButton();
            saveasButton = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            trayIcon = new NotifyIcon(components);
            tabControl1.SuspendLayout();
            fixturesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            functionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)functionsEditPanel).BeginInit();
            functionsEditPanel.SuspendLayout();
            functionEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel6).BeginInit();
            kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            simpledeskPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sliderPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            kryptonToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(fixturesPage);
            tabControl1.Controls.Add(fixtureMatrixViewPage);
            tabControl1.Controls.Add(functionsPage);
            tabControl1.Controls.Add(simpledeskPage);
            tabControl1.Controls.Add(livemodePage);
            tabControl1.Controls.Add(setupPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 40);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1720, 924);
            tabControl1.TabIndex = 0;
            // 
            // fixturesPage
            // 
            fixturesPage.BackColor = Color.Black;
            fixturesPage.Controls.Add(devicesPanel);
            fixturesPage.Controls.Add(kryptonPanel1);
            fixturesPage.Location = new Point(4, 4);
            fixturesPage.Name = "fixturesPage";
            fixturesPage.Padding = new Padding(3);
            fixturesPage.Size = new Size(1712, 890);
            fixturesPage.TabIndex = 0;
            fixturesPage.Text = "Geräte";
            // 
            // devicesPanel
            // 
            devicesPanel.Dock = DockStyle.Fill;
            devicesPanel.Location = new Point(3, 44);
            devicesPanel.Name = "devicesPanel";
            devicesPanel.Size = new Size(1706, 843);
            devicesPanel.TabIndex = 3;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonButton8);
            kryptonPanel1.Controls.Add(kryptonButton6);
            kryptonPanel1.Controls.Add(kryptonButton5);
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(3, 3);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1706, 41);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel1.TabIndex = 2;
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
            kryptonButton8.Click += RemoveDVButton_Click;
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
            kryptonButton6.Click += EditDVButton_Click;
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
            kryptonButton5.Click += AddDVButton_Click;
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
            label2.Text = "Geräte";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fixtureMatrixViewPage
            // 
            fixtureMatrixViewPage.BackColor = Color.Black;
            fixtureMatrixViewPage.Location = new Point(4, 4);
            fixtureMatrixViewPage.Name = "fixtureMatrixViewPage";
            fixtureMatrixViewPage.Size = new Size(1712, 890);
            fixtureMatrixViewPage.TabIndex = 4;
            fixtureMatrixViewPage.Text = "Fixture-Matrix";
            // 
            // functionsPage
            // 
            functionsPage.BackColor = Color.Black;
            functionsPage.Controls.Add(functionsPanel);
            functionsPage.Controls.Add(functionsEditPanel);
            functionsPage.Controls.Add(kryptonPanel3);
            functionsPage.Location = new Point(4, 4);
            functionsPage.Name = "functionsPage";
            functionsPage.Size = new Size(1712, 890);
            functionsPage.TabIndex = 5;
            functionsPage.Text = "Funktionen";
            // 
            // functionsPanel
            // 
            functionsPanel.Dock = DockStyle.Fill;
            functionsPanel.Location = new Point(0, 41);
            functionsPanel.Name = "functionsPanel";
            functionsPanel.Size = new Size(1712, 483);
            functionsPanel.TabIndex = 5;
            // 
            // functionsEditPanel
            // 
            functionsEditPanel.Controls.Add(functionEditPanel);
            functionsEditPanel.Controls.Add(kryptonPanel5);
            functionsEditPanel.Dock = DockStyle.Bottom;
            functionsEditPanel.Location = new Point(0, 524);
            functionsEditPanel.Name = "functionsEditPanel";
            functionsEditPanel.Size = new Size(1712, 366);
            functionsEditPanel.StateCommon.Color1 = Color.Black;
            functionsEditPanel.TabIndex = 4;
            functionsEditPanel.Visible = false;
            // 
            // functionEditPanel
            // 
            functionEditPanel.Controls.Add(kryptonPanel6);
            functionEditPanel.Dock = DockStyle.Fill;
            functionEditPanel.Location = new Point(0, 41);
            functionEditPanel.Name = "functionEditPanel";
            functionEditPanel.Size = new Size(1712, 325);
            functionEditPanel.TabIndex = 5;
            functionEditPanel.Paint += functionEditPanel_Paint;
            // 
            // kryptonPanel6
            // 
            kryptonPanel6.Controls.Add(kryptonButton17);
            kryptonPanel6.Controls.Add(kryptonButton16);
            kryptonPanel6.Dock = DockStyle.Left;
            kryptonPanel6.Location = new Point(0, 0);
            kryptonPanel6.Name = "kryptonPanel6";
            kryptonPanel6.Size = new Size(41, 325);
            kryptonPanel6.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel6.TabIndex = 5;
            kryptonPanel6.Paint += kryptonPanel6_Paint;
            // 
            // kryptonButton17
            // 
            kryptonButton17.Dock = DockStyle.Top;
            kryptonButton17.Location = new Point(0, 41);
            kryptonButton17.Name = "kryptonButton17";
            kryptonButton17.Size = new Size(41, 41);
            kryptonButton17.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton17.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton17.StateCommon.Back.Image = Properties.Resources.icons8_x_240;
            kryptonButton17.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton17.StateCommon.Border.Color1 = Color.White;
            kryptonButton17.StateCommon.Border.Color2 = Color.White;
            kryptonButton17.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton17.StateCommon.Border.Rounding = 53F;
            kryptonButton17.StateCommon.Border.Width = 4;
            kryptonButton17.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton17.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton17.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton17.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton17.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton17.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton17.TabIndex = 16;
            kryptonButton17.ToolTipValues.Description = "Erstellt eine Integration mit SongRequest und LocalSend, die für einen automatischen Musikmodus genutzt wird.";
            kryptonButton17.ToolTipValues.EnableToolTips = true;
            kryptonButton17.ToolTipValues.Heading = "Musikmodus erstellen";
            kryptonButton17.Values.Text = "";
            // 
            // kryptonButton16
            // 
            kryptonButton16.Dock = DockStyle.Top;
            kryptonButton16.Location = new Point(0, 0);
            kryptonButton16.Name = "kryptonButton16";
            kryptonButton16.Size = new Size(41, 41);
            kryptonButton16.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton16.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton16.StateCommon.Back.Image = Properties.Resources.icons8_add_96;
            kryptonButton16.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton16.StateCommon.Border.Color1 = Color.White;
            kryptonButton16.StateCommon.Border.Color2 = Color.White;
            kryptonButton16.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton16.StateCommon.Border.Rounding = 53F;
            kryptonButton16.StateCommon.Border.Width = 4;
            kryptonButton16.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton16.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton16.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton16.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton16.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton16.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton16.TabIndex = 15;
            kryptonButton16.ToolTipValues.Description = "Erstellt eine Integration mit SongRequest und LocalSend, die für einen automatischen Musikmodus genutzt wird.";
            kryptonButton16.ToolTipValues.EnableToolTips = true;
            kryptonButton16.ToolTipValues.Heading = "Musikmodus erstellen";
            kryptonButton16.Values.Text = "";
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Controls.Add(txtFunctionName);
            kryptonPanel5.Controls.Add(functionSave);
            kryptonPanel5.Controls.Add(label4);
            kryptonPanel5.Dock = DockStyle.Top;
            kryptonPanel5.Location = new Point(0, 0);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.Size = new Size(1712, 41);
            kryptonPanel5.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel5.TabIndex = 4;
            // 
            // txtFunctionName
            // 
            txtFunctionName.CueHint.Color1 = Color.Gray;
            txtFunctionName.CueHint.CueHintText = "Funktionsnamen eingeben";
            txtFunctionName.CueHint.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFunctionName.Dock = DockStyle.Right;
            txtFunctionName.Location = new Point(1202, 0);
            txtFunctionName.Name = "txtFunctionName";
            txtFunctionName.Size = new Size(469, 42);
            txtFunctionName.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            txtFunctionName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFunctionName.StateCommon.Border.Rounding = 15F;
            txtFunctionName.StateCommon.Border.Width = 4;
            txtFunctionName.StateCommon.Content.Color1 = Color.White;
            txtFunctionName.StateCommon.Content.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFunctionName.TabIndex = 17;
            txtFunctionName.TextChanged += txtFunctionName_TextChanged;
            // 
            // functionSave
            // 
            functionSave.Dock = DockStyle.Right;
            functionSave.Location = new Point(1671, 0);
            functionSave.Name = "functionSave";
            functionSave.Size = new Size(41, 41);
            functionSave.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            functionSave.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            functionSave.StateCommon.Back.Image = Properties.Resources.icons8_save_96;
            functionSave.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            functionSave.StateCommon.Border.Color1 = Color.White;
            functionSave.StateCommon.Border.Color2 = Color.White;
            functionSave.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            functionSave.StateCommon.Border.Rounding = 53F;
            functionSave.StateCommon.Border.Width = 4;
            functionSave.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            functionSave.StateCommon.Content.ShortText.Color1 = Color.White;
            functionSave.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            functionSave.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            functionSave.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            functionSave.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            functionSave.TabIndex = 18;
            functionSave.ToolTipValues.Description = "Speichert die Funktion";
            functionSave.ToolTipValues.EnableToolTips = true;
            functionSave.ToolTipValues.Heading = "Speichern";
            functionSave.Values.Text = "";
            functionSave.Click += functionSave_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(224, 41);
            label4.TabIndex = 10;
            label4.Text = "Funktion bearbeiten";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(kryptonButton15);
            kryptonPanel3.Controls.Add(kryptonButton14);
            kryptonPanel3.Controls.Add(kryptonButton13);
            kryptonPanel3.Controls.Add(kryptonButton12);
            kryptonPanel3.Controls.Add(kryptonButton11);
            kryptonPanel3.Controls.Add(kryptonButton7);
            kryptonPanel3.Controls.Add(kryptonButton9);
            kryptonPanel3.Controls.Add(kryptonButton10);
            kryptonPanel3.Controls.Add(label3);
            kryptonPanel3.Dock = DockStyle.Top;
            kryptonPanel3.Location = new Point(0, 0);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(1712, 41);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel3.TabIndex = 3;
            // 
            // kryptonButton15
            // 
            kryptonButton15.Dock = DockStyle.Right;
            kryptonButton15.Location = new Point(1589, 0);
            kryptonButton15.Name = "kryptonButton15";
            kryptonButton15.Size = new Size(41, 41);
            kryptonButton15.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton15.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton15.StateCommon.Back.Image = Properties.Resources.icons8_eye_96;
            kryptonButton15.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton15.StateCommon.Border.Color1 = Color.White;
            kryptonButton15.StateCommon.Border.Color2 = Color.White;
            kryptonButton15.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton15.StateCommon.Border.Rounding = 53F;
            kryptonButton15.StateCommon.Border.Width = 4;
            kryptonButton15.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton15.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton15.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton15.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton15.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton15.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton15.TabIndex = 17;
            kryptonButton15.ToolTipValues.Description = "Schaltet um, ob während der Bearbeitung von Funktionen die Änderungen LIVE über DMX ausgegeben werden sollen.";
            kryptonButton15.ToolTipValues.EnableToolTips = true;
            kryptonButton15.ToolTipValues.Heading = "Vorschau umschalten";
            kryptonButton15.Values.Text = "";
            // 
            // kryptonButton14
            // 
            kryptonButton14.Dock = DockStyle.Right;
            kryptonButton14.Location = new Point(1630, 0);
            kryptonButton14.Name = "kryptonButton14";
            kryptonButton14.Size = new Size(41, 41);
            kryptonButton14.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton14.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton14.StateCommon.Back.Image = Properties.Resources.icons8_edit_96;
            kryptonButton14.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton14.StateCommon.Border.Color1 = Color.White;
            kryptonButton14.StateCommon.Border.Color2 = Color.White;
            kryptonButton14.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton14.StateCommon.Border.Rounding = 53F;
            kryptonButton14.StateCommon.Border.Width = 4;
            kryptonButton14.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton14.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton14.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton14.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton14.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton14.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton14.TabIndex = 16;
            kryptonButton14.ToolTipValues.Description = "Öffnet das Bearbeitungsfenster";
            kryptonButton14.ToolTipValues.EnableToolTips = true;
            kryptonButton14.ToolTipValues.Heading = "Funktion bearbeiten";
            kryptonButton14.Values.Text = " ";
            // 
            // kryptonButton13
            // 
            kryptonButton13.Dock = DockStyle.Right;
            kryptonButton13.Location = new Point(1671, 0);
            kryptonButton13.Name = "kryptonButton13";
            kryptonButton13.Size = new Size(41, 41);
            kryptonButton13.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton13.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton13.StateCommon.Back.Image = Properties.Resources.icons8_x_240;
            kryptonButton13.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton13.StateCommon.Border.Color1 = Color.White;
            kryptonButton13.StateCommon.Border.Color2 = Color.White;
            kryptonButton13.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton13.StateCommon.Border.Rounding = 53F;
            kryptonButton13.StateCommon.Border.Width = 4;
            kryptonButton13.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton13.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton13.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton13.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton13.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton13.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton13.TabIndex = 15;
            kryptonButton13.ToolTipValues.Description = "Löscht die aktuell ausgewählte Funktion";
            kryptonButton13.ToolTipValues.Heading = "Löschen";
            kryptonButton13.Values.Text = "";
            // 
            // kryptonButton12
            // 
            kryptonButton12.Dock = DockStyle.Left;
            kryptonButton12.Location = new Point(332, 0);
            kryptonButton12.Name = "kryptonButton12";
            kryptonButton12.Size = new Size(41, 41);
            kryptonButton12.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton12.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton12.StateCommon.Back.Image = Properties.Resources.icons8_radio_waves_96;
            kryptonButton12.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton12.StateCommon.Border.Color1 = Color.White;
            kryptonButton12.StateCommon.Border.Color2 = Color.White;
            kryptonButton12.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton12.StateCommon.Border.Rounding = 53F;
            kryptonButton12.StateCommon.Border.Width = 4;
            kryptonButton12.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton12.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton12.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton12.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton12.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton12.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton12.TabIndex = 14;
            kryptonButton12.ToolTipValues.Description = "Erstellt eine Integration mit SongRequest und LocalSend, die für einen automatischen Musikmodus genutzt wird.";
            kryptonButton12.ToolTipValues.EnableToolTips = true;
            kryptonButton12.ToolTipValues.Heading = "Musikmodus erstellen";
            kryptonButton12.Values.Text = "";
            kryptonButton12.Click += kryptonButton12_Click;
            // 
            // kryptonButton11
            // 
            kryptonButton11.Dock = DockStyle.Left;
            kryptonButton11.Location = new Point(291, 0);
            kryptonButton11.Name = "kryptonButton11";
            kryptonButton11.Size = new Size(41, 41);
            kryptonButton11.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton11.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton11.StateCommon.Back.Image = Properties.Resources.icons8_data_matrix_code_96;
            kryptonButton11.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton11.StateCommon.Border.Color1 = Color.White;
            kryptonButton11.StateCommon.Border.Color2 = Color.White;
            kryptonButton11.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton11.StateCommon.Border.Rounding = 53F;
            kryptonButton11.StateCommon.Border.Width = 4;
            kryptonButton11.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton11.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton11.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton11.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton11.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton11.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton11.TabIndex = 13;
            kryptonButton11.ToolTipValues.Description = "Erstellt eine RGB-Matrix, die für Farbübergänge und Farbmuster genutzt werden";
            kryptonButton11.ToolTipValues.EnableToolTips = true;
            kryptonButton11.ToolTipValues.Heading = "RGB Matrix erstellen";
            kryptonButton11.Values.Text = "";
            kryptonButton11.Click += kryptonButton11_Click;
            // 
            // kryptonButton7
            // 
            kryptonButton7.Dock = DockStyle.Left;
            kryptonButton7.Location = new Point(250, 0);
            kryptonButton7.Name = "kryptonButton7";
            kryptonButton7.Size = new Size(41, 41);
            kryptonButton7.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton7.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton7.StateCommon.Back.Image = Properties.Resources.icons8_effect_96;
            kryptonButton7.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton7.StateCommon.Border.Color1 = Color.White;
            kryptonButton7.StateCommon.Border.Color2 = Color.White;
            kryptonButton7.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton7.StateCommon.Border.Rounding = 53F;
            kryptonButton7.StateCommon.Border.Width = 4;
            kryptonButton7.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton7.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton7.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton7.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton7.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton7.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton7.TabIndex = 8;
            kryptonButton7.ToolTipValues.Description = "Erstellt einen Effekt, der für Moving Head Bewegungen genutzt wird.";
            kryptonButton7.ToolTipValues.EnableToolTips = true;
            kryptonButton7.ToolTipValues.Heading = "Effekt erstellen";
            kryptonButton7.Values.Text = "";
            kryptonButton7.Click += kryptonButton7_Click;
            // 
            // kryptonButton9
            // 
            kryptonButton9.Dock = DockStyle.Left;
            kryptonButton9.Location = new Point(209, 0);
            kryptonButton9.Name = "kryptonButton9";
            kryptonButton9.Size = new Size(41, 41);
            kryptonButton9.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton9.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton9.StateCommon.Back.Image = Properties.Resources.icons8_rgb_histogram_96;
            kryptonButton9.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton9.StateCommon.Border.Color1 = Color.White;
            kryptonButton9.StateCommon.Border.Color2 = Color.White;
            kryptonButton9.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton9.StateCommon.Border.Rounding = 53F;
            kryptonButton9.StateCommon.Border.Width = 4;
            kryptonButton9.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton9.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton9.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton9.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton9.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton9.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton9.TabIndex = 12;
            kryptonButton9.ToolTipValues.Description = "Erstellt einen Chaser, womit Zeitabläufe erstellt werden können.";
            kryptonButton9.ToolTipValues.EnableToolTips = true;
            kryptonButton9.ToolTipValues.Heading = "Chaser erstellen";
            kryptonButton9.Values.Text = "";
            kryptonButton9.Click += kryptonButton9_Click;
            // 
            // kryptonButton10
            // 
            kryptonButton10.Dock = DockStyle.Left;
            kryptonButton10.Location = new Point(168, 0);
            kryptonButton10.Name = "kryptonButton10";
            kryptonButton10.Size = new Size(41, 41);
            kryptonButton10.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton10.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton10.StateCommon.Back.Image = Properties.Resources.icons8_scene_96;
            kryptonButton10.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton10.StateCommon.Border.Color1 = Color.White;
            kryptonButton10.StateCommon.Border.Color2 = Color.White;
            kryptonButton10.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton10.StateCommon.Border.Rounding = 53F;
            kryptonButton10.StateCommon.Border.Width = 4;
            kryptonButton10.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton10.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton10.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton10.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton10.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton10.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonButton10.TabIndex = 11;
            kryptonButton10.ToolTipValues.Description = "Erstellt eine Szene, in der ein statischer Stand erstellt wird.";
            kryptonButton10.ToolTipValues.EnableToolTips = true;
            kryptonButton10.ToolTipValues.Heading = "Szene erstellen";
            kryptonButton10.Values.Text = "";
            kryptonButton10.Click += kryptonButton10_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 41);
            label3.TabIndex = 10;
            label3.Text = "Funktionen";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // simpledeskPage
            // 
            simpledeskPage.BackColor = Color.Black;
            simpledeskPage.Controls.Add(sliderPanel);
            simpledeskPage.Controls.Add(kryptonPanel2);
            simpledeskPage.Location = new Point(4, 4);
            simpledeskPage.Name = "simpledeskPage";
            simpledeskPage.Padding = new Padding(3);
            simpledeskPage.Size = new Size(1712, 890);
            simpledeskPage.TabIndex = 1;
            simpledeskPage.Text = "Einfache Arbeitsfläche";
            // 
            // sliderPanel
            // 
            sliderPanel.AutoScroll = true;
            sliderPanel.Dock = DockStyle.Fill;
            sliderPanel.Location = new Point(3, 44);
            sliderPanel.Name = "sliderPanel";
            sliderPanel.Size = new Size(1706, 843);
            sliderPanel.StateCommon.Color1 = Color.Black;
            sliderPanel.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonButton4);
            kryptonPanel2.Controls.Add(kryptonButton3);
            kryptonPanel2.Controls.Add(label1);
            kryptonPanel2.Controls.Add(kryptonButton2);
            kryptonPanel2.Controls.Add(kryptonButton1);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(3, 3);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1706, 41);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel2.TabIndex = 1;
            // 
            // kryptonButton4
            // 
            kryptonButton4.Dock = DockStyle.Right;
            kryptonButton4.Location = new Point(1542, 0);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new Size(41, 41);
            kryptonButton4.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton4.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton4.StateCommon.Back.Image = Properties.Resources.icons8_export_96;
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
            kryptonButton4.Values.Text = "";
            // 
            // kryptonButton3
            // 
            kryptonButton3.Dock = DockStyle.Right;
            kryptonButton3.Location = new Point(1583, 0);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(41, 41);
            kryptonButton3.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton3.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton3.StateCommon.Back.Image = Properties.Resources.icons8_group_by_96;
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
            kryptonButton3.TabIndex = 11;
            kryptonButton3.Values.Text = "";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(291, 41);
            label1.TabIndex = 10;
            label1.Text = "Universum 1: Kanäle 1-512";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Dock = DockStyle.Right;
            kryptonButton2.Location = new Point(1624, 0);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(41, 41);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton2.StateCommon.Back.Image = Properties.Resources.icons8_pause_96;
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
            kryptonButton2.TabIndex = 9;
            kryptonButton2.Values.Text = "";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Dock = DockStyle.Right;
            kryptonButton1.Location = new Point(1665, 0);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(41, 41);
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
            kryptonButton1.TabIndex = 8;
            kryptonButton1.Values.Text = "";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // livemodePage
            // 
            livemodePage.BackColor = Color.Black;
            livemodePage.Location = new Point(4, 4);
            livemodePage.Name = "livemodePage";
            livemodePage.Size = new Size(1712, 890);
            livemodePage.TabIndex = 2;
            livemodePage.Text = "Performance";
            // 
            // setupPage
            // 
            setupPage.BackColor = Color.Black;
            setupPage.Location = new Point(4, 4);
            setupPage.Name = "setupPage";
            setupPage.Size = new Size(1712, 890);
            setupPage.TabIndex = 3;
            setupPage.Text = "Konfiguration";
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.BackColor = Color.FromArgb(15, 15, 15);
            kryptonToolStrip1.Font = new Font("Segoe UI", 9F);
            kryptonToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            kryptonToolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, openButton, saveButton, saveasButton, toolStripButton1, toolStripButton2, toolStripButton3 });
            kryptonToolStrip1.Location = new Point(0, 0);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.RenderMode = ToolStripRenderMode.System;
            kryptonToolStrip1.Size = new Size(1720, 40);
            kryptonToolStrip1.TabIndex = 1;
            kryptonToolStrip1.Text = "kryptonToolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(207, 37);
            toolStripLabel1.Text = "tAG-DMX v0.1";
            // 
            // openButton
            // 
            openButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openButton.Image = Properties.Resources.icons8_opened_folder_240;
            openButton.ImageTransparentColor = Color.Magenta;
            openButton.Name = "openButton";
            openButton.Size = new Size(83, 37);
            openButton.Text = "Öffnen";
            openButton.Click += OpenButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.Image = Properties.Resources.icons8_save_96;
            saveButton.ImageTransparentColor = Color.Magenta;
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(106, 37);
            saveButton.Text = "Speichern";
            saveButton.Click += SaveButton_Click;
            // 
            // saveasButton
            // 
            saveasButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveasButton.Image = Properties.Resources.icons8_save_as_96;
            saveasButton.ImageTransparentColor = Color.Magenta;
            saveasButton.Name = "saveasButton";
            saveasButton.Size = new Size(151, 37);
            saveasButton.Text = "Speichern unter";
            saveasButton.Click += SaveAsButton_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton1.Image = Properties.Resources.icons8_new_window_96;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(62, 37);
            toolStripButton1.Text = "Neu";
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton2.Image = Properties.Resources.icons8_exit_96;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(97, 37);
            toolStripButton2.Text = "Beenden";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton3.Image = Properties.Resources.icons8_settings_240;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(135, 37);
            toolStripButton3.Text = "Einstellungen";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Black;
            statusStrip1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusStrip1.Location = new Point(0, 964);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1720, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // trayIcon
            // 
            trayIcon.Text = "tAG-DMX";
            trayIcon.Visible = true;
            // 
            // DMXmain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1720, 986);
            CloseBox = false;
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(kryptonToolStrip1);
            CornerRoundingRadius = 15F;
            DoubleBuffered = true;
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "DMXmain";
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
            Text = "tAG-DMX | Geräte";
            WindowState = FormWindowState.Maximized;
            Load += DMXmain_Load;
            tabControl1.ResumeLayout(false);
            fixturesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            functionsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)functionsEditPanel).EndInit();
            functionsEditPanel.ResumeLayout(false);
            functionEditPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel6).EndInit();
            kryptonPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            kryptonPanel5.ResumeLayout(false);
            kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            simpledeskPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sliderPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonToolStrip1.ResumeLayout(false);
            kryptonToolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TabControl tabControl1;
        private TabPage fixturesPage;
        private TabPage simpledeskPage;
        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton openButton;
        private ToolStripButton saveButton;
        private ToolStripButton saveasButton;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private StatusStrip statusStrip1;
        private TabPage livemodePage;
        private TabPage setupPage;
        private NotifyIcon trayIcon;
        private Krypton.Toolkit.KryptonPanel sliderPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Label label1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Label label2;
        private Krypton.Toolkit.KryptonButton kryptonButton8;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private FlowLayoutPanel devicesPanel;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private TabPage fixtureMatrixViewPage;
        private TabPage functionsPage;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonButton kryptonButton13;
        private Krypton.Toolkit.KryptonButton kryptonButton12;
        private Krypton.Toolkit.KryptonButton kryptonButton11;
        private Krypton.Toolkit.KryptonButton kryptonButton7;
        private Krypton.Toolkit.KryptonButton kryptonButton9;
        private Krypton.Toolkit.KryptonButton kryptonButton10;
        private Label label3;
        private Krypton.Toolkit.KryptonPanel functionsEditPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Label label4;
        private Krypton.Toolkit.KryptonButton kryptonButton15;
        private Krypton.Toolkit.KryptonButton kryptonButton14;
        private Krypton.Toolkit.KryptonTextBox txtFunctionName;
        private Krypton.Toolkit.KryptonButton functionSave;
        private Panel functionEditPanel;
        private FlowLayoutPanel functionsPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private Krypton.Toolkit.KryptonButton kryptonButton17;
        private Krypton.Toolkit.KryptonButton kryptonButton16;
    }
}