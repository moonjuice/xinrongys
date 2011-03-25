namespace xinrongys
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.customerPage = new System.Windows.Forms.TabPage();
            this.customerView = new System.Windows.Forms.DataGridView();
            this.customerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierPage = new System.Windows.Forms.TabPage();
            this.supplierView = new System.Windows.Forms.DataGridView();
            this.supplierMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSupplierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSupplierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delSupplierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshSupplierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makingPage = new System.Windows.Forms.TabPage();
            this.makingView = new System.Windows.Forms.DataGridView();
            this.makingMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMakingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMakingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delMakingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMakingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daomuPage = new System.Windows.Forms.TabPage();
            this.daomuView = new System.Windows.Forms.DataGridView();
            this.daomuMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDaomuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDaomuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delDaomuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDaomuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.customerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
            this.customerMenu.SuspendLayout();
            this.supplierPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierView)).BeginInit();
            this.supplierMenu.SuspendLayout();
            this.makingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makingView)).BeginInit();
            this.makingMenu.SuspendLayout();
            this.daomuPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daomuView)).BeginInit();
            this.daomuMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 512);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(784, 562);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.customerPage);
            this.tabControl.Controls.Add(this.supplierPage);
            this.tabControl.Controls.Add(this.makingPage);
            this.tabControl.Controls.Add(this.daomuPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 512);
            this.tabControl.TabIndex = 0;
            // 
            // customerPage
            // 
            this.customerPage.Controls.Add(this.customerView);
            this.customerPage.Location = new System.Drawing.Point(4, 26);
            this.customerPage.Name = "customerPage";
            this.customerPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerPage.Size = new System.Drawing.Size(776, 482);
            this.customerPage.TabIndex = 0;
            this.customerPage.Text = "客戶基本資料";
            this.customerPage.UseVisualStyleBackColor = true;
            // 
            // customerView
            // 
            this.customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerView.ContextMenuStrip = this.customerMenu;
            this.customerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerView.Location = new System.Drawing.Point(3, 3);
            this.customerView.Name = "customerView";
            this.customerView.ReadOnly = true;
            this.customerView.RowTemplate.Height = 24;
            this.customerView.Size = new System.Drawing.Size(770, 476);
            this.customerView.TabIndex = 0;
            // 
            // customerMenu
            // 
            this.customerMenu.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.customerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerMenuItem,
            this.editCustomerMenuItem,
            this.delCustomerMenuItem,
            this.refreshCustomerMenuItem});
            this.customerMenu.Name = "customerMenu";
            this.customerMenu.Size = new System.Drawing.Size(143, 100);
            // 
            // addCustomerMenuItem
            // 
            this.addCustomerMenuItem.Name = "addCustomerMenuItem";
            this.addCustomerMenuItem.Size = new System.Drawing.Size(142, 24);
            this.addCustomerMenuItem.Text = "新增資料";
            // 
            // editCustomerMenuItem
            // 
            this.editCustomerMenuItem.Name = "editCustomerMenuItem";
            this.editCustomerMenuItem.Size = new System.Drawing.Size(142, 24);
            this.editCustomerMenuItem.Text = "修改資料";
            // 
            // delCustomerMenuItem
            // 
            this.delCustomerMenuItem.Name = "delCustomerMenuItem";
            this.delCustomerMenuItem.Size = new System.Drawing.Size(142, 24);
            this.delCustomerMenuItem.Text = "刪除資料";
            // 
            // refreshCustomerMenuItem
            // 
            this.refreshCustomerMenuItem.Name = "refreshCustomerMenuItem";
            this.refreshCustomerMenuItem.Size = new System.Drawing.Size(142, 24);
            this.refreshCustomerMenuItem.Text = "重新整理";
            // 
            // supplierPage
            // 
            this.supplierPage.Controls.Add(this.supplierView);
            this.supplierPage.Location = new System.Drawing.Point(4, 26);
            this.supplierPage.Name = "supplierPage";
            this.supplierPage.Padding = new System.Windows.Forms.Padding(3);
            this.supplierPage.Size = new System.Drawing.Size(776, 482);
            this.supplierPage.TabIndex = 1;
            this.supplierPage.Text = "供應商基本資料";
            this.supplierPage.UseVisualStyleBackColor = true;
            // 
            // supplierView
            // 
            this.supplierView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierView.ContextMenuStrip = this.supplierMenu;
            this.supplierView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierView.Location = new System.Drawing.Point(3, 3);
            this.supplierView.Name = "supplierView";
            this.supplierView.ReadOnly = true;
            this.supplierView.RowTemplate.Height = 24;
            this.supplierView.Size = new System.Drawing.Size(770, 476);
            this.supplierView.TabIndex = 0;
            // 
            // supplierMenu
            // 
            this.supplierMenu.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.supplierMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSupplierMenuItem,
            this.editSupplierMenuItem,
            this.delSupplierMenuItem,
            this.refreshSupplierMenuItem});
            this.supplierMenu.Name = "customerMenu";
            this.supplierMenu.Size = new System.Drawing.Size(143, 100);
            // 
            // addSupplierMenuItem
            // 
            this.addSupplierMenuItem.Name = "addSupplierMenuItem";
            this.addSupplierMenuItem.Size = new System.Drawing.Size(142, 24);
            this.addSupplierMenuItem.Text = "新增資料";
            // 
            // editSupplierMenuItem
            // 
            this.editSupplierMenuItem.Name = "editSupplierMenuItem";
            this.editSupplierMenuItem.Size = new System.Drawing.Size(142, 24);
            this.editSupplierMenuItem.Text = "修改資料";
            // 
            // delSupplierMenuItem
            // 
            this.delSupplierMenuItem.Name = "delSupplierMenuItem";
            this.delSupplierMenuItem.Size = new System.Drawing.Size(142, 24);
            this.delSupplierMenuItem.Text = "刪除資料";
            // 
            // refreshSupplierMenuItem
            // 
            this.refreshSupplierMenuItem.Name = "refreshSupplierMenuItem";
            this.refreshSupplierMenuItem.Size = new System.Drawing.Size(142, 24);
            this.refreshSupplierMenuItem.Text = "重新整理";
            // 
            // makingPage
            // 
            this.makingPage.Controls.Add(this.makingView);
            this.makingPage.Location = new System.Drawing.Point(4, 26);
            this.makingPage.Name = "makingPage";
            this.makingPage.Size = new System.Drawing.Size(776, 482);
            this.makingPage.TabIndex = 2;
            this.makingPage.Text = "材料基本資料";
            this.makingPage.UseVisualStyleBackColor = true;
            // 
            // makingView
            // 
            this.makingView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.makingView.ContextMenuStrip = this.makingMenu;
            this.makingView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makingView.Location = new System.Drawing.Point(0, 0);
            this.makingView.Name = "makingView";
            this.makingView.ReadOnly = true;
            this.makingView.RowTemplate.Height = 24;
            this.makingView.Size = new System.Drawing.Size(776, 482);
            this.makingView.TabIndex = 0;
            // 
            // makingMenu
            // 
            this.makingMenu.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.makingMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMakingMenuItem,
            this.editMakingMenuItem,
            this.delMakingMenuItem,
            this.refreshMakingMenuItem});
            this.makingMenu.Name = "customerMenu";
            this.makingMenu.Size = new System.Drawing.Size(143, 100);
            // 
            // addMakingMenuItem
            // 
            this.addMakingMenuItem.Name = "addMakingMenuItem";
            this.addMakingMenuItem.Size = new System.Drawing.Size(142, 24);
            this.addMakingMenuItem.Text = "新增資料";
            // 
            // editMakingMenuItem
            // 
            this.editMakingMenuItem.Name = "editMakingMenuItem";
            this.editMakingMenuItem.Size = new System.Drawing.Size(142, 24);
            this.editMakingMenuItem.Text = "修改資料";
            // 
            // delMakingMenuItem
            // 
            this.delMakingMenuItem.Name = "delMakingMenuItem";
            this.delMakingMenuItem.Size = new System.Drawing.Size(142, 24);
            this.delMakingMenuItem.Text = "刪除資料";
            // 
            // refreshMakingMenuItem
            // 
            this.refreshMakingMenuItem.Name = "refreshMakingMenuItem";
            this.refreshMakingMenuItem.Size = new System.Drawing.Size(142, 24);
            this.refreshMakingMenuItem.Text = "重新整理";
            // 
            // daomuPage
            // 
            this.daomuPage.Controls.Add(this.daomuView);
            this.daomuPage.Location = new System.Drawing.Point(4, 26);
            this.daomuPage.Name = "daomuPage";
            this.daomuPage.Size = new System.Drawing.Size(776, 482);
            this.daomuPage.TabIndex = 3;
            this.daomuPage.Text = "刀模基本資料";
            this.daomuPage.UseVisualStyleBackColor = true;
            // 
            // daomuView
            // 
            this.daomuView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daomuView.ContextMenuStrip = this.daomuMenu;
            this.daomuView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daomuView.Location = new System.Drawing.Point(0, 0);
            this.daomuView.Name = "daomuView";
            this.daomuView.ReadOnly = true;
            this.daomuView.RowTemplate.Height = 24;
            this.daomuView.Size = new System.Drawing.Size(776, 482);
            this.daomuView.TabIndex = 0;
            // 
            // daomuMenu
            // 
            this.daomuMenu.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.daomuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDaomuMenuItem,
            this.editDaomuMenuItem,
            this.delDaomuMenuItem,
            this.refreshDaomuMenuItem});
            this.daomuMenu.Name = "customerMenu";
            this.daomuMenu.Size = new System.Drawing.Size(143, 100);
            // 
            // addDaomuMenuItem
            // 
            this.addDaomuMenuItem.Name = "addDaomuMenuItem";
            this.addDaomuMenuItem.Size = new System.Drawing.Size(142, 24);
            this.addDaomuMenuItem.Text = "新增資料";
            // 
            // editDaomuMenuItem
            // 
            this.editDaomuMenuItem.Name = "editDaomuMenuItem";
            this.editDaomuMenuItem.Size = new System.Drawing.Size(142, 24);
            this.editDaomuMenuItem.Text = "修改資料";
            // 
            // delDaomuMenuItem
            // 
            this.delDaomuMenuItem.Name = "delDaomuMenuItem";
            this.delDaomuMenuItem.Size = new System.Drawing.Size(142, 24);
            this.delDaomuMenuItem.Text = "刪除資料";
            // 
            // refreshDaomuMenuItem
            // 
            this.refreshDaomuMenuItem.Name = "refreshDaomuMenuItem";
            this.refreshDaomuMenuItem.Size = new System.Drawing.Size(142, 24);
            this.refreshDaomuMenuItem.Text = "重新整理";
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // settingMenuItem
            // 
            this.settingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMenuItem});
            this.settingMenuItem.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.settingMenuItem.Name = "settingMenuItem";
            this.settingMenuItem.Size = new System.Drawing.Size(53, 24);
            this.settingMenuItem.Text = "設定";
            // 
            // connectMenuItem
            // 
            this.connectMenuItem.Name = "connectMenuItem";
            this.connectMenuItem.Size = new System.Drawing.Size(174, 24);
            this.connectMenuItem.Text = "連線至資料庫";
            this.connectMenuItem.Click += new System.EventHandler(this.connectMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "xinrongys";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.customerPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
            this.customerMenu.ResumeLayout(false);
            this.supplierPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierView)).EndInit();
            this.supplierMenu.ResumeLayout(false);
            this.makingPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.makingView)).EndInit();
            this.makingMenu.ResumeLayout(false);
            this.daomuPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daomuView)).EndInit();
            this.daomuMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage customerPage;
        private System.Windows.Forms.TabPage supplierPage;
        private System.Windows.Forms.TabPage makingPage;
        private System.Windows.Forms.TabPage daomuPage;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectMenuItem;
        private System.Windows.Forms.DataGridView customerView;
        private System.Windows.Forms.DataGridView supplierView;
        private System.Windows.Forms.DataGridView makingView;
        private System.Windows.Forms.DataGridView daomuView;
        private System.Windows.Forms.ContextMenuStrip customerMenu;
        private System.Windows.Forms.ToolStripMenuItem addCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshCustomerMenuItem;
        private System.Windows.Forms.ContextMenuStrip supplierMenu;
        private System.Windows.Forms.ToolStripMenuItem addSupplierMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSupplierMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delSupplierMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshSupplierMenuItem;
        private System.Windows.Forms.ContextMenuStrip makingMenu;
        private System.Windows.Forms.ToolStripMenuItem addMakingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMakingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delMakingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshMakingMenuItem;
        private System.Windows.Forms.ContextMenuStrip daomuMenu;
        private System.Windows.Forms.ToolStripMenuItem addDaomuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDaomuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delDaomuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDaomuMenuItem;
    }
}

