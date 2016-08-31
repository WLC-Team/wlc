namespace RefOutTest
{
    partial class RefOut
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
            this.RefOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RefOutBtn
            // 
            this.RefOutBtn.Location = new System.Drawing.Point(93, 86);
            this.RefOutBtn.Name = "RefOutBtn";
            this.RefOutBtn.Size = new System.Drawing.Size(75, 23);
            this.RefOutBtn.TabIndex = 0;
            this.RefOutBtn.Text = "RefOutBt";
            this.RefOutBtn.UseVisualStyleBackColor = true;
            this.RefOutBtn.Click += new System.EventHandler(this.RefOutBtn_Click);
            // 
            // RefOut
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.RefOutBtn);
            this.Name = "RefOut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RefOutBt;
        private System.Windows.Forms.Button RefOutBtn;
    }
}

