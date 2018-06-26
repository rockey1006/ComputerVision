namespace BasicImageProcessing
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
            this.btnLoadPicture = new System.Windows.Forms.Button();
            this.btnConvertToGrey = new System.Windows.Forms.Button();
            this.btnAdjustBrightness = new System.Windows.Forms.Button();
            this.btnAdjustContrast = new System.Windows.Forms.Button();
            this.btnSaveProcessedPicture = new System.Windows.Forms.Button();
            this.picOrig = new System.Windows.Forms.PictureBox();
            this.picProcessed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadPicture
            // 
            this.btnLoadPicture.Location = new System.Drawing.Point(58, 37);
            this.btnLoadPicture.Name = "btnLoadPicture";
            this.btnLoadPicture.Size = new System.Drawing.Size(236, 84);
            this.btnLoadPicture.TabIndex = 0;
            this.btnLoadPicture.Text = "Load Picture";
            this.btnLoadPicture.UseVisualStyleBackColor = true;
            this.btnLoadPicture.Click += new System.EventHandler(this.btnLoadPicture_Click);
            // 
            // btnConvertToGrey
            // 
            this.btnConvertToGrey.Location = new System.Drawing.Point(58, 147);
            this.btnConvertToGrey.Name = "btnConvertToGrey";
            this.btnConvertToGrey.Size = new System.Drawing.Size(222, 68);
            this.btnConvertToGrey.TabIndex = 1;
            this.btnConvertToGrey.Text = "Convert To Grey";
            this.btnConvertToGrey.UseVisualStyleBackColor = true;
            this.btnConvertToGrey.Click += new System.EventHandler(this.btnConvertToGrey_Click);
            // 
            // btnAdjustBrightness
            // 
            this.btnAdjustBrightness.Location = new System.Drawing.Point(58, 267);
            this.btnAdjustBrightness.Name = "btnAdjustBrightness";
            this.btnAdjustBrightness.Size = new System.Drawing.Size(222, 59);
            this.btnAdjustBrightness.TabIndex = 2;
            this.btnAdjustBrightness.Text = "Adjust Brightness";
            this.btnAdjustBrightness.UseVisualStyleBackColor = true;
            this.btnAdjustBrightness.Click += new System.EventHandler(this.btnAdjustBrightness_Click);
            // 
            // btnAdjustContrast
            // 
            this.btnAdjustContrast.Location = new System.Drawing.Point(58, 379);
            this.btnAdjustContrast.Name = "btnAdjustContrast";
            this.btnAdjustContrast.Size = new System.Drawing.Size(208, 60);
            this.btnAdjustContrast.TabIndex = 3;
            this.btnAdjustContrast.Text = "Adjust Contrast";
            this.btnAdjustContrast.UseVisualStyleBackColor = true;
            this.btnAdjustContrast.Click += new System.EventHandler(this.btnAdjustContrast_Click);
            // 
            // btnSaveProcessedPicture
            // 
            this.btnSaveProcessedPicture.Location = new System.Drawing.Point(680, 603);
            this.btnSaveProcessedPicture.Name = "btnSaveProcessedPicture";
            this.btnSaveProcessedPicture.Size = new System.Drawing.Size(256, 53);
            this.btnSaveProcessedPicture.TabIndex = 4;
            this.btnSaveProcessedPicture.Text = "Save Processed Picture";
            this.btnSaveProcessedPicture.UseVisualStyleBackColor = true;
            this.btnSaveProcessedPicture.Click += new System.EventHandler(this.btnSaveProcessedPicture_Click);
            // 
            // picOrig
            // 
            this.picOrig.Location = new System.Drawing.Point(329, 37);
            this.picOrig.Name = "picOrig";
            this.picOrig.Size = new System.Drawing.Size(489, 520);
            this.picOrig.TabIndex = 5;
            this.picOrig.TabStop = false;
            // 
            // picProcessed
            // 
            this.picProcessed.Location = new System.Drawing.Point(893, 37);
            this.picProcessed.Name = "picProcessed";
            this.picProcessed.Size = new System.Drawing.Size(505, 520);
            this.picProcessed.TabIndex = 6;
            this.picProcessed.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 853);
            this.Controls.Add(this.picProcessed);
            this.Controls.Add(this.picOrig);
            this.Controls.Add(this.btnSaveProcessedPicture);
            this.Controls.Add(this.btnAdjustContrast);
            this.Controls.Add(this.btnAdjustBrightness);
            this.Controls.Add(this.btnConvertToGrey);
            this.Controls.Add(this.btnLoadPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPicture;
        private System.Windows.Forms.Button btnConvertToGrey;
        private System.Windows.Forms.Button btnAdjustBrightness;
        private System.Windows.Forms.Button btnAdjustContrast;
        private System.Windows.Forms.Button btnSaveProcessedPicture;
        private System.Windows.Forms.PictureBox picOrig;
        private System.Windows.Forms.PictureBox picProcessed;
    }
}

