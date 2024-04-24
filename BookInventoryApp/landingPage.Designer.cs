namespace BookInventoryApp
{
    partial class landingPage
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
            roundedButton1 = new CustomControls.RoundedButton();
            roundedButton2 = new CustomControls.RoundedButton();
            roundedButton3 = new CustomControls.RoundedButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(198, 220, 220);
            roundedButton1.BackgroundColor = Color.FromArgb(198, 220, 220);
            roundedButton1.BorderColor = Color.FromArgb(95, 115, 115);
            roundedButton1.BorderRadius = 40;
            roundedButton1.BorderSize = 2;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Georgia", 27.75F, FontStyle.Bold);
            roundedButton1.ForeColor = Color.FromArgb(7, 26, 26);
            roundedButton1.Location = new Point(306, 191);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(185, 75);
            roundedButton1.TabIndex = 1;
            roundedButton1.Text = "Add";
            roundedButton1.TextColor = Color.FromArgb(7, 26, 26);
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.FromArgb(198, 220, 220);
            roundedButton2.BackgroundColor = Color.FromArgb(198, 220, 220);
            roundedButton2.BorderColor = Color.FromArgb(95, 115, 115);
            roundedButton2.BorderRadius = 40;
            roundedButton2.BorderSize = 2;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Georgia", 27.75F, FontStyle.Bold);
            roundedButton2.ForeColor = Color.FromArgb(7, 26, 26);
            roundedButton2.Location = new Point(544, 191);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(185, 75);
            roundedButton2.TabIndex = 2;
            roundedButton2.Text = "Edit";
            roundedButton2.TextColor = Color.FromArgb(7, 26, 26);
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += roundedButton2_Click;
            // 
            // roundedButton3
            // 
            roundedButton3.BackColor = Color.FromArgb(198, 220, 220);
            roundedButton3.BackgroundColor = Color.FromArgb(198, 220, 220);
            roundedButton3.BorderColor = Color.FromArgb(95, 115, 115);
            roundedButton3.BorderRadius = 40;
            roundedButton3.BorderSize = 2;
            roundedButton3.FlatAppearance.BorderSize = 0;
            roundedButton3.FlatStyle = FlatStyle.Flat;
            roundedButton3.Font = new Font("Georgia", 27.75F, FontStyle.Bold);
            roundedButton3.ForeColor = Color.FromArgb(7, 26, 26);
            roundedButton3.Location = new Point(782, 191);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(185, 75);
            roundedButton3.TabIndex = 3;
            roundedButton3.Text = "Delete";
            roundedButton3.TextColor = Color.FromArgb(7, 26, 26);
            roundedButton3.UseVisualStyleBackColor = false;
            roundedButton3.Click += roundedButton3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1272, 75);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BookStoreLogo;
            pictureBox1.InitialImage = Properties.Resources.BookStoreLogo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(1272, 109);
            panel3.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(172, 186, 186);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Georgia", 14.25F, FontStyle.Bold);
            textBox6.Location = new Point(1149, 23);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(111, 68);
            textBox6.TabIndex = 0;
            textBox6.Text = "Add Quantity";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(172, 186, 186);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Georgia", 14.25F, FontStyle.Bold);
            textBox5.Location = new Point(982, 23);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(161, 68);
            textBox5.TabIndex = 0;
            textBox5.Text = "Add ISBN";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(172, 186, 186);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Georgia", 14.25F, FontStyle.Bold);
            textBox4.Location = new Point(815, 23);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 68);
            textBox4.TabIndex = 0;
            textBox4.Text = "Add Year Published";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(172, 186, 186);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Georgia", 14.25F, FontStyle.Bold);
            textBox3.Location = new Point(589, 23);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 68);
            textBox3.TabIndex = 0;
            textBox3.Text = "Add Category";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(172, 186, 186);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Georgia", 14.25F, FontStyle.Bold);
            textBox2.Location = new Point(363, 23);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 68);
            textBox2.TabIndex = 0;
            textBox2.Text = "Add Author";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(172, 186, 186);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Georgia", 14.25F, FontStyle.Bold);
            textBox1.Location = new Point(12, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 68);
            textBox1.TabIndex = 0;
            textBox1.Text = "Add Book Title";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(172, 186, 186);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1248, 532);
            dataGridView1.TabIndex = 8;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // landingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 239, 239);
            ClientSize = new Size(1272, 831);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(roundedButton3);
            Controls.Add(roundedButton2);
            Controls.Add(roundedButton1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "landingPage";
            Text = "landingPage";
            Load += landingPage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CustomControls.RoundedButton roundedButton1;
        private CustomControls.RoundedButton roundedButton2;
        private CustomControls.RoundedButton roundedButton3;
        private Panel panel1;
        private Panel panel3;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}