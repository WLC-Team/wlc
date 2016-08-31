namespace WLC
{
    partial class WLC
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
            this.SrcDirTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WinRTTB = new System.Windows.Forms.TextBox();
            this.DstDirTB = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.SrcDir = new System.Windows.Forms.Button();
            this.DstDir = new System.Windows.Forms.Button();
            this.WinRTDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SrcDirTB
            // 
            this.SrcDirTB.Location = new System.Drawing.Point(135, 54);
            this.SrcDirTB.Name = "SrcDirTB";
            this.SrcDirTB.Size = new System.Drawing.Size(419, 20);
            this.SrcDirTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Src Dir";
            // 
            // WinRTTB
            // 
            this.WinRTTB.Location = new System.Drawing.Point(135, 92);
            this.WinRTTB.Name = "WinRTTB";
            this.WinRTTB.Size = new System.Drawing.Size(419, 20);
            this.WinRTTB.TabIndex = 3;
            this.WinRTTB.Text = "C:\\Program Files (x86)\\Windows Kits\\8.1\\References\\CommonConfiguration\\Neutral\\An" +
    "notated;C:\\Program Files (x86)\\Microsoft Visual Studio 14.0\\VC\\vcpackages";
            // 
            // DstDirTB
            // 
            this.DstDirTB.Location = new System.Drawing.Point(135, 128);
            this.DstDirTB.Name = "DstDirTB";
            this.DstDirTB.Size = new System.Drawing.Size(419, 20);
            this.DstDirTB.TabIndex = 5;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(262, 182);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 23);
            this.Convert.TabIndex = 6;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // SrcDir
            // 
            this.SrcDir.Location = new System.Drawing.Point(39, 50);
            this.SrcDir.Name = "SrcDir";
            this.SrcDir.Size = new System.Drawing.Size(75, 23);
            this.SrcDir.TabIndex = 7;
            this.SrcDir.Text = "Src Dir";
            this.SrcDir.UseVisualStyleBackColor = true;
            this.SrcDir.Click += new System.EventHandler(this.SrcDir_Click);
            // 
            // DstDir
            // 
            this.DstDir.Location = new System.Drawing.Point(39, 125);
            this.DstDir.Name = "DstDir";
            this.DstDir.Size = new System.Drawing.Size(75, 23);
            this.DstDir.TabIndex = 8;
            this.DstDir.Text = "Dst Dir";
            this.DstDir.UseVisualStyleBackColor = true;
            this.DstDir.Click += new System.EventHandler(this.DstDir_Click);
            // 
            // WinRTDir
            // 
            this.WinRTDir.Location = new System.Drawing.Point(39, 90);
            this.WinRTDir.Name = "WinRTDir";
            this.WinRTDir.Size = new System.Drawing.Size(75, 23);
            this.WinRTDir.TabIndex = 9;
            this.WinRTDir.Text = "WinRT Dir";
            this.WinRTDir.UseVisualStyleBackColor = true;
            this.WinRTDir.Click += new System.EventHandler(this.WinRTDir_Click);
            // 
            // WLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 287);
            this.Controls.Add(this.WinRTDir);
            this.Controls.Add(this.DstDir);
            this.Controls.Add(this.SrcDir);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.DstDirTB);
            this.Controls.Add(this.WinRTTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SrcDirTB);
            this.Name = "WLC";
            this.Text = "WLC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SrcDirTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WinRTTB;
        private System.Windows.Forms.TextBox DstDirTB;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button SrcDir;
        private System.Windows.Forms.Button DstDir;
        private System.Windows.Forms.Button WinRTDir;
    }
}

