namespace FileManager {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mainFileManagerView1 = new FileManager.Views.MainFileManagerView();
            this.SuspendLayout();
            // 
            // mainFileManagerView1
            // 
            this.mainFileManagerView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFileManagerView1.Location = new System.Drawing.Point(0, 0);
            this.mainFileManagerView1.Name = "mainFileManagerView1";
            this.mainFileManagerView1.Size = new System.Drawing.Size(728, 407);
            this.mainFileManagerView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 407);
            this.Controls.Add(this.mainFileManagerView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.MainFileManagerView mainFileManagerView1;

    }
}

