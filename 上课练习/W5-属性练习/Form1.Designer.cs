namespace W5_属性练习
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
            this.numericUpDown_Cows = new System.Windows.Forms.NumericUpDown();
            this.label_display = new System.Windows.Forms.Label();
            this.numericUpDown_FeedPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FeedPrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown_Cows
            // 
            this.numericUpDown_Cows.Location = new System.Drawing.Point(24, 138);
            this.numericUpDown_Cows.Name = "numericUpDown_Cows";
            this.numericUpDown_Cows.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_Cows.TabIndex = 0;
            this.numericUpDown_Cows.ValueChanged += new System.EventHandler(this.numericUpDown_Cows_ValueChanged);
            // 
            // label_display
            // 
            this.label_display.AutoSize = true;
            this.label_display.Location = new System.Drawing.Point(21, 190);
            this.label_display.Name = "label_display";
            this.label_display.Size = new System.Drawing.Size(167, 15);
            this.label_display.TabIndex = 2;
            this.label_display.Text = "the bags of feed is ";
            // 
            // numericUpDown_FeedPrice
            // 
            this.numericUpDown_FeedPrice.Location = new System.Drawing.Point(24, 73);
            this.numericUpDown_FeedPrice.Name = "numericUpDown_FeedPrice";
            this.numericUpDown_FeedPrice.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_FeedPrice.TabIndex = 3;
            this.numericUpDown_FeedPrice.ValueChanged += new System.EventHandler(this.numericUpDown_FeedPrice_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "粮食价格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "牛的数目";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown_Cows);
            this.panel1.Controls.Add(this.label_display);
            this.panel1.Controls.Add(this.numericUpDown_FeedPrice);
            this.panel1.Location = new System.Drawing.Point(40, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 241);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 436);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FeedPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_Cows;
        private System.Windows.Forms.Label label_display;
        private System.Windows.Forms.NumericUpDown numericUpDown_FeedPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

