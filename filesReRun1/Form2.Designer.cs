namespace filesReRun1
{
    partial class Form2
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
            this.uploadBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewOriginal = new System.Windows.Forms.DataGridView();
            this.dataGridViewNew = new System.Windows.Forms.DataGridView();
            this.btn_process = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadBtn
            // 
            this.uploadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(12, 110);
            this.uploadBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(153, 47);
            this.uploadBtn.TabIndex = 0;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1346, 120);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 47);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewOriginal
            // 
            this.dataGridViewOriginal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOriginal.Location = new System.Drawing.Point(12, 186);
            this.dataGridViewOriginal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewOriginal.Name = "dataGridViewOriginal";
            this.dataGridViewOriginal.RowHeadersWidth = 62;
            this.dataGridViewOriginal.RowTemplate.Height = 28;
            this.dataGridViewOriginal.Size = new System.Drawing.Size(701, 592);
            this.dataGridViewOriginal.TabIndex = 5;
            // 
            // dataGridViewNew
            // 
            this.dataGridViewNew.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNew.Location = new System.Drawing.Point(770, 187);
            this.dataGridViewNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewNew.Name = "dataGridViewNew";
            this.dataGridViewNew.RowHeadersWidth = 62;
            this.dataGridViewNew.RowTemplate.Height = 28;
            this.dataGridViewNew.Size = new System.Drawing.Size(740, 591);
            this.dataGridViewNew.TabIndex = 6;
            // 
            // btn_process
            // 
            this.btn_process.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_process.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_process.ForeColor = System.Drawing.Color.White;
            this.btn_process.Location = new System.Drawing.Point(650, 120);
            this.btn_process.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(174, 47);
            this.btn_process.TabIndex = 10;
            this.btn_process.Text = "Process";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 37F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(305, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(978, 77);
            this.label2.TabIndex = 11;
            this.label2.Text = "Baby Upload Converter";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(766, 809);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(442, 23);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "Enter name of Modifier and Capturer:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(1225, 806);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(183, 26);
            this.txt_name.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(352, 875);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 875);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select your worksheet here:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 812);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 26);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 812);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "File destination";
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1579, 898);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(98, 41);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1576, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 34);
            this.label4.TabIndex = 17;
            this.label4.Text = "This system only\r\n uses ecxel files";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::filesReRun1.Properties.Resources.download1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::filesReRun1.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(1599, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1640, 1050);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridViewNew);
            this.Controls.Add(this.dataGridViewOriginal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.uploadBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Baby Upload";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridViewOriginal;
        private System.Windows.Forms.DataGridView dataGridViewNew;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}