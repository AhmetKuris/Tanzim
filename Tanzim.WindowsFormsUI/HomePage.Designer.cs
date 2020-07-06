namespace Tanzim.WindowsFormsUI
{
    partial class HomePage
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
            this.homePageStartBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanelTransaction = new System.Windows.Forms.TableLayoutPanel();
            this.lblTrackName = new System.Windows.Forms.Label();
            this.tbxTrackName = new System.Windows.Forms.TextBox();
            this.lblTrackCategory = new System.Windows.Forms.Label();
            this.cbxTrackCategory = new System.Windows.Forms.ComboBox();
            this.homePageStopBtn = new System.Windows.Forms.Button();
            this.dgwTracksHomePage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxTrackCategoryDataGridView = new System.Windows.Forms.ComboBox();
            this.lblShowAllCategories = new System.Windows.Forms.Label();
            this.homePageSendpdfBtn = new System.Windows.Forms.Button();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.lblTimerMain = new System.Windows.Forms.Label();
            this.HomePageMenustrp = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStyliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTracksHomePage)).BeginInit();
            this.HomePageMenustrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePageStartBtn
            // 
            this.homePageStartBtn.BackgroundImage = global::Tanzim.WindowsFormsUI.Properties.Resources.kisspng_arrow_button_computer_icons_clip_art_start_button_5ae174cb7921b9_2657468715247249394962;
            this.homePageStartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homePageStartBtn.Location = new System.Drawing.Point(929, 90);
            this.homePageStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.homePageStartBtn.Name = "homePageStartBtn";
            this.homePageStartBtn.Size = new System.Drawing.Size(69, 68);
            this.homePageStartBtn.TabIndex = 0;
            this.homePageStartBtn.UseVisualStyleBackColor = true;
            this.homePageStartBtn.Click += new System.EventHandler(this.homePageStartBtn_Click);
            // 
            // tableLayoutPanelTransaction
            // 
            this.tableLayoutPanelTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelTransaction.ColumnCount = 2;
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelTransaction.Controls.Add(this.lblTrackName, 0, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.tbxTrackName, 0, 1);
            this.tableLayoutPanelTransaction.Controls.Add(this.lblTrackCategory, 1, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.cbxTrackCategory, 1, 1);
            this.tableLayoutPanelTransaction.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanelTransaction.Location = new System.Drawing.Point(60, 74);
            this.tableLayoutPanelTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelTransaction.Name = "tableLayoutPanelTransaction";
            this.tableLayoutPanelTransaction.RowCount = 2;
            this.tableLayoutPanelTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelTransaction.Size = new System.Drawing.Size(701, 96);
            this.tableLayoutPanelTransaction.TabIndex = 12;
            // 
            // lblTrackName
            // 
            this.lblTrackName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrackName.AutoSize = true;
            this.lblTrackName.ForeColor = System.Drawing.Color.White;
            this.lblTrackName.Location = new System.Drawing.Point(152, 15);
            this.lblTrackName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(45, 17);
            this.lblTrackName.TabIndex = 13;
            this.lblTrackName.Text = "Name";
            this.lblTrackName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxTrackName
            // 
            this.tbxTrackName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxTrackName.Location = new System.Drawing.Point(79, 60);
            this.tbxTrackName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTrackName.Name = "tbxTrackName";
            this.tbxTrackName.Size = new System.Drawing.Size(192, 23);
            this.tbxTrackName.TabIndex = 20;
            // 
            // lblTrackCategory
            // 
            this.lblTrackCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrackCategory.AutoSize = true;
            this.lblTrackCategory.ForeColor = System.Drawing.Color.White;
            this.lblTrackCategory.Location = new System.Drawing.Point(493, 15);
            this.lblTrackCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrackCategory.Name = "lblTrackCategory";
            this.lblTrackCategory.Size = new System.Drawing.Size(65, 17);
            this.lblTrackCategory.TabIndex = 15;
            this.lblTrackCategory.Text = "Category";
            this.lblTrackCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxTrackCategory
            // 
            this.cbxTrackCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTrackCategory.FormattingEnabled = true;
            this.cbxTrackCategory.Location = new System.Drawing.Point(435, 61);
            this.cbxTrackCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTrackCategory.MaxDropDownItems = 2;
            this.cbxTrackCategory.Name = "cbxTrackCategory";
            this.cbxTrackCategory.Size = new System.Drawing.Size(180, 24);
            this.cbxTrackCategory.TabIndex = 26;
            // 
            // homePageStopBtn
            // 
            this.homePageStopBtn.BackgroundImage = global::Tanzim.WindowsFormsUI.Properties.Resources.kindpng_1177384;
            this.homePageStopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homePageStopBtn.Location = new System.Drawing.Point(929, 89);
            this.homePageStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.homePageStopBtn.Name = "homePageStopBtn";
            this.homePageStopBtn.Size = new System.Drawing.Size(67, 66);
            this.homePageStopBtn.TabIndex = 1;
            this.homePageStopBtn.UseVisualStyleBackColor = true;
            this.homePageStopBtn.Visible = false;
            this.homePageStopBtn.Click += new System.EventHandler(this.homePageStopBtn_Click);
            // 
            // dgwTracksHomePage
            // 
            this.dgwTracksHomePage.BackgroundColor = System.Drawing.Color.White;
            this.dgwTracksHomePage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTracksHomePage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.dgwTracksHomePage.Location = new System.Drawing.Point(60, 342);
            this.dgwTracksHomePage.Margin = new System.Windows.Forms.Padding(4);
            this.dgwTracksHomePage.Name = "dgwTracksHomePage";
            this.dgwTracksHomePage.ReadOnly = true;
            this.dgwTracksHomePage.Size = new System.Drawing.Size(909, 185);
            this.dgwTracksHomePage.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Duration";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // cbxTrackCategoryDataGridView
            // 
            this.cbxTrackCategoryDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTrackCategoryDataGridView.FormattingEnabled = true;
            this.cbxTrackCategoryDataGridView.Location = new System.Drawing.Point(788, 290);
            this.cbxTrackCategoryDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTrackCategoryDataGridView.MaxDropDownItems = 2;
            this.cbxTrackCategoryDataGridView.Name = "cbxTrackCategoryDataGridView";
            this.cbxTrackCategoryDataGridView.Size = new System.Drawing.Size(180, 24);
            this.cbxTrackCategoryDataGridView.TabIndex = 26;
            this.cbxTrackCategoryDataGridView.SelectionChangeCommitted += new System.EventHandler(this.cbxTrackCategoryDataGridView_SelectionChangeCommitted);
            // 
            // lblShowAllCategories
            // 
            this.lblShowAllCategories.AutoSize = true;
            this.lblShowAllCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblShowAllCategories.ForeColor = System.Drawing.Color.White;
            this.lblShowAllCategories.Location = new System.Drawing.Point(700, 297);
            this.lblShowAllCategories.Name = "lblShowAllCategories";
            this.lblShowAllCategories.Size = new System.Drawing.Size(61, 17);
            this.lblShowAllCategories.TabIndex = 27;
            this.lblShowAllCategories.Text = "Show All";
            this.lblShowAllCategories.Click += new System.EventHandler(this.lblShowAllCategories_Click);
            // 
            // homePageSendpdfBtn
            // 
            this.homePageSendpdfBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.homePageSendpdfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePageSendpdfBtn.ForeColor = System.Drawing.Color.White;
            this.homePageSendpdfBtn.Location = new System.Drawing.Point(802, 563);
            this.homePageSendpdfBtn.Name = "homePageSendpdfBtn";
            this.homePageSendpdfBtn.Size = new System.Drawing.Size(166, 40);
            this.homePageSendpdfBtn.TabIndex = 28;
            this.homePageSendpdfBtn.Text = "Send Report By Email";
            this.homePageSendpdfBtn.UseVisualStyleBackColor = false;
            this.homePageSendpdfBtn.Click += new System.EventHandler(this.homePageSendpdfBtn_Click);
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // lblTimerMain
            // 
            this.lblTimerMain.AutoSize = true;
            this.lblTimerMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.lblTimerMain.Location = new System.Drawing.Point(783, 106);
            this.lblTimerMain.Name = "lblTimerMain";
            this.lblTimerMain.Size = new System.Drawing.Size(103, 29);
            this.lblTimerMain.TabIndex = 29;
            this.lblTimerMain.Text = "00:00:00";
            // 
            // HomePageMenustrp
            // 
            this.HomePageMenustrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.HomePageMenustrp.Location = new System.Drawing.Point(0, 0);
            this.HomePageMenustrp.Name = "HomePageMenustrp";
            this.HomePageMenustrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HomePageMenustrp.Size = new System.Drawing.Size(1112, 24);
            this.HomePageMenustrp.TabIndex = 29;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColurToolStripMenuItem,
            this.fontStyliToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backgroundColurToolStripMenuItem
            // 
            this.backgroundColurToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backgroundColurToolStripMenuItem.Name = "backgroundColurToolStripMenuItem";
            this.backgroundColurToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backgroundColurToolStripMenuItem.Text = "Background colur";
            this.backgroundColurToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backgroundColurToolStripMenuItem.Click += new System.EventHandler(this.backgroundColurToolStripMenuItem_Click);
            // 
            // fontStyliToolStripMenuItem
            // 
            this.fontStyliToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.fontStyliToolStripMenuItem.Name = "fontStyliToolStripMenuItem";
            this.fontStyliToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.fontStyliToolStripMenuItem.Text = "Font styli          ";
            this.fontStyliToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fontStyliToolStripMenuItem.Click += new System.EventHandler(this.fontStyliToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1112, 639);
            this.Controls.Add(this.lblTimerMain);
            this.Controls.Add(this.homePageSendpdfBtn);
            this.Controls.Add(this.lblShowAllCategories);
            this.Controls.Add(this.dgwTracksHomePage);
            this.Controls.Add(this.tableLayoutPanelTransaction);
            this.Controls.Add(this.homePageStopBtn);
            this.Controls.Add(this.cbxTrackCategoryDataGridView);
            this.Controls.Add(this.homePageStartBtn);
            this.Controls.Add(this.HomePageMenustrp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainMenuStrip = this.HomePageMenustrp;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1128, 678);
            this.MinimumSize = new System.Drawing.Size(1128, 678);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.Resize += new System.EventHandler(this.HomePage_Resize);
            this.tableLayoutPanelTransaction.ResumeLayout(false);
            this.tableLayoutPanelTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTracksHomePage)).EndInit();
            this.HomePageMenustrp.ResumeLayout(false);
            this.HomePageMenustrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homePageStartBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTransaction;
        private System.Windows.Forms.Label lblTrackCategory;
        private System.Windows.Forms.Label lblTrackName;
        private System.Windows.Forms.TextBox tbxTrackName;
        private System.Windows.Forms.ComboBox cbxTrackCategory;
        private System.Windows.Forms.Button homePageStopBtn;
        private System.Windows.Forms.DataGridView dgwTracksHomePage;
        private System.Windows.Forms.ComboBox cbxTrackCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblShowAllCategories;
        private System.Windows.Forms.Button homePageSendpdfBtn;
 
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label lblTimerMain;

        private System.Windows.Forms.MenuStrip HomePageMenustrp;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontStyliToolStripMenuItem;
    }
}