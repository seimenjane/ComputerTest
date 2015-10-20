namespace config
{
    partial class setupWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diskTest = new System.Windows.Forms.Button();
            this.diskDetail = new System.Windows.Forms.Label();
            this.diskSelector = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.ipTest = new System.Windows.Forms.Button();
            this.ipGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ipInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.ipGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.diskTest);
            this.groupBox1.Controls.Add(this.diskDetail);
            this.groupBox1.Controls.Add(this.diskSelector);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据盘设置";
            // 
            // diskTest
            // 
            this.diskTest.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.diskTest.Location = new System.Drawing.Point(156, 37);
            this.diskTest.Name = "diskTest";
            this.diskTest.Size = new System.Drawing.Size(75, 23);
            this.diskTest.TabIndex = 2;
            this.diskTest.Text = "测试";
            this.diskTest.UseVisualStyleBackColor = true;
            this.diskTest.Click += new System.EventHandler(this.diskTest_Click);
            // 
            // diskDetail
            // 
            this.diskDetail.AutoSize = true;
            this.diskDetail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.diskDetail.Location = new System.Drawing.Point(6, 115);
            this.diskDetail.Name = "diskDetail";
            this.diskDetail.Size = new System.Drawing.Size(0, 16);
            this.diskDetail.TabIndex = 1;
            // 
            // diskSelector
            // 
            this.diskSelector.FormattingEnabled = true;
            this.diskSelector.Items.AddRange(new object[] {
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.diskSelector.Location = new System.Drawing.Point(6, 37);
            this.diskSelector.Name = "diskSelector";
            this.diskSelector.Size = new System.Drawing.Size(113, 24);
            this.diskSelector.TabIndex = 0;
            this.diskSelector.SelectedIndexChanged += new System.EventHandler(this.diskSelector_SelectedIndexChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(480, 253);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "保存";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ipTest
            // 
            this.ipTest.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ipTest.Location = new System.Drawing.Point(64, 115);
            this.ipTest.Name = "ipTest";
            this.ipTest.Size = new System.Drawing.Size(75, 23);
            this.ipTest.TabIndex = 3;
            this.ipTest.Text = "测试";
            this.ipTest.UseVisualStyleBackColor = true;
            this.ipTest.Click += new System.EventHandler(this.ipTest_Click);
            // 
            // ipGroup
            // 
            this.ipGroup.Controls.Add(this.label1);
            this.ipGroup.Controls.Add(this.ipTest);
            this.ipGroup.Controls.Add(this.ipInput);
            this.ipGroup.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ipGroup.Location = new System.Drawing.Point(355, 12);
            this.ipGroup.Name = "ipGroup";
            this.ipGroup.Size = new System.Drawing.Size(200, 162);
            this.ipGroup.TabIndex = 4;
            this.ipGroup.TabStop = false;
            this.ipGroup.Text = "教师机地址";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入教师机的ip地址";
            // 
            // ipInput
            // 
            this.ipInput.Location = new System.Drawing.Point(9, 67);
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(142, 26);
            this.ipInput.TabIndex = 0;
            // 
            // setupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 300);
            this.Controls.Add(this.ipGroup);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "setupWindow";
            this.Text = "设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ipGroup.ResumeLayout(false);
            this.ipGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label diskDetail;
        private System.Windows.Forms.ComboBox diskSelector;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button ipTest;
        private System.Windows.Forms.GroupBox ipGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipInput;
        private System.Windows.Forms.Button diskTest;
    }
}

