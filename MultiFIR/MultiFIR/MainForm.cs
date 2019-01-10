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

namespace MultiFIR
{
    public partial class MainForm : Form
    {
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
            InitOpenCLComboBox();
            SetToolTips();
        }

        private void InitOpenCLComboBox()
        {
            ErrorCode error;
            Cl.GetPlatformIDs(out error);
            var platforms = Cl.GetPlatformIDs(out error);

            foreach (var platform in platforms)
            {
                var platformName = Cl.GetPlatformInfo(platform, PlatformInfo.Name, out error).ToString();
                comboBoxOpenCLPlatform.Items.Add(platformName);
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
    }
}
