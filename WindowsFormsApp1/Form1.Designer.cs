namespace WindowsFormsApp1
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.btnReadAsync = new System.Windows.Forms.Button();
            this.btnReadSync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(710, 1);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(92, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(5, 2);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(707, 22);
            this.tbURL.TabIndex = 1;
            this.tbURL.Text = "tbURL";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(100, 45);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.Size = new System.Drawing.Size(100, 22);
            this.tbResults.TabIndex = 2;
            // 
            // btnReadAsync
            // 
            this.btnReadAsync.Location = new System.Drawing.Point(125, 87);
            this.btnReadAsync.Name = "btnReadAsync";
            this.btnReadAsync.Size = new System.Drawing.Size(75, 23);
            this.btnReadAsync.TabIndex = 3;
            this.btnReadAsync.Text = "button1";
            this.btnReadAsync.UseVisualStyleBackColor = true;
            this.btnReadAsync.Click += new System.EventHandler(this.btnReadAsync_Click);
            // 
            // btnReadSync
            // 
            this.btnReadSync.Location = new System.Drawing.Point(251, 86);
            this.btnReadSync.Name = "btnReadSync";
            this.btnReadSync.Size = new System.Drawing.Size(75, 23);
            this.btnReadSync.TabIndex = 4;
            this.btnReadSync.Text = "btnReadSync";
            this.btnReadSync.UseVisualStyleBackColor = true;
            this.btnReadSync.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadSync);
            this.Controls.Add(this.btnReadAsync);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Button btnReadAsync;
        private System.Windows.Forms.Button btnReadSync;
    }
}

