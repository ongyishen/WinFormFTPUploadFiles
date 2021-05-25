namespace WinFormFTPUploadFiles
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveSetting);
            this.panel1.Controls.Add(this.Port);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Host);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.FilePath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 136);
            this.panel1.TabIndex = 1;
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Location = new System.Drawing.Point(874, 8);
            this.btnSaveSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(86, 20);
            this.btnSaveSetting.TabIndex = 24;
            this.btnSaveSetting.Text = "Save Setting";
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(472, 9);
            this.Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(94, 20);
            this.Port.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Port";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(97, 69);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(272, 20);
            this.Password.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Password";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(97, 39);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(272, 20);
            this.Username.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Username";
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(97, 9);
            this.Host.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(272, 20);
            this.Host.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Host";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Local File Path";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(874, 105);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(86, 23);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(746, 105);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(116, 23);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(97, 108);
            this.FilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(626, 20);
            this.FilePath.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-89, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "From Path";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoadFiles);
            this.panel2.Controls.Add(this.chkSelectAll);
            this.panel2.Controls.Add(this.btnUpload);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 77);
            this.panel2.TabIndex = 2;
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Location = new System.Drawing.Point(524, 49);
            this.btnLoadFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(214, 23);
            this.btnLoadFiles.TabIndex = 27;
            this.btnLoadFiles.Text = "Load Files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(16, 49);
            this.chkSelectAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkSelectAll.TabIndex = 26;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(746, 49);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(214, 23);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 8);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(728, 35);
            this.progressBar1.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(746, 6);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(214, 37);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "-";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 313);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(976, 313);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IsUpload";
            this.Column1.HeaderText = "Upload";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Size";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.HeaderText = "Size(MB)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 526);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP Upload File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveSetting;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

