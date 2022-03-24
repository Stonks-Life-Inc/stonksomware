namespace stonksomware
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.RichTextBox richTextBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Panel panel2;
            this.button2 = new System.Windows.Forms.Button();
            this.date_label = new System.Windows.Forms.Label();
            this.timeLeft_label = new System.Windows.Forms.Label();
            this.timeLeft_progressBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            label1 = new System.Windows.Forms.Label();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Black", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(456, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1436, 199);
            label1.TabIndex = 1;
            label1.Text = "StonkSomware 💀";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            richTextBox1.Location = new System.Drawing.Point(0, 7);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(1359, 493);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            label2.Location = new System.Drawing.Point(318, 3);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(559, 38);
            label2.TabIndex = 1;
            label2.Text = "Send 69$ worth of bitcoin to this address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            label3.Location = new System.Drawing.Point(23, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(379, 38);
            label3.TabIndex = 2;
            label3.Text = "Your files will be deleted in:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dateLabel.Location = new System.Drawing.Point(159, 83);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(92, 38);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "DATE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(149, 218);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(115, 32);
            label4.TabIndex = 4;
            label4.Text = "Time left";
            // 
            // panel1
            // 
            panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panel1.AutoSize = true;
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(this.button2);
            panel1.Location = new System.Drawing.Point(0, 509);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1359, 135);
            panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackgroundImage = global::stonksomware.Properties.Resources.bitcoin;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 125);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panel2.AutoSize = true;
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(this.date_label);
            panel2.Controls.Add(this.timeLeft_label);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateLabel);
            panel2.Controls.Add(label3);
            panel2.Location = new System.Drawing.Point(0, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(438, 343);
            panel2.TabIndex = 7;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_label.Location = new System.Drawing.Point(1, 143);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(68, 32);
            this.date_label.TabIndex = 6;
            this.date_label.Text = "DATE";
            this.date_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLeft_label
            // 
            this.timeLeft_label.AutoSize = true;
            this.timeLeft_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLeft_label.Location = new System.Drawing.Point(3, 280);
            this.timeLeft_label.Name = "timeLeft_label";
            this.timeLeft_label.Size = new System.Drawing.Size(161, 39);
            this.timeLeft_label.TabIndex = 5;
            this.timeLeft_label.Text = "TIMELEFT";
            this.timeLeft_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLeft_progressBar
            // 
            this.timeLeft_progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLeft_progressBar.Location = new System.Drawing.Point(222, 874);
            this.timeLeft_progressBar.Maximum = 300;
            this.timeLeft_progressBar.Name = "timeLeft_progressBar";
            this.timeLeft_progressBar.Size = new System.Drawing.Size(1593, 67);
            this.timeLeft_progressBar.Step = 1;
            this.timeLeft_progressBar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 874);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "🔒 Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackgroundImage = global::stonksomware.Properties.Resources.sli_malcolm;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(0, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 285);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackgroundImage = global::stonksomware.Properties.Resources.sli;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(438, 199);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(richTextBox1);
            this.panel5.Controls.Add(panel1);
            this.panel5.Location = new System.Drawing.Point(456, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1359, 654);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(panel2);
            this.panel6.Location = new System.Drawing.Point(12, 217);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(441, 953);
            this.panel6.TabIndex = 11;
            // 
            // timerProgress
            // 
            this.timerProgress.Enabled = true;
            this.timerProgress.Interval = 1000;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1827, 953);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeLeft_progressBar);
            this.Controls.Add(label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private ProgressBar timeLeft_progressBar;
        private Button button1;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private Label label2;
        private Button button2;
        private Panel panel2;
        private Label dateLabel;
        private Label label3;
        private Label timeLeft_label;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private System.Windows.Forms.Timer timerProgress;
        private Label date_label;
    }
}