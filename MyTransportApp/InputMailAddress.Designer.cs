namespace MyTransportApp
{
    partial class InputMailAddress
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
            this.textBoxEnterMailInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEnterMailInput
            // 
            this.textBoxEnterMailInput.Location = new System.Drawing.Point(12, 25);
            this.textBoxEnterMailInput.Name = "textBoxEnterMailInput";
            this.textBoxEnterMailInput.Size = new System.Drawing.Size(338, 20);
            this.textBoxEnterMailInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empfänger E-Mail-Adresse";
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(12, 51);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(338, 23);
            this.btnSendMail.TabIndex = 2;
            this.btnSendMail.Text = "E-Mail versenden";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // InputMailAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 84);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEnterMailInput);
            this.Name = "InputMailAddress";
            this.Text = "E-Mail Adresse eingeben";
            this.Load += new System.EventHandler(this.InputMailAddress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxEnterMailInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendMail;
    }
}