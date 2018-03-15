namespace FHIR_Test_Application
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCreatePatient = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPatientNum = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPatientNumber = new System.Windows.Forms.Label();
            this.grpIdentifiers = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPatientTitle = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.dlgBrowseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdSelectFile = new System.Windows.Forms.Button();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.grpIdentifiers.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(99, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdSelectFile);
            this.groupBox1.Controls.Add(this.cmdCreatePatient);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(378, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(199, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdCreatePatient
            // 
            this.cmdCreatePatient.BackColor = System.Drawing.Color.Indigo;
            this.cmdCreatePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCreatePatient.ForeColor = System.Drawing.Color.White;
            this.cmdCreatePatient.Location = new System.Drawing.Point(6, 57);
            this.cmdCreatePatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdCreatePatient.Name = "cmdCreatePatient";
            this.cmdCreatePatient.Size = new System.Drawing.Size(87, 35);
            this.cmdCreatePatient.TabIndex = 11;
            this.cmdCreatePatient.Text = "Create";
            this.cmdCreatePatient.UseVisualStyleBackColor = false;
            this.cmdCreatePatient.Click += new System.EventHandler(this.cmdCreatePatient_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Indigo;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(99, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(9, 87);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(151, 25);
            this.txtSurname.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(172, 87);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(159, 25);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtPatientNum
            // 
            this.txtPatientNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientNum.Location = new System.Drawing.Point(9, 149);
            this.txtPatientNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientNum.Name = "txtPatientNum";
            this.txtPatientNum.Size = new System.Drawing.Size(151, 25);
            this.txtPatientNum.TabIndex = 5;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(6, 66);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(62, 17);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(169, 66);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 17);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name(s):";
            // 
            // lblPatientNumber
            // 
            this.lblPatientNumber.AutoSize = true;
            this.lblPatientNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNumber.Location = new System.Drawing.Point(6, 128);
            this.lblPatientNumber.Name = "lblPatientNumber";
            this.lblPatientNumber.Size = new System.Drawing.Size(102, 17);
            this.lblPatientNumber.TabIndex = 8;
            this.lblPatientNumber.Text = "Patient Number:";
            // 
            // grpIdentifiers
            // 
            this.grpIdentifiers.Controls.Add(this.label1);
            this.grpIdentifiers.Controls.Add(this.cmbPatientTitle);
            this.grpIdentifiers.Controls.Add(this.lblPatientNumber);
            this.grpIdentifiers.Controls.Add(this.txtFirstName);
            this.grpIdentifiers.Controls.Add(this.lblFirstName);
            this.grpIdentifiers.Controls.Add(this.txtPatientNum);
            this.grpIdentifiers.Controls.Add(this.lblSurname);
            this.grpIdentifiers.Controls.Add(this.txtSurname);
            this.grpIdentifiers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIdentifiers.Location = new System.Drawing.Point(13, 13);
            this.grpIdentifiers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpIdentifiers.Name = "grpIdentifiers";
            this.grpIdentifiers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpIdentifiers.Size = new System.Drawing.Size(348, 191);
            this.grpIdentifiers.TabIndex = 9;
            this.grpIdentifiers.TabStop = false;
            this.grpIdentifiers.Text = "Patient Identity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title:";
            // 
            // cmbPatientTitle
            // 
            this.cmbPatientTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatientTitle.FormattingEnabled = true;
            this.cmbPatientTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms.",
            "Dr.",
            "Other",
            "N/A"});
            this.cmbPatientTitle.Location = new System.Drawing.Point(47, 22);
            this.cmbPatientTitle.Name = "cmbPatientTitle";
            this.cmbPatientTitle.Size = new System.Drawing.Size(75, 25);
            this.cmbPatientTitle.TabIndex = 9;
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Location = new System.Drawing.Point(13, 211);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(349, 148);
            this.txtOutput.TabIndex = 10;
            // 
            // dlgBrowseFolder
            // 
            this.dlgBrowseFolder.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // cmdSelectFile
            // 
            this.cmdSelectFile.BackColor = System.Drawing.Color.Indigo;
            this.cmdSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSelectFile.ForeColor = System.Drawing.Color.White;
            this.cmdSelectFile.Location = new System.Drawing.Point(99, 57);
            this.cmdSelectFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSelectFile.Name = "cmdSelectFile";
            this.cmdSelectFile.Size = new System.Drawing.Size(87, 35);
            this.cmdSelectFile.TabIndex = 12;
            this.cmdSelectFile.Text = "File...";
            this.cmdSelectFile.UseVisualStyleBackColor = false;
            this.cmdSelectFile.Click += new System.EventHandler(this.button4_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 371);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.grpIdentifiers);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "FHIR Test Client";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpIdentifiers.ResumeLayout(false);
            this.grpIdentifiers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPatientNum;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPatientNumber;
        private System.Windows.Forms.GroupBox grpIdentifiers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button cmdCreatePatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPatientTitle;
        private System.Windows.Forms.FolderBrowserDialog dlgBrowseFolder;
        private System.Windows.Forms.Button cmdSelectFile;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
    }
}

