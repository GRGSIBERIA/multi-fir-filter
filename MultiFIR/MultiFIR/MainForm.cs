﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCL.Net;
using MultiFIR.Library;

namespace MultiFIR
{
    public partial class MainForm : Form
    {
        OpenCLProvider opencl;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ClCheckError(OpenCL.Net.ErrorCode error, string name)
        {
            if (error != ErrorCode.Success)
                Console.WriteLine("Error: " + name + " (" + error.ToString() + ")");
        }

        private void ContextNotify(string errorInfo, byte[] data, IntPtr cb, IntPtr userData)
        {
            Console.WriteLine("OpenCL Notification: " + errorInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            opencl = new OpenCLProvider();

            InitOpenCLComboBox();
            InitASIOComboBox();
            InitGPUComboBox();

            SetToolTips();
        }

        private void InitGPUComboBox()
        {
            
        }

        private void InitASIOComboBox()
        {
            
        }

        private void InitOpenCLComboBox()
        {
            foreach (var platform in opencl.PlatformInformations)
            {
                comboBoxOpenCLPlatform.Items.Add(platform.Name);
            }
        }

        private void SetToolTips()
        {
            toolTip = new ToolTip(this.components);

            toolTip.InitialDelay = 2000;
            toolTip.ReshowDelay = 1000;
            toolTip.AutoPopDelay = 1000;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(comboBoxOpenCLPlatform, "OpenCLがインストールされたプラットフォーム情報を表示します");
            toolTip.SetToolTip(textBoxDevicePlatform, "環境によって文字化けします");
            toolTip.SetToolTip(textBoxDeviceType, "環境によって文字化けします");
        }

        private void SetTextAndReadOnlyEnabled(TextBox target, string text, string suffix="")
        {
            target.Text = text + " " + suffix;
            target.Enabled = true;
            target.ReadOnly = true;
        }

        private void SelectedOpenCLPlatform(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            var index = combo.SelectedIndex;
            opencl.SelectedPlatformIndex = index;

            // OpenCLプラットフォームが選択されたときの各種情報を入れる
            var info = opencl.SelectedPlatformInformation;
            SetTextAndReadOnlyEnabled(textBoxPlatformName, info.Name);
            SetTextAndReadOnlyEnabled(textBoxPlatformVendor, info.Vendor);
            SetTextAndReadOnlyEnabled(textBoxPlatformVersion, info.Version);
            SetTextAndReadOnlyEnabled(textBoxPlatformProfile, info.Profile);

            // GPU情報を選択させる
            labelValidateSelectOpenCLPlatform.Text = "";
            comboBoxGPUDevice.Enabled = true;
            labelNextAnnotationGPUDevice.Text = "GPU情報タブで演算するGPUデバイスを選択してください";

            opencl.IncludeDevices();
            foreach (var device in opencl.DeviceInformations)
            {
                comboBoxGPUDevice.Items.Add(device.Name);
            }
            
        }

        private void SelectedGPUDevice(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            var index = combo.SelectedIndex;
            opencl.SelectedDeviceIndex = index;

            var info = opencl.SelectedDeviceInformation;
            SetTextAndReadOnlyEnabled(textBoxDeviceName, info.Name);
            SetTextAndReadOnlyEnabled(textBoxDevicePlatform, info.Platform);
            SetTextAndReadOnlyEnabled(textBoxDeviceVendor, info.Vendor);
            SetTextAndReadOnlyEnabled(textBoxDeviceVersion, info.Version);
            SetTextAndReadOnlyEnabled(textBoxDeviceType, info.DeviceType);
            SetTextAndReadOnlyEnabled(textBoxAvailable, info.Available);
            SetTextAndReadOnlyEnabled(textBoxCompilerAvailable, info.CompilerAvailable);
            SetTextAndReadOnlyEnabled(textBoxDriverVersion, info.DriverVersion);
        }
    }
}
