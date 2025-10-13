namespace ChuaDeMau1
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
            textBoxCV = new TextBox();
            label3 = new Label();
            textBoxTen = new TextBox();
            label4 = new Label();
            label5 = new Label();
            radioButtonNam = new RadioButton();
            radioButtonNu = new RadioButton();
            dataGridView1 = new DataGridView();
            buttonThem = new AntdUI.Button();
            buttonExit = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(417, 62);
            label1.Name = "label1";
            label1.Size = new Size(325, 51);
            label1.TabIndex = 0;
            label1.Text = "Quản lý nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 189);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên";
            // 
            // textBoxMa
            // 
            textBoxMa.Location = new Point(207, 189);
            textBoxMa.Name = "textBoxMa";
            textBoxMa.Size = new Size(289, 31);
            textBoxMa.TabIndex = 2;
            // 
            // textBoxCV
            // 
            textBoxCV.Location = new Point(891, 199);
            textBoxCV.Name = "textBoxCV";
            textBoxCV.Size = new Size(289, 31);
            textBoxCV.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(730, 199);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 3;
            label3.Text = "Chức vụ";
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(207, 295);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(289, 31);
            textBoxTen.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 295);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 5;
            label4.Text = "Tên nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(730, 301);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 7;
            label5.Text = "Giới tính";
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(891, 301);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(75, 29);
            radioButtonNam.TabIndex = 8;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(1039, 301);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(61, 29);
            radioButtonNu.TabIndex = 9;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 463);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(849, 268);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(1000, 478);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(180, 60);
            buttonThem.TabIndex = 11;
            buttonThem.Text = "Thêm";
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(1013, 581);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(167, 63);
            buttonExit.TabIndex = 12;
            buttonExit.Text = "Exit";
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 753);
            Controls.Add(buttonExit);
            Controls.Add(buttonThem);
            Controls.Add(dataGridView1);
            Controls.Add(radioButtonNu);
            Controls.Add(radioButtonNam);
            Controls.Add(label5);
            Controls.Add(textBoxTen);
            Controls.Add(label4);
            Controls.Add(textBoxCV);
            Controls.Add(label3);
            Controls.Add(textBoxMa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxMa;
        private TextBox textBoxCV;
        private Label label3;
        private TextBox textBoxTen;
        private Label label4;
        private Label label5;
        private RadioButton radioButtonNam;
        private RadioButton radioButtonNu;
        private DataGridView dataGridView1;
        private AntdUI.Button buttonThem;
        private AntdUI.Button buttonExit;
    }
}
