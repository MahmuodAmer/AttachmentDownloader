namespace AttachmentDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_download = new System.Windows.Forms.Button();
            this.textBox_host = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_subjectRegex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_imapFolder = new System.Windows.Forms.TextBox();
            this.dateTimePicker_after = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_before = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_outputFolder = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_fileNameTemplate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_selectOutputFolder = new System.Windows.Forms.Button();
            this.button_saveCOnfiguration = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_pythonPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_download
            // 
            this.button_download.Location = new System.Drawing.Point(52, 554);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(919, 63);
            this.button_download.TabIndex = 0;
            this.button_download.Text = "Download";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // textBox_host
            // 
            this.textBox_host.Location = new System.Drawing.Point(176, 34);
            this.textBox_host.Name = "textBox_host";
            this.textBox_host.Size = new System.Drawing.Size(289, 27);
            this.textBox_host.TabIndex = 1;
            this.textBox_host.Text = "imap.gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(176, 107);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(289, 27);
            this.textBox_username.TabIndex = 3;
            this.textBox_username.Text = "zezoamer113@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(177, 180);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(289, 27);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.Text = "ipfcqukzqvdnkbgi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "After Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "SubjectRegex";
            // 
            // textBox_subjectRegex
            // 
            this.textBox_subjectRegex.Location = new System.Drawing.Point(176, 326);
            this.textBox_subjectRegex.Name = "textBox_subjectRegex";
            this.textBox_subjectRegex.Size = new System.Drawing.Size(289, 27);
            this.textBox_subjectRegex.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "IMapFolder";
            // 
            // textBox_imapFolder
            // 
            this.textBox_imapFolder.Location = new System.Drawing.Point(176, 253);
            this.textBox_imapFolder.Name = "textBox_imapFolder";
            this.textBox_imapFolder.Size = new System.Drawing.Size(289, 27);
            this.textBox_imapFolder.TabIndex = 7;
            this.textBox_imapFolder.Text = "WithAttachments";
            // 
            // dateTimePicker_after
            // 
            this.dateTimePicker_after.Location = new System.Drawing.Point(176, 399);
            this.dateTimePicker_after.Name = "dateTimePicker_after";
            this.dateTimePicker_after.Size = new System.Drawing.Size(289, 27);
            this.dateTimePicker_after.TabIndex = 13;
            // 
            // dateTimePicker_before
            // 
            this.dateTimePicker_before.Location = new System.Drawing.Point(176, 478);
            this.dateTimePicker_before.Name = "dateTimePicker_before";
            this.dateTimePicker_before.Size = new System.Drawing.Size(289, 27);
            this.dateTimePicker_before.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "IMap Server Port";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(682, 106);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(289, 27);
            this.textBox_port.TabIndex = 20;
            this.textBox_port.Text = "993";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Output Folder";
            // 
            // textBox_outputFolder
            // 
            this.textBox_outputFolder.Enabled = false;
            this.textBox_outputFolder.Location = new System.Drawing.Point(682, 34);
            this.textBox_outputFolder.Name = "textBox_outputFolder";
            this.textBox_outputFolder.Size = new System.Drawing.Size(289, 27);
            this.textBox_outputFolder.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(532, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "FileNameTemplate";
            // 
            // textBox_fileNameTemplate
            // 
            this.textBox_fileNameTemplate.Location = new System.Drawing.Point(682, 184);
            this.textBox_fileNameTemplate.Name = "textBox_fileNameTemplate";
            this.textBox_fileNameTemplate.Size = new System.Drawing.Size(289, 27);
            this.textBox_fileNameTemplate.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Before Date";
            // 
            // button_selectOutputFolder
            // 
            this.button_selectOutputFolder.Location = new System.Drawing.Point(977, 34);
            this.button_selectOutputFolder.Name = "button_selectOutputFolder";
            this.button_selectOutputFolder.Size = new System.Drawing.Size(51, 27);
            this.button_selectOutputFolder.TabIndex = 26;
            this.button_selectOutputFolder.Text = "...";
            this.button_selectOutputFolder.UseVisualStyleBackColor = true;
            this.button_selectOutputFolder.Click += new System.EventHandler(this.button_selectOutputFolder_Click);
            // 
            // button_saveCOnfiguration
            // 
            this.button_saveCOnfiguration.Location = new System.Drawing.Point(682, 346);
            this.button_saveCOnfiguration.Name = "button_saveCOnfiguration";
            this.button_saveCOnfiguration.Size = new System.Drawing.Size(289, 39);
            this.button_saveCOnfiguration.TabIndex = 27;
            this.button_saveCOnfiguration.Text = "Save Configuration";
            this.button_saveCOnfiguration.UseVisualStyleBackColor = true;
            this.button_saveCOnfiguration.Click += new System.EventHandler(this.button_saveCOnfiguration_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(580, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Python Path";
            // 
            // textBox_pythonPath
            // 
            this.textBox_pythonPath.Location = new System.Drawing.Point(682, 253);
            this.textBox_pythonPath.Name = "textBox_pythonPath";
            this.textBox_pythonPath.Size = new System.Drawing.Size(289, 27);
            this.textBox_pythonPath.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(177, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "If Empty it will search in all the folders";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(176, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(320, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Use Regex patterns to Identify email by subject";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(682, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(227, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Make template for the file name ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(682, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(219, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "The Path for the python exe file ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(682, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "The output folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 633);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_pythonPath);
            this.Controls.Add(this.button_saveCOnfiguration);
            this.Controls.Add(this.button_selectOutputFolder);
            this.Controls.Add(this.dateTimePicker_before);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_outputFolder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_fileNameTemplate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker_after);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_subjectRegex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_imapFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_host);
            this.Controls.Add(this.button_download);
            this.Name = "Form1";
            this.Text = "Attachment Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_download;
        private TextBox textBox_host;
        private Label label1;
        private Label label2;
        private TextBox textBox_username;
        private Label label3;
        private TextBox textBox_password;
        private Label label4;
        private Label label5;
        private TextBox textBox_subjectRegex;
        private Label label6;
        private TextBox textBox_imapFolder;
        private DateTimePicker dateTimePicker_after;
        private DateTimePicker dateTimePicker_before;
        private Label label9;
        private TextBox textBox_port;
        private Label label10;
        private TextBox textBox_outputFolder;
        private Label label11;
        private TextBox textBox_fileNameTemplate;
        private Label label12;
        private Button button_selectOutputFolder;
        private Button button_saveCOnfiguration;
        private Label label7;
        private TextBox textBox_pythonPath;
        private Label label8;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}