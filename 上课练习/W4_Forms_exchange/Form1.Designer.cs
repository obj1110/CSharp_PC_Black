namespace W4_Forms_exchange
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_para_1 = new System.Windows.Forms.Label();
            this.label_para_2 = new System.Windows.Forms.Label();
            this.label_parameter_1 = new System.Windows.Forms.Label();
            this.label_parameter_2 = new System.Windows.Forms.Label();
            this.button_set_parameter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_para_1
            // 
            this.label_para_1.AutoSize = true;
            this.label_para_1.Location = new System.Drawing.Point(12, 74);
            this.label_para_1.Name = "label_para_1";
            this.label_para_1.Size = new System.Drawing.Size(52, 15);
            this.label_para_1.TabIndex = 0;
            this.label_para_1.Text = "参数一";
            // 
            // label_para_2
            // 
            this.label_para_2.AutoSize = true;
            this.label_para_2.Location = new System.Drawing.Point(12, 121);
            this.label_para_2.Name = "label_para_2";
            this.label_para_2.Size = new System.Drawing.Size(52, 15);
            this.label_para_2.TabIndex = 1;
            this.label_para_2.Text = "参数二";
            // 
            // label_parameter_1
            // 
            this.label_parameter_1.AutoSize = true;
            this.label_parameter_1.Location = new System.Drawing.Point(106, 74);
            this.label_parameter_1.Name = "label_parameter_1";
            this.label_parameter_1.Size = new System.Drawing.Size(55, 15);
            this.label_parameter_1.TabIndex = 2;
            this.label_parameter_1.Text = "label1";
            // 
            // label_parameter_2
            // 
            this.label_parameter_2.AutoSize = true;
            this.label_parameter_2.Location = new System.Drawing.Point(106, 121);
            this.label_parameter_2.Name = "label_parameter_2";
            this.label_parameter_2.Size = new System.Drawing.Size(55, 15);
            this.label_parameter_2.TabIndex = 3;
            this.label_parameter_2.Text = "label2";
            // 
            // button_set_parameter
            // 
            this.button_set_parameter.Location = new System.Drawing.Point(45, 186);
            this.button_set_parameter.Name = "button_set_parameter";
            this.button_set_parameter.Size = new System.Drawing.Size(115, 34);
            this.button_set_parameter.TabIndex = 4;
            this.button_set_parameter.Text = "设置参数";
            this.button_set_parameter.UseVisualStyleBackColor = true;
            this.button_set_parameter.Click += new System.EventHandler(this.button_set_parameter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button_set_parameter);
            this.Controls.Add(this.label_parameter_2);
            this.Controls.Add(this.label_parameter_1);
            this.Controls.Add(this.label_para_2);
            this.Controls.Add(this.label_para_1);
            this.Name = "Form1";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_para_1;
        private System.Windows.Forms.Label label_para_2;
        private System.Windows.Forms.Label label_parameter_1;
        private System.Windows.Forms.Label label_parameter_2;
        private System.Windows.Forms.Button button_set_parameter;
    }
}