namespace Lab_Attendance_Tracker
{
    partial class MainForm
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
            if(disposing && (components != null))
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
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.studentNumberLabel = new System.Windows.Forms.Label();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumberTextBox.Location = new System.Drawing.Point(97, 57);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
            this.studentNumberTextBox.Size = new System.Drawing.Size(252, 30);
            this.studentNumberTextBox.TabIndex = 0;
            // 
            // studentNumberLabel
            // 
            this.studentNumberLabel.AutoSize = true;
            this.studentNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumberLabel.Location = new System.Drawing.Point(92, 25);
            this.studentNumberLabel.Name = "studentNumberLabel";
            this.studentNumberLabel.Size = new System.Drawing.Size(257, 29);
            this.studentNumberLabel.TabIndex = 1;
            this.studentNumberLabel.Text = "Enter Student Number:";
            this.studentNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckInButton
            // 
            this.CheckInButton.Location = new System.Drawing.Point(97, 103);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(90, 33);
            this.CheckInButton.TabIndex = 2;
            this.CheckInButton.Text = "Check-in";
            this.CheckInButton.UseVisualStyleBackColor = true;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(259, 103);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(90, 33);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 159);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.CheckInButton);
            this.Controls.Add(this.studentNumberLabel);
            this.Controls.Add(this.studentNumberTextBox);
            this.Name = "MainForm";
            this.Text = "Check-In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.Label studentNumberLabel;
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Button RegisterButton;
    }
}

