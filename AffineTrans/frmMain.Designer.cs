namespace AffineTrans
{
    partial class frmMain
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
            this.picMain = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nRotate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nOffsetX = new System.Windows.Forms.NumericUpDown();
            this.nOffsetY = new System.Windows.Forms.NumericUpDown();
            this.nScaleX = new System.Windows.Forms.NumericUpDown();
            this.nScaleY = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScaleY)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMain.Location = new System.Drawing.Point(12, 12);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(600, 600);
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(616, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "变换参数";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.nRotate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nOffsetX, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nOffsetY, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nScaleX, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nScaleY, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(166, 234);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nRotate
            // 
            this.nRotate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nRotate.Location = new System.Drawing.Point(86, 12);
            this.nRotate.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nRotate.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nRotate.Name = "nRotate";
            this.nRotate.Size = new System.Drawing.Size(77, 21);
            this.nRotate.TabIndex = 0;
            this.nRotate.ValueChanged += new System.EventHandler(this.nRotate_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "旋转";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "平移X";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "平移Y";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "缩放X";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "缩放Y";
            // 
            // nOffsetX
            // 
            this.nOffsetX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nOffsetX.DecimalPlaces = 2;
            this.nOffsetX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nOffsetX.Location = new System.Drawing.Point(86, 58);
            this.nOffsetX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nOffsetX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nOffsetX.Name = "nOffsetX";
            this.nOffsetX.Size = new System.Drawing.Size(77, 21);
            this.nOffsetX.TabIndex = 0;
            this.nOffsetX.ValueChanged += new System.EventHandler(this.nOffsetX_ValueChanged);
            // 
            // nOffsetY
            // 
            this.nOffsetY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nOffsetY.DecimalPlaces = 2;
            this.nOffsetY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nOffsetY.Location = new System.Drawing.Point(86, 104);
            this.nOffsetY.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nOffsetY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nOffsetY.Name = "nOffsetY";
            this.nOffsetY.Size = new System.Drawing.Size(77, 21);
            this.nOffsetY.TabIndex = 0;
            this.nOffsetY.ValueChanged += new System.EventHandler(this.nOffsetY_ValueChanged);
            // 
            // nScaleX
            // 
            this.nScaleX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nScaleX.DecimalPlaces = 2;
            this.nScaleX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nScaleX.Location = new System.Drawing.Point(86, 150);
            this.nScaleX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nScaleX.Name = "nScaleX";
            this.nScaleX.Size = new System.Drawing.Size(77, 21);
            this.nScaleX.TabIndex = 0;
            this.nScaleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nScaleX.ValueChanged += new System.EventHandler(this.nScaleX_ValueChanged);
            // 
            // nScaleY
            // 
            this.nScaleY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nScaleY.DecimalPlaces = 2;
            this.nScaleY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nScaleY.Location = new System.Drawing.Point(86, 198);
            this.nScaleY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nScaleY.Name = "nScaleY";
            this.nScaleY.Size = new System.Drawing.Size(77, 21);
            this.nScaleY.TabIndex = 0;
            this.nScaleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nScaleY.ValueChanged += new System.EventHandler(this.nScaleY_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(616, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 340);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "变换顺序";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.radioButton1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButton2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioButton3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.radioButton4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.radioButton5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.radioButton6, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(166, 320);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "1.旋转平移缩放";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 16);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "2.旋转缩放平移X";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(26, 124);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(113, 16);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Tag = "2";
            this.radioButton3.Text = "3.平移旋转缩放X";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(26, 177);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(113, 16);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Tag = "3";
            this.radioButton4.Text = "4.平移缩放旋转X";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(26, 230);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(113, 16);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Tag = "4";
            this.radioButton5.Text = "5.缩放旋转平移X";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(26, 284);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(113, 16);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.Tag = "5";
            this.radioButton6.Text = "6.缩放平移旋转X";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picMain);
            this.Name = "frmMain";
            this.Text = "Affine Transform Test";
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScaleY)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown nRotate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nOffsetX;
        private System.Windows.Forms.NumericUpDown nOffsetY;
        private System.Windows.Forms.NumericUpDown nScaleX;
        private System.Windows.Forms.NumericUpDown nScaleY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}

