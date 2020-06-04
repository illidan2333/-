namespace Homework7
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
            this.components = new System.ComponentModel.Container();
            this.btnDraw = new System.Windows.Forms.Button();
            this.labelPenColor = new System.Windows.Forms.Label();
            this.Canvas = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialogPen = new System.Windows.Forms.ColorDialog();
            this.labelN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.trackBarN = new System.Windows.Forms.TrackBar();
            this.labelLeng = new System.Windows.Forms.Label();
            this.txtLeng = new System.Windows.Forms.TextBox();
            this.labelPer1 = new System.Windows.Forms.Label();
            this.txtPer1 = new System.Windows.Forms.TextBox();
            this.labelPer2 = new System.Windows.Forms.Label();
            this.txtPer2 = new System.Windows.Forms.TextBox();
            this.labelTh1 = new System.Windows.Forms.Label();
            this.labelTh2 = new System.Windows.Forms.Label();
            this.txtTh1 = new System.Windows.Forms.TextBox();
            this.txtTh2 = new System.Windows.Forms.TextBox();
            this.InputPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN)).BeginInit();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.AutoSize = true;
            this.btnDraw.Font = new System.Drawing.Font("宋体", 20F);
            this.btnDraw.Location = new System.Drawing.Point(7, 14);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(161, 70);
            this.btnDraw.TabIndex = 14;
            this.btnDraw.Text = "开始绘制";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // labelPenColor
            // 
            this.labelPenColor.AutoSize = true;
            this.labelPenColor.Font = new System.Drawing.Font("宋体", 20F);
            this.labelPenColor.Location = new System.Drawing.Point(181, 32);
            this.labelPenColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPenColor.Name = "labelPenColor";
            this.labelPenColor.Size = new System.Drawing.Size(219, 34);
            this.labelPenColor.TabIndex = 13;
            this.labelPenColor.Text = "点击选择颜色";
            this.labelPenColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPenColor.Click += new System.EventHandler(this.labelPenColor_Click);
            // 
            // Canvas
            // 
            this.Canvas.AutoSize = true;
            this.Canvas.Location = new System.Drawing.Point(13, 13);
            this.Canvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(489, 402);
            this.Canvas.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // colorDialogPen
            // 
            this.colorDialogPen.AnyColor = true;
            this.colorDialogPen.ShowHelp = true;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(1, 155);
            this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(91, 15);
            this.labelN.TabIndex = 1;
            this.labelN.Text = "递归深度 = ";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(118, 145);
            this.txtN.Margin = new System.Windows.Forms.Padding(4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(41, 25);
            this.txtN.TabIndex = 2;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInt_KeyPress);
            this.txtN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtN_KeyUp);
            this.txtN.Leave += new System.EventHandler(this.txtN_Leave);
            // 
            // trackBarN
            // 
            this.trackBarN.Location = new System.Drawing.Point(173, 144);
            this.trackBarN.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarN.Maximum = 20;
            this.trackBarN.Name = "trackBarN";
            this.trackBarN.Size = new System.Drawing.Size(246, 56);
            this.trackBarN.TabIndex = 0;
            this.trackBarN.Scroll += new System.EventHandler(this.trackBarN_Scroll);
            // 
            // labelLeng
            // 
            this.labelLeng.AutoSize = true;
            this.labelLeng.Location = new System.Drawing.Point(4, 202);
            this.labelLeng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLeng.Name = "labelLeng";
            this.labelLeng.Size = new System.Drawing.Size(91, 15);
            this.labelLeng.TabIndex = 3;
            this.labelLeng.Text = "主干长度 = ";
            // 
            // txtLeng
            // 
            this.txtLeng.Location = new System.Drawing.Point(118, 199);
            this.txtLeng.Margin = new System.Windows.Forms.Padding(4);
            this.txtLeng.Name = "txtLeng";
            this.txtLeng.Size = new System.Drawing.Size(106, 25);
            this.txtLeng.TabIndex = 4;
            this.txtLeng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFloat_KeyPress);
            // 
            // labelPer1
            // 
            this.labelPer1.AutoSize = true;
            this.labelPer1.Location = new System.Drawing.Point(1, 337);
            this.labelPer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPer1.Name = "labelPer1";
            this.labelPer1.Size = new System.Drawing.Size(121, 15);
            this.labelPer1.TabIndex = 5;
            this.labelPer1.Text = "右分支长度比 = ";
            // 
            // txtPer1
            // 
            this.txtPer1.Location = new System.Drawing.Point(124, 334);
            this.txtPer1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPer1.Name = "txtPer1";
            this.txtPer1.Size = new System.Drawing.Size(10, 25);
            this.txtPer1.TabIndex = 6;
            this.txtPer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFloat_KeyPress);
            this.txtPer1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxRatio_KeyUp);
            this.txtPer1.Leave += new System.EventHandler(this.TextBoxRatio_Leave);
            // 
            // labelPer2
            // 
            this.labelPer2.AutoSize = true;
            this.labelPer2.Location = new System.Drawing.Point(1, 387);
            this.labelPer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPer2.Name = "labelPer2";
            this.labelPer2.Size = new System.Drawing.Size(121, 15);
            this.labelPer2.TabIndex = 7;
            this.labelPer2.Text = "左分支长度比 = ";
            // 
            // txtPer2
            // 
            this.txtPer2.Location = new System.Drawing.Point(124, 377);
            this.txtPer2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPer2.Name = "txtPer2";
            this.txtPer2.Size = new System.Drawing.Size(10, 25);
            this.txtPer2.TabIndex = 8;
            this.txtPer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFloat_KeyPress);
            this.txtPer2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxRatio_KeyUp);
            this.txtPer2.Leave += new System.EventHandler(this.TextBoxRatio_Leave);
            // 
            // labelTh1
            // 
            this.labelTh1.AutoSize = true;
            this.labelTh1.Location = new System.Drawing.Point(4, 245);
            this.labelTh1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTh1.Name = "labelTh1";
            this.labelTh1.Size = new System.Drawing.Size(98, 15);
            this.labelTh1.TabIndex = 9;
            this.labelTh1.Text = "右分支角度 =";
            // 
            // labelTh2
            // 
            this.labelTh2.AutoSize = true;
            this.labelTh2.Location = new System.Drawing.Point(4, 295);
            this.labelTh2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTh2.Name = "labelTh2";
            this.labelTh2.Size = new System.Drawing.Size(106, 15);
            this.labelTh2.TabIndex = 10;
            this.labelTh2.Text = "左分支角度 = ";
            // 
            // txtTh1
            // 
            this.txtTh1.Location = new System.Drawing.Point(118, 242);
            this.txtTh1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTh1.Name = "txtTh1";
            this.txtTh1.Size = new System.Drawing.Size(98, 25);
            this.txtTh1.TabIndex = 11;
            this.txtTh1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFloat_KeyPress);
            this.txtTh1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAngle_KeyUp);
            this.txtTh1.Leave += new System.EventHandler(this.TextBoxAngle_Leave);
            // 
            // txtTh2
            // 
            this.txtTh2.Location = new System.Drawing.Point(118, 292);
            this.txtTh2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTh2.Name = "txtTh2";
            this.txtTh2.Size = new System.Drawing.Size(98, 25);
            this.txtTh2.TabIndex = 12;
            this.txtTh2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFloat_KeyPress);
            this.txtTh2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAngle_KeyUp);
            this.txtTh2.Leave += new System.EventHandler(this.TextBoxAngle_Leave);
            // 
            // InputPanel
            // 
            this.InputPanel.AutoSize = true;
            this.InputPanel.Controls.Add(this.txtTh2);
            this.InputPanel.Controls.Add(this.labelPenColor);
            this.InputPanel.Controls.Add(this.btnDraw);
            this.InputPanel.Controls.Add(this.txtTh1);
            this.InputPanel.Controls.Add(this.labelTh2);
            this.InputPanel.Controls.Add(this.labelTh1);
            this.InputPanel.Controls.Add(this.txtPer2);
            this.InputPanel.Controls.Add(this.labelPer2);
            this.InputPanel.Controls.Add(this.txtPer1);
            this.InputPanel.Controls.Add(this.labelPer1);
            this.InputPanel.Controls.Add(this.txtLeng);
            this.InputPanel.Controls.Add(this.labelLeng);
            this.InputPanel.Controls.Add(this.trackBarN);
            this.InputPanel.Controls.Add(this.txtN);
            this.InputPanel.Controls.Add(this.labelN);
            this.InputPanel.Location = new System.Drawing.Point(510, 13);
            this.InputPanel.Margin = new System.Windows.Forms.Padding(4);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(423, 406);
            this.InputPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 434);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.InputPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "CayleyTree";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN)).EndInit();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Canvas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelPenColor;
        private System.Windows.Forms.ColorDialog colorDialogPen;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TrackBar trackBarN;
        private System.Windows.Forms.Label labelLeng;
        private System.Windows.Forms.TextBox txtLeng;
        private System.Windows.Forms.Label labelPer1;
        private System.Windows.Forms.TextBox txtPer1;
        private System.Windows.Forms.Label labelPer2;
        private System.Windows.Forms.TextBox txtPer2;
        private System.Windows.Forms.Label labelTh1;
        private System.Windows.Forms.Label labelTh2;
        private System.Windows.Forms.TextBox txtTh1;
        private System.Windows.Forms.TextBox txtTh2;
        private System.Windows.Forms.Panel InputPanel;
    }
}

