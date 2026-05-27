namespace Safe_Home_Authurity
{
    partial class buildingreg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buildingreg));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            registerbutton1 = new Button();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            exit = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(622, 105);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(622, 153);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(622, 204);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(622, 256);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(296, 23);
            textBox4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(504, 110);
            label3.Name = "label3";
            label3.Size = new Size(71, 16);
            label3.TabIndex = 13;
            label3.Text = "Building Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(504, 158);
            label1.Name = "label1";
            label1.Size = new Size(93, 16);
            label1.TabIndex = 14;
            label1.Text = "Building Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(504, 208);
            label2.Name = "label2";
            label2.Size = new Size(33, 16);
            label2.TabIndex = 15;
            label2.Text = "City:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(504, 258);
            label4.Name = "label4";
            label4.Size = new Size(49, 16);
            label4.TabIndex = 16;
            label4.Text = "Sector:";
            // 
            // registerbutton1
            // 
            registerbutton1.BackColor = Color.FromArgb(33, 11, 97);
            registerbutton1.ForeColor = Color.White;
            registerbutton1.Location = new Point(704, 315);
            registerbutton1.Margin = new Padding(3, 2, 3, 2);
            registerbutton1.Name = "registerbutton1";
            registerbutton1.Size = new Size(102, 34);
            registerbutton1.TabIndex = 20;
            registerbutton1.Text = "Register";
            registerbutton1.UseVisualStyleBackColor = false;
            registerbutton1.Click += registerbutton1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(639, 10);
            label5.Name = "label5";
            label5.Size = new Size(255, 22);
            label5.TabIndex = 21;
            label5.Text = " BUILDING MANAGEMENT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(exit);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 514);
            panel1.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("ISOCTEUR", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(33, 302);
            label6.Name = "label6";
            label6.Size = new Size(357, 31);
            label6.TabIndex = 30;
            label6.Text = "Safe Home Authority";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(90, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 202);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(689, 20);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 27;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // buildingreg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1083, 514);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(registerbutton1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "buildingreg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "buildingreg";
            Load += buildingreg_Load;
            Click += exit_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button registerbutton1;
        private Label label5;
        private Panel panel1;
        private Label exit;
        private PictureBox pictureBox1;
        private Label label6;
        private PictureBox pictureBox2;
    }
}