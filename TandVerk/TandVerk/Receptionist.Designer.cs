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
            this.tabBokaTid = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabBokaTid.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // läggTillPatient
            // 
            this.läggTillPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.läggTillPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.läggTillPatient.Location = new System.Drawing.Point(0, 35);
            this.läggTillPatient.Name = "läggTillPatient";
            this.läggTillPatient.Size = new System.Drawing.Size(175, 75);
            this.läggTillPatient.TabIndex = 0;
            this.läggTillPatient.Text = "Lägg Till Patient";
            this.läggTillPatient.UseVisualStyleBackColor = true;
            // 
            // ändraBokning
            // 
            this.ändraBokning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ändraBokning.Location = new System.Drawing.Point(282, 77);
            this.ändraBokning.Name = "ändraBokning";
            this.ändraBokning.Size = new System.Drawing.Size(162, 86);
            this.ändraBokning.TabIndex = 1;
            this.ändraBokning.Text = "Ändra Bokning";
            this.ändraBokning.UseVisualStyleBackColor = true;
            // 
            // bokaTid
            // 
            this.bokaTid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bokaTid.Location = new System.Drawing.Point(281, 91);
            this.bokaTid.Name = "bokaTid";
            this.bokaTid.Size = new System.Drawing.Size(163, 82);
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
            this.ändraUppgifter.Location = new System.Drawing.Point(181, 39);
            this.ändraUppgifter.Name = "ändraUppgifter";
            this.ändraUppgifter.Size = new System.Drawing.Size(162, 71);
            this.ändraUppgifter.TabIndex = 3;
            this.ändraUppgifter.Text = "Ändra Uppgifter";
            this.ändraUppgifter.UseVisualStyleBackColor = true;
            // 
            // betalning
            // 
            this.betalning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.betalning.Location = new System.Drawing.Point(288, 69);
            this.betalning.Name = "betalning";
            this.betalning.Size = new System.Drawing.Size(163, 83);
            this.betalning.TabIndex = 4;
            this.betalning.Text = "Betalning";
            this.betalning.UseVisualStyleBackColor = true;
            // 
            // taBortKund
            // 
            this.taBortKund.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taBortKund.Location = new System.Drawing.Point(289, 90);
            this.taBortKund.Name = "taBortKund";
            this.taBortKund.Size = new System.Drawing.Size(162, 72);
            this.taBortKund.TabIndex = 5;
            this.taBortKund.Text = "Ta Bort Kund";
            this.taBortKund.UseVisualStyleBackColor = true;
            // 
            // tabBokaTid
            // 
            this.tabBokaTid.Controls.Add(this.tabPage1);
            this.tabBokaTid.Controls.Add(this.tabPage2);
            this.tabBokaTid.Controls.Add(this.tabPage3);
            this.tabBokaTid.Controls.Add(this.tabPage4);
            this.tabBokaTid.Location = new System.Drawing.Point(0, 0);
            this.tabBokaTid.Name = "tabBokaTid";
            this.tabBokaTid.SelectedIndex = 0;
            this.tabBokaTid.Size = new System.Drawing.Size(455, 187);
            this.tabBokaTid.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bokaTid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(447, 169);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ändraBokning);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(447, 169);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.läggTillPatient);
            this.tabPage3.Controls.Add(this.ändraUppgifter);
            this.tabPage3.Controls.Add(this.taBortKund);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(447, 158);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.betalning);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(447, 158);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 471);
            this.Controls.Add(this.tabBokaTid);
            this.MaximumSize = new System.Drawing.Size(1131, 518);
            this.MinimumSize = new System.Drawing.Size(1131, 518);
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            this.tabBokaTid.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button läggTillPatient;
        private System.Windows.Forms.Button ändraBokning;
        private System.Windows.Forms.Button bokaTid;
        private System.Windows.Forms.Button ändraUppgifter;
        private System.Windows.Forms.Button betalning;
        private System.Windows.Forms.Button taBortKund;
        private System.Windows.Forms.TabControl tabBokaTid;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}