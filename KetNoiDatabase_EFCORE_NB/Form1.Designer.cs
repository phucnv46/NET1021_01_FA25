namespace KetNoiDatabase_EFCORE_NB
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
            textBoxMa = new TextBox();
            textBoxHT = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerNS = new DateTimePicker();
            textBoxDC = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxLop = new ComboBox();
            buttonLM = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            buttonThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 613);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1593, 328);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 79);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 1;
            label1.Text = "Mã sinh viên";
            // 
            // textBoxMa
            // 
            textBoxMa.Font = new Font("Segoe UI", 12F);
            textBoxMa.Location = new Point(160, 75);
            textBoxMa.Name = "textBoxMa";
            textBoxMa.Size = new Size(334, 39);
            textBoxMa.TabIndex = 2;
            // 
            // textBoxHT
            // 
            textBoxHT.Font = new Font("Segoe UI", 12F);
            textBoxHT.Location = new Point(736, 79);
            textBoxHT.Name = "textBoxHT";
            textBoxHT.Size = new Size(334, 39);
            textBoxHT.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(612, 82);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 3;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1147, 85);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 5;
            label3.Text = "Ngày sinh";
            // 
            // dateTimePickerNS
            // 
            dateTimePickerNS.Location = new Point(1281, 87);
            dateTimePickerNS.Name = "dateTimePickerNS";
            dateTimePickerNS.Size = new Size(300, 31);
            dateTimePickerNS.TabIndex = 6;
            // 
            // textBoxDC
            // 
            textBoxDC.Font = new Font("Segoe UI", 12F);
            textBoxDC.Location = new Point(160, 189);
            textBoxDC.Name = "textBoxDC";
            textBoxDC.Size = new Size(334, 39);
            textBoxDC.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(60, 192);
            label4.Name = "label4";
            label4.Size = new Size(87, 32);
            label4.TabIndex = 7;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(636, 196);
            label5.Name = "label5";
            label5.Size = new Size(53, 32);
            label5.TabIndex = 9;
            label5.Text = "Lớp";
            // 
            // comboBoxLop
            // 
            comboBoxLop.FormattingEnabled = true;
            comboBoxLop.Location = new Point(743, 192);
            comboBoxLop.Name = "comboBoxLop";
            comboBoxLop.Size = new Size(327, 33);
            comboBoxLop.TabIndex = 10;
            // 
            // buttonLM
            // 
            buttonLM.Location = new Point(1227, 440);
            buttonLM.Name = "buttonLM";
            buttonLM.Size = new Size(204, 61);
            buttonLM.TabIndex = 20;
            buttonLM.Text = "Làm mới";
            buttonLM.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(857, 440);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(204, 61);
            buttonXoa.TabIndex = 19;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(531, 440);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(204, 61);
            buttonSua.TabIndex = 18;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(161, 440);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(204, 61);
            buttonThem.TabIndex = 17;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1593, 941);
            Controls.Add(buttonLM);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(comboBoxLop);
            Controls.Add(label5);
            Controls.Add(textBoxDC);
            Controls.Add(label4);
            Controls.Add(dateTimePickerNS);
            Controls.Add(label3);
            Controls.Add(textBoxHT);
            Controls.Add(label2);
            Controls.Add(textBoxMa);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxMa;
        private TextBox textBoxHT;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerNS;
        private TextBox textBoxDC;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxLop;
        private Button buttonLM;
        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonThem;
    }
}
