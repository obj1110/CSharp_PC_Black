namespace W4_exchange_information_between_forms
{
    partial class Form_Sub
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
            this.button_2Main = new System.Windows.Forms.Button();
            this.numericUpDown_Sub = new System.Windows.Forms.NumericUpDown();
            this.label_Sub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sub)).BeginInit();
            this.SuspendLayout();
            // 
            // button_2Main
            // 
            this.button_2Main.Location = new System.Drawing.Point(73, 145);
            this.button_2Main.Name = "button_2Main";
            this.button_2Main.Size = new System.Drawing.Size(162, 64);
            this.button_2Main.TabIndex = 0;
            this.button_2Main.Text = "给父窗口传值";
            this.button_2Main.UseVisualStyleBackColor = true;
            this.button_2Main.Click += new System.EventHandler(this.button_2Main_Click);
            // 
            // numericUpDown_Sub
            // 
            this.numericUpDown_Sub.Location = new System.Drawing.Point(73, 57);
            this.numericUpDown_Sub.Name = "numericUpDown_Sub";
            this.numericUpDown_Sub.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_Sub.TabIndex = 1;
            // 
            // label_Sub
            // 
            this.label_Sub.AutoSize = true;
            this.label_Sub.Location = new System.Drawing.Point(73, 106);
            this.label_Sub.Name = "label_Sub";
            this.label_Sub.Size = new System.Drawing.Size(55, 15);
            this.label_Sub.TabIndex = 2;
            this.label_Sub.Text = "label1";
            // 
            // Form_Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label_Sub);
            this.Controls.Add(this.numericUpDown_Sub);
            this.Controls.Add(this.button_2Main);
            this.Name = "Form_Sub";
            this.Text = "Form_Sub";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_2Main;
        private System.Windows.Forms.NumericUpDown numericUpDown_Sub;
        public System.Windows.Forms.Label label_Sub;
    }
}