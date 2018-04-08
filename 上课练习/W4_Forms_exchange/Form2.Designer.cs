namespace W4_Forms_exchange
{
    partial class Form2
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
            this.numericUpDown_parameter_1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_parameter_2 = new System.Windows.Forms.NumericUpDown();
            this.button_exchange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_parameter_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_parameter_2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_parameter_1
            // 
            this.numericUpDown_parameter_1.Location = new System.Drawing.Point(65, 59);
            this.numericUpDown_parameter_1.Name = "numericUpDown_parameter_1";
            this.numericUpDown_parameter_1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_parameter_1.TabIndex = 0;
            // 
            // numericUpDown_parameter_2
            // 
            this.numericUpDown_parameter_2.Location = new System.Drawing.Point(65, 126);
            this.numericUpDown_parameter_2.Name = "numericUpDown_parameter_2";
            this.numericUpDown_parameter_2.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_parameter_2.TabIndex = 1;
            // 
            // button_exchange
            // 
            this.button_exchange.Location = new System.Drawing.Point(65, 179);
            this.button_exchange.Name = "button_exchange";
            this.button_exchange.Size = new System.Drawing.Size(120, 28);
            this.button_exchange.TabIndex = 2;
            this.button_exchange.Text = "完成";
            this.button_exchange.UseVisualStyleBackColor = true;
            this.button_exchange.Click += new System.EventHandler(this.button_exchange_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button_exchange);
            this.Controls.Add(this.numericUpDown_parameter_2);
            this.Controls.Add(this.numericUpDown_parameter_1);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_parameter_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_parameter_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_exchange;
        public System.Windows.Forms.NumericUpDown numericUpDown_parameter_1;
        public System.Windows.Forms.NumericUpDown numericUpDown_parameter_2;
    }
}

