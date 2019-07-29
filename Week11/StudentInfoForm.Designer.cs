namespace Week11
{
    partial class StudentInfoForm
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.DataLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(139, 67);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(105, 42);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DataLabel
            // 
            this.DataLabel.BackColor = System.Drawing.Color.White;
            this.DataLabel.Location = new System.Drawing.Point(314, 67);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(272, 42);
            this.DataLabel.TabIndex = 0;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Location = new System.Drawing.Point(56, 130);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(188, 42);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.White;
            this.FirstNameDataLabel.Location = new System.Drawing.Point(314, 130);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(272, 42);
            this.FirstNameDataLabel.TabIndex = 0;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(62, 196);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(182, 42);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.BackColor = System.Drawing.Color.White;
            this.LastNameDataLabel.Location = new System.Drawing.Point(314, 196);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(272, 42);
            this.LastNameDataLabel.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(50, 357);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(131, 69);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 622);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LastNameDataLabel);
            this.Controls.Add(this.FirstNameDataLabel);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.IdLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "StudentInfoForm";
            this.Text = "StudentInfoForm";
            this.Activated += new System.EventHandler(this.StudentInfoForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentInfoForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Button BackButton;
    }
}