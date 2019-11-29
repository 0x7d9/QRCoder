namespace QRCoderDemo
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelECC = new System.Windows.Forms.Label();
            this.comboBoxECC = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.textBoxQRCode = new System.Windows.Forms.TextBox();
            this.iconSize = new System.Windows.Forms.NumericUpDown();
            this.labelIconsize = new System.Windows.Forms.Label();
            this.selectIconBtn = new System.Windows.Forms.Button();
            this.iconPath = new System.Windows.Forms.TextBox();
            this.labelIcon = new System.Windows.Forms.Label();
            this.labelNotice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).BeginInit();
            this.SuspendLayout();
            // 
            // labelECC
            // 
            this.labelECC.AutoSize = true;
            this.labelECC.Location = new System.Drawing.Point(12, 15);
            this.labelECC.Name = "labelECC";
            this.labelECC.Size = new System.Drawing.Size(59, 12);
            this.labelECC.TabIndex = 0;
            this.labelECC.Text = "ECC-Level";
            // 
            // comboBoxECC
            // 
            this.comboBoxECC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxECC.FormattingEnabled = true;
            this.comboBoxECC.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.comboBoxECC.Location = new System.Drawing.Point(77, 12);
            this.comboBoxECC.Name = "comboBoxECC";
            this.comboBoxECC.Size = new System.Drawing.Size(125, 20);
            this.comboBoxECC.TabIndex = 4;
            this.comboBoxECC.SelectedIndexChanged += new System.EventHandler(this.ComboBoxECC_SelectedIndexChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGenerate.Location = new System.Drawing.Point(279, 462);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(85, 23);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Generate(&E)";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(682, 462);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save QR code";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQRCode.Location = new System.Drawing.Point(370, 38);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(402, 418);
            this.pictureBoxQRCode.TabIndex = 11;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // textBoxQRCode
            // 
            this.textBoxQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxQRCode.Location = new System.Drawing.Point(14, 38);
            this.textBoxQRCode.Multiline = true;
            this.textBoxQRCode.Name = "textBoxQRCode";
            this.textBoxQRCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQRCode.Size = new System.Drawing.Size(350, 418);
            this.textBoxQRCode.TabIndex = 13;
            this.textBoxQRCode.TextChanged += new System.EventHandler(this.TextBoxQRCode_TextChanged);
            // 
            // iconSize
            // 
            this.iconSize.Location = new System.Drawing.Point(439, 11);
            this.iconSize.Name = "iconSize";
            this.iconSize.Size = new System.Drawing.Size(80, 21);
            this.iconSize.TabIndex = 18;
            // 
            // labelIconsize
            // 
            this.labelIconsize.AutoSize = true;
            this.labelIconsize.Location = new System.Drawing.Point(368, 15);
            this.labelIconsize.Name = "labelIconsize";
            this.labelIconsize.Size = new System.Drawing.Size(65, 12);
            this.labelIconsize.TabIndex = 17;
            this.labelIconsize.Text = "Icon size:";
            // 
            // selectIconBtn
            // 
            this.selectIconBtn.Location = new System.Drawing.Point(682, 8);
            this.selectIconBtn.Name = "selectIconBtn";
            this.selectIconBtn.Size = new System.Drawing.Size(61, 23);
            this.selectIconBtn.TabIndex = 16;
            this.selectIconBtn.Text = "Select";
            this.selectIconBtn.UseVisualStyleBackColor = true;
            this.selectIconBtn.Click += new System.EventHandler(this.SelectIconBtn_Click);
            // 
            // iconPath
            // 
            this.iconPath.Location = new System.Drawing.Point(566, 10);
            this.iconPath.Name = "iconPath";
            this.iconPath.Size = new System.Drawing.Size(110, 21);
            this.iconPath.TabIndex = 15;
            // 
            // labelIcon
            // 
            this.labelIcon.AutoSize = true;
            this.labelIcon.Location = new System.Drawing.Point(525, 15);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(35, 12);
            this.labelIcon.TabIndex = 14;
            this.labelIcon.Text = "Icon:";
            // 
            // labelNotice
            // 
            this.labelNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNotice.AutoSize = true;
            this.labelNotice.ForeColor = System.Drawing.Color.Red;
            this.labelNotice.Location = new System.Drawing.Point(370, 467);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(71, 12);
            this.labelNotice.TabIndex = 19;
            this.labelNotice.Text = "labelNotice";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 497);
            this.Controls.Add(this.labelNotice);
            this.Controls.Add(this.iconSize);
            this.Controls.Add(this.labelIconsize);
            this.Controls.Add(this.selectIconBtn);
            this.Controls.Add(this.iconPath);
            this.Controls.Add(this.labelIcon);
            this.Controls.Add(this.textBoxQRCode);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.comboBoxECC);
            this.Controls.Add(this.labelECC);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelECC;
        private System.Windows.Forms.ComboBox comboBoxECC;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.TextBox textBoxQRCode;
        private System.Windows.Forms.NumericUpDown iconSize;
        private System.Windows.Forms.Label labelIconsize;
        private System.Windows.Forms.Button selectIconBtn;
        private System.Windows.Forms.TextBox iconPath;
        private System.Windows.Forms.Label labelIcon;
        private System.Windows.Forms.Label labelNotice;
    }
}

