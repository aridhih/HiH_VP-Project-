namespace HiH_VP_Project_.Formss
{
    partial class BookAppointmnet
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView3 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 137);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Select Doctor";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(303, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(796, 220);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1116, 72);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(796, 220);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellClick += dataGridView2_CellContentClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.CellContentDoubleClick += dataGridView2_CellContentClick;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(130, 78);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Select Patient";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 0;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(8, 87);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 4;
            label1.Text = "Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 146);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 4;
            label2.Text = "Doctor ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 4;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 267);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 4;
            label4.Text = "Time";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 261);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "12AM";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 0;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.ControlLight;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(510, 315);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(925, 411);
            dataGridView3.TabIndex = 3;
            dataGridView3.CellClick += dataGridView3_CellContentClick;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            dataGridView3.CellContentDoubleClick += dataGridView3_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(293, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(293, 471);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Read";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(293, 546);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 7;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(293, 622);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 8;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Arial Black", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(1853, 12);
            button5.Name = "button5";
            button5.Size = new Size(59, 53);
            button5.TabIndex = 9;
            button5.Text = "←";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // BookAppointmnet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1924, 749);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Name = "BookAppointmnet";
            Text = "BookAppointmnet";
            WindowState = FormWindowState.Maximized;
            Load += BookAppointmnet_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}