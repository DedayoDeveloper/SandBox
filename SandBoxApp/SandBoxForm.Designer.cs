
namespace SandBoxApp
{
    partial class SandBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SandBoxForm));
            this.rtbx_console = new System.Windows.Forms.RichTextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tbl_permissions = new System.Windows.Forms.TableLayoutPanel();
            this.checkIO = new System.Windows.Forms.CheckBox();
            this.checkSecurity = new System.Windows.Forms.CheckBox();
            this.checkUI = new System.Windows.Forms.CheckBox();
            this.checkFileDialog = new System.Windows.Forms.CheckBox();
            this.checkIsolatedStorage = new System.Windows.Forms.CheckBox();
            this.checkEnvironment = new System.Windows.Forms.CheckBox();
            this.checkKeyContainer = new System.Windows.Forms.CheckBox();
            this.checkPrincipal = new System.Windows.Forms.CheckBox();
            this.checkReflection = new System.Windows.Forms.CheckBox();
            this.checkRegistry = new System.Windows.Forms.CheckBox();
            this.checkStore = new System.Windows.Forms.CheckBox();
            this.checkWeb = new System.Windows.Forms.CheckBox();
            this.tbx_filepath = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.tbx_params = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkUnrestricted = new System.Windows.Forms.CheckBox();
            this.checkTypeDescriptor = new System.Windows.Forms.CheckBox();
            this.tbl_permissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbx_console
            // 
            this.rtbx_console.Location = new System.Drawing.Point(12, 342);
            this.rtbx_console.Name = "rtbx_console";
            this.rtbx_console.Size = new System.Drawing.Size(776, 96);
            this.rtbx_console.TabIndex = 0;
            this.rtbx_console.Text = "";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(571, 312);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "Execute";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(666, 312);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // tbl_permissions
            // 
            this.tbl_permissions.BackColor = System.Drawing.Color.YellowGreen;
            this.tbl_permissions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbl_permissions.BackgroundImage")));
            this.tbl_permissions.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tbl_permissions.ColumnCount = 2;
            this.tbl_permissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.55717F));
            this.tbl_permissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.44283F));
            this.tbl_permissions.Controls.Add(this.checkTypeDescriptor, 0, 6);
            this.tbl_permissions.Controls.Add(this.checkUnrestricted, 0, 6);
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
            this.tbl_permissions.Location = new System.Drawing.Point(63, 64);
            this.tbl_permissions.Name = "tbl_permissions";
            this.tbl_permissions.RowCount = 7;
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tbl_permissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_permissions.Size = new System.Drawing.Size(678, 242);
            this.tbl_permissions.TabIndex = 9;
            this.tbl_permissions.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_permissions_Paint);
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
            // checkSecurity
            // 
            this.checkSecurity.AutoSize = true;
            this.checkSecurity.BackColor = System.Drawing.Color.Black;
            this.checkSecurity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkSecurity.Location = new System.Drawing.Point(6, 116);
            this.checkSecurity.Name = "checkSecurity";
            this.checkSecurity.Size = new System.Drawing.Size(150, 17);
            this.checkSecurity.TabIndex = 7;
            this.checkSecurity.Text = "SECURITY-PERMISSION";
            this.checkSecurity.UseVisualStyleBackColor = false;
            // 
            // checkUI
            // 
            this.checkUI.AutoSize = true;
            this.checkUI.BackColor = System.Drawing.Color.Black;
            this.checkUI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkUI.Location = new System.Drawing.Point(6, 38);
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
            this.checkFileDialog.Location = new System.Drawing.Point(6, 75);
            this.checkFileDialog.Name = "checkFileDialog";
            this.checkFileDialog.Size = new System.Drawing.Size(161, 17);
            this.checkFileDialog.TabIndex = 6;
            this.checkFileDialog.Text = "FILE-DIALOG-PERMISSION";
            this.checkFileDialog.UseVisualStyleBackColor = false;
            // 
            // checkIsolatedStorage
            // 
            this.checkIsolatedStorage.AutoSize = true;
            this.checkIsolatedStorage.BackColor = System.Drawing.Color.Black;
            this.checkIsolatedStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkIsolatedStorage.Location = new System.Drawing.Point(6, 158);
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
            this.checkEnvironment.Location = new System.Drawing.Point(6, 194);
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
            this.checkKeyContainer.Location = new System.Drawing.Point(300, 6);
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
            this.checkPrincipal.Location = new System.Drawing.Point(300, 38);
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
            this.checkReflection.Location = new System.Drawing.Point(300, 75);
            this.checkReflection.Name = "checkReflection";
            this.checkReflection.Size = new System.Drawing.Size(144, 17);
            this.checkReflection.TabIndex = 12;
            this.checkReflection.Text = "REFLECT-PERMISSION";
            this.checkReflection.UseVisualStyleBackColor = false;
            this.checkReflection.CheckedChanged += new System.EventHandler(this.checkReflection_CheckedChanged);
            // 
            // checkRegistry
            // 
            this.checkRegistry.AutoSize = true;
            this.checkRegistry.BackColor = System.Drawing.Color.Black;
            this.checkRegistry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkRegistry.Location = new System.Drawing.Point(300, 116);
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
            this.checkStore.Location = new System.Drawing.Point(300, 158);
            this.checkStore.Name = "checkStore";
            this.checkStore.Size = new System.Drawing.Size(133, 17);
            this.checkStore.TabIndex = 14;
            this.checkStore.Text = "STORE-PERMISSION";
            this.checkStore.UseVisualStyleBackColor = false;
            // 
            // checkWeb
            // 
            this.checkWeb.AutoSize = true;
            this.checkWeb.BackColor = System.Drawing.Color.Black;
            this.checkWeb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkWeb.Location = new System.Drawing.Point(300, 194);
            this.checkWeb.Name = "checkWeb";
            this.checkWeb.Size = new System.Drawing.Size(121, 17);
            this.checkWeb.TabIndex = 15;
            this.checkWeb.Text = "WEB-PERMISSION";
            this.checkWeb.UseVisualStyleBackColor = false;
            // 
            // tbx_filepath
            // 
            this.tbx_filepath.Location = new System.Drawing.Point(63, 12);
            this.tbx_filepath.Name = "tbx_filepath";
            this.tbx_filepath.Size = new System.Drawing.Size(583, 20);
            this.tbx_filepath.TabIndex = 10;
            this.tbx_filepath.TextChanged += new System.EventHandler(this.tbx_filepath_TextChanged);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(652, 9);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 11;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // tbx_params
            // 
            this.tbx_params.Location = new System.Drawing.Point(128, 38);
            this.tbx_params.Name = "tbx_params";
            this.tbx_params.Size = new System.Drawing.Size(599, 20);
            this.tbx_params.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Schadow BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Params";
            // 
            // checkUnrestricted
            // 
            this.checkUnrestricted.AutoSize = true;
            this.checkUnrestricted.BackColor = System.Drawing.Color.Black;
            this.checkUnrestricted.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkUnrestricted.Location = new System.Drawing.Point(300, 221);
            this.checkUnrestricted.Name = "checkUnrestricted";
            this.checkUnrestricted.Size = new System.Drawing.Size(111, 15);
            this.checkUnrestricted.TabIndex = 16;
            this.checkUnrestricted.Text = "UNRESTRICTED";
            this.checkUnrestricted.UseVisualStyleBackColor = false;
            // 
            // checkTypeDescriptor
            // 
            this.checkTypeDescriptor.AutoSize = true;
            this.checkTypeDescriptor.BackColor = System.Drawing.Color.Black;
            this.checkTypeDescriptor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkTypeDescriptor.Location = new System.Drawing.Point(6, 221);
            this.checkTypeDescriptor.Name = "checkTypeDescriptor";
            this.checkTypeDescriptor.Size = new System.Drawing.Size(197, 15);
            this.checkTypeDescriptor.TabIndex = 17;
            this.checkTypeDescriptor.Text = "TYPE-DESCRIPTOR-PERMISSION";
            this.checkTypeDescriptor.UseVisualStyleBackColor = false;
            // 
            // SandBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_params);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tbx_filepath);
            this.Controls.Add(this.tbl_permissions);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.rtbx_console);
            this.Name = "SandBoxForm";
            this.Text = "SandBoxForm";
            this.Load += new System.EventHandler(this.SandBoxForm_Load);
            this.tbl_permissions.ResumeLayout(false);
            this.tbl_permissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbx_console;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TableLayoutPanel tbl_permissions;
        private System.Windows.Forms.CheckBox checkIO;
        private System.Windows.Forms.CheckBox checkSecurity;
        private System.Windows.Forms.CheckBox checkUI;
        private System.Windows.Forms.CheckBox checkFileDialog;
        private System.Windows.Forms.CheckBox checkIsolatedStorage;
        private System.Windows.Forms.CheckBox checkEnvironment;
        private System.Windows.Forms.CheckBox checkKeyContainer;
        private System.Windows.Forms.CheckBox checkPrincipal;
        private System.Windows.Forms.CheckBox checkReflection;
        private System.Windows.Forms.CheckBox checkRegistry;
        private System.Windows.Forms.CheckBox checkStore;
        private System.Windows.Forms.CheckBox checkWeb;
        private System.Windows.Forms.TextBox tbx_filepath;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox tbx_params;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkUnrestricted;
        private System.Windows.Forms.CheckBox checkTypeDescriptor;
    }
}