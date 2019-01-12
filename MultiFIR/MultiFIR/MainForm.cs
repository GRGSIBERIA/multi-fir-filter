using System;
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
            toolTip1 = new ToolTip(this.components);

            toolTip1.InitialDelay = 2000;
            toolTip1.ReshowDelay = 1000;
            toolTip1.AutoPopDelay = 1000;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(comboBoxOpenCLPlatform, "OpenCLがインストールされたプラットフォーム情報を表示します");
        }

        private void SelectedOpenCLPlatform(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            var index = combo.SelectedIndex;
            opencl.SelectedPlatformIndex = index;

            // OpenCLプラットフォームが選択されたときの各種情報を入れる

        }
    }
}
