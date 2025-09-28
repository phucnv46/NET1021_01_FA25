namespace Datagridview_BingdingList
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
            buttonThem = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            buttonLM = new Button();
            label1 = new Label();
            textBoxMa = new TextBox();
            textBoxTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDownNamSX = new NumericUpDown();
            label4 = new Label();
            comboBoxStudio = new ComboBox();
            label5 = new Label();
            numericUpDownSoTap = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNamSX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoTap).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 606);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1641, 360);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(115, 455);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(167, 62);
            buttonThem.TabIndex = 1;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(415, 455);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(167, 62);
            buttonSua.TabIndex = 2;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(703, 455);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(167, 62);
            buttonXoa.TabIndex = 3;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonLM
            // 
            buttonLM.Location = new Point(967, 455);
            buttonLM.Name = "buttonLM";
            buttonLM.Size = new Size(167, 62);
            buttonLM.TabIndex = 4;
            buttonLM.Text = "Làm mới";
            buttonLM.UseVisualStyleBackColor = true;
            buttonLM.Click += buttonLM_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(70, 86);
            label1.Name = "label1";
            label1.Size = new Size(48, 32);
            label1.TabIndex = 5;
            label1.Text = "Mã";
            // 
            // textBoxMa
            // 
            textBoxMa.Location = new Point(152, 86);
            textBoxMa.Name = "textBoxMa";
            textBoxMa.ReadOnly = true;
            textBoxMa.Size = new Size(334, 31);
            textBoxMa.TabIndex = 6;
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(682, 85);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(377, 31);
            textBoxTen.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(600, 85);
            label2.Name = "label2";
            label2.Size = new Size(52, 32);
            label2.TabIndex = 7;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1157, 86);
            label3.Name = "label3";
            label3.Size = new Size(99, 32);
            label3.TabIndex = 9;
            label3.Text = "Năm SX";
            // 
            // numericUpDownNamSX
            // 
            numericUpDownNamSX.Location = new Point(1276, 86);
            numericUpDownNamSX.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownNamSX.Name = "numericUpDownNamSX";
            numericUpDownNamSX.Size = new Size(323, 31);
            numericUpDownNamSX.TabIndex = 10;
            numericUpDownNamSX.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(50, 205);
            label4.Name = "label4";
            label4.Size = new Size(82, 32);
            label4.TabIndex = 11;
            label4.Text = "Studio";
            // 
            // comboBoxStudio
            // 
            comboBoxStudio.FormattingEnabled = true;
            comboBoxStudio.Location = new Point(152, 208);
            comboBoxStudio.Name = "comboBoxStudio";
            comboBoxStudio.Size = new Size(334, 33);
            comboBoxStudio.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(581, 209);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 13;
            label5.Text = "Số tập";
            // 
            // numericUpDownSoTap
            // 
            numericUpDownSoTap.Location = new Point(682, 213);
            numericUpDownSoTap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownSoTap.Name = "numericUpDownSoTap";
            numericUpDownSoTap.Size = new Size(377, 31);
            numericUpDownSoTap.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1641, 966);
            Controls.Add(numericUpDownSoTap);
            Controls.Add(label5);
            Controls.Add(comboBoxStudio);
            Controls.Add(label4);
            Controls.Add(numericUpDownNamSX);
            Controls.Add(label3);
            Controls.Add(textBoxTen);
            Controls.Add(label2);
            Controls.Add(textBoxMa);
            Controls.Add(label1);
            Controls.Add(buttonLM);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNamSX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoTap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonLM;
        private Label label1;
        private TextBox textBoxMa;
        private TextBox textBoxTen;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDownNamSX;
        private Label label4;
        private ComboBox comboBoxStudio;
        private Label label5;
        private NumericUpDown numericUpDownSoTap;
    }
}
