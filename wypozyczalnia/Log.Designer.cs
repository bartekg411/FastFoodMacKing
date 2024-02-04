namespace wypozyczalnia
{
    partial class Log
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.customButton1 = new wypozyczalnia.CustomButton();
            this.ButtonCancel = new wypozyczalnia.CustomButton();
            this.ButtonLog = new wypozyczalnia.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login.Location = new System.Drawing.Point(760, 350);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(400, 62);
            this.Login.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password.Location = new System.Drawing.Point(760, 450);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(400, 62);
            this.Password.TabIndex = 4;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Red;
            this.customButton1.BorderColor = System.Drawing.Color.White;
            this.customButton1.BorderRadius = 5;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(173, 340);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(315, 136);
            this.customButton1.TabIndex = 5;
            this.customButton1.Text = "Admin";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ButtonCancel.BorderColor = System.Drawing.Color.White;
            this.ButtonCancel.BorderRadius = 5;
            this.ButtonCancel.BorderSize = 0;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(820, 650);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(280, 75);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cofnij";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonLog
            // 
            this.ButtonLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ButtonLog.BorderColor = System.Drawing.Color.White;
            this.ButtonLog.BorderRadius = 5;
            this.ButtonLog.BorderSize = 0;
            this.ButtonLog.FlatAppearance.BorderSize = 0;
            this.ButtonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonLog.ForeColor = System.Drawing.Color.White;
            this.ButtonLog.Location = new System.Drawing.Point(820, 550);
            this.ButtonLog.Name = "ButtonLog";
            this.ButtonLog.Size = new System.Drawing.Size(280, 75);
            this.ButtonLog.TabIndex = 2;
            this.ButtonLog.Text = "Zaloguj";
            this.ButtonLog.UseVisualStyleBackColor = false;
            this.ButtonLog.Click += new System.EventHandler(this.ButtonLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(636, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonLog);
            this.Controls.Add(this.Login);
            this.Name = "Log";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private CustomButton ButtonLog;
        private CustomButton ButtonCancel;
        private System.Windows.Forms.TextBox Password;
        private CustomButton customButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
