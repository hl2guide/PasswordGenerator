namespace PasswordGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxGeneratedPassword = new System.Windows.Forms.TextBox();
            this.trackBarLength = new System.Windows.Forms.TrackBar();
            this.labelLength = new System.Windows.Forms.Label();
            this.buttonGeneratePassword = new System.Windows.Forms.Button();
            this.buttonCopyPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLength)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxGeneratedPassword
            // 
            this.textBoxGeneratedPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxGeneratedPassword.Font = new System.Drawing.Font("Monoid", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGeneratedPassword.Location = new System.Drawing.Point(8, 75);
            this.textBoxGeneratedPassword.MaxLength = 70;
            this.textBoxGeneratedPassword.Name = "textBoxGeneratedPassword";
            this.textBoxGeneratedPassword.ReadOnly = true;
            this.textBoxGeneratedPassword.Size = new System.Drawing.Size(958, 33);
            this.textBoxGeneratedPassword.TabIndex = 2;
            this.textBoxGeneratedPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxGeneratedPassword.Click += new System.EventHandler(this.textBoxGeneratedPassword_Click);
            this.textBoxGeneratedPassword.Enter += new System.EventHandler(this.textBoxGeneratedPassword_Enter);
            // 
            // trackBarLength
            // 
            this.trackBarLength.Location = new System.Drawing.Point(8, 29);
            this.trackBarLength.Maximum = 70;
            this.trackBarLength.Minimum = 12;
            this.trackBarLength.Name = "trackBarLength";
            this.trackBarLength.Size = new System.Drawing.Size(807, 45);
            this.trackBarLength.TabIndex = 1;
            this.trackBarLength.TickFrequency = 5;
            this.trackBarLength.Value = 12;
            this.trackBarLength.Scroll += new System.EventHandler(this.trackBarLength_Scroll);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(15, 9);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(40, 13);
            this.labelLength.TabIndex = 0;
            this.labelLength.Text = "&Length";
            // 
            // buttonGeneratePassword
            // 
            this.buttonGeneratePassword.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonGeneratePassword.Location = new System.Drawing.Point(821, 9);
            this.buttonGeneratePassword.Name = "buttonGeneratePassword";
            this.buttonGeneratePassword.Size = new System.Drawing.Size(78, 60);
            this.buttonGeneratePassword.TabIndex = 1;
            this.buttonGeneratePassword.Text = "&Generate";
            this.buttonGeneratePassword.UseVisualStyleBackColor = false;
            this.buttonGeneratePassword.Click += new System.EventHandler(this.buttonGeneratePassword_Click);
            // 
            // buttonCopyPassword
            // 
            this.buttonCopyPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCopyPassword.Enabled = false;
            this.buttonCopyPassword.Location = new System.Drawing.Point(905, 9);
            this.buttonCopyPassword.Name = "buttonCopyPassword";
            this.buttonCopyPassword.Size = new System.Drawing.Size(61, 60);
            this.buttonCopyPassword.TabIndex = 2;
            this.buttonCopyPassword.Text = "&Copy";
            this.buttonCopyPassword.UseVisualStyleBackColor = false;
            this.buttonCopyPassword.Click += new System.EventHandler(this.buttonCopyPassword_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 117);
            this.Controls.Add(this.buttonCopyPassword);
            this.Controls.Add(this.textBoxGeneratedPassword);
            this.Controls.Add(this.trackBarLength);
            this.Controls.Add(this.buttonGeneratePassword);
            this.Controls.Add(this.labelLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordGenerator 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.TrackBar trackBarLength;
        private System.Windows.Forms.Button buttonGeneratePassword;
        private System.Windows.Forms.TextBox textBoxGeneratedPassword;
        private System.Windows.Forms.Button buttonCopyPassword;
    }
}

