namespace AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            groupBox3 = new GroupBox();
            label8 = new Label();
            btnStartStop = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 30);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 21);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 7);
            label1.Name = "label1";
            label1.Size = new Size(142, 16);
            label1.TabIndex = 1;
            label1.Text = "ORION Auto Clicker 1.0";
            label1.Click += Form1_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(399, 0);
            button2.Name = "button2";
            button2.Size = new Size(35, 30);
            button2.TabIndex = 2;
            button2.TabStop = false;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Black;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(435, 0);
            button1.Name = "button1";
            button1.Size = new Size(35, 30);
            button1.TabIndex = 1;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(23, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 166);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Click Interval";
            groupBox1.MouseCaptureChanged += groupBox1_MouseCaptureChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 125);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 7;
            label4.Text = "milliseconds";
            label4.Click += Form1_Click_1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(6, 122);
            textBox3.MaxLength = 10;
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = RightToLeft.Yes;
            textBox3.Size = new Size(52, 22);
            textBox3.TabIndex = 8;
            textBox3.TabStop = false;
            textBox3.Text = "100";
            textBox3.Enter += textBox3_Enter;
            textBox3.KeyDown += textBox1_KeyDown;
            textBox3.KeyPress += textBox1_KeyPress;
            textBox3.Leave += textBox1_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 95);
            label5.Name = "label5";
            label5.Size = new Size(57, 17);
            label5.TabIndex = 5;
            label5.Text = "seconds";
            label5.Click += Form1_Click_1;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(6, 92);
            textBox4.MaxLength = 10;
            textBox4.Name = "textBox4";
            textBox4.RightToLeft = RightToLeft.Yes;
            textBox4.Size = new Size(52, 22);
            textBox4.TabIndex = 6;
            textBox4.TabStop = false;
            textBox4.Text = "0";
            textBox4.Enter += textBox4_Enter;
            textBox4.KeyDown += textBox1_KeyDown;
            textBox4.KeyPress += textBox1_KeyPress;
            textBox4.Leave += textBox1_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 65);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 3;
            label3.Text = "minutes";
            label3.Click += Form1_Click_1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(6, 62);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(52, 22);
            textBox2.TabIndex = 4;
            textBox2.TabStop = false;
            textBox2.Text = "0";
            textBox2.Enter += textBox2_Enter;
            textBox2.KeyDown += textBox1_KeyDown;
            textBox2.KeyPress += textBox1_KeyPress;
            textBox2.Leave += textBox1_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 35);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 2;
            label2.Text = "hours";
            label2.Click += Form1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(6, 32);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(52, 22);
            textBox1.TabIndex = 2;
            textBox1.TabStop = false;
            textBox1.Text = "0";
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(206, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(241, 103);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Click Option";
            groupBox2.MouseCaptureChanged += groupBox1_MouseCaptureChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Left", "Right" });
            comboBox1.Location = new Point(110, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(117, 25);
            comboBox1.TabIndex = 7;
            comboBox1.TabStop = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.DropDownClosed += comboBox1_DropDownClosed;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Single", "Double" });
            comboBox2.Location = new Point(110, 62);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(117, 25);
            comboBox2.TabIndex = 6;
            comboBox2.TabStop = false;
            comboBox2.DropDownClosed += comboBox1_DropDownClosed;
            comboBox2.TextChanged += comboBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 67);
            label7.Name = "label7";
            label7.Size = new Size(70, 17);
            label7.TabIndex = 5;
            label7.Text = "Click Type:";
            label7.Click += Form1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 37);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 3;
            label6.Text = "Mouse Button:";
            label6.Click += Form1_Click_1;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(42, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(48, 22);
            textBox5.TabIndex = 7;
            textBox5.TabStop = false;
            textBox5.Text = "F5";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.Click += textBox5_Click;
            textBox5.KeyDown += textBox5_KeyDown;
            textBox5.Leave += textBox5_Leave;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Location = new Point(206, 156);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(98, 57);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Start/Stop";
            groupBox3.MouseCaptureChanged += groupBox1_MouseCaptureChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 24);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 8;
            label8.Text = "Key:";
            label8.Click += label8_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnStartStop.FlatStyle = FlatStyle.Flat;
            btnStartStop.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartStop.Location = new Point(315, 163);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(131, 50);
            btnStartStop.TabIndex = 9;
            btnStartStop.TabStop = false;
            btnStartStop.Text = "START";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(470, 238);
            Controls.Add(btnStartStop);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ORION Auto Clicker 1.0";
            Load += Form1_Load;
            Click += Form1_Click_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label7;
        private TextBox textBox5;
        private GroupBox groupBox3;
        private Label label8;
        private Button btnStartStop;
        private PictureBox pictureBox1;
    }
}