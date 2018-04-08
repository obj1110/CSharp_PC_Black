namespace W4_exchange_information_between_forms
{
    partial class FormMain
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
            this.label_Main = new System.Windows.Forms.Label();
            this.numericUpDown_Main = new System.Windows.Forms.NumericUpDown();
            this.button_OpenSub = new System.Windows.Forms.Button();
            this.button_Main2Sub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Main
            // 
            this.label_Main.AutoSize = true;
            this.label_Main.Location = new System.Drawing.Point(74, 72);
            this.label_Main.Name = "label_Main";
            this.label_Main.Size = new System.Drawing.Size(55, 15);
            this.label_Main.TabIndex = 0;
            this.label_Main.Text = "label1";
            // 
            // numericUpDown_Main
            // 
            this.numericUpDown_Main.Location = new System.Drawing.Point(77, 90);
            this.numericUpDown_Main.Name = "numericUpDown_Main";
            this.numericUpDown_Main.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_Main.TabIndex = 1;
            // 
            // button_OpenSub
            // 
            this.button_OpenSub.Location = new System.Drawing.Point(77, 121);
            this.button_OpenSub.Name = "button_OpenSub";
            this.button_OpenSub.Size = new System.Drawing.Size(205, 64);
            this.button_OpenSub.TabIndex = 2;
            this.button_OpenSub.Text = "用子窗口设置数值";
            this.button_OpenSub.UseVisualStyleBackColor = true;
            this.button_OpenSub.Click += new System.EventHandler(this.button_OpenSub_Click);
            // 
            // button_Main2Sub
            // 
            this.button_Main2Sub.Location = new System.Drawing.Point(77, 191);
            this.button_Main2Sub.Name = "button_Main2Sub";
            this.button_Main2Sub.Size = new System.Drawing.Size(205, 67);
            this.button_Main2Sub.TabIndex = 3;
            this.button_Main2Sub.Text = "给子窗口传值";
            this.button_Main2Sub.UseVisualStyleBackColor = true;
            this.button_Main2Sub.Click += new System.EventHandler(this.button_Main2Sub_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 355);
            this.Controls.Add(this.button_Main2Sub);
            this.Controls.Add(this.button_OpenSub);
            this.Controls.Add(this.numericUpDown_Main);
            this.Controls.Add(this.label_Main);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Main;
        private System.Windows.Forms.NumericUpDown numericUpDown_Main;
        private System.Windows.Forms.Button button_OpenSub;
        private System.Windows.Forms.Button button_Main2Sub;
    }
}

