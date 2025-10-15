namespace ChuaDeMau2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxMa = new TextBox();
            textBoxTenSach = new TextBox();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            radioButton1L = new RadioButton();
            radioButton1k = new RadioButton();
            dataGridView1 = new DataGridView();
            buttonThem = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 84);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 183);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã sách";
            // 
            // textBoxMa
            // 
            textBoxMa.Location = new Point(175, 185);
            textBoxMa.Name = "textBoxMa";
            textBoxMa.Size = new Size(354, 31);
            textBoxMa.TabIndex = 2;
            // 
            // textBoxTenSach
            // 
            textBoxTenSach.Location = new Point(175, 292);
            textBoxTenSach.Name = "textBoxTenSach";
            textBoxTenSach.Size = new Size(354, 31);
            textBoxTenSach.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 290);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 3;
            label3.Text = "Tên sách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(750, 183);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 5;
            label4.Text = "Đơn giá";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(865, 181);
            numericUpDown1.Maximum = new decimal(new int[] { -494665728, 2095475792, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(365, 31);
            numericUpDown1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(750, 298);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 7;
            label5.Text = "Số trang";
            // 
            // radioButton1L
            // 
            radioButton1L.AutoSize = true;
            radioButton1L.Location = new Point(874, 300);
            radioButton1L.Name = "radioButton1L";
            radioButton1L.Size = new Size(67, 29);
            radioButton1L.TabIndex = 8;
            radioButton1L.TabStop = true;
            radioButton1L.Text = "100";
            radioButton1L.UseVisualStyleBackColor = true;
            // 
            // radioButton1k
            // 
            radioButton1k.AutoSize = true;
            radioButton1k.Location = new Point(1089, 300);
            radioButton1k.Name = "radioButton1k";
            radioButton1k.Size = new Size(77, 29);
            radioButton1k.TabIndex = 9;
            radioButton1k.TabStop = true;
            radioButton1k.Text = "1000";
            radioButton1k.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(77, 454);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(938, 269);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(1123, 465);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(138, 53);
            buttonThem.TabIndex = 11;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 786);
            Controls.Add(buttonThem);
            Controls.Add(dataGridView1);
            Controls.Add(radioButton1k);
            Controls.Add(radioButton1L);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(textBoxTenSach);
            Controls.Add(label3);
            Controls.Add(textBoxMa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxMa;
        private TextBox textBoxTenSach;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private RadioButton radioButton1L;
        private RadioButton radioButton1k;
        private DataGridView dataGridView1;
        private Button buttonThem;
    }
}
