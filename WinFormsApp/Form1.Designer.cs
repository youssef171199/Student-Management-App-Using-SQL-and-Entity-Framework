namespace WinFormsApp
{
    partial class add_label
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
            students_GV = new DataGridView();
            textBox1 = new TextBox();
            search_btn = new Button();
            reset_btn = new Button();
            id_txt = new TextBox();
            name_txt = new TextBox();
            adress_txt = new TextBox();
            age_txt = new TextBox();
            add_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            dept_txt = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)students_GV).BeginInit();
            SuspendLayout();
            // 
            // students_GV
            // 
            students_GV.BackgroundColor = SystemColors.ControlLightLight;
            students_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            students_GV.Location = new Point(12, 64);
            students_GV.Name = "students_GV";
            students_GV.Size = new Size(645, 366);
            students_GV.TabIndex = 0;
            students_GV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 1;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(234, 36);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(75, 23);
            search_btn.TabIndex = 2;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += button1_Click;
            // 
            // reset_btn
            // 
            reset_btn.Location = new Point(315, 36);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(75, 23);
            reset_btn.TabIndex = 3;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // id_txt
            // 
            id_txt.Location = new Point(731, 61);
            id_txt.Name = "id_txt";
            id_txt.Size = new Size(136, 23);
            id_txt.TabIndex = 4;
            // 
            // name_txt
            // 
            name_txt.Location = new Point(731, 90);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(136, 23);
            name_txt.TabIndex = 5;
            // 
            // adress_txt
            // 
            adress_txt.Location = new Point(731, 148);
            adress_txt.Name = "adress_txt";
            adress_txt.Size = new Size(136, 23);
            adress_txt.TabIndex = 6;
            // 
            // age_txt
            // 
            age_txt.Location = new Point(731, 119);
            age_txt.Name = "age_txt";
            age_txt.Size = new Size(136, 23);
            age_txt.TabIndex = 7;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(731, 221);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(136, 23);
            add_btn.TabIndex = 8;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(659, 69);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 9;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(659, 98);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 10;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(659, 156);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 11;
            label3.Text = "Adress";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(659, 127);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 12;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(663, 198);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(672, 293);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(731, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dept_txt
            // 
            dept_txt.AutoSize = true;
            dept_txt.Location = new Point(659, 185);
            dept_txt.Name = "dept_txt";
            dept_txt.Size = new Size(70, 15);
            dept_txt.TabIndex = 16;
            dept_txt.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 18);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 17;
            label7.Text = "search bar";
            // 
            // add_label
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 443);
            Controls.Add(label7);
            Controls.Add(dept_txt);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(add_btn);
            Controls.Add(age_txt);
            Controls.Add(adress_txt);
            Controls.Add(name_txt);
            Controls.Add(id_txt);
            Controls.Add(reset_btn);
            Controls.Add(search_btn);
            Controls.Add(textBox1);
            Controls.Add(students_GV);
            ForeColor = SystemColors.ControlText;
            Name = "add_label";
            Text = "Student mangment app";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)students_GV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView students_GV;
        private TextBox textBox1;
        private Button search_btn;
        private Button reset_btn;
        private TextBox id_txt;
        private TextBox name_txt;
        private TextBox adress_txt;
        private TextBox age_txt;
        private Button add_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Label dept_txt;
        private Label label7;
    }
}
