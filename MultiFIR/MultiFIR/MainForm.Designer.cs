﻿namespace MultiFIR
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOpenCL = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOpenCLPlatform = new System.Windows.Forms.ComboBox();
            this.tabPageASIO = new System.Windows.Forms.TabPage();
            this.tabPageFilter = new System.Windows.Forms.TabPage();
            this.tabPageControl = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageOpenCL.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOpenCL);
            this.tabControl1.Controls.Add(this.tabPageASIO);
            this.tabControl1.Controls.Add(this.tabPageFilter);
            this.tabControl1.Controls.Add(this.tabPageControl);
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageOpenCL
            // 
            this.tabPageOpenCL.Controls.Add(this.label1);
            this.tabPageOpenCL.Controls.Add(this.groupBox1);
            this.tabPageOpenCL.Controls.Add(this.comboBoxOpenCLPlatform);
            this.tabPageOpenCL.Location = new System.Drawing.Point(4, 22);
            this.tabPageOpenCL.Name = "tabPageOpenCL";
            this.tabPageOpenCL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOpenCL.Size = new System.Drawing.Size(768, 360);
            this.tabPageOpenCL.TabIndex = 0;
            this.tabPageOpenCL.Text = "OpenCL情報";
            this.tabPageOpenCL.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 322);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "デバイス情報";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "OpenCL プラットフォーム";
            // 
            // comboBoxOpenCLPlatform
            // 
            this.comboBoxOpenCLPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpenCLPlatform.FormattingEnabled = true;
            this.comboBoxOpenCLPlatform.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxOpenCLPlatform.Location = new System.Drawing.Point(129, 6);
            this.comboBoxOpenCLPlatform.Name = "comboBoxOpenCLPlatform";
            this.comboBoxOpenCLPlatform.Size = new System.Drawing.Size(121, 20);
            this.comboBoxOpenCLPlatform.TabIndex = 0;
            // 
            // tabPageASIO
            // 
            this.tabPageASIO.Location = new System.Drawing.Point(4, 22);
            this.tabPageASIO.Name = "tabPageASIO";
            this.tabPageASIO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageASIO.Size = new System.Drawing.Size(768, 360);
            this.tabPageASIO.TabIndex = 1;
            this.tabPageASIO.Text = "ASIO情報";
            this.tabPageASIO.UseVisualStyleBackColor = true;
            // 
            // tabPageFilter
            // 
            this.tabPageFilter.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilter.Name = "tabPageFilter";
            this.tabPageFilter.Size = new System.Drawing.Size(768, 360);
            this.tabPageFilter.TabIndex = 3;
            this.tabPageFilter.Text = "フィルタ";
            this.tabPageFilter.UseVisualStyleBackColor = true;
            // 
            // tabPageControl
            // 
            this.tabPageControl.Location = new System.Drawing.Point(4, 22);
            this.tabPageControl.Name = "tabPageControl";
            this.tabPageControl.Size = new System.Drawing.Size(768, 360);
            this.tabPageControl.TabIndex = 2;
            this.tabPageControl.Text = "コントロール";
            this.tabPageControl.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.ファイルFToolStripMenuItem.Text = "ファイル (&F)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Multi FIR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOpenCL.ResumeLayout(false);
            this.tabPageOpenCL.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOpenCL;
        private System.Windows.Forms.TabPage tabPageASIO;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageControl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOpenCLPlatform;
        private System.Windows.Forms.TabPage tabPageFilter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

