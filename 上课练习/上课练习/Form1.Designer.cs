namespace 上课练习
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
            this.button_Lloyd = new System.Windows.Forms.Button();
            this.button_Lucinda = new System.Windows.Forms.Button();
            this.button_Swap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_int_parameter = new System.Windows.Forms.Button();
            this.button_array_parameter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Lloyd
            // 
            this.button_Lloyd.Location = new System.Drawing.Point(36, 19);
            this.button_Lloyd.Name = "button_Lloyd";
            this.button_Lloyd.Size = new System.Drawing.Size(75, 23);
            this.button_Lloyd.TabIndex = 0;
            this.button_Lloyd.Text = "button1";
            this.button_Lloyd.UseVisualStyleBackColor = true;
            this.button_Lloyd.Click += new System.EventHandler(this.button_Lloyd_Click);
            // 
            // button_Lucinda
            // 
            this.button_Lucinda.Location = new System.Drawing.Point(36, 65);
            this.button_Lucinda.Name = "button_Lucinda";
            this.button_Lucinda.Size = new System.Drawing.Size(75, 23);
            this.button_Lucinda.TabIndex = 1;
            this.button_Lucinda.Text = "button2";
            this.button_Lucinda.UseVisualStyleBackColor = true;
            this.button_Lucinda.Click += new System.EventHandler(this.button_Lucinda_Click);
            // 
            // button_Swap
            // 
            this.button_Swap.Location = new System.Drawing.Point(36, 115);
            this.button_Swap.Name = "button_Swap";
            this.button_Swap.Size = new System.Drawing.Size(75, 23);
            this.button_Swap.TabIndex = 2;
            this.button_Swap.Text = "button3";
            this.button_Swap.UseVisualStyleBackColor = true;
            this.button_Swap.Click += new System.EventHandler(this.button_Swap_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_Swap);
            this.panel1.Controls.Add(this.button_Lloyd);
            this.panel1.Controls.Add(this.button_Lucinda);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 209);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button_array_parameter);
            this.panel2.Controls.Add(this.button_int_parameter);
            this.panel2.Location = new System.Drawing.Point(248, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 208);
            this.panel2.TabIndex = 4;
            // 
            // button_int_parameter
            // 
            this.button_int_parameter.Location = new System.Drawing.Point(31, 18);
            this.button_int_parameter.Name = "button_int_parameter";
            this.button_int_parameter.Size = new System.Drawing.Size(75, 23);
            this.button_int_parameter.TabIndex = 0;
            this.button_int_parameter.Text = "button1";
            this.button_int_parameter.UseVisualStyleBackColor = true;
            this.button_int_parameter.Click += new System.EventHandler(this.button_int_parameter_Click);
            // 
            // button_array_parameter
            // 
            this.button_array_parameter.Location = new System.Drawing.Point(31, 64);
            this.button_array_parameter.Name = "button_array_parameter";
            this.button_array_parameter.Size = new System.Drawing.Size(75, 23);
            this.button_array_parameter.TabIndex = 1;
            this.button_array_parameter.Text = "button2";
            this.button_array_parameter.UseVisualStyleBackColor = true;
            this.button_array_parameter.Click += new System.EventHandler(this.button_array_parameter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Lloyd;
        private System.Windows.Forms.Button button_Lucinda;
        private System.Windows.Forms.Button button_Swap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_array_parameter;
        private System.Windows.Forms.Button button_int_parameter;
    }
}

