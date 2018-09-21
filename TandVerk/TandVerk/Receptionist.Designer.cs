namespace TandVerk
{
    partial class Receptionist
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
            this.läggTillPatient = new System.Windows.Forms.Button();
            this.ändraBokning = new System.Windows.Forms.Button();
            this.bokaTid = new System.Windows.Forms.Button();
            this.ändraUppgifter = new System.Windows.Forms.Button();
            this.betalning = new System.Windows.Forms.Button();
            this.taBortKund = new System.Windows.Forms.Button();
            this.tabReceptionist = new System.Windows.Forms.TabControl();
            this.tabBokaTid = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelAngePersonnummer = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxPersonnumer = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tabÄndraBokning = new System.Windows.Forms.TabPage();
            this.tabTaBortKund = new System.Windows.Forms.TabPage();
            this.tabÄndraPatientUppgifter = new System.Windows.Forms.TabPage();
            this.tabLäggTillPatient = new System.Windows.Forms.TabPage();
            this.tabBetalning = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelÄndraTid = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabReceptionist.SuspendLayout();
            this.tabBokaTid.SuspendLayout();
            this.panelAngePersonnummer.SuspendLayout();
            this.tabÄndraBokning.SuspendLayout();
            this.tabTaBortKund.SuspendLayout();
            this.tabÄndraPatientUppgifter.SuspendLayout();
            this.tabLäggTillPatient.SuspendLayout();
            this.tabBetalning.SuspendLayout();
            this.panelÄndraTid.SuspendLayout();
            this.SuspendLayout();
            // 
            // läggTillPatient
            // 
            this.läggTillPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.läggTillPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.läggTillPatient.Location = new System.Drawing.Point(579, 226);
            this.läggTillPatient.Name = "läggTillPatient";
            this.läggTillPatient.Size = new System.Drawing.Size(300, 175);
            this.läggTillPatient.TabIndex = 0;
            this.läggTillPatient.Text = "Lägg Till Patient";
            this.läggTillPatient.UseVisualStyleBackColor = true;
            // 
            // ändraBokning
            // 
            this.ändraBokning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ändraBokning.Location = new System.Drawing.Point(660, 234);
            this.ändraBokning.Name = "ändraBokning";
            this.ändraBokning.Size = new System.Drawing.Size(280, 153);
            this.ändraBokning.TabIndex = 1;
            this.ändraBokning.Text = "Ändra Bokning";
            this.ändraBokning.UseVisualStyleBackColor = true;
            this.ändraBokning.Click += new System.EventHandler(this.ändraBokning_Click);
            // 
            // bokaTid
            // 
            this.bokaTid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bokaTid.Location = new System.Drawing.Point(660, 248);
            this.bokaTid.Name = "bokaTid";
            this.bokaTid.Size = new System.Drawing.Size(280, 153);
            this.bokaTid.TabIndex = 2;
            this.bokaTid.Text = "Boka Tid";
            this.bokaTid.UseVisualStyleBackColor = true;
            this.bokaTid.Click += new System.EventHandler(this.bokaTid_Click);
            // 
            // ändraUppgifter
            // 
            this.ändraUppgifter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ändraUppgifter.Location = new System.Drawing.Point(579, 224);
            this.ändraUppgifter.Name = "ändraUppgifter";
            this.ändraUppgifter.Size = new System.Drawing.Size(300, 177);
            this.ändraUppgifter.TabIndex = 3;
            this.ändraUppgifter.Text = "Ändra Uppgifter";
            this.ändraUppgifter.UseVisualStyleBackColor = true;
            // 
            // betalning
            // 
            this.betalning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.betalning.Location = new System.Drawing.Point(658, 268);
            this.betalning.Name = "betalning";
            this.betalning.Size = new System.Drawing.Size(270, 133);
            this.betalning.TabIndex = 4;
            this.betalning.Text = "Betalning";
            this.betalning.UseVisualStyleBackColor = true;
            // 
            // taBortKund
            // 
            this.taBortKund.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taBortKund.Location = new System.Drawing.Point(549, 224);
            this.taBortKund.Name = "taBortKund";
            this.taBortKund.Size = new System.Drawing.Size(300, 177);
            this.taBortKund.TabIndex = 5;
            this.taBortKund.Text = "Ta Bort Kund";
            this.taBortKund.UseVisualStyleBackColor = true;
            // 
            // tabReceptionist
            // 
            this.tabReceptionist.Controls.Add(this.tabBokaTid);
            this.tabReceptionist.Controls.Add(this.tabÄndraBokning);
            this.tabReceptionist.Controls.Add(this.tabTaBortKund);
            this.tabReceptionist.Controls.Add(this.tabÄndraPatientUppgifter);
            this.tabReceptionist.Controls.Add(this.tabLäggTillPatient);
            this.tabReceptionist.Controls.Add(this.tabBetalning);
            this.tabReceptionist.Location = new System.Drawing.Point(1, 0);
            this.tabReceptionist.Name = "tabReceptionist";
            this.tabReceptionist.SelectedIndex = 0;
            this.tabReceptionist.Size = new System.Drawing.Size(954, 436);
            this.tabReceptionist.TabIndex = 6;
            this.tabReceptionist.SelectedIndexChanged += new System.EventHandler(this.tabReceptionist_SelectedIndexChanged);
            // 
            // tabBokaTid
            // 
            this.tabBokaTid.Controls.Add(this.panelAngePersonnummer);
            this.tabBokaTid.Controls.Add(this.dateTimePicker1);
            this.tabBokaTid.Controls.Add(this.label2);
            this.tabBokaTid.Controls.Add(this.label1);
            this.tabBokaTid.Controls.Add(this.checkedListBox2);
            this.tabBokaTid.Controls.Add(this.checkedListBox1);
            this.tabBokaTid.Controls.Add(this.textBox2);
            this.tabBokaTid.Controls.Add(this.textBox1);
            this.tabBokaTid.Controls.Add(this.bokaTid);
            this.tabBokaTid.Location = new System.Drawing.Point(4, 25);
            this.tabBokaTid.Name = "tabBokaTid";
            this.tabBokaTid.Padding = new System.Windows.Forms.Padding(3);
            this.tabBokaTid.Size = new System.Drawing.Size(946, 407);
            this.tabBokaTid.TabIndex = 0;
            this.tabBokaTid.Text = "Boka Tid";
            this.tabBokaTid.UseVisualStyleBackColor = true;
            this.tabBokaTid.Click += new System.EventHandler(this.tabBokaTid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tankläkarlista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Typ Av Besök";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Marko",
            "Björn",
            "Pavle",
            "Jamie",
            "Ted"});
            this.checkedListBox2.Location = new System.Drawing.Point(31, 295);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox2.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Operation",
            "Plombering",
            "Undersökning"});
            this.checkedListBox1.Location = new System.Drawing.Point(31, 176);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(138, 55);
            this.checkedListBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Patientens Personnummer";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Patientens Namn";
            // 
            // panelAngePersonnummer
            // 
            this.panelAngePersonnummer.Controls.Add(this.buttonOK);
            this.panelAngePersonnummer.Controls.Add(this.textBoxPersonnumer);
            this.panelAngePersonnummer.Controls.Add(this.maskedTextBox1);
            this.panelAngePersonnummer.Location = new System.Drawing.Point(7, 11);
            this.panelAngePersonnummer.Name = "panelAngePersonnummer";
            this.panelAngePersonnummer.Size = new System.Drawing.Size(947, 373);
            this.panelAngePersonnummer.TabIndex = 3;
            this.panelAngePersonnummer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAngePersonnummer_Paint);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(539, 124);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            this.buttonOK.Enter += new System.EventHandler(this.bokaTid_Click);
            // 
            // textBoxPersonnumer
            // 
            this.textBoxPersonnumer.Location = new System.Drawing.Point(71, 126);
            this.textBoxPersonnumer.Name = "textBoxPersonnumer";
            this.textBoxPersonnumer.Size = new System.Drawing.Size(216, 22);
            this.textBoxPersonnumer.TabIndex = 1;
            this.textBoxPersonnumer.Text = "Ange Personnummer 10 siffror";
            this.textBoxPersonnumer.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(376, 125);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // tabÄndraBokning
            // 
            this.tabÄndraBokning.Controls.Add(this.panelÄndraTid);
            this.tabÄndraBokning.Controls.Add(this.dateTimePicker2);
            this.tabÄndraBokning.Controls.Add(this.label3);
            this.tabÄndraBokning.Controls.Add(this.label4);
            this.tabÄndraBokning.Controls.Add(this.checkedListBox3);
            this.tabÄndraBokning.Controls.Add(this.checkedListBox4);
            this.tabÄndraBokning.Controls.Add(this.textBox4);
            this.tabÄndraBokning.Controls.Add(this.textBox5);
            this.tabÄndraBokning.Controls.Add(this.ändraBokning);
            this.tabÄndraBokning.Location = new System.Drawing.Point(4, 25);
            this.tabÄndraBokning.Name = "tabÄndraBokning";
            this.tabÄndraBokning.Padding = new System.Windows.Forms.Padding(3);
            this.tabÄndraBokning.Size = new System.Drawing.Size(946, 407);
            this.tabÄndraBokning.TabIndex = 2;
            this.tabÄndraBokning.Text = "Ändra Bokning";
            this.tabÄndraBokning.UseVisualStyleBackColor = true;
            this.tabÄndraBokning.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabTaBortKund
            // 
            this.tabTaBortKund.Controls.Add(this.taBortKund);
            this.tabTaBortKund.Location = new System.Drawing.Point(4, 25);
            this.tabTaBortKund.Name = "tabTaBortKund";
            this.tabTaBortKund.Padding = new System.Windows.Forms.Padding(3);
            this.tabTaBortKund.Size = new System.Drawing.Size(946, 407);
            this.tabTaBortKund.TabIndex = 3;
            this.tabTaBortKund.Text = "Ta Bort Kund";
            this.tabTaBortKund.UseVisualStyleBackColor = true;
            // 
            // tabÄndraPatientUppgifter
            // 
            this.tabÄndraPatientUppgifter.Controls.Add(this.ändraUppgifter);
            this.tabÄndraPatientUppgifter.Location = new System.Drawing.Point(4, 25);
            this.tabÄndraPatientUppgifter.Name = "tabÄndraPatientUppgifter";
            this.tabÄndraPatientUppgifter.Padding = new System.Windows.Forms.Padding(3);
            this.tabÄndraPatientUppgifter.Size = new System.Drawing.Size(946, 407);
            this.tabÄndraPatientUppgifter.TabIndex = 4;
            this.tabÄndraPatientUppgifter.Text = "Ändra Patient Upggifter";
            this.tabÄndraPatientUppgifter.UseVisualStyleBackColor = true;
            // 
            // tabLäggTillPatient
            // 
            this.tabLäggTillPatient.Controls.Add(this.läggTillPatient);
            this.tabLäggTillPatient.Location = new System.Drawing.Point(4, 25);
            this.tabLäggTillPatient.Name = "tabLäggTillPatient";
            this.tabLäggTillPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabLäggTillPatient.Size = new System.Drawing.Size(946, 407);
            this.tabLäggTillPatient.TabIndex = 5;
            this.tabLäggTillPatient.Text = "Lägg TIll Patient";
            this.tabLäggTillPatient.UseVisualStyleBackColor = true;
            // 
            // tabBetalning
            // 
            this.tabBetalning.Controls.Add(this.betalning);
            this.tabBetalning.Location = new System.Drawing.Point(4, 25);
            this.tabBetalning.Name = "tabBetalning";
            this.tabBetalning.Padding = new System.Windows.Forms.Padding(3);
            this.tabBetalning.Size = new System.Drawing.Size(946, 407);
            this.tabBetalning.TabIndex = 6;
            this.tabBetalning.Text = "Betalning";
            this.tabBetalning.UseVisualStyleBackColor = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(347, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panelÄndraTid
            // 
            this.panelÄndraTid.Controls.Add(this.button1);
            this.panelÄndraTid.Controls.Add(this.textBox3);
            this.panelÄndraTid.Controls.Add(this.maskedTextBox2);
            this.panelÄndraTid.Location = new System.Drawing.Point(9, 19);
            this.panelÄndraTid.Name = "panelÄndraTid";
            this.panelÄndraTid.Size = new System.Drawing.Size(937, 368);
            this.panelÄndraTid.TabIndex = 2;
            this.panelÄndraTid.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Ange Personnummer 10 siffror";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(300, 66);
            this.maskedTextBox2.Mask = "0000000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox2.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(338, 166);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tankläkarlista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Typ Av Besök";
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Marko",
            "Björn",
            "Pavle",
            "Jamie",
            "Ted"});
            this.checkedListBox3.Location = new System.Drawing.Point(22, 285);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox3.TabIndex = 14;
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Items.AddRange(new object[] {
            "Operation",
            "Plombering",
            "Undersökning"});
            this.checkedListBox4.Location = new System.Drawing.Point(22, 166);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(138, 55);
            this.checkedListBox4.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(22, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 22);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Patientens Personnummer";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(22, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 22);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Patientens Namn";
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 471);
            this.Controls.Add(this.tabReceptionist);
            this.MaximumSize = new System.Drawing.Size(1131, 518);
            this.MinimumSize = new System.Drawing.Size(1131, 518);
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            this.tabReceptionist.ResumeLayout(false);
            this.tabBokaTid.ResumeLayout(false);
            this.tabBokaTid.PerformLayout();
            this.panelAngePersonnummer.ResumeLayout(false);
            this.panelAngePersonnummer.PerformLayout();
            this.tabÄndraBokning.ResumeLayout(false);
            this.tabÄndraBokning.PerformLayout();
            this.tabTaBortKund.ResumeLayout(false);
            this.tabÄndraPatientUppgifter.ResumeLayout(false);
            this.tabLäggTillPatient.ResumeLayout(false);
            this.tabBetalning.ResumeLayout(false);
            this.panelÄndraTid.ResumeLayout(false);
            this.panelÄndraTid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button läggTillPatient;
        private System.Windows.Forms.Button ändraBokning;
        private System.Windows.Forms.Button bokaTid;
        private System.Windows.Forms.Button ändraUppgifter;
        private System.Windows.Forms.Button betalning;
        private System.Windows.Forms.Button taBortKund;
        private System.Windows.Forms.TabControl tabReceptionist;
        private System.Windows.Forms.TabPage tabBokaTid;
        private System.Windows.Forms.TabPage tabÄndraBokning;
        private System.Windows.Forms.TabPage tabTaBortKund;
        private System.Windows.Forms.TabPage tabÄndraPatientUppgifter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabLäggTillPatient;
        private System.Windows.Forms.TabPage tabBetalning;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel panelAngePersonnummer;
        private System.Windows.Forms.TextBox textBoxPersonnumer;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panelÄndraTid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}