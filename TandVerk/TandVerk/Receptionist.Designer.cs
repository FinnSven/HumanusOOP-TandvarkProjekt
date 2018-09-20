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
            this.SuspendLayout();
            // 
            // läggTillPatient
            // 
            this.läggTillPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.läggTillPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.läggTillPatient.Location = new System.Drawing.Point(174, 364);
            this.läggTillPatient.Name = "läggTillPatient";
            this.läggTillPatient.Size = new System.Drawing.Size(175, 86);
            this.läggTillPatient.TabIndex = 0;
            this.läggTillPatient.Text = "Lägg Till Patient";
            this.läggTillPatient.UseVisualStyleBackColor = true;
            // 
            // ändraBokning
            // 
            this.ändraBokning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ändraBokning.Location = new System.Drawing.Point(719, 72);
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
            this.bokaTid.Location = new System.Drawing.Point(186, 72);
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
            this.ändraUppgifter.Location = new System.Drawing.Point(719, 218);
            this.ändraUppgifter.Name = "ändraUppgifter";
            this.ändraUppgifter.Size = new System.Drawing.Size(162, 82);
            this.ändraUppgifter.TabIndex = 3;
            this.ändraUppgifter.Text = "Ändra Uppgifter";
            this.ändraUppgifter.UseVisualStyleBackColor = true;
            // 
            // betalning
            // 
            this.betalning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.betalning.Location = new System.Drawing.Point(186, 217);
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
            this.taBortKund.Location = new System.Drawing.Point(719, 364);
            this.taBortKund.Name = "taBortKund";
            this.taBortKund.Size = new System.Drawing.Size(162, 83);
            this.taBortKund.TabIndex = 5;
            this.taBortKund.Text = "Ta Bort Kund";
            this.taBortKund.UseVisualStyleBackColor = true;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 471);
            this.Controls.Add(this.taBortKund);
            this.Controls.Add(this.betalning);
            this.Controls.Add(this.ändraUppgifter);
            this.Controls.Add(this.bokaTid);
            this.Controls.Add(this.ändraBokning);
            this.Controls.Add(this.läggTillPatient);
            this.MaximumSize = new System.Drawing.Size(1131, 518);
            this.MinimumSize = new System.Drawing.Size(1131, 518);
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button läggTillPatient;
        private System.Windows.Forms.Button ändraBokning;
        private System.Windows.Forms.Button bokaTid;
        private System.Windows.Forms.Button ändraUppgifter;
        private System.Windows.Forms.Button betalning;
        private System.Windows.Forms.Button taBortKund;
    }
}