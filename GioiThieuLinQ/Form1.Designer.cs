namespace GioiThieuLinQ
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
            textBoxTIm = new TextBox();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            selectMultiple1 = new AntdUI.SelectMultiple();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 606);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1630, 340);
            dataGridView1.TabIndex = 0;
            // 
            // textBoxTIm
            // 
            textBoxTIm.Location = new Point(1043, 478);
            textBoxTIm.Name = "textBoxTIm";
            textBoxTIm.Size = new Size(351, 31);
            textBoxTIm.TabIndex = 1;
            textBoxTIm.TextChanged += textBoxTIm_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1434, 478);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(982, 97);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(461, 144);
            checkedListBox1.TabIndex = 3;
            // 
            // selectMultiple1
            // 
            selectMultiple1.Items.AddRange(new object[] { "Xanh", "Đỏ", "Tím", "Vàng" });
            selectMultiple1.Location = new Point(196, 143);
            selectMultiple1.Name = "selectMultiple1";
            selectMultiple1.Size = new Size(428, 45);
            selectMultiple1.TabIndex = 4;
            selectMultiple1.Text = "selectMultiple1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1630, 946);
            Controls.Add(selectMultiple1);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Controls.Add(textBoxTIm);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxTIm;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private AntdUI.SelectMultiple selectMultiple1;
    }
}
