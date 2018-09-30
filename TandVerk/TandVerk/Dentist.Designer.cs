namespace TandVerk
{
    partial class Dentist
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDentistView = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.PatientSearch = new System.Windows.Forms.Button();
            this.patientSearchPanel = new System.Windows.Forms.Panel();
            this.searchPanelButton = new System.Windows.Forms.Button();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabXrayView = new System.Windows.Forms.TabPage();
            this.xRayRondellLabel = new System.Windows.Forms.Label();
            this.xRayViewPaitentName = new System.Windows.Forms.Label();
            this.SecondXRpicLabel = new System.Windows.Forms.Label();
            this.MainXRpiclabel = new System.Windows.Forms.Label();
            this.directoryOfPatientXray = new System.Windows.Forms.ListBox();
            this.xrayRondell = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MainXraypic = new System.Windows.Forms.PictureBox();
            this.tabHistoryView = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabDentistView.SuspendLayout();
            this.patientSearchPanel.SuspendLayout();
            this.tabXrayView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xrayRondell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainXraypic)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDentistView);
            this.tabControl1.Controls.Add(this.tabXrayView);
            this.tabControl1.Controls.Add(this.tabHistoryView);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1099, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDentistView
            // 
            this.tabDentistView.Controls.Add(this.label2);
            this.tabDentistView.Controls.Add(this.textBox2);
            this.tabDentistView.Controls.Add(this.textBox1);
            this.tabDentistView.Controls.Add(this.label1);
            this.tabDentistView.Controls.Add(this.dateTimePicker2);
            this.tabDentistView.Controls.Add(this.dateTimePicker1);
            this.tabDentistView.Controls.Add(this.monthCalendar1);
            this.tabDentistView.Controls.Add(this.PatientSearch);
            this.tabDentistView.Controls.Add(this.patientSearchPanel);
            this.tabDentistView.Location = new System.Drawing.Point(4, 25);
            this.tabDentistView.Name = "tabDentistView";
            this.tabDentistView.Padding = new System.Windows.Forms.Padding(3);
            this.tabDentistView.Size = new System.Drawing.Size(1091, 490);
            this.tabDentistView.TabIndex = 0;
            this.tabDentistView.Text = "Dentist View";
            this.tabDentistView.UseVisualStyleBackColor = true;
            this.tabDentistView.Click += new System.EventHandler(this.tabDentistView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Other Notices";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 241);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 222);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 214);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 249);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Daily Task display";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dagens Uppgifter";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(49, 188);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(632, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(824, 256);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // PatientSearch
            // 
            this.PatientSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PatientSearch.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PatientSearch.Location = new System.Drawing.Point(8, 6);
            this.PatientSearch.Name = "PatientSearch";
            this.PatientSearch.Size = new System.Drawing.Size(175, 23);
            this.PatientSearch.TabIndex = 0;
            this.PatientSearch.Text = "Patient Search";
            this.PatientSearch.UseVisualStyleBackColor = false;
            this.PatientSearch.Click += new System.EventHandler(this.PatientSearch_Click);
            // 
            // patientSearchPanel
            // 
            this.patientSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.patientSearchPanel.Controls.Add(this.searchPanelButton);
            this.patientSearchPanel.Controls.Add(this.Searchbox);
            this.patientSearchPanel.Location = new System.Drawing.Point(879, 16);
            this.patientSearchPanel.Name = "patientSearchPanel";
            this.patientSearchPanel.Size = new System.Drawing.Size(200, 100);
            this.patientSearchPanel.TabIndex = 8;
            this.patientSearchPanel.Visible = false;
            this.patientSearchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.patientSearchPanel_Paint);
            // 
            // searchPanelButton
            // 
            this.searchPanelButton.Location = new System.Drawing.Point(60, 62);
            this.searchPanelButton.Name = "searchPanelButton";
            this.searchPanelButton.Size = new System.Drawing.Size(75, 23);
            this.searchPanelButton.TabIndex = 1;
            this.searchPanelButton.Text = "OK";
            this.searchPanelButton.UseVisualStyleBackColor = true;
            this.searchPanelButton.Click += new System.EventHandler(this.searchPanelButton_Click);
            // 
            // Searchbox
            // 
            this.Searchbox.Location = new System.Drawing.Point(30, 19);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(134, 22);
            this.Searchbox.TabIndex = 0;
            this.Searchbox.Text = "Insert Perssonummer";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1091, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabXrayView
            // 
            this.tabXrayView.Controls.Add(this.xRayRondellLabel);
            this.tabXrayView.Controls.Add(this.xRayViewPaitentName);
            this.tabXrayView.Controls.Add(this.SecondXRpicLabel);
            this.tabXrayView.Controls.Add(this.MainXRpiclabel);
            this.tabXrayView.Controls.Add(this.directoryOfPatientXray);
            this.tabXrayView.Controls.Add(this.xrayRondell);
            this.tabXrayView.Controls.Add(this.pictureBox2);
            this.tabXrayView.Controls.Add(this.MainXraypic);
            this.tabXrayView.Location = new System.Drawing.Point(4, 25);
            this.tabXrayView.Name = "tabXrayView";
            this.tabXrayView.Padding = new System.Windows.Forms.Padding(3);
            this.tabXrayView.Size = new System.Drawing.Size(1091, 490);
            this.tabXrayView.TabIndex = 2;
            this.tabXrayView.Text = "X Ray View";
            this.tabXrayView.UseVisualStyleBackColor = true;
            // 
            // xRayRondellLabel
            // 
            this.xRayRondellLabel.AutoSize = true;
            this.xRayRondellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xRayRondellLabel.Location = new System.Drawing.Point(14, 333);
            this.xRayRondellLabel.Name = "xRayRondellLabel";
            this.xRayRondellLabel.Size = new System.Drawing.Size(128, 20);
            this.xRayRondellLabel.TabIndex = 7;
            this.xRayRondellLabel.Text = "X Ray Rondell";
            // 
            // xRayViewPaitentName
            // 
            this.xRayViewPaitentName.AutoSize = true;
            this.xRayViewPaitentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xRayViewPaitentName.Location = new System.Drawing.Point(13, 13);
            this.xRayViewPaitentName.Name = "xRayViewPaitentName";
            this.xRayViewPaitentName.Size = new System.Drawing.Size(141, 25);
            this.xRayViewPaitentName.TabIndex = 6;
            this.xRayViewPaitentName.Text = "Patient Name";
            // 
            // SecondXRpicLabel
            // 
            this.SecondXRpicLabel.AutoSize = true;
            this.SecondXRpicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondXRpicLabel.Location = new System.Drawing.Point(421, 279);
            this.SecondXRpicLabel.Name = "SecondXRpicLabel";
            this.SecondXRpicLabel.Size = new System.Drawing.Size(132, 20);
            this.SecondXRpicLabel.TabIndex = 5;
            this.SecondXRpicLabel.Text = "Previous X ray";
            // 
            // MainXRpiclabel
            // 
            this.MainXRpiclabel.AutoSize = true;
            this.MainXRpiclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainXRpiclabel.Location = new System.Drawing.Point(421, 13);
            this.MainXRpiclabel.Name = "MainXRpiclabel";
            this.MainXRpiclabel.Size = new System.Drawing.Size(171, 20);
            this.MainXRpiclabel.TabIndex = 4;
            this.MainXRpiclabel.Text = "Most Recent X Ray";
            // 
            // directoryOfPatientXray
            // 
            this.directoryOfPatientXray.FormattingEnabled = true;
            this.directoryOfPatientXray.ItemHeight = 16;
            this.directoryOfPatientXray.Location = new System.Drawing.Point(17, 57);
            this.directoryOfPatientXray.Name = "directoryOfPatientXray";
            this.directoryOfPatientXray.Size = new System.Drawing.Size(311, 228);
            this.directoryOfPatientXray.TabIndex = 3;
            // 
            // xrayRondell
            // 
            this.xrayRondell.Location = new System.Drawing.Point(17, 366);
            this.xrayRondell.Name = "xrayRondell";
            this.xrayRondell.Size = new System.Drawing.Size(378, 98);
            this.xrayRondell.TabIndex = 2;
            this.xrayRondell.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(424, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 191);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // MainXraypic
            // 
            this.MainXraypic.Location = new System.Drawing.Point(424, 32);
            this.MainXraypic.Name = "MainXraypic";
            this.MainXraypic.Size = new System.Drawing.Size(361, 232);
            this.MainXraypic.TabIndex = 0;
            this.MainXraypic.TabStop = false;
            // 
            // tabHistoryView
            // 
            this.tabHistoryView.Location = new System.Drawing.Point(4, 25);
            this.tabHistoryView.Name = "tabHistoryView";
            this.tabHistoryView.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistoryView.Size = new System.Drawing.Size(1091, 490);
            this.tabHistoryView.TabIndex = 3;
            this.tabHistoryView.Text = "History";
            this.tabHistoryView.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1091, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Dentist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 531);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dentist";
            this.Text = "Dentist";
            this.tabControl1.ResumeLayout(false);
            this.tabDentistView.ResumeLayout(false);
            this.tabDentistView.PerformLayout();
            this.patientSearchPanel.ResumeLayout(false);
            this.patientSearchPanel.PerformLayout();
            this.tabXrayView.ResumeLayout(false);
            this.tabXrayView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xrayRondell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainXraypic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDentistView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button PatientSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabXrayView;
        private System.Windows.Forms.Label SecondXRpicLabel;
        private System.Windows.Forms.Label MainXRpiclabel;
        private System.Windows.Forms.ListBox directoryOfPatientXray;
        private System.Windows.Forms.PictureBox xrayRondell;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox MainXraypic;
        private System.Windows.Forms.Label xRayViewPaitentName;
        private System.Windows.Forms.Label xRayRondellLabel;
        private System.Windows.Forms.TabPage tabHistoryView;
        private System.Windows.Forms.Panel patientSearchPanel;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Button searchPanelButton;
        private System.Windows.Forms.TabPage tabPage1;
        
    }
}