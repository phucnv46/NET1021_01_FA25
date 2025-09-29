namespace KetNoiDatabase_EFCore
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBoxMaSach = new TextBox();
            textBoxTenSach = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDownNSX = new NumericUpDown();
            textBoxNXB = new TextBox();
            label4 = new Label();
            numericUpDownSL = new NumericUpDown();
            label5 = new Label();
            numericUpDownGB = new NumericUpDown();
            label6 = new Label();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonLM = new Button();
            buttonXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNSX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGB).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 650);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1827, 324);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 82);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 1;
            label1.Text = "Mã Sách";
            // 
            // textBoxMaSach
            // 
            textBoxMaSach.Font = new Font("Segoe UI", 12F);
            textBoxMaSach.Location = new Point(203, 82);
            textBoxMaSach.Name = "textBoxMaSach";
            textBoxMaSach.ReadOnly = true;
            textBoxMaSach.Size = new Size(342, 39);
            textBoxMaSach.TabIndex = 2;
            // 
            // textBoxTenSach
            // 
            textBoxTenSach.Font = new Font("Segoe UI", 12F);
            textBoxTenSach.Location = new Point(853, 82);
            textBoxTenSach.Name = "textBoxTenSach";
            textBoxTenSach.Size = new Size(342, 39);
            textBoxTenSach.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(702, 89);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 3;
            label2.Text = "Tên Sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1290, 89);
            label3.Name = "label3";
            label3.Size = new Size(164, 32);
            label3.TabIndex = 5;
            label3.Text = "Năm xuất bản";
            label3.Click += label3_Click;
            // 
            // numericUpDownNSX
            // 
            numericUpDownNSX.Font = new Font("Segoe UI", 12F);
            numericUpDownNSX.Location = new Point(1492, 88);
            numericUpDownNSX.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownNSX.Name = "numericUpDownNSX";
            numericUpDownNSX.Size = new Size(323, 39);
            numericUpDownNSX.TabIndex = 6;
            // 
            // textBoxNXB
            // 
            textBoxNXB.Font = new Font("Segoe UI", 12F);
            textBoxNXB.Location = new Point(203, 190);
            textBoxNXB.Name = "textBoxNXB";
            textBoxNXB.Size = new Size(342, 39);
            textBoxNXB.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(95, 190);
            label4.Name = "label4";
            label4.Size = new Size(60, 32);
            label4.TabIndex = 7;
            label4.Text = "NXB";
            // 
            // numericUpDownSL
            // 
            numericUpDownSL.Font = new Font("Segoe UI", 12F);
            numericUpDownSL.Location = new Point(872, 192);
            numericUpDownSL.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numericUpDownSL.Name = "numericUpDownSL";
            numericUpDownSL.Size = new Size(323, 39);
            numericUpDownSL.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(702, 197);
            label5.Name = "label5";
            label5.Size = new Size(110, 32);
            label5.TabIndex = 9;
            label5.Text = "Số lượng";
            // 
            // numericUpDownGB
            // 
            numericUpDownGB.Font = new Font("Segoe UI", 12F);
            numericUpDownGB.Location = new Point(1492, 192);
            numericUpDownGB.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numericUpDownGB.Name = "numericUpDownGB";
            numericUpDownGB.Size = new Size(323, 39);
            numericUpDownGB.TabIndex = 12;
            numericUpDownGB.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(1359, 190);
            label6.Name = "label6";
            label6.Size = new Size(95, 32);
            label6.TabIndex = 11;
            label6.Text = "Giá bán";
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(293, 451);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(204, 61);
            buttonThem.TabIndex = 13;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(663, 451);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(204, 61);
            buttonSua.TabIndex = 14;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonLM
            // 
            buttonLM.Location = new Point(1359, 451);
            buttonLM.Name = "buttonLM";
            buttonLM.Size = new Size(204, 61);
            buttonLM.TabIndex = 16;
            buttonLM.Text = "Làm mới";
            buttonLM.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(989, 451);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(204, 61);
            buttonXoa.TabIndex = 15;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 974);
            Controls.Add(buttonLM);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(numericUpDownGB);
            Controls.Add(label6);
            Controls.Add(numericUpDownSL);
            Controls.Add(label5);
            Controls.Add(textBoxNXB);
            Controls.Add(label4);
            Controls.Add(numericUpDownNSX);
            Controls.Add(label3);
            Controls.Add(textBoxTenSach);
            Controls.Add(label2);
            Controls.Add(textBoxMaSach);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNSX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSL).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxMaSach;
        private TextBox textBoxTenSach;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDownNSX;
        private TextBox textBoxNXB;
        private Label label4;
        private NumericUpDown numericUpDownSL;
        private Label label5;
        private NumericUpDown numericUpDownGB;
        private Label label6;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonLM;
        private Button buttonXoa;
    }
}
