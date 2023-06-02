namespace SerialDebugger
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolscript_generic = new System.Windows.Forms.ToolStrip();
            this.btn_generic_start = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_generic_serialSelect = new System.Windows.Forms.ToolStripLabel();
            this.cbbox_generic_serialSelect = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_generic_serialBaudrate = new System.Windows.Forms.ToolStripLabel();
            this.cbbox_generic_serialBaudrate = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_generic_serialDataBitsCount = new System.Windows.Forms.ToolStripLabel();
            this.cbbox_ = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_generic_serialStopBit = new System.Windows.Forms.ToolStripLabel();
            this.cbbox_generic_serialStopBit = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_generic_serialParty = new System.Windows.Forms.ToolStripLabel();
            this.cbbox_generic_serialParty = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.txtbox_generic_log = new System.Windows.Forms.TextBox();
            this.panel_generic = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpage_NormalSerelDbg = new System.Windows.Forms.TabPage();
            this.tabpage_oscilloscope = new System.Windows.Forms.TabPage();
            this.toolscript_generic.SuspendLayout();
            this.panel_generic.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolscript_generic
            // 
            this.toolscript_generic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_generic_start,
            this.toolStripSeparator1,
            this.lbl_generic_serialSelect,
            this.cbbox_generic_serialSelect,
            this.toolStripSeparator2,
            this.lbl_generic_serialBaudrate,
            this.cbbox_generic_serialBaudrate,
            this.toolStripSeparator3,
            this.lbl_generic_serialDataBitsCount,
            this.cbbox_,
            this.toolStripSeparator4,
            this.lbl_generic_serialParty,
            this.cbbox_generic_serialParty,
            this.toolStripSeparator5,
            this.lbl_generic_serialStopBit,
            this.cbbox_generic_serialStopBit,
            this.toolStripSeparator6});
            this.toolscript_generic.Location = new System.Drawing.Point(0, 0);
            this.toolscript_generic.Name = "toolscript_generic";
            this.toolscript_generic.Size = new System.Drawing.Size(1264, 25);
            this.toolscript_generic.TabIndex = 0;
            this.toolscript_generic.Text = "toolStrip1";
            // 
            // btn_generic_start
            // 
            this.btn_generic_start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_generic_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_generic_start.Image")));
            this.btn_generic_start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_generic_start.Name = "btn_generic_start";
            this.btn_generic_start.Size = new System.Drawing.Size(60, 22);
            this.btn_generic_start.Text = "打开串口";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_generic_serialSelect
            // 
            this.lbl_generic_serialSelect.Name = "lbl_generic_serialSelect";
            this.lbl_generic_serialSelect.Size = new System.Drawing.Size(56, 22);
            this.lbl_generic_serialSelect.Text = "选择串口";
            // 
            // cbbox_generic_serialSelect
            // 
            this.cbbox_generic_serialSelect.Name = "cbbox_generic_serialSelect";
            this.cbbox_generic_serialSelect.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_generic_serialBaudrate
            // 
            this.lbl_generic_serialBaudrate.Name = "lbl_generic_serialBaudrate";
            this.lbl_generic_serialBaudrate.Size = new System.Drawing.Size(68, 22);
            this.lbl_generic_serialBaudrate.Text = "选择波特率";
            // 
            // cbbox_generic_serialBaudrate
            // 
            this.cbbox_generic_serialBaudrate.Name = "cbbox_generic_serialBaudrate";
            this.cbbox_generic_serialBaudrate.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_generic_serialDataBitsCount
            // 
            this.lbl_generic_serialDataBitsCount.Name = "lbl_generic_serialDataBitsCount";
            this.lbl_generic_serialDataBitsCount.Size = new System.Drawing.Size(44, 22);
            this.lbl_generic_serialDataBitsCount.Text = "数据位";
            // 
            // cbbox_
            // 
            this.cbbox_.Name = "cbbox_";
            this.cbbox_.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_generic_serialStopBit
            // 
            this.lbl_generic_serialStopBit.Name = "lbl_generic_serialStopBit";
            this.lbl_generic_serialStopBit.Size = new System.Drawing.Size(44, 22);
            this.lbl_generic_serialStopBit.Text = "停止位";
            // 
            // cbbox_generic_serialStopBit
            // 
            this.cbbox_generic_serialStopBit.Name = "cbbox_generic_serialStopBit";
            this.cbbox_generic_serialStopBit.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_generic_serialParty
            // 
            this.lbl_generic_serialParty.Name = "lbl_generic_serialParty";
            this.lbl_generic_serialParty.Size = new System.Drawing.Size(44, 22);
            this.lbl_generic_serialParty.Text = "校验位";
            // 
            // cbbox_generic_serialParty
            // 
            this.cbbox_generic_serialParty.Name = "cbbox_generic_serialParty";
            this.cbbox_generic_serialParty.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // txtbox_generic_log
            // 
            this.txtbox_generic_log.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtbox_generic_log.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbox_generic_log.Location = new System.Drawing.Point(972, 25);
            this.txtbox_generic_log.Multiline = true;
            this.txtbox_generic_log.Name = "txtbox_generic_log";
            this.txtbox_generic_log.ReadOnly = true;
            this.txtbox_generic_log.Size = new System.Drawing.Size(292, 656);
            this.txtbox_generic_log.TabIndex = 1;
            // 
            // panel_generic
            // 
            this.panel_generic.Controls.Add(this.tabControl1);
            this.panel_generic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_generic.Location = new System.Drawing.Point(0, 25);
            this.panel_generic.Name = "panel_generic";
            this.panel_generic.Size = new System.Drawing.Size(972, 656);
            this.panel_generic.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpage_NormalSerelDbg);
            this.tabControl1.Controls.Add(this.tabpage_oscilloscope);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 656);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpage_NormalSerelDbg
            // 
            this.tabpage_NormalSerelDbg.Location = new System.Drawing.Point(4, 22);
            this.tabpage_NormalSerelDbg.Name = "tabpage_NormalSerelDbg";
            this.tabpage_NormalSerelDbg.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_NormalSerelDbg.Size = new System.Drawing.Size(964, 630);
            this.tabpage_NormalSerelDbg.TabIndex = 0;
            this.tabpage_NormalSerelDbg.Text = "通用串口调试";
            this.tabpage_NormalSerelDbg.UseVisualStyleBackColor = true;
            // 
            // tabpage_oscilloscope
            // 
            this.tabpage_oscilloscope.Location = new System.Drawing.Point(4, 22);
            this.tabpage_oscilloscope.Name = "tabpage_oscilloscope";
            this.tabpage_oscilloscope.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_oscilloscope.Size = new System.Drawing.Size(964, 630);
            this.tabpage_oscilloscope.TabIndex = 1;
            this.tabpage_oscilloscope.Text = "串口示波器";
            this.tabpage_oscilloscope.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel_generic);
            this.Controls.Add(this.txtbox_generic_log);
            this.Controls.Add(this.toolscript_generic);
            this.Name = "MainForm";
            this.Text = "串口调试助手";
            this.toolscript_generic.ResumeLayout(false);
            this.toolscript_generic.PerformLayout();
            this.panel_generic.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolscript_generic;
        private System.Windows.Forms.ToolStripButton btn_generic_start;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lbl_generic_serialSelect;
        private System.Windows.Forms.ToolStripComboBox cbbox_generic_serialSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lbl_generic_serialBaudrate;
        private System.Windows.Forms.ToolStripComboBox cbbox_generic_serialBaudrate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lbl_generic_serialDataBitsCount;
        private System.Windows.Forms.ToolStripComboBox cbbox_;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lbl_generic_serialStopBit;
        private System.Windows.Forms.ToolStripComboBox cbbox_generic_serialStopBit;
        private System.Windows.Forms.ToolStripLabel lbl_generic_serialParty;
        private System.Windows.Forms.ToolStripComboBox cbbox_generic_serialParty;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.TextBox txtbox_generic_log;
        private System.Windows.Forms.Panel panel_generic;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage_NormalSerelDbg;
        private System.Windows.Forms.TabPage tabpage_oscilloscope;
    }
}

