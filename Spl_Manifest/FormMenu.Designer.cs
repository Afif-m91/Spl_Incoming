namespace Spl_Manifest
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karyawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manifestUdaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatManifestUdaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manifestDaratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatDataManifestUdaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printManifestUdaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printManifestDaratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Nama_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterDataToolStripMenuItem,
            this.manifestToolStripMenuItem,
            this.printManifestToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1559, 60);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karyawanToolStripMenuItem,
            this.userToolStripMenuItem});
            this.masterDataToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("masterDataToolStripMenuItem.Image")));
            this.masterDataToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.masterDataToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(102, 56);
            this.masterDataToolStripMenuItem.Text = "&Master Data";
            this.masterDataToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.masterDataToolStripMenuItem.Click += new System.EventHandler(this.masterDataToolStripMenuItem_Click);
            // 
            // karyawanToolStripMenuItem
            // 
            this.karyawanToolStripMenuItem.Name = "karyawanToolStripMenuItem";
            this.karyawanToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.karyawanToolStripMenuItem.Text = "Karyawan";
            this.karyawanToolStripMenuItem.Click += new System.EventHandler(this.karyawanToolStripMenuItem_Click_1);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // manifestToolStripMenuItem
            // 
            this.manifestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manifestUdaraToolStripMenuItem,
            this.manifestDaratToolStripMenuItem});
            this.manifestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manifestToolStripMenuItem.Image")));
            this.manifestToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.manifestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manifestToolStripMenuItem.Name = "manifestToolStripMenuItem";
            this.manifestToolStripMenuItem.Size = new System.Drawing.Size(83, 56);
            this.manifestToolStripMenuItem.Text = "&Incoming";
            this.manifestToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.manifestToolStripMenuItem.Click += new System.EventHandler(this.manifestToolStripMenuItem_Click);
            // 
            // manifestUdaraToolStripMenuItem
            // 
            this.manifestUdaraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatManifestUdaraToolStripMenuItem});
            this.manifestUdaraToolStripMenuItem.Name = "manifestUdaraToolStripMenuItem";
            this.manifestUdaraToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.manifestUdaraToolStripMenuItem.Text = "Incoming Udara";
            this.manifestUdaraToolStripMenuItem.Click += new System.EventHandler(this.manifestUdaraToolStripMenuItem_Click_1);
            // 
            // lihatManifestUdaraToolStripMenuItem
            // 
            this.lihatManifestUdaraToolStripMenuItem.Name = "lihatManifestUdaraToolStripMenuItem";
            this.lihatManifestUdaraToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.lihatManifestUdaraToolStripMenuItem.Text = "Lihat Data Incoming Udara";
            this.lihatManifestUdaraToolStripMenuItem.Click += new System.EventHandler(this.lihatManifestUdaraToolStripMenuItem_Click);
            // 
            // manifestDaratToolStripMenuItem
            // 
            this.manifestDaratToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatDataManifestUdaraToolStripMenuItem});
            this.manifestDaratToolStripMenuItem.Name = "manifestDaratToolStripMenuItem";
            this.manifestDaratToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.manifestDaratToolStripMenuItem.Text = "Incoming Darat";
            this.manifestDaratToolStripMenuItem.Click += new System.EventHandler(this.manifestDaratToolStripMenuItem_Click);
            // 
            // lihatDataManifestUdaraToolStripMenuItem
            // 
            this.lihatDataManifestUdaraToolStripMenuItem.Name = "lihatDataManifestUdaraToolStripMenuItem";
            this.lihatDataManifestUdaraToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.lihatDataManifestUdaraToolStripMenuItem.Text = "Lihat Data Incoming Darat";
            this.lihatDataManifestUdaraToolStripMenuItem.Click += new System.EventHandler(this.lihatDataManifestUdaraToolStripMenuItem_Click);
            // 
            // printManifestToolStripMenuItem
            // 
            this.printManifestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printManifestUdaraToolStripMenuItem,
            this.printManifestDaratToolStripMenuItem});
            this.printManifestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printManifestToolStripMenuItem.Image")));
            this.printManifestToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.printManifestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printManifestToolStripMenuItem.Name = "printManifestToolStripMenuItem";
            this.printManifestToolStripMenuItem.Size = new System.Drawing.Size(117, 56);
            this.printManifestToolStripMenuItem.Text = "&Print Incoming";
            this.printManifestToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.printManifestToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // printManifestUdaraToolStripMenuItem
            // 
            this.printManifestUdaraToolStripMenuItem.Name = "printManifestUdaraToolStripMenuItem";
            this.printManifestUdaraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printManifestUdaraToolStripMenuItem.Text = "Print Incoming Udara";
            this.printManifestUdaraToolStripMenuItem.Click += new System.EventHandler(this.printManifestUdaraToolStripMenuItem_Click);
            // 
            // printManifestDaratToolStripMenuItem
            // 
            this.printManifestDaratToolStripMenuItem.Name = "printManifestDaratToolStripMenuItem";
            this.printManifestDaratToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printManifestDaratToolStripMenuItem.Text = "Print Incoming Darat";
            this.printManifestDaratToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 56);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusDate,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.Nama_User});
            this.statusStrip1.Location = new System.Drawing.Point(0, 743);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1559, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(186, 20);
            this.toolStripStatusLabel1.Text = " Copyright  ©  SPL 2020     ";
            // 
            // statusDate
            // 
            this.statusDate.Name = "statusDate";
            this.statusDate.Size = new System.Drawing.Size(41, 20);
            this.statusDate.Text = "Date";
            this.statusDate.Click += new System.EventHandler(this.statusDate_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(15, 20);
            this.toolStripStatusLabel2.Text = "-";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(90, 20);
            this.toolStripStatusLabel3.Text = "User Login : ";
            // 
            // Nama_User
            // 
            this.Nama_User.Name = "Nama_User";
            this.Nama_User.Size = new System.Drawing.Size(84, 20);
            this.Nama_User.Text = "Nama_User";
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 60);
            this.MainContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(1559, 683);
            this.MainContainer.SplitterDistance = 384;
            this.MainContainer.SplitterWidth = 5;
            this.MainContainer.TabIndex = 4;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 768);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karyawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manifestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manifestUdaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manifestDaratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printManifestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printManifestUdaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatManifestUdaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printManifestDaratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatDataManifestUdaraToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusDate;
        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripStatusLabel Nama_User;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

