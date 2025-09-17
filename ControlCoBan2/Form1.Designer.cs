namespace ControlCoBan2
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
            textBoxMSV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxHoTen = new TextBox();
            label3 = new Label();
            dateTimePickerNgaySinh = new DateTimePicker();
            label4 = new Label();
            comboBoxLop = new ComboBox();
            label5 = new Label();
            radioButtonNam = new RadioButton();
            radioButtonNu = new RadioButton();
            label6 = new Label();
            textBoxDC = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxMSV
            // 
            textBoxMSV.Font = new Font("Segoe UI", 12F);
            textBoxMSV.Location = new Point(215, 74);
            textBoxMSV.Name = "textBoxMSV";
            textBoxMSV.Size = new Size(343, 39);
            textBoxMSV.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(55, 74);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 1;
            label1.Text = "Mã Sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(740, 81);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 3;
            label2.Text = "Họ tên";
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Font = new Font("Segoe UI", 12F);
            textBoxHoTen.Location = new Point(868, 74);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(343, 39);
            textBoxHoTen.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1327, 77);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 4;
            label3.Text = "Ngày sinh";
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Short;
            dateTimePickerNgaySinh.Location = new Point(1477, 82);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(300, 31);
            dateTimePickerNgaySinh.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(156, 268);
            label4.Name = "label4";
            label4.Size = new Size(53, 32);
            label4.TabIndex = 6;
            label4.Text = "Lớp";
            // 
            // comboBoxLop
            // 
            comboBoxLop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxLop.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxLop.FormattingEnabled = true;
            comboBoxLop.Items.AddRange(new object[] { "NET1021.01", "SD203031", "SD203032", "NET1021.02" });
            comboBoxLop.Location = new Point(221, 267);
            comboBoxLop.Name = "comboBoxLop";
            comboBoxLop.Size = new Size(337, 33);
            comboBoxLop.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(740, 268);
            label5.Name = "label5";
            label5.Size = new Size(105, 32);
            label5.TabIndex = 8;
            label5.Text = "Giới tính";
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(868, 272);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(75, 29);
            radioButtonNam.TabIndex = 9;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(1070, 272);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(61, 29);
            radioButtonNu.TabIndex = 10;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(1327, 268);
            label6.Name = "label6";
            label6.Size = new Size(87, 32);
            label6.TabIndex = 12;
            label6.Text = "Địa chỉ";
            // 
            // textBoxDC
            // 
            textBoxDC.Font = new Font("Segoe UI", 12F);
            textBoxDC.Location = new Point(1455, 261);
            textBoxDC.Name = "textBoxDC";
            textBoxDC.Size = new Size(343, 39);
            textBoxDC.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(855, 593);
            button1.Name = "button1";
            button1.Size = new Size(169, 49);
            button1.TabIndex = 13;
            button1.Text = "Hiển thị";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1916, 976);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBoxDC);
            Controls.Add(radioButtonNu);
            Controls.Add(radioButtonNam);
            Controls.Add(label5);
            Controls.Add(comboBoxLop);
            Controls.Add(label4);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxHoTen);
            Controls.Add(label1);
            Controls.Add(textBoxMSV);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMSV;
        private Label label1;
        private Label label2;
        private TextBox textBoxHoTen;
        private Label label3;
        private DateTimePicker dateTimePickerNgaySinh;
        private Label label4;
        private ComboBox comboBoxLop;
        private Label label5;
        private RadioButton radioButtonNam;
        private RadioButton radioButtonNu;
        private Label label6;
        private TextBox textBoxDC;
        private Button button1;
    }
}
