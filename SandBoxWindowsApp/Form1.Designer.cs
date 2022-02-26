
namespace SandBoxWindowsApp
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
            this.txb_filepath = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.rtbx_console = new System.Windows.Forms.RichTextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_filepath
            // 
            this.txb_filepath.Location = new System.Drawing.Point(29, 20);
            this.txb_filepath.Name = "txb_filepath";
            this.txb_filepath.Size = new System.Drawing.Size(473, 20);
            this.txb_filepath.TabIndex = 0;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(517, 18);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // rtbx_console
            // 
            this.rtbx_console.Location = new System.Drawing.Point(29, 396);
            this.rtbx_console.Name = "rtbx_console";
            this.rtbx_console.Size = new System.Drawing.Size(473, 160);
            this.rtbx_console.TabIndex = 2;
            this.rtbx_console.Text = "";
            this.rtbx_console.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(517, 418);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 111);
            this.btn_run.TabIndex = 3;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 578);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.rtbx_console);
            this.Controls.Add(this.txb_filepath);
            this.Controls.Add(this.btn_browse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_filepath;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.RichTextBox rtbx_console;
        private System.Windows.Forms.Button btn_run;
    }
}

