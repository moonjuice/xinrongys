namespace xinrongys
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.editButton = new System.Windows.Forms.ToolStripButton();
            this.delButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.customerPage = new System.Windows.Forms.TabPage();
            this.supplierPage = new System.Windows.Forms.TabPage();
            this.makingPage = new System.Windows.Forms.TabPage();
            this.daomuPage = new System.Windows.Forms.TabPage();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 515);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(784, 562);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.editButton,
            this.delButton,
            this.refreshButton});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(104, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(23, 22);
            this.addButton.Text = "toolStripButton1";
            this.addButton.ToolTipText = "新增資料";
            // 
            // editButton
            // 
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(23, 22);
            this.editButton.Text = "toolStripButton2";
            this.editButton.ToolTipText = "修改資料";
            // 
            // delButton
            // 
            this.delButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delButton.Image = ((System.Drawing.Image)(resources.GetObject("delButton.Image")));
            this.delButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(23, 22);
            this.delButton.Text = "toolStripButton3";
            this.delButton.ToolTipText = "刪除資料";
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(23, 22);
            this.refreshButton.Text = "toolStripButton4";
            this.refreshButton.ToolTipText = "重新整理";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.customerPage);
            this.tabControl.Controls.Add(this.supplierPage);
            this.tabControl.Controls.Add(this.makingPage);
            this.tabControl.Controls.Add(this.daomuPage);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(781, 509);
            this.tabControl.TabIndex = 0;
            // 
            // customerPage
            // 
            this.customerPage.Location = new System.Drawing.Point(4, 26);
            this.customerPage.Name = "customerPage";
            this.customerPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerPage.Size = new System.Drawing.Size(773, 479);
            this.customerPage.TabIndex = 0;
            this.customerPage.Text = "客戶基本資料";
            this.customerPage.UseVisualStyleBackColor = true;
            // 
            // supplierPage
            // 
            this.supplierPage.Location = new System.Drawing.Point(4, 26);
            this.supplierPage.Name = "supplierPage";
            this.supplierPage.Padding = new System.Windows.Forms.Padding(3);
            this.supplierPage.Size = new System.Drawing.Size(773, 479);
            this.supplierPage.TabIndex = 1;
            this.supplierPage.Text = "供應商基本資料";
            this.supplierPage.UseVisualStyleBackColor = true;
            // 
            // makingPage
            // 
            this.makingPage.Location = new System.Drawing.Point(4, 26);
            this.makingPage.Name = "makingPage";
            this.makingPage.Size = new System.Drawing.Size(773, 479);
            this.makingPage.TabIndex = 2;
            this.makingPage.Text = "材料基本資料";
            this.makingPage.UseVisualStyleBackColor = true;
            // 
            // daomuPage
            // 
            this.daomuPage.Location = new System.Drawing.Point(4, 26);
            this.daomuPage.Name = "daomuPage";
            this.daomuPage.Size = new System.Drawing.Size(773, 479);
            this.daomuPage.TabIndex = 3;
            this.daomuPage.Text = "刀模基本資料";
            this.daomuPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "xinrongys";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton editButton;
        private System.Windows.Forms.ToolStripButton delButton;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage customerPage;
        private System.Windows.Forms.TabPage supplierPage;
        private System.Windows.Forms.TabPage makingPage;
        private System.Windows.Forms.TabPage daomuPage;
    }
}

