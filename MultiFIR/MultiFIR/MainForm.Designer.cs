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
            this.labelNextAnnotationGPUDevice = new System.Windows.Forms.Label();
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
            this.labelValidateSelectOpenCLPlatform = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxCompilerAvailable = new System.Windows.Forms.TextBox();
            this.textBoxAvailable = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxAddressBits = new System.Windows.Forms.TextBox();
            this.textBoxMaxGroupSize = new System.Windows.Forms.TextBox();
            this.textBoxMaxWorkItemSize = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxGlobalMemorySize = new System.Windows.Forms.TextBox();
            this.textBoxLocalMemorySize = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxMaxFrequency = new System.Windows.Forms.TextBox();
            this.textBoxComputeUnit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDeviceType = new System.Windows.Forms.TextBox();
            this.textBoxDriverVersion = new System.Windows.Forms.TextBox();
            this.textBoxDeviceVendor = new System.Windows.Forms.TextBox();
            this.textBoxDeviceVersion = new System.Windows.Forms.TextBox();
            this.textBoxDevicePlatform = new System.Windows.Forms.TextBox();
            this.textBoxDeviceName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGPUDevice = new System.Windows.Forms.ComboBox();
            this.tabPageASIO = new System.Windows.Forms.TabPage();
            this.tabPageFilter = new System.Windows.Forms.TabPage();
            this.tabPageControl = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageOpenCL.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageGPU.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tabPageOpenCL.Text = "OpenCL設定";
            this.tabPageOpenCL.UseVisualStyleBackColor = true;
            // 
            // labelNextAnnotationGPUDevice
            // 
            this.labelNextAnnotationGPUDevice.AutoSize = true;
            this.labelNextAnnotationGPUDevice.Location = new System.Drawing.Point(300, 9);
            this.labelNextAnnotationGPUDevice.Name = "labelNextAnnotationGPUDevice";
            this.labelNextAnnotationGPUDevice.Size = new System.Drawing.Size(0, 12);
            this.labelNextAnnotationGPUDevice.TabIndex = 3;
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
            this.comboBoxOpenCLPlatform.Size = new System.Drawing.Size(156, 20);
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
            this.tabPageGPU.Text = "GPU設定";
            this.tabPageGPU.UseVisualStyleBackColor = true;
            // 
            // labelValidateSelectOpenCLPlatform
            // 
            this.labelValidateSelectOpenCLPlatform.AutoSize = true;
            this.labelValidateSelectOpenCLPlatform.ForeColor = System.Drawing.Color.DarkRed;
            this.labelValidateSelectOpenCLPlatform.Location = new System.Drawing.Point(259, 9);
            this.labelValidateSelectOpenCLPlatform.Name = "labelValidateSelectOpenCLPlatform";
            this.labelValidateSelectOpenCLPlatform.Size = new System.Drawing.Size(179, 12);
            this.labelValidateSelectOpenCLPlatform.TabIndex = 3;
            this.labelValidateSelectOpenCLPlatform.Text = "OpenCLプラットフォームが未選択です";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.textBoxCompilerAvailable);
            this.groupBox2.Controls.Add(this.textBoxAvailable);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBoxAddressBits);
            this.groupBox2.Controls.Add(this.textBoxMaxGroupSize);
            this.groupBox2.Controls.Add(this.textBoxMaxWorkItemSize);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBoxGlobalMemorySize);
            this.groupBox2.Controls.Add(this.textBoxLocalMemorySize);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxMaxFrequency);
            this.groupBox2.Controls.Add(this.textBoxComputeUnit);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxDeviceType);
            this.groupBox2.Controls.Add(this.textBoxDriverVersion);
            this.groupBox2.Controls.Add(this.textBoxDeviceVendor);
            this.groupBox2.Controls.Add(this.textBoxDeviceVersion);
            this.groupBox2.Controls.Add(this.textBoxDevicePlatform);
            this.groupBox2.Controls.Add(this.textBoxDeviceName);
            this.groupBox2.Location = new System.Drawing.Point(5, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 324);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GPU デバイス情報";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 202);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 12);
            this.label21.TabIndex = 29;
            this.label21.Text = "コンパイラ利用可";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 12);
            this.label20.TabIndex = 28;
            this.label20.Text = "デバイス利用可";
            // 
            // textBoxCompilerAvailable
            // 
            this.textBoxCompilerAvailable.Enabled = false;
            this.textBoxCompilerAvailable.Location = new System.Drawing.Point(113, 199);
            this.textBoxCompilerAvailable.Name = "textBoxCompilerAvailable";
            this.textBoxCompilerAvailable.Size = new System.Drawing.Size(169, 19);
            this.textBoxCompilerAvailable.TabIndex = 27;
            // 
            // textBoxAvailable
            // 
            this.textBoxAvailable.Enabled = false;
            this.textBoxAvailable.Location = new System.Drawing.Point(113, 174);
            this.textBoxAvailable.Name = "textBoxAvailable";
            this.textBoxAvailable.Size = new System.Drawing.Size(169, 19);
            this.textBoxAvailable.TabIndex = 26;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(354, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 12);
            this.label19.TabIndex = 25;
            this.label19.Text = "最大グループ数";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(354, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 12);
            this.label18.TabIndex = 24;
            this.label18.Text = "最大ワーカー数";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(354, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 23;
            this.label17.Text = "アドレス空間";
            // 
            // textBoxAddressBits
            // 
            this.textBoxAddressBits.Enabled = false;
            this.textBoxAddressBits.Location = new System.Drawing.Point(461, 123);
            this.textBoxAddressBits.Name = "textBoxAddressBits";
            this.textBoxAddressBits.Size = new System.Drawing.Size(169, 19);
            this.textBoxAddressBits.TabIndex = 22;
            // 
            // textBoxMaxGroupSize
            // 
            this.textBoxMaxGroupSize.Enabled = false;
            this.textBoxMaxGroupSize.Location = new System.Drawing.Point(461, 174);
            this.textBoxMaxGroupSize.Name = "textBoxMaxGroupSize";
            this.textBoxMaxGroupSize.Size = new System.Drawing.Size(169, 19);
            this.textBoxMaxGroupSize.TabIndex = 21;
            // 
            // textBoxMaxWorkItemSize
            // 
            this.textBoxMaxWorkItemSize.Enabled = false;
            this.textBoxMaxWorkItemSize.Location = new System.Drawing.Point(461, 149);
            this.textBoxMaxWorkItemSize.Name = "textBoxMaxWorkItemSize";
            this.textBoxMaxWorkItemSize.Size = new System.Drawing.Size(169, 19);
            this.textBoxMaxWorkItemSize.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(354, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "グローバルメモリ容量";
            // 
            // textBoxGlobalMemorySize
            // 
            this.textBoxGlobalMemorySize.Enabled = false;
            this.textBoxGlobalMemorySize.Location = new System.Drawing.Point(461, 97);
            this.textBoxGlobalMemorySize.Name = "textBoxGlobalMemorySize";
            this.textBoxGlobalMemorySize.Size = new System.Drawing.Size(169, 19);
            this.textBoxGlobalMemorySize.TabIndex = 18;
            // 
            // textBoxLocalMemorySize
            // 
            this.textBoxLocalMemorySize.Enabled = false;
            this.textBoxLocalMemorySize.Location = new System.Drawing.Point(461, 71);
            this.textBoxLocalMemorySize.Name = "textBoxLocalMemorySize";
            this.textBoxLocalMemorySize.Size = new System.Drawing.Size(169, 19);
            this.textBoxLocalMemorySize.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(354, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 12);
            this.label15.TabIndex = 16;
            this.label15.Text = "ローカルメモリ容量";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(354, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "最大動作周波数";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "演算ユニット数";
            // 
            // textBoxMaxFrequency
            // 
            this.textBoxMaxFrequency.Enabled = false;
            this.textBoxMaxFrequency.Location = new System.Drawing.Point(461, 45);
            this.textBoxMaxFrequency.Name = "textBoxMaxFrequency";
            this.textBoxMaxFrequency.Size = new System.Drawing.Size(169, 19);
            this.textBoxMaxFrequency.TabIndex = 13;
            // 
            // textBoxComputeUnit
            // 
            this.textBoxComputeUnit.Enabled = false;
            this.textBoxComputeUnit.Location = new System.Drawing.Point(461, 19);
            this.textBoxComputeUnit.Name = "textBoxComputeUnit";
            this.textBoxComputeUnit.Size = new System.Drawing.Size(169, 19);
            this.textBoxComputeUnit.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "デバイスの種類";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "ドライババージョン";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "ベンダー";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "バージョン";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "プラットフォーム";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "デバイス名";
            // 
            // textBoxDeviceType
            // 
            this.textBoxDeviceType.Enabled = false;
            this.textBoxDeviceType.Location = new System.Drawing.Point(113, 149);
            this.textBoxDeviceType.Name = "textBoxDeviceType";
            this.textBoxDeviceType.Size = new System.Drawing.Size(169, 19);
            this.textBoxDeviceType.TabIndex = 5;
            // 
            // textBoxDriverVersion
            // 
            this.textBoxDriverVersion.Enabled = false;
            this.textBoxDriverVersion.Location = new System.Drawing.Point(113, 123);
            this.textBoxDriverVersion.Name = "textBoxDriverVersion";
            this.textBoxDriverVersion.Size = new System.Drawing.Size(169, 19);
            this.textBoxDriverVersion.TabIndex = 4;
            // 
            // textBoxDeviceVendor
            // 
            this.textBoxDeviceVendor.Enabled = false;
            this.textBoxDeviceVendor.Location = new System.Drawing.Point(113, 97);
            this.textBoxDeviceVendor.Name = "textBoxDeviceVendor";
            this.textBoxDeviceVendor.Size = new System.Drawing.Size(169, 19);
            this.textBoxDeviceVendor.TabIndex = 3;
            // 
            // textBoxDeviceVersion
            // 
            this.textBoxDeviceVersion.Enabled = false;
            this.textBoxDeviceVersion.Location = new System.Drawing.Point(113, 71);
            this.textBoxDeviceVersion.Name = "textBoxDeviceVersion";
            this.textBoxDeviceVersion.Size = new System.Drawing.Size(169, 19);
            this.textBoxDeviceVersion.TabIndex = 2;
            // 
            // textBoxDevicePlatform
            // 
            this.textBoxDevicePlatform.Enabled = false;
            this.textBoxDevicePlatform.Location = new System.Drawing.Point(113, 45);
            this.textBoxDevicePlatform.Name = "textBoxDevicePlatform";
            this.textBoxDevicePlatform.Size = new System.Drawing.Size(169, 19);
            this.textBoxDevicePlatform.TabIndex = 1;
            // 
            // textBoxDeviceName
            // 
            this.textBoxDeviceName.Enabled = false;
            this.textBoxDeviceName.Location = new System.Drawing.Point(113, 19);
            this.textBoxDeviceName.Name = "textBoxDeviceName";
            this.textBoxDeviceName.Size = new System.Drawing.Size(169, 19);
            this.textBoxDeviceName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "GPU デバイス";
            // 
            // comboBoxGPUDevice
            // 
            this.comboBoxGPUDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGPUDevice.Enabled = false;
            this.comboBoxGPUDevice.FormattingEnabled = true;
            this.comboBoxGPUDevice.Location = new System.Drawing.Point(79, 6);
            this.comboBoxGPUDevice.Name = "comboBoxGPUDevice";
            this.comboBoxGPUDevice.Size = new System.Drawing.Size(171, 20);
            this.comboBoxGPUDevice.TabIndex = 0;
            this.comboBoxGPUDevice.TextChanged += new System.EventHandler(this.SelectedGPUDevice);
            // 
            // tabPageASIO
            // 
            this.tabPageASIO.Location = new System.Drawing.Point(4, 22);
            this.tabPageASIO.Name = "tabPageASIO";
            this.tabPageASIO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageASIO.Size = new System.Drawing.Size(768, 360);
            this.tabPageASIO.TabIndex = 1;
            this.tabPageASIO.Text = "ASIO設定";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageGPU.ResumeLayout(false);
            this.tabPageGPU.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxDevicePlatform;
        private System.Windows.Forms.TextBox textBoxDeviceName;
        private System.Windows.Forms.TextBox textBoxDeviceType;
        private System.Windows.Forms.TextBox textBoxDriverVersion;
        private System.Windows.Forms.TextBox textBoxDeviceVendor;
        private System.Windows.Forms.TextBox textBoxDeviceVersion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLocalMemorySize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxMaxFrequency;
        private System.Windows.Forms.TextBox textBoxComputeUnit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxGlobalMemorySize;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxAddressBits;
        private System.Windows.Forms.TextBox textBoxMaxGroupSize;
        private System.Windows.Forms.TextBox textBoxMaxWorkItemSize;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxCompilerAvailable;
        private System.Windows.Forms.TextBox textBoxAvailable;
    }
}

