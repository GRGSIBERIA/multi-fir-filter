namespace RawComverter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.selectDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "File or Directory Path (Enable D&&D)";
            // 
            // filePathBox
            // 
            this.filePathBox.AllowDrop = true;
            this.filePathBox.Location = new System.Drawing.Point(15, 28);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.Size = new System.Drawing.Size(286, 19);
            this.filePathBox.TabIndex = 1;
            this.filePathBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.filePathBox_DragDrop);
            this.filePathBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.filePathBox_DragEnter);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(226, 53);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // selectDialog
            // 
            this.selectDialog.Location = new System.Drawing.Point(308, 28);
            this.selectDialog.Name = "selectDialog";
            this.selectDialog.Size = new System.Drawing.Size(30, 19);
            this.selectDialog.TabIndex = 3;
            this.selectDialog.Text = "...";
            this.selectDialog.UseVisualStyleBackColor = true;
            this.selectDialog.Click += new System.EventHandler(this.selectDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 82);
            this.Controls.Add(this.selectDialog);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Raw Image Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button selectDialog;
    }
}

