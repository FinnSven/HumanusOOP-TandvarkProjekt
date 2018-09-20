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
            this.SuspendLayout();
            // 
            // läggTillPatient
            // 
            this.läggTillPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.läggTillPatient.Location = new System.Drawing.Point(31, 68);
            this.läggTillPatient.Name = "läggTillPatient";
            this.läggTillPatient.Size = new System.Drawing.Size(175, 86);
            this.läggTillPatient.TabIndex = 0;
            this.läggTillPatient.Text = "Lägg Till Patient";
            this.läggTillPatient.UseVisualStyleBackColor = true;
            // 
            // ändraBokning
            // 
            this.ändraBokning.Location = new System.Drawing.Point(515, 68);
            this.ändraBokning.Name = "ändraBokning";
            this.ändraBokning.Size = new System.Drawing.Size(162, 86);
            this.ändraBokning.TabIndex = 1;
            this.ändraBokning.Text = "Ändra Bokning";
            this.ändraBokning.UseVisualStyleBackColor = true;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 471);
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
    }
}