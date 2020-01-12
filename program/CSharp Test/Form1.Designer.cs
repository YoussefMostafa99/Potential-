namespace CSharp_Test
{
    partial class Form1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.rbtn4 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(104, 368);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(574, 42);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "&Load Image";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // pB1
            // 
            this.pB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB1.Location = new System.Drawing.Point(104, 28);
            this.pB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(567, 319);
            this.pB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB1.TabIndex = 1;
            this.pB1.TabStop = false;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(97, 502);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(581, 42);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "&Compress and Save";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(245, 349);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(300, 17);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Click On The Button Below To Choose an Image";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(228, 483);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(304, 17);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Click On The Button Below To Begin The Process";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(344, 9);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(101, 17);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Selected Image";
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(278, 448);
            this.rbtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(86, 21);
            this.rbtn1.TabIndex = 6;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "50 Levels";
            this.rbtn1.UseVisualStyleBackColor = true;
            this.rbtn1.CheckedChanged += new System.EventHandler(this.rbtn1_CheckedChanged);
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(573, 448);
            this.rbtn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(98, 21);
            this.rbtn2.TabIndex = 7;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "100 Levels ";
            this.rbtn2.UseVisualStyleBackColor = true;
            this.rbtn2.CheckedChanged += new System.EventHandler(this.rbtn2_CheckedChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(35, 428);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(229, 17);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "Lowest Quality Highest Compression";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(519, 428);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(229, 17);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "Highest Quality Lowest Compression";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbtn4
            // 
            this.rbtn4.AutoSize = true;
            this.rbtn4.Location = new System.Drawing.Point(428, 448);
            this.rbtn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn4.Name = "rbtn4";
            this.rbtn4.Size = new System.Drawing.Size(86, 21);
            this.rbtn4.TabIndex = 10;
            this.rbtn4.TabStop = true;
            this.rbtn4.Text = "75 Levels";
            this.rbtn4.UseVisualStyleBackColor = true;
            this.rbtn4.CheckedChanged += new System.EventHandler(this.rbtn4_CheckedChanged);
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(165, 448);
            this.rbtn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(86, 21);
            this.rbtn3.TabIndex = 11;
            this.rbtn3.TabStop = true;
            this.rbtn3.Text = "25 Levels";
            this.rbtn3.UseVisualStyleBackColor = true;
            this.rbtn3.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
            // 
            // rbtn5
            // 
            this.rbtn5.AutoSize = true;
            this.rbtn5.Location = new System.Drawing.Point(39, 448);
            this.rbtn5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(78, 21);
            this.rbtn5.TabIndex = 12;
            this.rbtn5.TabStop = true;
            this.rbtn5.Text = "0 Levels";
            this.rbtn5.UseVisualStyleBackColor = true;
            this.rbtn5.CheckedChanged += new System.EventHandler(this.rbtn5_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.rbtn5);
            this.Controls.Add(this.rbtn3);
            this.Controls.Add(this.rbtn4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.rbtn2);
            this.Controls.Add(this.rbtn1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.btn1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Compression-Alpha-CSharpV2.(Layout Change)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.RadioButton rbtn4;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtn5;
    }
}

