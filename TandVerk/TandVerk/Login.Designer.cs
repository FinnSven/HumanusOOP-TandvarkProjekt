namespace TandVerk
{
    partial class Login
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
            this.txtb_UserName = new System.Windows.Forms.TextBox();
            this.txtb_PassWord = new System.Windows.Forms.TextBox();
            this.btn_LoginOk = new System.Windows.Forms.Button();
            this.btn_LoginCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_UserName
            // 
            this.txtb_UserName.Location = new System.Drawing.Point(74, 71);
            this.txtb_UserName.Name = "txtb_UserName";
            this.txtb_UserName.Size = new System.Drawing.Size(100, 22);
            this.txtb_UserName.TabIndex = 0;
            // 
            // txtb_PassWord
            // 
            this.txtb_PassWord.Location = new System.Drawing.Point(74, 113);
            this.txtb_PassWord.Name = "txtb_PassWord";
            this.txtb_PassWord.Size = new System.Drawing.Size(100, 22);
            this.txtb_PassWord.TabIndex = 1;
            // 
            // btn_LoginOk
            // 
            this.btn_LoginOk.Location = new System.Drawing.Point(23, 185);
            this.btn_LoginOk.Name = "btn_LoginOk";
            this.btn_LoginOk.Size = new System.Drawing.Size(75, 23);
            this.btn_LoginOk.TabIndex = 2;
            this.btn_LoginOk.Text = "Login";
            this.btn_LoginOk.UseVisualStyleBackColor = true;
            this.btn_LoginOk.Click += new System.EventHandler(this.btn_LoginOk_Click);
            // 
            // btn_LoginCancel
            // 
            this.btn_LoginCancel.Location = new System.Drawing.Point(164, 185);
            this.btn_LoginCancel.Name = "btn_LoginCancel";
            this.btn_LoginCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_LoginCancel.TabIndex = 3;
            this.btn_LoginCancel.Text = "Cancel";
            this.btn_LoginCancel.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btn_LoginCancel);
            this.Controls.Add(this.btn_LoginOk);
            this.Controls.Add(this.txtb_PassWord);
            this.Controls.Add(this.txtb_UserName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_UserName;
        private System.Windows.Forms.TextBox txtb_PassWord;
        private System.Windows.Forms.Button btn_LoginOk;
        private System.Windows.Forms.Button btn_LoginCancel;
    }
}

