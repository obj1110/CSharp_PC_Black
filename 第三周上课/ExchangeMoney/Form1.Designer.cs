namespace ExchangeMoney
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_JoeMoney = new System.Windows.Forms.Label();
            this.label_BobMoney = new System.Windows.Forms.Label();
            this.label_BankMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joe has $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bob has $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "the bank has $";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_giveJoe);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "return $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_giveBob);
            // 
            // label_JoeMoney
            // 
            this.label_JoeMoney.AutoSize = true;
            this.label_JoeMoney.Location = new System.Drawing.Point(204, 55);
            this.label_JoeMoney.Name = "label_JoeMoney";
            this.label_JoeMoney.Size = new System.Drawing.Size(55, 15);
            this.label_JoeMoney.TabIndex = 5;
            this.label_JoeMoney.Text = "label4";
            // 
            // label_BobMoney
            // 
            this.label_BobMoney.AutoSize = true;
            this.label_BobMoney.Location = new System.Drawing.Point(207, 89);
            this.label_BobMoney.Name = "label_BobMoney";
            this.label_BobMoney.Size = new System.Drawing.Size(55, 15);
            this.label_BobMoney.TabIndex = 6;
            this.label_BobMoney.Text = "label5";
            // 
            // label_BankMoney
            // 
            this.label_BankMoney.AutoSize = true;
            this.label_BankMoney.Location = new System.Drawing.Point(207, 125);
            this.label_BankMoney.Name = "label_BankMoney";
            this.label_BankMoney.Size = new System.Drawing.Size(55, 15);
            this.label_BankMoney.TabIndex = 7;
            this.label_BankMoney.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 317);
            this.Controls.Add(this.label_BankMoney);
            this.Controls.Add(this.label_BobMoney);
            this.Controls.Add(this.label_JoeMoney);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_JoeMoney;
        private System.Windows.Forms.Label label_BobMoney;
        private System.Windows.Forms.Label label_BankMoney;
    }
}

