namespace ColorTheme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yellowRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.normalRadioButton);
            this.groupBox1.Controls.Add(this.whiteRadioButton);
            this.groupBox1.Controls.Add(this.redRadioButton);
            this.groupBox1.Controls.Add(this.yellowRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(23, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a background Color";
            // 
            // yellowRadioButton
            // 
            this.yellowRadioButton.AutoSize = true;
            this.yellowRadioButton.Location = new System.Drawing.Point(63, 59);
            this.yellowRadioButton.Name = "yellowRadioButton";
            this.yellowRadioButton.Size = new System.Drawing.Size(69, 21);
            this.yellowRadioButton.TabIndex = 0;
            this.yellowRadioButton.TabStop = true;
            this.yellowRadioButton.Text = "Yellow";
            this.yellowRadioButton.UseVisualStyleBackColor = true;
            this.yellowRadioButton.CheckedChanged += new System.EventHandler(this.yellowRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(63, 104);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(55, 21);
            this.redRadioButton.TabIndex = 1;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // whiteRadioButton
            // 
            this.whiteRadioButton.AutoSize = true;
            this.whiteRadioButton.Location = new System.Drawing.Point(63, 148);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(65, 21);
            this.whiteRadioButton.TabIndex = 2;
            this.whiteRadioButton.TabStop = true;
            this.whiteRadioButton.Text = "White";
            this.whiteRadioButton.UseVisualStyleBackColor = true;
            this.whiteRadioButton.CheckedChanged += new System.EventHandler(this.whiteRadioButton_CheckedChanged);
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Location = new System.Drawing.Point(63, 189);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(125, 21);
            this.normalRadioButton.TabIndex = 3;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "Back to Normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            this.normalRadioButton.CheckedChanged += new System.EventHandler(this.normalRadioButton_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(87, 325);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(123, 39);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 400);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton whiteRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton yellowRadioButton;
        private System.Windows.Forms.Button exitButton;
    }
}

