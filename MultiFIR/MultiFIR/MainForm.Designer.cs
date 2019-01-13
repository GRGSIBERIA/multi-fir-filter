namespace MultiFIR
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPlatformProfile = new System.Windows.Forms.TextBox();
            this.textBoxPlatformVersion = new System.Windows.Forms.TextBox();
            this.textBoxPlatformVendor = new System.Windows.Forms.TextBox();
            this.textBoxPlatformName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOpenCLPlatform = new System.Windows.Forms.ComboBox();
            this.tabPageGPU = new System.Windows.Forms.TabPage();
            this.tabPageASIO = new System.Windows.Forms.TabPage();
            this.tabPageFilter = new System.Windows.Forms.TabPage();
            this.tabPageControl = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxGPUDevice = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelValidateSelectOpenCLPlatform = new System.Windows.Forms.Label();
            this.labelNextAnnotationGPUDevice = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageOpenCL.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageGPU.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOpenCL);
            this.tabControl1.Controls.Add(this.tabPageGPU);
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
            this.tabPageOpenCL.Controls.Add(this.labelNextAnnotationGPUDevice);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "OpenCL プラットフォーム";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPlatformProfile);
            this.groupBox1.Controls.Add(this.textBoxPlatformVersion);
            this.groupBox1.Controls.Add(this.textBoxPlatformVendor);
            this.groupBox1.Controls.Add(this.textBoxPlatformName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 322);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "プラットフォーム情報";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "プロファイル";
            // 
            // textBoxPlatformProfile
            // 
            this.textBoxPlatformProfile.Enabled = false;
            this.textBoxPlatformProfile.Location = new System.Drawing.Point(111, 97);
            this.textBoxPlatformProfile.Name = "textBoxPlatformProfile";
            this.textBoxPlatformProfile.Size = new System.Drawing.Size(166, 19);
            this.textBoxPlatformProfile.TabIndex = 6;
            // 
            // textBoxPlatformVersion
            // 
            this.textBoxPlatformVersion.Enabled = false;
            this.textBoxPlatformVersion.Location = new System.Drawing.Point(111, 71);
            this.textBoxPlatformVersion.Name = "textBoxPlatformVersion";
            this.textBoxPlatformVersion.Size = new System.Drawing.Size(166, 19);
            this.textBoxPlatformVersion.TabIndex = 5;
            // 
            // textBoxPlatformVendor
            // 
            this.textBoxPlatformVendor.Enabled = false;
            this.textBoxPlatformVendor.Location = new System.Drawing.Point(111, 45);
            this.textBoxPlatformVendor.Name = "textBoxPlatformVendor";
            this.textBoxPlatformVendor.Size = new System.Drawing.Size(166, 19);
            this.textBoxPlatformVendor.TabIndex = 4;
            // 
            // textBoxPlatformName
            // 
            this.textBoxPlatformName.Enabled = false;
            this.textBoxPlatformName.Location = new System.Drawing.Point(111, 19);
            this.textBoxPlatformName.Name = "textBoxPlatformName";
            this.textBoxPlatformName.Size = new System.Drawing.Size(166, 19);
            this.textBoxPlatformName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "ベンダー";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "バージョン";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "プラットフォーム名";
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
            this.comboBoxOpenCLPlatform.TextChanged += new System.EventHandler(this.SelectedOpenCLPlatform);
            // 
            // tabPageGPU
            // 
            this.tabPageGPU.Controls.Add(this.labelValidateSelectOpenCLPlatform);
            this.tabPageGPU.Controls.Add(this.groupBox2);
            this.tabPageGPU.Controls.Add(this.label6);
            this.tabPageGPU.Controls.Add(this.comboBoxGPUDevice);
            this.tabPageGPU.Location = new System.Drawing.Point(4, 22);
            this.tabPageGPU.Name = "tabPageGPU";
            this.tabPageGPU.Size = new System.Drawing.Size(768, 360);
            this.tabPageGPU.TabIndex = 4;
            this.tabPageGPU.Text = "GPU情報";
            this.tabPageGPU.UseVisualStyleBackColor = true;
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
            // comboBoxGPUDevice
            // 
            this.comboBoxGPUDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGPUDevice.Enabled = false;
            this.comboBoxGPUDevice.FormattingEnabled = true;
            this.comboBoxGPUDevice.Location = new System.Drawing.Point(75, 6);
            this.comboBoxGPUDevice.Name = "comboBoxGPUDevice";
            this.comboBoxGPUDevice.Size = new System.Drawing.Size(121, 20);
            this.comboBoxGPUDevice.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "GPUデバイス";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(5, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 324);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GPUデバイス情報";
            // 
            // labelValidateSelectOpenCLPlatform
            // 
            this.labelValidateSelectOpenCLPlatform.AutoSize = true;
            this.labelValidateSelectOpenCLPlatform.ForeColor = System.Drawing.Color.DarkRed;
            this.labelValidateSelectOpenCLPlatform.Location = new System.Drawing.Point(202, 9);
            this.labelValidateSelectOpenCLPlatform.Name = "labelValidateSelectOpenCLPlatform";
            this.labelValidateSelectOpenCLPlatform.Size = new System.Drawing.Size(179, 12);
            this.labelValidateSelectOpenCLPlatform.TabIndex = 3;
            this.labelValidateSelectOpenCLPlatform.Text = "OpenCLプラットフォームが未選択です";
            // 
            // labelNextAnnotationGPUDevice
            // 
            this.labelNextAnnotationGPUDevice.AutoSize = true;
            this.labelNextAnnotationGPUDevice.Location = new System.Drawing.Point(256, 9);
            this.labelNextAnnotationGPUDevice.Name = "labelNextAnnotationGPUDevice";
            this.labelNextAnnotationGPUDevice.Size = new System.Drawing.Size(0, 12);
            this.labelNextAnnotationGPUDevice.TabIndex = 3;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageGPU.ResumeLayout(false);
            this.tabPageGPU.PerformLayout();
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
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlatformVersion;
        private System.Windows.Forms.TextBox textBoxPlatformVendor;
        private System.Windows.Forms.TextBox textBoxPlatformName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageGPU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPlatformProfile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGPUDevice;
        private System.Windows.Forms.Label labelValidateSelectOpenCLPlatform;
        private System.Windows.Forms.Label labelNextAnnotationGPUDevice;
    }
}

