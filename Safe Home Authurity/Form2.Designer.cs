namespace Safe_Home_Authurity
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            exit = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("RomanT", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(158, 470);
            label1.Name = "label1";
            label1.Size = new Size(218, 67);
            label1.TabIndex = 0;
            label1.Text = "Owner";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("RomanT", 28.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(886, 484);
            label2.Name = "label2";
            label2.Size = new Size(208, 67);
            label2.TabIndex = 1;
            label2.Text = "Police";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 732);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 144);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 308);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(838, 145);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 308);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 8);
            label3.Name = "label3";
            label3.Size = new Size(188, 51);
            label3.TabIndex = 1;
            label3.Text = "Login As";
            label3.Click += label3_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.Red;
            exit.Location = new Point(1223, 9);
            exit.Name = "exit";
            exit.Size = new Size(21, 23);
            exit.TabIndex = 26;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SansSerif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label4.Location = new Point(158, 530);
            label4.Name = "label4";
            label4.Size = new Size(229, 20);
            label4.TabIndex = 2;
            label4.Text = "Click the Owner icon to log in";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SansSerif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(886, 551);
            label5.Name = "label5";
            label5.Size = new Size(226, 20);
            label5.TabIndex = 3;
            label5.Text = "Click the Police icon to log in";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SansSerif", 10.1999989F);
            label6.Location = new Point(11, 59);
            label6.Name = "label6";
            label6.Size = new Size(291, 20);
            label6.TabIndex = 3;
            label6.Text = "Please Choose Your Role to Continue";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(1256, 732);
            Controls.Add(label5);
            Controls.Add(exit);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label exit;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}