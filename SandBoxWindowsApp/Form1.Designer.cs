
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txb_filepath = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.rtbx_console = new System.Windows.Forms.RichTextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.checkIO = new System.Windows.Forms.CheckBox();
            this.checkUI = new System.Windows.Forms.CheckBox();
            this.checkFileDialog = new System.Windows.Forms.CheckBox();
            this.checkSecurity = new System.Windows.Forms.CheckBox();
            this.tbl_permissions = new System.Windows.Forms.TableLayoutPanel();
            this.checkIsolatedStorage = new System.Windows.Forms.CheckBox();
            this.checkEnvironment = new System.Windows.Forms.CheckBox();
            this.checkKeyContainer = new System.Windows.Forms.CheckBox();
            this.checkPrincipal = new System.Windows.Forms.CheckBox();
            this.checkReflection = new System.Windows.Forms.CheckBox();
            this.checkRegistry = new System.Windows.Forms.CheckBox();
            this.checkStore = new System.Windows.Forms.CheckBox();
            this.checkWeb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkUnrestricted = new System.Windows.Forms.CheckBox();
            this.tbl_permissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_filepath
            // 
            this.txb_filepath.Location = new System.Drawing.Point(29, 54);
            this.txb_filepath.Name = "txb_filepath";
            this.txb_filepath.Size = new System.Drawing.Size(554, 20);
            this.txb_filepath.TabIndex = 0;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(508, 12);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 36);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // rtbx_console
            // 
            this.rtbx_console.Location = new System.Drawing.Point(29, 473);
            this.rtbx_console.Name = "rtbx_console";
            this.rtbx_console.Size = new System.Drawing.Size(554, 160);
            this.rtbx_console.TabIndex = 2;
            this.rtbx_console.Text = "";
            this.rtbx_console.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(508, 429);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 38);
            this.btn_run.TabIndex = 3;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkIO
            // 
            this.checkIO.AutoSize = true;
            this.checkIO.BackColor = System.Drawing.Color.Black;
            this.checkIO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkIO.Location = new System.Drawing.Point(6, 6);
            this.checkIO.Name = "checkIO";
            this.checkIO.Size = new System.Drawing.Size(132, 17);
            this.checkIO.TabIndex = 4;
            this.checkIO.Text = "FILE-IO-PERMISSION";
            this.checkIO.UseVisualStyleBackColor = false;
            // 
            // checkUI
            // 
            this.checkUI.AutoSize = true;
            this.checkUI.BackColor = System.Drawing.Color.Black;
            this.checkUI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkUI.Location = new System.Drawing.Point(6, 52);
            this.checkUI.Name = "checkUI";
            this.checkUI.Size = new System.Drawing.Size(107, 17);
            this.checkUI.TabIndex = 5;
            this.checkUI.Text = "UI-PERMISSION";
            this.checkUI.UseVisualStyleBackColor = false;
            // 
            // checkFileDialog
            // 
            this.checkFileDialog.AutoSize = true;
            this.checkFileDialog.BackColor = System.Drawing.Color.Black;
            this.checkFileDialog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkFileDialog.Location = new System.Drawing.Point(6, 98);
            this.checkFileDialog.Name = "checkFileDialog";
            this.checkFileDialog.Size = new System.Drawing.Size(161, 17);
            this.checkFileDialog.TabIndex = 6;
            this.checkFileDialog.Text = "FILE-DIALOG-PERMISSION";
            this.checkFileDialog.UseVisualStyleBackColor = false;
            this.checkFileDialog.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkSecurity
            // 
            this.checkSecurity.AutoSize = true;
            this.checkSecurity.BackColor = System.Drawing.Color.Black;
            this.checkSecurity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkSecurity.Location = new System.Drawing.Point(6, 151);
            this.checkSecurity.Name = "checkSecurity";
            this.checkSecurity.Size = new System.Drawing.Size(150, 17);
            this.checkSecurity.TabIndex = 7;
            this.checkSecurity.Text = "SECURITY-PERMISSION";
            this.checkSecurity.UseVisualStyleBackColor = false;
            this.checkSecurity.CheckedChanged += new System.EventHandler(this.checkSecurity_CheckedChanged);
            // 
            // tbl_permissions
            // 
            this.tbl_permissions.BackColor = System.Drawing.Color.YellowGreen;
            this.tbl_permissions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbl_permissions.BackgroundImage")));
            this.tbl_permissions.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tbl_permissions.ColumnCount = 2;
            this.tbl_permissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_permissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_permissions.Controls.Add(this.checkIO, 0, 0);
            this.tbl_permissions.Controls.Add(this.checkSecurity, 0, 3);
            this.tbl_permissions.Controls.Add(this.checkUI, 0, 1);
            this.tbl_permissions.Controls.Add(this.checkFileDialog, 0, 2);
            this.tbl_permissions.Controls.Add(this.checkIsolatedStorage, 0, 4);
            this.tbl_permissions.Controls.Add(this.checkEnvironment, 0, 5);
            this.tbl_permissions.Controls.Add(this.checkKeyContainer, 1, 0);
            this.tbl_permissions.Controls.Add(this.checkPrincipal, 1, 1);
            this.tbl_permissions.Controls.Add(this.checkReflection, 1, 2);
            this.tbl_permissions.Controls.Add(this.checkRegistry, 1, 3);
            this.tbl_permissions.Controls.Add(this.checkStore, 1, 4);
            this.tbl_permissions.Controls.Add(this.checkWeb, 1, 5);
            this.tbl_permissions.Location = new System.Drawing.Point(29, 116);
            this.tbl_permissions.Name = "tbl_permissions";
            this.tbl_permissions.RowCount = 6;
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_permissions.Size = new System.Drawing.Size(554, 307);
            this.tbl_permissions.TabIndex = 8;
            this.tbl_permissions.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // checkIsolatedStorage
            // 
            this.checkIsolatedStorage.AutoSize = true;
            this.checkIsolatedStorage.BackColor = System.Drawing.Color.Black;
            this.checkIsolatedStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkIsolatedStorage.Location = new System.Drawing.Point(6, 204);
            this.checkIsolatedStorage.Name = "checkIsolatedStorage";
            this.checkIsolatedStorage.Size = new System.Drawing.Size(229, 17);
            this.checkIsolatedStorage.TabIndex = 8;
            this.checkIsolatedStorage.Text = "ISOLATED-STORAGE-FILE-PERMISSION";
            this.checkIsolatedStorage.UseVisualStyleBackColor = false;
            // 
            // checkEnvironment
            // 
            this.checkEnvironment.AutoSize = true;
            this.checkEnvironment.BackColor = System.Drawing.Color.Black;
            this.checkEnvironment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkEnvironment.Location = new System.Drawing.Point(6, 257);
            this.checkEnvironment.Name = "checkEnvironment";
            this.checkEnvironment.Size = new System.Drawing.Size(176, 17);
            this.checkEnvironment.TabIndex = 9;
            this.checkEnvironment.Text = "ENVIRONMENT-PERMISSION";
            this.checkEnvironment.UseVisualStyleBackColor = false;
            // 
            // checkKeyContainer
            // 
            this.checkKeyContainer.AutoSize = true;
            this.checkKeyContainer.BackColor = System.Drawing.Color.Black;
            this.checkKeyContainer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkKeyContainer.Location = new System.Drawing.Point(281, 6);
            this.checkKeyContainer.Name = "checkKeyContainer";
            this.checkKeyContainer.Size = new System.Drawing.Size(183, 17);
            this.checkKeyContainer.TabIndex = 10;
            this.checkKeyContainer.Text = "KEY-CONTAINER-PERMISSION";
            this.checkKeyContainer.UseVisualStyleBackColor = false;
            // 
            // checkPrincipal
            // 
            this.checkPrincipal.AutoSize = true;
            this.checkPrincipal.BackColor = System.Drawing.Color.Black;
            this.checkPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkPrincipal.Location = new System.Drawing.Point(281, 52);
            this.checkPrincipal.Name = "checkPrincipal";
            this.checkPrincipal.Size = new System.Drawing.Size(152, 17);
            this.checkPrincipal.TabIndex = 11;
            this.checkPrincipal.Text = "PRINCIPAL-PERMISSION";
            this.checkPrincipal.UseVisualStyleBackColor = false;
            // 
            // checkReflection
            // 
            this.checkReflection.AutoSize = true;
            this.checkReflection.BackColor = System.Drawing.Color.Black;
            this.checkReflection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkReflection.Location = new System.Drawing.Point(281, 98);
            this.checkReflection.Name = "checkReflection";
            this.checkReflection.Size = new System.Drawing.Size(144, 17);
            this.checkReflection.TabIndex = 12;
            this.checkReflection.Text = "REFLECT-PERMISSION";
            this.checkReflection.UseVisualStyleBackColor = false;
            // 
            // checkRegistry
            // 
            this.checkRegistry.AutoSize = true;
            this.checkRegistry.BackColor = System.Drawing.Color.Black;
            this.checkRegistry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkRegistry.Location = new System.Drawing.Point(281, 151);
            this.checkRegistry.Name = "checkRegistry";
            this.checkRegistry.Size = new System.Drawing.Size(151, 17);
            this.checkRegistry.TabIndex = 13;
            this.checkRegistry.Text = "REGISTRY-PERMISSION";
            this.checkRegistry.UseVisualStyleBackColor = false;
            // 
            // checkStore
            // 
            this.checkStore.AutoSize = true;
            this.checkStore.BackColor = System.Drawing.Color.Black;
            this.checkStore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkStore.Location = new System.Drawing.Point(281, 204);
            this.checkStore.Name = "checkStore";
            this.checkStore.Size = new System.Drawing.Size(133, 17);
            this.checkStore.TabIndex = 14;
            this.checkStore.Text = "STORE-PERMISSION";
            this.checkStore.UseVisualStyleBackColor = false;
            this.checkStore.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkWeb
            // 
            this.checkWeb.AutoSize = true;
            this.checkWeb.BackColor = System.Drawing.Color.Black;
            this.checkWeb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkWeb.Location = new System.Drawing.Point(281, 257);
            this.checkWeb.Name = "checkWeb";
            this.checkWeb.Size = new System.Drawing.Size(121, 17);
            this.checkWeb.TabIndex = 15;
            this.checkWeb.Text = "WEB-PERMISSION";
            this.checkWeb.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select File(.exe)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "SELECT NECESSARY PERMISSIONS";
            // 
            // checkUnrestricted
            // 
            this.checkUnrestricted.AutoSize = true;
            this.checkUnrestricted.Location = new System.Drawing.Point(413, 93);
            this.checkUnrestricted.Name = "checkUnrestricted";
            this.checkUnrestricted.Size = new System.Drawing.Size(170, 17);
            this.checkUnrestricted.TabIndex = 11;
            this.checkUnrestricted.Text = "USE DEFAULT PERMISSION";
            this.checkUnrestricted.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(604, 647);
            this.Controls.Add(this.checkUnrestricted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbl_permissions);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.rtbx_console);
            this.Controls.Add(this.txb_filepath);
            this.Controls.Add(this.btn_browse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbl_permissions.ResumeLayout(false);
            this.tbl_permissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_filepath;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.RichTextBox rtbx_console;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.CheckBox checkIO;
        private System.Windows.Forms.CheckBox checkUI;
        private System.Windows.Forms.CheckBox checkFileDialog;
        private System.Windows.Forms.CheckBox checkSecurity;
        private System.Windows.Forms.TableLayoutPanel tbl_permissions;
        private System.Windows.Forms.CheckBox checkIsolatedStorage;
        private System.Windows.Forms.CheckBox checkEnvironment;
        private System.Windows.Forms.CheckBox checkKeyContainer;
        private System.Windows.Forms.CheckBox checkPrincipal;
        private System.Windows.Forms.CheckBox checkReflection;
        private System.Windows.Forms.CheckBox checkRegistry;
        private System.Windows.Forms.CheckBox checkStore;
        private System.Windows.Forms.CheckBox checkWeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkUnrestricted;
    }
}

