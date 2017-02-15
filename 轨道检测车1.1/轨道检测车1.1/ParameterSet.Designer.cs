namespace 轨道检测车1._1
{
    partial class ParameterSet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GBMileage = new System.Windows.Forms.GroupBox();
            this.GBShift = new System.Windows.Forms.GroupBox();
            this.GBFaro = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TboxCurMileage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbPort1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TboxPath1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TboxBaseName1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbPort2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TboxOffset = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TboxPath2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TboxBaseName2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TboxAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TboxSplitLines = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TboxNumCols = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TboxRate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.GBMileage.SuspendLayout();
            this.GBShift.SuspendLayout();
            this.GBFaro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GBFaro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 332);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GBMileage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 335);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GBShift);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(534, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 335);
            this.panel3.TabIndex = 2;
            // 
            // GBMileage
            // 
            this.GBMileage.Controls.Add(this.TboxBaseName1);
            this.GBMileage.Controls.Add(this.label4);
            this.GBMileage.Controls.Add(this.TboxPath1);
            this.GBMileage.Controls.Add(this.label3);
            this.GBMileage.Controls.Add(this.CbPort1);
            this.GBMileage.Controls.Add(this.label2);
            this.GBMileage.Controls.Add(this.TboxCurMileage);
            this.GBMileage.Controls.Add(this.label1);
            this.GBMileage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBMileage.Location = new System.Drawing.Point(0, 0);
            this.GBMileage.Name = "GBMileage";
            this.GBMileage.Size = new System.Drawing.Size(534, 335);
            this.GBMileage.TabIndex = 0;
            this.GBMileage.TabStop = false;
            this.GBMileage.Text = "里程计参数";
            // 
            // GBShift
            // 
            this.GBShift.Controls.Add(this.TboxBaseName2);
            this.GBShift.Controls.Add(this.label8);
            this.GBShift.Controls.Add(this.TboxPath2);
            this.GBShift.Controls.Add(this.label7);
            this.GBShift.Controls.Add(this.TboxOffset);
            this.GBShift.Controls.Add(this.label6);
            this.GBShift.Controls.Add(this.CbPort2);
            this.GBShift.Controls.Add(this.label5);
            this.GBShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBShift.Location = new System.Drawing.Point(0, 0);
            this.GBShift.Name = "GBShift";
            this.GBShift.Size = new System.Drawing.Size(446, 335);
            this.GBShift.TabIndex = 0;
            this.GBShift.TabStop = false;
            this.GBShift.Text = "位移计参数";
            // 
            // GBFaro
            // 
            this.GBFaro.Controls.Add(this.statusStrip1);
            this.GBFaro.Controls.Add(this.BtnCancel);
            this.GBFaro.Controls.Add(this.BtnConfirm);
            this.GBFaro.Controls.Add(this.textBox1);
            this.GBFaro.Controls.Add(this.label13);
            this.GBFaro.Controls.Add(this.TboxRate);
            this.GBFaro.Controls.Add(this.label12);
            this.GBFaro.Controls.Add(this.TboxNumCols);
            this.GBFaro.Controls.Add(this.textBox2);
            this.GBFaro.Controls.Add(this.TboxSplitLines);
            this.GBFaro.Controls.Add(this.label10);
            this.GBFaro.Controls.Add(this.TboxAddress);
            this.GBFaro.Controls.Add(this.label9);
            this.GBFaro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBFaro.Location = new System.Drawing.Point(0, 0);
            this.GBFaro.Name = "GBFaro";
            this.GBFaro.Size = new System.Drawing.Size(980, 332);
            this.GBFaro.TabIndex = 0;
            this.GBFaro.TabStop = false;
            this.GBFaro.Text = "扫描仪参数";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前里程：";
            // 
            // TboxCurMileage
            // 
            this.TboxCurMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxCurMileage.Location = new System.Drawing.Point(184, 118);
            this.TboxCurMileage.Name = "TboxCurMileage";
            this.TboxCurMileage.Size = new System.Drawing.Size(265, 31);
            this.TboxCurMileage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "连接串口：";
            // 
            // CbPort1
            // 
            this.CbPort1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbPort1.FormattingEnabled = true;
            this.CbPort1.Location = new System.Drawing.Point(184, 43);
            this.CbPort1.Name = "CbPort1";
            this.CbPort1.Size = new System.Drawing.Size(121, 29);
            this.CbPort1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "存储路径：";
            // 
            // TboxPath1
            // 
            this.TboxPath1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxPath1.Location = new System.Drawing.Point(184, 190);
            this.TboxPath1.Name = "TboxPath1";
            this.TboxPath1.Size = new System.Drawing.Size(265, 31);
            this.TboxPath1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "文件基本名：";
            // 
            // TboxBaseName1
            // 
            this.TboxBaseName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxBaseName1.Location = new System.Drawing.Point(184, 280);
            this.TboxBaseName1.Name = "TboxBaseName1";
            this.TboxBaseName1.Size = new System.Drawing.Size(265, 31);
            this.TboxBaseName1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "连接串口：";
            // 
            // CbPort2
            // 
            this.CbPort2.FormattingEnabled = true;
            this.CbPort2.Location = new System.Drawing.Point(167, 57);
            this.CbPort2.Name = "CbPort2";
            this.CbPort2.Size = new System.Drawing.Size(121, 29);
            this.CbPort2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "偏置常数：";
            // 
            // TboxOffset
            // 
            this.TboxOffset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxOffset.Location = new System.Drawing.Point(160, 118);
            this.TboxOffset.Name = "TboxOffset";
            this.TboxOffset.Size = new System.Drawing.Size(239, 31);
            this.TboxOffset.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "存储路径：";
            // 
            // TboxPath2
            // 
            this.TboxPath2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxPath2.Location = new System.Drawing.Point(160, 193);
            this.TboxPath2.Name = "TboxPath2";
            this.TboxPath2.Size = new System.Drawing.Size(239, 31);
            this.TboxPath2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "文件基本名：";
            // 
            // TboxBaseName2
            // 
            this.TboxBaseName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxBaseName2.Location = new System.Drawing.Point(160, 280);
            this.TboxBaseName2.Name = "TboxBaseName2";
            this.TboxBaseName2.Size = new System.Drawing.Size(239, 31);
            this.TboxBaseName2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "IP地址：";
            // 
            // TboxAddress
            // 
            this.TboxAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxAddress.Location = new System.Drawing.Point(225, 41);
            this.TboxAddress.Name = "TboxAddress";
            this.TboxAddress.Size = new System.Drawing.Size(320, 31);
            this.TboxAddress.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "单线数：";
            // 
            // TboxSplitLines
            // 
            this.TboxSplitLines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxSplitLines.Location = new System.Drawing.Point(225, 95);
            this.TboxSplitLines.Name = "TboxSplitLines";
            this.TboxSplitLines.Size = new System.Drawing.Size(320, 31);
            this.TboxSplitLines.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(225, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(320, 31);
            this.textBox2.TabIndex = 4;
            // 
            // TboxNumCols
            // 
            this.TboxNumCols.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxNumCols.AutoSize = true;
            this.TboxNumCols.Location = new System.Drawing.Point(71, 155);
            this.TboxNumCols.Name = "TboxNumCols";
            this.TboxNumCols.Size = new System.Drawing.Size(98, 21);
            this.TboxNumCols.TabIndex = 5;
            this.TboxNumCols.Text = "总线数：";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "扫描频率：";
            // 
            // TboxRate
            // 
            this.TboxRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxRate.Location = new System.Drawing.Point(225, 209);
            this.TboxRate.Name = "TboxRate";
            this.TboxRate.Size = new System.Drawing.Size(320, 31);
            this.TboxRate.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "文件基本名：";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(225, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 31);
            this.textBox1.TabIndex = 9;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConfirm.Location = new System.Drawing.Point(664, 245);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(108, 48);
            this.BtnConfirm.TabIndex = 10;
            this.BtnConfirm.Text = "确 定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancel.Location = new System.Drawing.Point(847, 245);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(108, 48);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "取 消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 307);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(974, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ParameterSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 667);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ParameterSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数设置";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.GBMileage.ResumeLayout(false);
            this.GBMileage.PerformLayout();
            this.GBShift.ResumeLayout(false);
            this.GBShift.PerformLayout();
            this.GBFaro.ResumeLayout(false);
            this.GBFaro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GBFaro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TboxRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TboxNumCols;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TboxSplitLines;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TboxAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox GBMileage;
        private System.Windows.Forms.TextBox TboxBaseName1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TboxPath1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TboxCurMileage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox GBShift;
        private System.Windows.Forms.TextBox TboxBaseName2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TboxPath2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TboxOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbPort2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}