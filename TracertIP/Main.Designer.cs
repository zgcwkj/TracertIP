namespace TracertIP
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Txt_IP = new System.Windows.Forms.Label();
            this.Text_IP = new System.Windows.Forms.TextBox();
            this.Dgv_Data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cms_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Rsmi_ToggleDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Text_OutData = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).BeginInit();
            this.Cms_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Start
            // 
            this.Btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Start.Location = new System.Drawing.Point(776, 14);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(110, 31);
            this.Btn_Start.TabIndex = 3;
            this.Btn_Start.Text = "检查跟踪";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Txt_IP
            // 
            this.Txt_IP.AutoSize = true;
            this.Txt_IP.Location = new System.Drawing.Point(14, 22);
            this.Txt_IP.Name = "Txt_IP";
            this.Txt_IP.Size = new System.Drawing.Size(98, 18);
            this.Txt_IP.TabIndex = 0;
            this.Txt_IP.Text = "追踪地址：";
            // 
            // Text_IP
            // 
            this.Text_IP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_IP.Location = new System.Drawing.Point(106, 16);
            this.Text_IP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text_IP.Name = "Text_IP";
            this.Text_IP.Size = new System.Drawing.Size(574, 28);
            this.Text_IP.TabIndex = 1;
            // 
            // Dgv_Data
            // 
            this.Dgv_Data.AllowUserToAddRows = false;
            this.Dgv_Data.AllowUserToDeleteRows = false;
            this.Dgv_Data.AllowUserToOrderColumns = true;
            this.Dgv_Data.AllowUserToResizeRows = false;
            this.Dgv_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Data.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.Dgv_Data.ContextMenuStrip = this.Cms_Menu;
            this.Dgv_Data.Location = new System.Drawing.Point(14, 53);
            this.Dgv_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv_Data.Name = "Dgv_Data";
            this.Dgv_Data.RowHeadersVisible = false;
            this.Dgv_Data.RowHeadersWidth = 51;
            this.Dgv_Data.RowTemplate.Height = 27;
            this.Dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Data.Size = new System.Drawing.Size(873, 473);
            this.Dgv_Data.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "序号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RTT1(ms)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RTT2(ms)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "RTT3(ms)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "目标地址";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "地址描述";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 250;
            // 
            // Cms_Menu
            // 
            this.Cms_Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Cms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rsmi_ToggleDisplay});
            this.Cms_Menu.Name = "Cms_Menu";
            this.Cms_Menu.Size = new System.Drawing.Size(189, 34);
            // 
            // Rsmi_ToggleDisplay
            // 
            this.Rsmi_ToggleDisplay.Name = "Rsmi_ToggleDisplay";
            this.Rsmi_ToggleDisplay.Size = new System.Drawing.Size(188, 30);
            this.Rsmi_ToggleDisplay.Text = "切换显示数据";
            this.Rsmi_ToggleDisplay.Click += new System.EventHandler(this.Rsmi_ToggleDisplay_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.Location = new System.Drawing.Point(686, 14);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(84, 31);
            this.Btn_Search.TabIndex = 2;
            this.Btn_Search.Text = "查询IP";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Text_OutData
            // 
            this.Text_OutData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_OutData.ContextMenuStrip = this.Cms_Menu;
            this.Text_OutData.Location = new System.Drawing.Point(14, 53);
            this.Text_OutData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text_OutData.Name = "Text_OutData";
            this.Text_OutData.Size = new System.Drawing.Size(873, 473);
            this.Text_OutData.TabIndex = 6;
            this.Text_OutData.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Text_IP);
            this.Controls.Add(this.Txt_IP);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Dgv_Data);
            this.Controls.Add(this.Text_OutData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(920, 595);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地址追踪工具 by zgcwkj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).EndInit();
            this.Cms_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label Txt_IP;
        private System.Windows.Forms.TextBox Text_IP;
        private System.Windows.Forms.DataGridView Dgv_Data;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.ContextMenuStrip Cms_Menu;
        private System.Windows.Forms.ToolStripMenuItem Rsmi_ToggleDisplay;
        private System.Windows.Forms.RichTextBox Text_OutData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

