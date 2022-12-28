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
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.btnChooseFolderPath = new System.Windows.Forms.Button();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.lbFolderPath = new System.Windows.Forms.Label();
            this.nudOrder = new System.Windows.Forms.NumericUpDown();
            this.lbFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseFilePath
            // 
            this.btnChooseFilePath.Location = new System.Drawing.Point(461, 28);
            this.btnChooseFilePath.Margin = new System.Windows.Forms.Padding(5);
            this.btnChooseFilePath.Name = "btnChooseFilePath";
            this.btnChooseFilePath.Size = new System.Drawing.Size(217, 32);
            this.btnChooseFilePath.TabIndex = 0;
            this.btnChooseFilePath.Text = "Choose File Path";
            this.btnChooseFilePath.UseVisualStyleBackColor = true;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(126, 28);
            this.tbFilePath.Margin = new System.Windows.Forms.Padding(5);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(325, 32);
            this.tbFilePath.TabIndex = 1;
            // 
            // pbImage1
            // 
            this.pbImage1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbImage1.Location = new System.Drawing.Point(12, 177);
            this.pbImage1.Name = "pbImage1";
            this.pbImage1.Size = new System.Drawing.Size(565, 321);
            this.pbImage1.TabIndex = 2;
            this.pbImage1.TabStop = false;
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Location = new System.Drawing.Point(126, 87);
            this.tbFolderPath.Margin = new System.Windows.Forms.Padding(5);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(325, 32);
            this.tbFolderPath.TabIndex = 3;
            // 
            // btnChooseFolderPath
            // 
            this.btnChooseFolderPath.Location = new System.Drawing.Point(461, 86);
            this.btnChooseFolderPath.Margin = new System.Windows.Forms.Padding(5);
            this.btnChooseFolderPath.Name = "btnChooseFolderPath";
            this.btnChooseFolderPath.Size = new System.Drawing.Size(217, 32);
            this.btnChooseFolderPath.TabIndex = 4;
            this.btnChooseFolderPath.Text = "Choose Folder Path";
            this.btnChooseFolderPath.UseVisualStyleBackColor = true;
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Location = new System.Drawing.Point(6, 31);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(86, 24);
            this.lbFilePath.TabIndex = 5;
            this.lbFilePath.Text = "File Path";
            // 
            // lbFolderPath
            // 
            this.lbFolderPath.AutoSize = true;
            this.lbFolderPath.Location = new System.Drawing.Point(6, 90);
            this.lbFolderPath.Name = "lbFolderPath";
            this.lbFolderPath.Size = new System.Drawing.Size(112, 24);
            this.lbFolderPath.TabIndex = 6;
            this.lbFolderPath.Text = "Folder Path";
            // 
            // nudOrder
            // 
            this.nudOrder.Location = new System.Drawing.Point(612, 177);
            this.nudOrder.Name = "nudOrder";
            this.nudOrder.Size = new System.Drawing.Size(66, 32);
            this.nudOrder.TabIndex = 7;
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(12, 150);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(109, 24);
            this.lbFileName.TabIndex = 8;
            this.lbFileName.Text = "FileName : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 510);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.nudOrder);
            this.Controls.Add(this.lbFolderPath);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.btnChooseFolderPath);
            this.Controls.Add(this.tbFolderPath);
            this.Controls.Add(this.pbImage1);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.btnChooseFilePath);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnChooseFilePath;
        private TextBox tbFilePath;
        private PictureBox pbImage1;
        private TextBox tbFolderPath;
        private Button btnChooseFolderPath;
        private Label lbFilePath;
        private Label lbFolderPath;
        private NumericUpDown nudOrder;
        private Label lbFileName;
    }
}