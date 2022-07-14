namespace RemoveBG_Client
{
    partial class FrmMain
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
            this.tBoxServerAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnLoadInput = new System.Windows.Forms.Button();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.saveImage = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBoxOutput = new System.Windows.Forms.PictureBox();
            this.pBoxInput = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxServerAddress
            // 
            this.tBoxServerAddress.Location = new System.Drawing.Point(96, 408);
            this.tBoxServerAddress.Name = "tBoxServerAddress";
            this.tBoxServerAddress.Size = new System.Drawing.Size(276, 20);
            this.tBoxServerAddress.TabIndex = 4;
            this.tBoxServerAddress.Text = "https://removebg.devstroop.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server address";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(476, 398);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(127, 41);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnLoadInput
            // 
            this.btnLoadInput.Location = new System.Drawing.Point(290, 13);
            this.btnLoadInput.Name = "btnLoadInput";
            this.btnLoadInput.Size = new System.Drawing.Size(75, 23);
            this.btnLoadInput.TabIndex = 7;
            this.btnLoadInput.Text = "Load";
            this.btnLoadInput.UseVisualStyleBackColor = true;
            this.btnLoadInput.Click += new System.EventHandler(this.btnLoadInput_Click);
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Location = new System.Drawing.Point(661, 13);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOutput.TabIndex = 8;
            this.btnSaveOutput.Text = "Save";
            this.btnSaveOutput.UseVisualStyleBackColor = true;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(609, 398);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(127, 41);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(209, 13);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(75, 23);
            this.btnClearInput.TabIndex = 10;
            this.btnClearInput.Text = "Clear";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Location = new System.Drawing.Point(580, 13);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(75, 23);
            this.btnClearOutput.TabIndex = 11;
            this.btnClearOutput.Text = "Clear";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // openImage
            // 
            this.openImage.DefaultExt = "jpg";
            this.openImage.Filter = "All files (*.*)|*.*";
            // 
            // saveImage
            // 
            this.saveImage.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RemoveBG_Client.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(280, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pBoxOutput
            // 
            this.pBoxOutput.Image = global::RemoveBG_Client.Properties.Resources.no_image;
            this.pBoxOutput.Location = new System.Drawing.Point(386, 42);
            this.pBoxOutput.Name = "pBoxOutput";
            this.pBoxOutput.Size = new System.Drawing.Size(350, 350);
            this.pBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxOutput.TabIndex = 3;
            this.pBoxOutput.TabStop = false;
            // 
            // pBoxInput
            // 
            this.pBoxInput.Image = global::RemoveBG_Client.Properties.Resources.no_image;
            this.pBoxInput.Location = new System.Drawing.Point(15, 42);
            this.pBoxInput.Name = "pBoxInput";
            this.pBoxInput.Size = new System.Drawing.Size(350, 350);
            this.pBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxInput.TabIndex = 2;
            this.pBoxInput.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSaveOutput);
            this.Controls.Add(this.btnLoadInput);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxServerAddress);
            this.Controls.Add(this.pBoxOutput);
            this.Controls.Add(this.pBoxInput);
            this.Name = "FrmMain";
            this.Text = "RemoveBG Client (Testing only)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxOutput;
        private System.Windows.Forms.PictureBox pBoxInput;
        private System.Windows.Forms.TextBox tBoxServerAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnLoadInput;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.SaveFileDialog saveImage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

