namespace PeopleRegsClient
{
    partial class FMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataSyncTimer = new System.Windows.Forms.Timer(this.components);
            this.dataSyncWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.filePrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePrintSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsSyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsExportSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsRefreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewShowFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.viewReloadFromDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.syncToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exportSelectedToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshListToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.infoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.filterClearButton = new System.Windows.Forms.Button();
            this.filterTitleLabel = new System.Windows.Forms.Label();
            this.filterVotingRegistrationStatusLabel = new System.Windows.Forms.Label();
            this.filterVotingRegistrationStatusEdit = new System.Windows.Forms.ComboBox();
            this.filterVotingRegistrationCityLabel = new System.Windows.Forms.Label();
            this.filterVotingRegistrationCityEdit = new System.Windows.Forms.ComboBox();
            this.filterIsCitizenOfBihEdit = new System.Windows.Forms.CheckBox();
            this.filterVotedOnPreviousElectionsEdit = new System.Windows.Forms.CheckBox();
            this.filterQualificationLabel = new System.Windows.Forms.Label();
            this.filterQualificationEdit = new System.Windows.Forms.ComboBox();
            this.filterOccupationLabel = new System.Windows.Forms.Label();
            this.filterOccupationEdit = new System.Windows.Forms.ComboBox();
            this.filterOriginCityLabel = new System.Windows.Forms.Label();
            this.filterOriginCityEdit = new System.Windows.Forms.ComboBox();
            this.filterCityLabel = new System.Windows.Forms.Label();
            this.filterCityEdit = new System.Windows.Forms.ComboBox();
            this.filterCountryLabel = new System.Windows.Forms.Label();
            this.filterCountryEdit = new System.Windows.Forms.ComboBox();
            this.filterAndContentSplitter = new System.Windows.Forms.Splitter();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.exportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.backupSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolsBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.loadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(760, 591);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.DoubleClick += new System.EventHandler(this.fileOpenToolStripMenuItem_Click);
            // 
            // dataSyncTimer
            // 
            this.dataSyncTimer.Tick += new System.EventHandler(this.DataSyncTimer_Tick);
            // 
            // dataSyncWorker
            // 
            this.dataSyncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DataSyncWorker_DoWork);
            this.dataSyncWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.dataSyncWorker_ProgressChanged);
            this.dataSyncWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DataSyncWorker_RunWorkerCompleted);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1053, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenToolStripMenuItem,
            this.toolStripSeparator5,
            this.filePrintToolStripMenuItem,
            this.filePrintSelectedToolStripMenuItem,
            this.toolStripSeparator4,
            this.fileExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.fileToolStripMenuItem.Text = "Program";
            // 
            // fileOpenToolStripMenuItem
            // 
            this.fileOpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileOpenToolStripMenuItem.Image")));
            this.fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            this.fileOpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpenToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.fileOpenToolStripMenuItem.Text = "Otvori";
            this.fileOpenToolStripMenuItem.Click += new System.EventHandler(this.fileOpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(287, 6);
            // 
            // filePrintToolStripMenuItem
            // 
            this.filePrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filePrintToolStripMenuItem.Image")));
            this.filePrintToolStripMenuItem.Name = "filePrintToolStripMenuItem";
            this.filePrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.filePrintToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.filePrintToolStripMenuItem.Text = "Štampaj listu";
            this.filePrintToolStripMenuItem.Click += new System.EventHandler(this.filePrintToolStripMenuItem_Click);
            // 
            // filePrintSelectedToolStripMenuItem
            // 
            this.filePrintSelectedToolStripMenuItem.Name = "filePrintSelectedToolStripMenuItem";
            this.filePrintSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.filePrintSelectedToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.filePrintSelectedToolStripMenuItem.Text = "Štampaj selektovane unose";
            this.filePrintSelectedToolStripMenuItem.Click += new System.EventHandler(this.filePrintSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(287, 6);
            // 
            // fileExitToolStripMenuItem
            // 
            this.fileExitToolStripMenuItem.Name = "fileExitToolStripMenuItem";
            this.fileExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.fileExitToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.fileExitToolStripMenuItem.Text = "Izlaz";
            this.fileExitToolStripMenuItem.Click += new System.EventHandler(this.fileExitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsSyncToolStripMenuItem,
            this.toolStripSeparator6,
            this.toolsExportToolStripMenuItem,
            this.toolsExportSelectedToolStripMenuItem,
            this.toolStripSeparator7,
            this.toolsBackupToolStripMenuItem,
            this.toolStripSeparator9,
            this.toolsRefreshListToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolsToolStripMenuItem.Text = "Alati";
            // 
            // toolsSyncToolStripMenuItem
            // 
            this.toolsSyncToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolsSyncToolStripMenuItem.Image")));
            this.toolsSyncToolStripMenuItem.Name = "toolsSyncToolStripMenuItem";
            this.toolsSyncToolStripMenuItem.Size = new System.Drawing.Size(340, 22);
            this.toolsSyncToolStripMenuItem.Text = "Sinhroniziraj sa serverom";
            this.toolsSyncToolStripMenuItem.Click += new System.EventHandler(this.toolsSyncToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(337, 6);
            // 
            // toolsExportToolStripMenuItem
            // 
            this.toolsExportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolsExportToolStripMenuItem.Image")));
            this.toolsExportToolStripMenuItem.Name = "toolsExportToolStripMenuItem";
            this.toolsExportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolsExportToolStripMenuItem.Size = new System.Drawing.Size(340, 22);
            this.toolsExportToolStripMenuItem.Text = "Eksportuj podatke u CSV";
            this.toolsExportToolStripMenuItem.Click += new System.EventHandler(this.toolsExportToolStripMenuItem_Click);
            // 
            // toolsExportSelectedToolStripMenuItem
            // 
            this.toolsExportSelectedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolsExportSelectedToolStripMenuItem.Image")));
            this.toolsExportSelectedToolStripMenuItem.Name = "toolsExportSelectedToolStripMenuItem";
            this.toolsExportSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.toolsExportSelectedToolStripMenuItem.Size = new System.Drawing.Size(340, 22);
            this.toolsExportSelectedToolStripMenuItem.Text = "Eksportuj selektovane podatke u CSV";
            this.toolsExportSelectedToolStripMenuItem.Click += new System.EventHandler(this.toolsExportSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(337, 6);
            // 
            // toolsRefreshListToolStripMenuItem
            // 
            this.toolsRefreshListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolsRefreshListToolStripMenuItem.Image")));
            this.toolsRefreshListToolStripMenuItem.Name = "toolsRefreshListToolStripMenuItem";
            this.toolsRefreshListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.toolsRefreshListToolStripMenuItem.Size = new System.Drawing.Size(340, 22);
            this.toolsRefreshListToolStripMenuItem.Text = "Osvježi prikaz sa novim podacima";
            this.toolsRefreshListToolStripMenuItem.Click += new System.EventHandler(this.toolsRefreshListToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewShowFilterToolStripMenuItem,
            this.toolStripSeparator8,
            this.viewReloadFromDbToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.viewToolStripMenuItem.Text = "Izgled";
            // 
            // viewShowFilterToolStripMenuItem
            // 
            this.viewShowFilterToolStripMenuItem.Checked = true;
            this.viewShowFilterToolStripMenuItem.CheckOnClick = true;
            this.viewShowFilterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewShowFilterToolStripMenuItem.Name = "viewShowFilterToolStripMenuItem";
            this.viewShowFilterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.viewShowFilterToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.viewShowFilterToolStripMenuItem.Text = "Prikaži filter";
            this.viewShowFilterToolStripMenuItem.Click += new System.EventHandler(this.viewShowFilterToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(248, 6);
            // 
            // viewReloadFromDbToolStripMenuItem
            // 
            this.viewReloadFromDbToolStripMenuItem.Name = "viewReloadFromDbToolStripMenuItem";
            this.viewReloadFromDbToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.viewReloadFromDbToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.viewReloadFromDbToolStripMenuItem.Text = "Učitaj podatke ponovo iz baze";
            this.viewReloadFromDbToolStripMenuItem.Click += new System.EventHandler(this.viewReloadFromDbToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "Pomoć";
            // 
            // helpAboutToolStripMenuItem
            // 
            this.helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            this.helpAboutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.helpAboutToolStripMenuItem.Text = "O programu";
            this.helpAboutToolStripMenuItem.Click += new System.EventHandler(this.helpAboutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator1,
            this.syncToolStripButton,
            this.toolStripSeparator2,
            this.exportToolStripButton,
            this.exportSelectedToolStripButton,
            this.toolStripSeparator3,
            this.refreshListToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1053, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Otvori";
            this.openToolStripButton.Click += new System.EventHandler(this.fileOpenToolStripMenuItem_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Štampaj listu";
            this.printToolStripButton.Click += new System.EventHandler(this.filePrintToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // syncToolStripButton
            // 
            this.syncToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.syncToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("syncToolStripButton.Image")));
            this.syncToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.syncToolStripButton.Name = "syncToolStripButton";
            this.syncToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.syncToolStripButton.Text = "Sinhroniziraj sa serverom";
            this.syncToolStripButton.Click += new System.EventHandler(this.toolsSyncToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // exportToolStripButton
            // 
            this.exportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripButton.Image")));
            this.exportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToolStripButton.Name = "exportToolStripButton";
            this.exportToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.exportToolStripButton.Text = "Eksportuj podatke u CSV";
            this.exportToolStripButton.Click += new System.EventHandler(this.toolsExportToolStripMenuItem_Click);
            // 
            // exportSelectedToolStripButton
            // 
            this.exportSelectedToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportSelectedToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exportSelectedToolStripButton.Image")));
            this.exportSelectedToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportSelectedToolStripButton.Name = "exportSelectedToolStripButton";
            this.exportSelectedToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.exportSelectedToolStripButton.Text = "Eksportuj selektovane podatke u CSV";
            this.exportSelectedToolStripButton.Click += new System.EventHandler(this.toolsExportSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshListToolStripButton
            // 
            this.refreshListToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshListToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshListToolStripButton.Image")));
            this.refreshListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshListToolStripButton.Name = "refreshListToolStripButton";
            this.refreshListToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.refreshListToolStripButton.Text = "Osvježi prikaz sa novim podacima";
            this.refreshListToolStripButton.Click += new System.EventHandler(this.toolsRefreshListToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 642);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1053, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // infoToolStripStatusLabel
            // 
            this.infoToolStripStatusLabel.Name = "infoToolStripStatusLabel";
            this.infoToolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.infoToolStripStatusLabel.Text = "Status";
            // 
            // filterPanel
            // 
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.filterClearButton);
            this.filterPanel.Controls.Add(this.filterTitleLabel);
            this.filterPanel.Controls.Add(this.filterVotingRegistrationStatusLabel);
            this.filterPanel.Controls.Add(this.filterVotingRegistrationStatusEdit);
            this.filterPanel.Controls.Add(this.filterVotingRegistrationCityLabel);
            this.filterPanel.Controls.Add(this.filterVotingRegistrationCityEdit);
            this.filterPanel.Controls.Add(this.filterIsCitizenOfBihEdit);
            this.filterPanel.Controls.Add(this.filterVotedOnPreviousElectionsEdit);
            this.filterPanel.Controls.Add(this.filterQualificationLabel);
            this.filterPanel.Controls.Add(this.filterQualificationEdit);
            this.filterPanel.Controls.Add(this.filterOccupationLabel);
            this.filterPanel.Controls.Add(this.filterOccupationEdit);
            this.filterPanel.Controls.Add(this.filterOriginCityLabel);
            this.filterPanel.Controls.Add(this.filterOriginCityEdit);
            this.filterPanel.Controls.Add(this.filterCityLabel);
            this.filterPanel.Controls.Add(this.filterCityEdit);
            this.filterPanel.Controls.Add(this.filterCountryLabel);
            this.filterPanel.Controls.Add(this.filterCountryEdit);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterPanel.Location = new System.Drawing.Point(0, 49);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(288, 593);
            this.filterPanel.TabIndex = 5;
            // 
            // filterClearButton
            // 
            this.filterClearButton.Location = new System.Drawing.Point(11, 467);
            this.filterClearButton.Name = "filterClearButton";
            this.filterClearButton.Size = new System.Drawing.Size(128, 23);
            this.filterClearButton.TabIndex = 17;
            this.filterClearButton.Text = "Poništi filter";
            this.filterClearButton.UseVisualStyleBackColor = true;
            this.filterClearButton.Click += new System.EventHandler(this.filterClearButton_Click);
            // 
            // filterTitleLabel
            // 
            this.filterTitleLabel.AutoSize = true;
            this.filterTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterTitleLabel.Location = new System.Drawing.Point(7, 10);
            this.filterTitleLabel.Name = "filterTitleLabel";
            this.filterTitleLabel.Size = new System.Drawing.Size(144, 20);
            this.filterTitleLabel.TabIndex = 16;
            this.filterTitleLabel.Text = "Filtriranje podataka";
            // 
            // filterVotingRegistrationStatusLabel
            // 
            this.filterVotingRegistrationStatusLabel.AutoSize = true;
            this.filterVotingRegistrationStatusLabel.Location = new System.Drawing.Point(8, 306);
            this.filterVotingRegistrationStatusLabel.Name = "filterVotingRegistrationStatusLabel";
            this.filterVotingRegistrationStatusLabel.Size = new System.Drawing.Size(135, 13);
            this.filterVotingRegistrationStatusLabel.TabIndex = 15;
            this.filterVotingRegistrationStatusLabel.Text = "Status registracije za izbore";
            // 
            // filterVotingRegistrationStatusEdit
            // 
            this.filterVotingRegistrationStatusEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterVotingRegistrationStatusEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterVotingRegistrationStatusEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterVotingRegistrationStatusEdit.FormattingEnabled = true;
            this.filterVotingRegistrationStatusEdit.Location = new System.Drawing.Point(11, 322);
            this.filterVotingRegistrationStatusEdit.Name = "filterVotingRegistrationStatusEdit";
            this.filterVotingRegistrationStatusEdit.Size = new System.Drawing.Size(267, 21);
            this.filterVotingRegistrationStatusEdit.TabIndex = 14;
            this.filterVotingRegistrationStatusEdit.SelectedIndexChanged += new System.EventHandler(this.filterEdit_FilterChanged);
            this.filterVotingRegistrationStatusEdit.Leave += new System.EventHandler(this.filterEdit_FilterChanged);
            // 
            // filterVotingRegistrationCityLabel
            // 
            this.filterVotingRegistrationCityLabel.AutoSize = true;
            this.filterVotingRegistrationCityLabel.Location = new System.Drawing.Point(8, 351);
            this.filterVotingRegistrationCityLabel.Name = "filterVotingRegistrationCityLabel";
            this.filterVotingRegistrationCityLabel.Size = new System.Drawing.Size(89, 13);
            this.filterVotingRegistrationCityLabel.TabIndex = 13;
            this.filterVotingRegistrationCityLabel.Text = "Prijavljen u općini";
            // 
            // filterVotingRegistrationCityEdit
            // 
            this.filterVotingRegistrationCityEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterVotingRegistrationCityEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterVotingRegistrationCityEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterVotingRegistrationCityEdit.FormattingEnabled = true;
            this.filterVotingRegistrationCityEdit.Location = new System.Drawing.Point(11, 367);
            this.filterVotingRegistrationCityEdit.Name = "filterVotingRegistrationCityEdit";
            this.filterVotingRegistrationCityEdit.Size = new System.Drawing.Size(267, 21);
            this.filterVotingRegistrationCityEdit.TabIndex = 12;
            this.filterVotingRegistrationCityEdit.SelectedIndexChanged += new System.EventHandler(this.filterEdit_FilterChanged);
            this.filterVotingRegistrationCityEdit.Leave += new System.EventHandler(this.filterEdit_FilterChanged);
            // 
            // filterIsCitizenOfBihEdit
            // 
            this.filterIsCitizenOfBihEdit.AutoSize = true;
            this.filterIsCitizenOfBihEdit.Checked = true;
            this.filterIsCitizenOfBihEdit.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.filterIsCitizenOfBihEdit.Location = new System.Drawing.Point(11, 404);
            this.filterIsCitizenOfBihEdit.Name = "filterIsCitizenOfBihEdit";
            this.filterIsCitizenOfBihEdit.Size = new System.Drawing.Size(98, 17);
            this.filterIsCitizenOfBihEdit.TabIndex = 11;
            this.filterIsCitizenOfBihEdit.Text = "Državljanin BiH";
            this.filterIsCitizenOfBihEdit.ThreeState = true;
            this.filterIsCitizenOfBihEdit.UseVisualStyleBackColor = true;
            this.filterIsCitizenOfBihEdit.CheckStateChanged += new System.EventHandler(this.filterEdit_FilterChanged);
            // 
            // filterVotedOnPreviousElectionsEdit
            // 
            this.filterVotedOnPreviousElectionsEdit.AutoSize = true;
            this.filterVotedOnPreviousElectionsEdit.Checked = true;
            this.filterVotedOnPreviousElectionsEdit.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.filterVotedOnPreviousElectionsEdit.Location = new System.Drawing.Point(11, 280);
            this.filterVotedOnPreviousElectionsEdit.Name = "filterVotedOnPreviousElectionsEdit";
            this.filterVotedOnPreviousElectionsEdit.Size = new System.Drawing.Size(170, 17);
            this.filterVotedOnPreviousElectionsEdit.TabIndex = 10;
            this.filterVotedOnPreviousElectionsEdit.Text = "Glasao na prethodnim izborima";
            this.filterVotedOnPreviousElectionsEdit.ThreeState = true;
            this.filterVotedOnPreviousElectionsEdit.UseVisualStyleBackColor = true;
            this.filterVotedOnPreviousElectionsEdit.CheckStateChanged += new System.EventHandler(this.filterEdit_FilterChanged);
            // 
            // filterQualificationLabel
            // 
            this.filterQualificationLabel.AutoSize = true;
            this.filterQualificationLabel.Location = new System.Drawing.Point(8, 226);
            this.filterQualificationLabel.Name = "filterQualificationLabel";
            this.filterQualificationLabel.Size = new System.Drawing.Size(81, 13);
            this.filterQualificationLabel.TabIndex = 9;
            this.filterQualificationLabel.Text = "Stručna sprema";
            // 
            // filterQualificationEdit
            // 
            this.filterQualificationEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterQualificationEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterQualificationEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterQualificationEdit.FormattingEnabled = true;
            this.filterQualificationEdit.Location = new System.Drawing.Point(11, 242);
            this.filterQualificationEdit.Name = "filterQualificationEdit";
            this.filterQualificationEdit.Size = new System.Drawing.Size(267, 21);
            this.filterQualificationEdit.TabIndex = 8;
            this.filterQualificationEdit.SelectedIndexChanged += new System.EventHandler(this.filterEdit_FilterChanged);
            this.filterQualificationEdit.Leave += new System.EventHandler(this.filterEdit_FilterChanged);
            // 
            // filterOccupationLabel
            // 
            this.filterOccupationLabel.AutoSize = true;
            this.filterOccupationLabel.Location = new System.Drawing.Point(8, 180);
            this.filterOccupationLabel.Name = "filterOccupationLabel";
            this.filterOccupationLabel.Size = new System.Drawing.Size(56, 13);
            this.filterOccupationLabel.TabIndex = 7;
            this.filterOccupationLabel.Text = "Zanimanje";
            // 
            // filterOccupationEdit
            // 
            this.filterOccupationEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterOccupationEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterOccupationEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterOccupationEdit.FormattingEnabled = true;
            this.filterOccupationEdit.Location = new System.Drawing.Point(11, 196);
            this.filterOccupationEdit.Name = "filterOccupationEdit";
            this.filterOccupationEdit.Size = new System.Drawing.Size(267, 21);
            this.filterOccupationEdit.TabIndex = 6;
            this.filterOccupationEdit.SelectedIndexChanged += new System.EventHandler(this.filterEdit_FilterChanged);
            this.filterOccupationEdit.Leave += new System.EventHandler(this.filterEdit_FilterChanged);
            // 
            // filterOriginCityLabel
            // 
            this.filterOriginCityLabel.AutoSize = true;
            this.filterOriginCityLabel.Location = new System.Drawing.Point(8, 134);
            this.filterOriginCityLabel.Name = "filterOriginCityLabel";
            this.filterOriginCityLabel.Size = new System.Drawing.Size(59, 13);
            this.filterOriginCityLabel.TabIndex = 5;
            this.filterOriginCityLabel.Text = "Grad u BiH";
            // 
            // filterOriginCityEdit
            // 
            this.filterOriginCityEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterOriginCityEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterOriginCityEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterOriginCityEdit.FormattingEnabled = true;
            this.filterOriginCityEdit.Location = new System.Drawing.Point(11, 150);
            this.filterOriginCityEdit.Name = "filterOriginCityEdit";
            this.filterOriginCityEdit.Size = new System.Drawing.Size(267, 21);
            this.filterOriginCityEdit.TabIndex = 4;
            this.filterOriginCityEdit.SelectedIndexChanged += new System.EventHandler(this.filterEdit_FilterChanged);
            this.filterOriginCityEdit.Leave += new System.EventHandler(this.filterEdit_FilterChanged);
            // 
            // filterCityLabel
            // 
            this.filterCityLabel.AutoSize = true;
            this.filterCityLabel.Location = new System.Drawing.Point(8, 88);
            this.filterCityLabel.Name = "filterCityLabel";
            this.filterCityLabel.Size = new System.Drawing.Size(30, 13);
            this.filterCityLabel.TabIndex = 3;
            this.filterCityLabel.Text = "Grad";
            // 
            // filterCityEdit
            // 
            this.filterCityEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterCityEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterCityEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterCityEdit.FormattingEnabled = true;
            this.filterCityEdit.Location = new System.Drawing.Point(11, 104);
            this.filterCityEdit.Name = "filterCityEdit";
            this.filterCityEdit.Size = new System.Drawing.Size(267, 21);
            this.filterCityEdit.TabIndex = 2;
            this.filterCityEdit.SelectedIndexChanged += new System.EventHandler(this.filterEdit_FilterChanged);
            this.filterCityEdit.Leave += new System.EventHandler(this.filterEdit_FilterChanged);
            // 
            // filterCountryLabel
            // 
            this.filterCountryLabel.AutoSize = true;
            this.filterCountryLabel.Location = new System.Drawing.Point(8, 42);
            this.filterCountryLabel.Name = "filterCountryLabel";
            this.filterCountryLabel.Size = new System.Drawing.Size(41, 13);
            this.filterCountryLabel.TabIndex = 1;
            this.filterCountryLabel.Text = "Država";
            // 
            // filterCountryEdit
            // 
            this.filterCountryEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterCountryEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterCountryEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterCountryEdit.FormattingEnabled = true;
            this.filterCountryEdit.Location = new System.Drawing.Point(11, 58);
            this.filterCountryEdit.Name = "filterCountryEdit";
            this.filterCountryEdit.Size = new System.Drawing.Size(267, 21);
            this.filterCountryEdit.TabIndex = 0;
            this.filterCountryEdit.SelectedIndexChanged += new System.EventHandler(this.filterEdit_FilterChanged);
            this.filterCountryEdit.Leave += new System.EventHandler(this.filterEdit_FilterChanged);
            // 
            // filterAndContentSplitter
            // 
            this.filterAndContentSplitter.Location = new System.Drawing.Point(288, 49);
            this.filterAndContentSplitter.Name = "filterAndContentSplitter";
            this.filterAndContentSplitter.Size = new System.Drawing.Size(3, 593);
            this.filterAndContentSplitter.TabIndex = 6;
            this.filterAndContentSplitter.TabStop = false;
            // 
            // dataPanel
            // 
            this.dataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataPanel.Controls.Add(this.loadingPanel);
            this.dataPanel.Controls.Add(this.dataGridView);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(291, 49);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(762, 593);
            this.dataPanel.TabIndex = 7;
            // 
            // loadingPanel
            // 
            this.loadingPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.loadingPanel.Controls.Add(this.loadingLabel);
            this.loadingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadingPanel.Location = new System.Drawing.Point(0, 0);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(760, 39);
            this.loadingPanel.TabIndex = 1;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadingLabel.ForeColor = System.Drawing.Color.White;
            this.loadingLabel.Location = new System.Drawing.Point(9, 10);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(232, 18);
            this.loadingLabel.TabIndex = 0;
            this.loadingLabel.Text = "Učitavanje podataka u toku ...";
            // 
            // exportSaveFileDialog
            // 
            this.exportSaveFileDialog.DefaultExt = "csv";
            this.exportSaveFileDialog.Filter = "CSV Datoteke|*.csv";
            // 
            // backupSaveFileDialog
            // 
            this.backupSaveFileDialog.DefaultExt = "csv";
            this.backupSaveFileDialog.Filter = "BAK Datoteke|*.bak";
            // 
            // toolsBackupToolStripMenuItem
            // 
            this.toolsBackupToolStripMenuItem.Name = "toolsBackupToolStripMenuItem";
            this.toolsBackupToolStripMenuItem.Size = new System.Drawing.Size(340, 22);
            this.toolsBackupToolStripMenuItem.Text = "Kreiraj rezervnu kopiju podataka";
            this.toolsBackupToolStripMenuItem.Click += new System.EventHandler(this.toolsBackupToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(337, 6);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 664);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.filterAndContentSplitter);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FMain";
            this.Text = "Projekat Online";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Timer dataSyncTimer;
        private System.ComponentModel.BackgroundWorker dataSyncWorker;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton syncToolStripButton;
        private System.Windows.Forms.ToolStripButton exportToolStripButton;
        private System.Windows.Forms.ToolStripButton exportSelectedToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel infoToolStripStatusLabel;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Splitter filterAndContentSplitter;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton refreshListToolStripButton;
        private System.Windows.Forms.Label filterCountryLabel;
        private System.Windows.Forms.ComboBox filterCountryEdit;
        private System.Windows.Forms.Label filterQualificationLabel;
        private System.Windows.Forms.ComboBox filterQualificationEdit;
        private System.Windows.Forms.Label filterOccupationLabel;
        private System.Windows.Forms.ComboBox filterOccupationEdit;
        private System.Windows.Forms.Label filterOriginCityLabel;
        private System.Windows.Forms.ComboBox filterOriginCityEdit;
        private System.Windows.Forms.Label filterCityLabel;
        private System.Windows.Forms.ComboBox filterCityEdit;
        private System.Windows.Forms.Label filterTitleLabel;
        private System.Windows.Forms.Label filterVotingRegistrationStatusLabel;
        private System.Windows.Forms.ComboBox filterVotingRegistrationStatusEdit;
        private System.Windows.Forms.Label filterVotingRegistrationCityLabel;
        private System.Windows.Forms.ComboBox filterVotingRegistrationCityEdit;
        private System.Windows.Forms.CheckBox filterIsCitizenOfBihEdit;
        private System.Windows.Forms.CheckBox filterVotedOnPreviousElectionsEdit;
        private System.Windows.Forms.Button filterClearButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem filePrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolsSyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolsExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsExportSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolsRefreshListToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog exportSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem filePrintSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewShowFilterToolStripMenuItem;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem viewReloadFromDbToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog backupSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem toolsBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    }
}

