namespace imgReg
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInitializeShapes = new System.Windows.Forms.Button();
            this.panShape1 = new System.Windows.Forms.Panel();
            this.panShape2 = new System.Windows.Forms.Panel();
            this.btnApplyTransformation = new System.Windows.Forms.Button();
            this.panShape3 = new System.Windows.Forms.Panel();
            this.btnOutlierRemoval = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInitializeShapes
            // 
            this.btnInitializeShapes.Location = new System.Drawing.Point(140, 467);
            this.btnInitializeShapes.Name = "btnInitializeShapes";
            this.btnInitializeShapes.Size = new System.Drawing.Size(161, 30);
            this.btnInitializeShapes.TabIndex = 0;
            this.btnInitializeShapes.Text = "Initialize Shapes";
            this.btnInitializeShapes.UseVisualStyleBackColor = true;
            this.btnInitializeShapes.Click += new System.EventHandler(this.btnInitializeShapes_Click);
            // 
            // panShape1
            // 
            this.panShape1.Location = new System.Drawing.Point(32, 57);
            this.panShape1.Name = "panShape1";
            this.panShape1.Size = new System.Drawing.Size(390, 390);
            this.panShape1.TabIndex = 1;
            // 
            // panShape2
            // 
            this.panShape2.Location = new System.Drawing.Point(428, 57);
            this.panShape2.Name = "panShape2";
            this.panShape2.Size = new System.Drawing.Size(390, 390);
            this.panShape2.TabIndex = 2;
            // 
            // btnApplyTransformation
            // 
            this.btnApplyTransformation.Location = new System.Drawing.Point(469, 467);
            this.btnApplyTransformation.Name = "btnApplyTransformation";
            this.btnApplyTransformation.Size = new System.Drawing.Size(161, 30);
            this.btnApplyTransformation.TabIndex = 3;
            this.btnApplyTransformation.Text = "Apply Transformation";
            this.btnApplyTransformation.UseVisualStyleBackColor = true;
            this.btnApplyTransformation.Click += new System.EventHandler(this.btnApplyTransformation_Click);
            // 
            // panShape3
            // 
            this.panShape3.Location = new System.Drawing.Point(824, 57);
            this.panShape3.Name = "panShape3";
            this.panShape3.Size = new System.Drawing.Size(390, 390);
            this.panShape3.TabIndex = 3;
            // 
            // btnOutlierRemoval
            // 
            this.btnOutlierRemoval.Location = new System.Drawing.Point(864, 467);
            this.btnOutlierRemoval.Name = "btnOutlierRemoval";
            this.btnOutlierRemoval.Size = new System.Drawing.Size(158, 30);
            this.btnOutlierRemoval.TabIndex = 4;
            this.btnOutlierRemoval.Text = "Outlier Removal";
            this.btnOutlierRemoval.UseVisualStyleBackColor = true;
            this.btnOutlierRemoval.Click += new System.EventHandler(this.btnOutlierRemoval_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 620);
            this.Controls.Add(this.btnOutlierRemoval);
            this.Controls.Add(this.panShape3);
            this.Controls.Add(this.btnApplyTransformation);
            this.Controls.Add(this.panShape2);
            this.Controls.Add(this.panShape1);
            this.Controls.Add(this.btnInitializeShapes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInitializeShapes;
        private System.Windows.Forms.Panel panShape1;
        private System.Windows.Forms.Panel panShape2;
        private System.Windows.Forms.Button btnApplyTransformation;
        private System.Windows.Forms.Panel panShape3;
        private System.Windows.Forms.Button btnOutlierRemoval;
    }
}

