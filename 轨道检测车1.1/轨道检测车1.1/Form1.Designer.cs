namespace 轨道检测车1._1
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
            this.TabDataProcess = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnParaSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCOM1 = new System.Windows.Forms.ComboBox();
            this.cbCOM2 = new System.Windows.Forms.ComboBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnRecord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1.SuspendLayout();
            this.TabDataCollect.SuspendLayout();
            this.TabDataProcess.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabDataCollect);
            this.tabControl1.Controls.Add(this.TabDataProcess);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1241, 602);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // TabDataCollect
            // 
            this.TabDataCollect.Controls.Add(this.panel2);
            this.TabDataCollect.Controls.Add(this.panel1);
            this.TabDataCollect.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabDataCollect.Location = new System.Drawing.Point(4, 44);
            this.TabDataCollect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TabDataCollect.Name = "TabDataCollect";
            this.TabDataCollect.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TabDataCollect.Size = new System.Drawing.Size(1233, 554);
            this.TabDataCollect.TabIndex = 0;
            this.TabDataCollect.Text = "数据采集";
            this.TabDataCollect.UseVisualStyleBackColor = true;
            // 
            // TabDataProcess
            // 
            this.TabDataProcess.Controls.Add(this.listView2);
            this.TabDataProcess.Controls.Add(this.listView1);
            this.TabDataProcess.Location = new System.Drawing.Point(4, 44);
            this.TabDataProcess.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TabDataProcess.Name = "TabDataProcess";
            this.TabDataProcess.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TabDataProcess.Size = new System.Drawing.Size(1233, 554);
            this.TabDataProcess.TabIndex = 1;
            this.TabDataProcess.Text = "数据处理";
            this.TabDataProcess.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnRecord);
            this.panel1.Controls.Add(this.BtnConnect);
            this.panel1.Controls.Add(this.cbCOM2);
            this.panel1.Controls.Add(this.cbCOM1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnParaSet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 271);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1221, 273);
            this.panel2.TabIndex = 1;
            // 
            // BtnParaSet
            // 
            this.BtnParaSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnParaSet.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnParaSet.Location = new System.Drawing.Point(51, 61);
            this.BtnParaSet.Name = "BtnParaSet";
            this.BtnParaSet.Size = new System.Drawing.Size(163, 70);
            this.BtnParaSet.TabIndex = 0;
            this.BtnParaSet.Text = "参数设置";
            this.BtnParaSet.UseVisualStyleBackColor = true;
            this.BtnParaSet.Click += new System.EventHandler(this.BtnParaSet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(487, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "里程计(COM1)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(851, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "位移计(COM3)";
            // 
            // cbCOM1
            // 
            this.cbCOM1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCOM1.FormattingEnabled = true;
            this.cbCOM1.Location = new System.Drawing.Point(491, 83);
            this.cbCOM1.Name = "cbCOM1";
            this.cbCOM1.Size = new System.Drawing.Size(138, 29);
            this.cbCOM1.TabIndex = 3;
            // 
            // cbCOM2
            // 
            this.cbCOM2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCOM2.FormattingEnabled = true;
            this.cbCOM2.Location = new System.Drawing.Point(855, 83);
            this.cbCOM2.Name = "cbCOM2";
            this.cbCOM2.Size = new System.Drawing.Size(138, 29);
            this.cbCOM2.TabIndex = 4;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConnect.Location = new System.Drawing.Point(51, 170);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(163, 70);
            this.BtnConnect.TabIndex = 5;
            this.BtnConnect.Text = "传感器连接";
            this.BtnConnect.UseVisualStyleBackColor = true;
            // 
            // BtnRecord
            // 
            this.BtnRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRecord.Location = new System.Drawing.Point(491, 170);
            this.BtnRecord.Name = "BtnRecord";
            this.BtnRecord.Size = new System.Drawing.Size(163, 70);
            this.BtnRecord.TabIndex = 6;
            this.BtnRecord.Text = "开始记录";
            this.BtnRecord.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(895, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "结束记录";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(907, 544);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(913, 5);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(314, 544);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1241, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 602);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "轨道检测采集系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.TabDataCollect.ResumeLayout(false);
            this.TabDataProcess.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabDataCollect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnParaSet;
        private System.Windows.Forms.TabPage TabDataProcess;
        private System.Windows.Forms.ComboBox cbCOM2;
        private System.Windows.Forms.ComboBox cbCOM1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnRecord;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

