namespace 第三周作业_201511190114_任春哲
{
    partial class Form_Main
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
            this.textBox_SerialNumber = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Builder = new System.Windows.Forms.TextBox();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.textBox_BackWood = new System.Windows.Forms.TextBox();
            this.textBox_TopWood = new System.Windows.Forms.TextBox();
            this.label_SerialNumber = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_builder = new System.Windows.Forms.Label();
            this.label_Model = new System.Windows.Forms.Label();
            this.label_Type = new System.Windows.Forms.Label();
            this.label_BackWood = new System.Windows.Forms.Label();
            this.label_TopWood = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_UpLoad = new System.Windows.Forms.Button();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_ChooseFolder = new System.Windows.Forms.Button();
            this.button_SaveAsCSV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_ReadCSV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_OpenCSV = new System.Windows.Forms.Button();
            this.label_ReadCSV = new System.Windows.Forms.Label();
            this.button_FindPrice = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReadCSV)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_SerialNumber
            // 
            this.textBox_SerialNumber.Location = new System.Drawing.Point(137, 12);
            this.textBox_SerialNumber.Name = "textBox_SerialNumber";
            this.textBox_SerialNumber.Size = new System.Drawing.Size(100, 25);
            this.textBox_SerialNumber.TabIndex = 0;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(137, 43);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(100, 25);
            this.textBox_Price.TabIndex = 1;
            // 
            // textBox_Builder
            // 
            this.textBox_Builder.Location = new System.Drawing.Point(137, 74);
            this.textBox_Builder.Name = "textBox_Builder";
            this.textBox_Builder.Size = new System.Drawing.Size(100, 25);
            this.textBox_Builder.TabIndex = 2;
            // 
            // textBox_Model
            // 
            this.textBox_Model.Location = new System.Drawing.Point(137, 105);
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(100, 25);
            this.textBox_Model.TabIndex = 3;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(137, 136);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(100, 25);
            this.textBox_Type.TabIndex = 4;
            // 
            // textBox_BackWood
            // 
            this.textBox_BackWood.Location = new System.Drawing.Point(137, 167);
            this.textBox_BackWood.Name = "textBox_BackWood";
            this.textBox_BackWood.Size = new System.Drawing.Size(100, 25);
            this.textBox_BackWood.TabIndex = 5;
            // 
            // textBox_TopWood
            // 
            this.textBox_TopWood.Location = new System.Drawing.Point(137, 198);
            this.textBox_TopWood.Name = "textBox_TopWood";
            this.textBox_TopWood.Size = new System.Drawing.Size(100, 25);
            this.textBox_TopWood.TabIndex = 6;
            // 
            // label_SerialNumber
            // 
            this.label_SerialNumber.AutoSize = true;
            this.label_SerialNumber.Location = new System.Drawing.Point(15, 22);
            this.label_SerialNumber.Name = "label_SerialNumber";
            this.label_SerialNumber.Size = new System.Drawing.Size(103, 15);
            this.label_SerialNumber.TabIndex = 7;
            this.label_SerialNumber.Text = "SerialNumber";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(15, 53);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(47, 15);
            this.label_price.TabIndex = 8;
            this.label_price.Text = "Price";
            // 
            // label_builder
            // 
            this.label_builder.AutoSize = true;
            this.label_builder.Location = new System.Drawing.Point(15, 84);
            this.label_builder.Name = "label_builder";
            this.label_builder.Size = new System.Drawing.Size(63, 15);
            this.label_builder.TabIndex = 9;
            this.label_builder.Text = "Builder";
            // 
            // label_Model
            // 
            this.label_Model.AutoSize = true;
            this.label_Model.Location = new System.Drawing.Point(15, 116);
            this.label_Model.Name = "label_Model";
            this.label_Model.Size = new System.Drawing.Size(47, 15);
            this.label_Model.TabIndex = 10;
            this.label_Model.Text = "Model";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(15, 147);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(39, 15);
            this.label_Type.TabIndex = 11;
            this.label_Type.Text = "Type";
            // 
            // label_BackWood
            // 
            this.label_BackWood.AutoSize = true;
            this.label_BackWood.Location = new System.Drawing.Point(15, 178);
            this.label_BackWood.Name = "label_BackWood";
            this.label_BackWood.Size = new System.Drawing.Size(71, 15);
            this.label_BackWood.TabIndex = 12;
            this.label_BackWood.Text = "BackWood";
            // 
            // label_TopWood
            // 
            this.label_TopWood.AutoSize = true;
            this.label_TopWood.Location = new System.Drawing.Point(15, 209);
            this.label_TopWood.Name = "label_TopWood";
            this.label_TopWood.Size = new System.Drawing.Size(63, 15);
            this.label_TopWood.TabIndex = 13;
            this.label_TopWood.Text = "TopWood";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_UpLoad);
            this.panel1.Controls.Add(this.textBox_TopWood);
            this.panel1.Controls.Add(this.label_TopWood);
            this.panel1.Controls.Add(this.textBox_SerialNumber);
            this.panel1.Controls.Add(this.label_BackWood);
            this.panel1.Controls.Add(this.textBox_Price);
            this.panel1.Controls.Add(this.label_Type);
            this.panel1.Controls.Add(this.textBox_Builder);
            this.panel1.Controls.Add(this.label_Model);
            this.panel1.Controls.Add(this.textBox_Model);
            this.panel1.Controls.Add(this.label_builder);
            this.panel1.Controls.Add(this.textBox_Type);
            this.panel1.Controls.Add(this.label_price);
            this.panel1.Controls.Add(this.textBox_BackWood);
            this.panel1.Controls.Add(this.label_SerialNumber);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 288);
            this.panel1.TabIndex = 14;
            // 
            // button_UpLoad
            // 
            this.button_UpLoad.Location = new System.Drawing.Point(21, 238);
            this.button_UpLoad.Name = "button_UpLoad";
            this.button_UpLoad.Size = new System.Drawing.Size(132, 30);
            this.button_UpLoad.TabIndex = 14;
            this.button_UpLoad.Text = "上传到数据库";
            this.button_UpLoad.UseVisualStyleBackColor = true;
            this.button_UpLoad.Click += new System.EventHandler(this.button_UpLoad_Click);
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(21, 16);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(219, 25);
            this.textBox_Path.TabIndex = 15;
            // 
            // button_ChooseFolder
            // 
            this.button_ChooseFolder.Location = new System.Drawing.Point(21, 47);
            this.button_ChooseFolder.Name = "button_ChooseFolder";
            this.button_ChooseFolder.Size = new System.Drawing.Size(132, 30);
            this.button_ChooseFolder.TabIndex = 14;
            this.button_ChooseFolder.Text = "选择文件夹";
            this.button_ChooseFolder.UseVisualStyleBackColor = true;
            this.button_ChooseFolder.Click += new System.EventHandler(this.button_ChooseFolder_Click);
            // 
            // button_SaveAsCSV
            // 
            this.button_SaveAsCSV.Location = new System.Drawing.Point(21, 83);
            this.button_SaveAsCSV.Name = "button_SaveAsCSV";
            this.button_SaveAsCSV.Size = new System.Drawing.Size(132, 30);
            this.button_SaveAsCSV.TabIndex = 16;
            this.button_SaveAsCSV.Text = "保存文件";
            this.button_SaveAsCSV.UseVisualStyleBackColor = true;
            this.button_SaveAsCSV.Click += new System.EventHandler(this.button_SaveAsCSV_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox_Path);
            this.panel2.Controls.Add(this.button_SaveAsCSV);
            this.panel2.Controls.Add(this.button_ChooseFolder);
            this.panel2.Location = new System.Drawing.Point(14, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 143);
            this.panel2.TabIndex = 17;
            // 
            // dataGridView_ReadCSV
            // 
            this.dataGridView_ReadCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReadCSV.Location = new System.Drawing.Point(279, 306);
            this.dataGridView_ReadCSV.Name = "dataGridView_ReadCSV";
            this.dataGridView_ReadCSV.RowTemplate.Height = 27;
            this.dataGridView_ReadCSV.Size = new System.Drawing.Size(278, 150);
            this.dataGridView_ReadCSV.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button_FindPrice);
            this.panel3.Controls.Add(this.label_ReadCSV);
            this.panel3.Controls.Add(this.button_OpenCSV);
            this.panel3.Location = new System.Drawing.Point(279, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 288);
            this.panel3.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_OpenCSV
            // 
            this.button_OpenCSV.Location = new System.Drawing.Point(30, 47);
            this.button_OpenCSV.Name = "button_OpenCSV";
            this.button_OpenCSV.Size = new System.Drawing.Size(132, 30);
            this.button_OpenCSV.TabIndex = 1;
            this.button_OpenCSV.Text = "打开文件";
            this.button_OpenCSV.UseVisualStyleBackColor = true;
            this.button_OpenCSV.Click += new System.EventHandler(this.button_OpenCSV_Click);
            // 
            // label_ReadCSV
            // 
            this.label_ReadCSV.AutoSize = true;
            this.label_ReadCSV.Location = new System.Drawing.Point(30, 16);
            this.label_ReadCSV.Name = "label_ReadCSV";
            this.label_ReadCSV.Size = new System.Drawing.Size(0, 15);
            this.label_ReadCSV.TabIndex = 2;
            // 
            // button_FindPrice
            // 
            this.button_FindPrice.Location = new System.Drawing.Point(30, 83);
            this.button_FindPrice.Name = "button_FindPrice";
            this.button_FindPrice.Size = new System.Drawing.Size(132, 30);
            this.button_FindPrice.TabIndex = 3;
            this.button_FindPrice.Text = "寻找最低价格";
            this.button_FindPrice.UseVisualStyleBackColor = true;
            this.button_FindPrice.Click += new System.EventHandler(this.button_FindPrice_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView_ReadCSV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReadCSV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SerialNumber;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Builder;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_BackWood;
        private System.Windows.Forms.TextBox textBox_TopWood;
        private System.Windows.Forms.Label label_SerialNumber;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_builder;
        private System.Windows.Forms.Label label_Model;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Label label_BackWood;
        private System.Windows.Forms.Label label_TopWood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_ChooseFolder;
        private System.Windows.Forms.Button button_SaveAsCSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_UpLoad;
        private System.Windows.Forms.DataGridView dataGridView_ReadCSV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_OpenCSV;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Label label_ReadCSV;
        private System.Windows.Forms.Button button_FindPrice;
    }
}

