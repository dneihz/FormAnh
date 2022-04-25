namespace FormAnh
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.buttonLoadImageFromDatabase = new System.Windows.Forms.Button();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.pictureBoxDes = new System.Windows.Forms.PictureBox();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(88, 325);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(165, 56);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(317, 325);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(139, 56);
            this.btnSaveToDatabase.TabIndex = 1;
            this.btnSaveToDatabase.Text = "Save";
            this.btnSaveToDatabase.UseVisualStyleBackColor = true;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // buttonLoadImageFromDatabase
            // 
            this.buttonLoadImageFromDatabase.Location = new System.Drawing.Point(541, 325);
            this.buttonLoadImageFromDatabase.Name = "buttonLoadImageFromDatabase";
            this.buttonLoadImageFromDatabase.Size = new System.Drawing.Size(142, 56);
            this.buttonLoadImageFromDatabase.TabIndex = 2;
            this.buttonLoadImageFromDatabase.Text = "Load";
            this.buttonLoadImageFromDatabase.UseVisualStyleBackColor = true;
            this.buttonLoadImageFromDatabase.Click += new System.EventHandler(this.buttonLoadImageFromDatabase_Click);
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Location = new System.Drawing.Point(88, 32);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(231, 211);
            this.pictureBoxSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSource.TabIndex = 3;
            this.pictureBoxSource.TabStop = false;
            // 
            // pictureBoxDes
            // 
            this.pictureBoxDes.Location = new System.Drawing.Point(467, 32);
            this.pictureBoxDes.Name = "pictureBoxDes";
            this.pictureBoxDes.Size = new System.Drawing.Size(231, 211);
            this.pictureBoxDes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDes.TabIndex = 4;
            this.pictureBoxDes.TabStop = false;
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            this.ofdOpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdOpenFile_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxDes);
            this.Controls.Add(this.pictureBoxSource);
            this.Controls.Add(this.buttonLoadImageFromDatabase);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSaveToDatabase;
        private System.Windows.Forms.Button buttonLoadImageFromDatabase;
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.PictureBox pictureBoxDes;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
    }
}

