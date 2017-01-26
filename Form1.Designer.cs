namespace ISO_Builder
{
    partial class FormBuildISO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuildISO));
            this.txtSourceFiles = new System.Windows.Forms.TextBox();
            this.btnOpenSource = new System.Windows.Forms.Button();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.btnDestinationPath = new System.Windows.Forms.Button();
            this.txtISOFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnBuildISO = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSourceFiles
            // 
            this.txtSourceFiles.Location = new System.Drawing.Point(12, 12);
            this.txtSourceFiles.Name = "txtSourceFiles";
            this.txtSourceFiles.Size = new System.Drawing.Size(399, 20);
            this.txtSourceFiles.TabIndex = 0;
            // 
            // btnOpenSource
            // 
            this.btnOpenSource.Location = new System.Drawing.Point(417, 10);
            this.btnOpenSource.Name = "btnOpenSource";
            this.btnOpenSource.Size = new System.Drawing.Size(105, 23);
            this.btnOpenSource.TabIndex = 1;
            this.btnOpenSource.Text = "Source Files";
            this.btnOpenSource.UseVisualStyleBackColor = true;
            this.btnOpenSource.Click += new System.EventHandler(this.btnOpenSource_Click);
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(12, 38);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(399, 20);
            this.txtDestinationPath.TabIndex = 2;
            // 
            // btnDestinationPath
            // 
            this.btnDestinationPath.Location = new System.Drawing.Point(417, 36);
            this.btnDestinationPath.Name = "btnDestinationPath";
            this.btnDestinationPath.Size = new System.Drawing.Size(105, 23);
            this.btnDestinationPath.TabIndex = 3;
            this.btnDestinationPath.Text = "Path to Save ISO";
            this.btnDestinationPath.UseVisualStyleBackColor = true;
            this.btnDestinationPath.Click += new System.EventHandler(this.btnDestinationPath_Click);
            // 
            // txtISOFileName
            // 
            this.txtISOFileName.Location = new System.Drawing.Point(12, 64);
            this.txtISOFileName.Name = "txtISOFileName";
            this.txtISOFileName.Size = new System.Drawing.Size(399, 20);
            this.txtISOFileName.TabIndex = 4;
            this.txtISOFileName.TextChanged += new System.EventHandler(this.txtISOFileName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISO File Name";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 90);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(621, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 6;
            // 
            // btnBuildISO
            // 
            this.btnBuildISO.Location = new System.Drawing.Point(528, 10);
            this.btnBuildISO.Name = "btnBuildISO";
            this.btnBuildISO.Size = new System.Drawing.Size(105, 74);
            this.btnBuildISO.TabIndex = 7;
            this.btnBuildISO.Text = "Build ISO";
            this.btnBuildISO.UseVisualStyleBackColor = true;
            this.btnBuildISO.Click += new System.EventHandler(this.btnBuildISO_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(305, 95);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(54, 13);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "Complete!";
            // 
            // FormBuildISO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 124);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnBuildISO);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtISOFileName);
            this.Controls.Add(this.btnDestinationPath);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.btnOpenSource);
            this.Controls.Add(this.txtSourceFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuildISO";
            this.Text = "ISO Builder";
            this.Load += new System.EventHandler(this.FormBuildISO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceFiles;
        private System.Windows.Forms.Button btnOpenSource;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Button btnDestinationPath;
        private System.Windows.Forms.TextBox txtISOFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnBuildISO;
        private System.Windows.Forms.Label lblProgress;
    }
}

