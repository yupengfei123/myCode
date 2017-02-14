namespace 轨道检测车1._0
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabDataCollect = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BtnRecord = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.cbCOM2 = new System.Windows.Forms.ComboBox();
            this.cbCOM1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TabDataProcess = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.BtnDataLoad = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabDataCollect.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabDataProcess.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabDataCollect);
            this.tabControl1.Controls.Add(this.TabDataProcess);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // TabDataCollect
            // 
            this.TabDataCollect.Controls.Add(this.panel1);
            this.TabDataCollect.Controls.Add(this.BtnRecord);
            this.TabDataCollect.Controls.Add(this.BtnStart);
            this.TabDataCollect.Controls.Add(this.cbCOM2);
            this.TabDataCollect.Controls.Add(this.cbCOM1);
            this.TabDataCollect.Controls.Add(this.label2);
            this.TabDataCollect.Controls.Add(this.label1);
            this.TabDataCollect.Controls.Add(this.BtnConnect);
            this.TabDataCollect.Location = new System.Drawing.Point(4, 22);
            this.TabDataCollect.Name = "TabDataCollect";
            this.TabDataCollect.Padding = new System.Windows.Forms.Padding(3);
            this.TabDataCollect.Size = new System.Drawing.Size(536, 426);
            this.TabDataCollect.TabIndex = 0;
            this.TabDataCollect.Text = "数据采集";
            this.TabDataCollect.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 277);
            this.panel1.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 277);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // BtnRecord
            // 
            this.BtnRecord.Enabled = false;
            this.BtnRecord.Location = new System.Drawing.Point(175, 88);
            this.BtnRecord.Name = "BtnRecord";
            this.BtnRecord.Size = new System.Drawing.Size(93, 39);
            this.BtnRecord.TabIndex = 6;
            this.BtnRecord.Text = "记录数据";
            this.BtnRecord.UseVisualStyleBackColor = true;
            this.BtnRecord.Click += new System.EventHandler(this.BtnRecord_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(23, 88);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(96, 39);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "开启传感器";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // cbCOM2
            // 
            this.cbCOM2.FormattingEnabled = true;
            this.cbCOM2.Location = new System.Drawing.Point(295, 44);
            this.cbCOM2.Name = "cbCOM2";
            this.cbCOM2.Size = new System.Drawing.Size(75, 20);
            this.cbCOM2.TabIndex = 4;
            // 
            // cbCOM1
            // 
            this.cbCOM1.FormattingEnabled = true;
            this.cbCOM1.Location = new System.Drawing.Point(166, 44);
            this.cbCOM1.Name = "cbCOM1";
            this.cbCOM1.Size = new System.Drawing.Size(75, 20);
            this.cbCOM1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "位移计(COM2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "里程计(COM1)";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(23, 25);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(96, 39);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "传感器连接";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // TabDataProcess
            // 
            this.TabDataProcess.Controls.Add(this.listView3);
            this.TabDataProcess.Controls.Add(this.listView2);
            this.TabDataProcess.Controls.Add(this.panel2);
            this.TabDataProcess.Location = new System.Drawing.Point(4, 22);
            this.TabDataProcess.Name = "TabDataProcess";
            this.TabDataProcess.Padding = new System.Windows.Forms.Padding(3);
            this.TabDataProcess.Size = new System.Drawing.Size(536, 426);
            this.TabDataProcess.TabIndex = 1;
            this.TabDataProcess.Text = "数据处理";
            this.TabDataProcess.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(393, 73);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(140, 350);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(3, 73);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(390, 350);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnConvert);
            this.panel2.Controls.Add(this.BtnDataLoad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 70);
            this.panel2.TabIndex = 0;
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(81, 0);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(75, 67);
            this.BtnConvert.TabIndex = 1;
            this.BtnConvert.Text = "开始转换";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // BtnDataLoad
            // 
            this.BtnDataLoad.Location = new System.Drawing.Point(0, 0);
            this.BtnDataLoad.Name = "BtnDataLoad";
            this.BtnDataLoad.Size = new System.Drawing.Size(75, 67);
            this.BtnDataLoad.TabIndex = 0;
            this.BtnDataLoad.Text = "加载数据";
            this.BtnDataLoad.UseVisualStyleBackColor = true;
            this.BtnDataLoad.Click += new System.EventHandler(this.BtnDataLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 452);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "轨道检测采集系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabDataCollect.ResumeLayout(false);
            this.TabDataCollect.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.TabDataProcess.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabDataCollect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TabPage TabDataProcess;
        private System.Windows.Forms.ComboBox cbCOM2;
        private System.Windows.Forms.ComboBox cbCOM1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Button BtnDataLoad;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
    }
}

