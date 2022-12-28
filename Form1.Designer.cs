namespace ex_LoadImage
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
            this.btnChooseFilePath = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.pbImage1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseFilePath
            // 
            this.btnChooseFilePath.Location = new System.Drawing.Point(385, 31);
            this.btnChooseFilePath.Margin = new System.Windows.Forms.Padding(5);
            this.btnChooseFilePath.Name = "btnChooseFilePath";
            this.btnChooseFilePath.Size = new System.Drawing.Size(217, 32);
            this.btnChooseFilePath.TabIndex = 0;
            this.btnChooseFilePath.Text = "Choose FilePath";
            this.btnChooseFilePath.UseVisualStyleBackColor = true;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(37, 32);
            this.tbFilePath.Margin = new System.Windows.Forms.Padding(5);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(325, 32);
            this.tbFilePath.TabIndex = 1;
            // 
            // pbImage1
            // 
            this.pbImage1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbImage1.Location = new System.Drawing.Point(37, 106);
            this.pbImage1.Name = "pbImage1";
            this.pbImage1.Size = new System.Drawing.Size(565, 321);
            this.pbImage1.TabIndex = 2;
            this.pbImage1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 510);
            this.Controls.Add(this.pbImage1);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.btnChooseFilePath);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnChooseFilePath;
        private TextBox tbFilePath;
        private PictureBox pbImage1;
    }
}