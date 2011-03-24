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
            this.新增資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新整理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierPage = new System.Windows.Forms.TabPage();
            this.supplierView = new System.Windows.Forms.DataGridView();
            this.supplierMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.makingPage = new System.Windows.Forms.TabPage();
            this.makingView = new System.Windows.Forms.DataGridView();
            this.makingMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.daomuPage = new System.Windows.Forms.TabPage();
            this.daomuView = new System.Windows.Forms.DataGridView();
            this.daomuMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.連線至資料庫ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
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
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
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
            this.customerView.RowTemplate.Height = 24;
            this.customerView.Size = new System.Drawing.Size(770, 476);
            this.customerView.TabIndex = 0;
            // 
            // customerMenu
            // 
            this.customerMenu.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.customerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增資料ToolStripMenuItem,
            this.修改資料ToolStripMenuItem,
            this.刪除資料ToolStripMenuItem,
            this.重新整理ToolStripMenuItem});
            this.customerMenu.Name = "customerMenu";
            this.customerMenu.Size = new System.Drawing.Size(143, 100);
            // 
            // 新增資料ToolStripMenuItem
            // 
            this.新增資料ToolStripMenuItem.Name = "新增資料ToolStripMenuItem";
            this.新增資料ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.新增資料ToolStripMenuItem.Text = "新增資料";
            // 
            // 修改資料ToolStripMenuItem
            // 
            this.修改資料ToolStripMenuItem.Name = "修改資料ToolStripMenuItem";
            this.修改資料ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.修改資料ToolStripMenuItem.Text = "修改資料";
            // 
            // 刪除資料ToolStripMenuItem
            // 
            this.刪除資料ToolStripMenuItem.Name = "刪除資料ToolStripMenuItem";
            this.刪除資料ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.刪除資料ToolStripMenuItem.Text = "刪除資料";
            // 
            // 重新整理ToolStripMenuItem
            // 
            this.重新整理ToolStripMenuItem.Name = "重新整理ToolStripMenuItem";
            this.重新整理ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.重新整理ToolStripMenuItem.Text = "重新整理";
            // 
            // supplierPage
            // 
            this.supplierPage.Controls.Add(this.supplierView);
            this.supplierPage.Location = new System.Drawing.Point(4, 22);
            this.supplierPage.Name = "supplierPage";
            this.supplierPage.Padding = new System.Windows.Forms.Padding(3);
            this.supplierPage.Size = new System.Drawing.Size(776, 490);
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
            this.supplierView.RowTemplate.Height = 24;
            this.supplierView.Size = new System.Drawing.Size(770, 484);
            this.supplierView.TabIndex = 0;
            // 
            // supplierMenu
            // 
            this.supplierMenu.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.supplierMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.supplierMenu.Name = "customerMenu";
            this.supplierMenu.Size = new System.Drawing.Size(143, 100);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem1.Text = "新增資料";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem2.Text = "修改資料";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem3.Text = "刪除資料";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem4.Text = "重新整理";
            // 
            // makingPage
            // 
            this.makingPage.Controls.Add(this.makingView);
            this.makingPage.Location = new System.Drawing.Point(4, 22);
            this.makingPage.Name = "makingPage";
            this.makingPage.Size = new System.Drawing.Size(776, 490);
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
            this.makingView.RowTemplate.Height = 24;
            this.makingView.Size = new System.Drawing.Size(776, 490);
            this.makingView.TabIndex = 0;
            // 
            // makingMenu
            // 
            this.makingMenu.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.makingMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.makingMenu.Name = "customerMenu";
            this.makingMenu.Size = new System.Drawing.Size(143, 100);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem5.Text = "新增資料";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem6.Text = "修改資料";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem7.Text = "刪除資料";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem8.Text = "重新整理";
            // 
            // daomuPage
            // 
            this.daomuPage.Controls.Add(this.daomuView);
            this.daomuPage.Location = new System.Drawing.Point(4, 22);
            this.daomuPage.Name = "daomuPage";
            this.daomuPage.Size = new System.Drawing.Size(776, 490);
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
            this.daomuView.RowTemplate.Height = 24;
            this.daomuView.Size = new System.Drawing.Size(776, 490);
            this.daomuView.TabIndex = 0;
            // 
            // daomuMenu
            // 
            this.daomuMenu.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.daomuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.daomuMenu.Name = "customerMenu";
            this.daomuMenu.Size = new System.Drawing.Size(143, 100);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem9.Text = "新增資料";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem10.Text = "修改資料";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem11.Text = "刪除資料";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem12.Text = "重新整理";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.連線至資料庫ToolStripMenuItem});
            this.設定ToolStripMenuItem.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // 連線至資料庫ToolStripMenuItem
            // 
            this.連線至資料庫ToolStripMenuItem.Name = "連線至資料庫ToolStripMenuItem";
            this.連線至資料庫ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.連線至資料庫ToolStripMenuItem.Text = "連線至資料庫";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 連線至資料庫ToolStripMenuItem;
        private System.Windows.Forms.DataGridView customerView;
        private System.Windows.Forms.DataGridView supplierView;
        private System.Windows.Forms.DataGridView makingView;
        private System.Windows.Forms.DataGridView daomuView;
        private System.Windows.Forms.ContextMenuStrip customerMenu;
        private System.Windows.Forms.ToolStripMenuItem 新增資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新整理ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip supplierMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip makingMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ContextMenuStrip daomuMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
    }
}

