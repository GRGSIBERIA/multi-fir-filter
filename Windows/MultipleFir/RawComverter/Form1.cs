using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace RawComverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filePathBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void filePathBox_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                filePathBox.Text = files[0];
            }
        }

        private void Convert(string path)
        {
            var image = Image.FromFile(path);
            var canvas = new Bitmap(image);
            FileStream fs = new FileStream(path + ".raw", FileMode.Create, FileAccess.Write);

            // 高さと幅を入力する
            fs.Write(BitConverter.GetBytes(image.Width), 0, 4);
            fs.Write(BitConverter.GetBytes(image.Height),0, 4);

            // 横に並んだピクセル情報を取得して書き出す
            int counter = 8;
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    var pixel = canvas.GetPixel(x, y);
                    var bytes = new byte[] { pixel.R, pixel.G, pixel.B, pixel.A };
                    fs.Write(bytes, 0, 4);
                    counter += 4;
                }
            }
            fs.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            var path = filePathBox.Text;

            
            if (File.Exists(path))
            {
                try
                {
                    Convert(path);
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Invalid Image File.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Directory.Exists(path))
            {
                var pathes = Directory.GetFiles(path);  // ディレクトリ単位

                foreach (var p in pathes)
                {
                    Convert(p);
                }
            }
        }

        private void selectDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.CheckFileExists = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePathBox.Text = dialog.FileName;
            }
        }
    }
}
