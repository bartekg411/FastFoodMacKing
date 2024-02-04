namespace wypozyczalnia
{
    partial class TakeOut
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
            this.buttonEatIn = new wypozyczalnia.CustomButton();
            this.buttonTakeOut = new wypozyczalnia.CustomButton();
            this.SuspendLayout();
            // 
            // buttonEatIn
            // 
            this.buttonEatIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.buttonEatIn.BorderColor = System.Drawing.Color.White;
            this.buttonEatIn.BorderRadius = 50;
            this.buttonEatIn.BorderSize = 0;
            this.buttonEatIn.FlatAppearance.BorderSize = 0;
            this.buttonEatIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.buttonEatIn.ForeColor = System.Drawing.Color.White;
            this.buttonEatIn.Location = new System.Drawing.Point(280, 775);
            this.buttonEatIn.Name = "buttonEatIn";
            this.buttonEatIn.Size = new System.Drawing.Size(600, 200);
            this.buttonEatIn.TabIndex = 2;
            this.buttonEatIn.Text = "Na miejscu";
            this.buttonEatIn.UseVisualStyleBackColor = false;
            this.buttonEatIn.Click += new System.EventHandler(this.buttonEatIn_Click);
            // 
            // buttonTakeOut
            // 
            this.buttonTakeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.buttonTakeOut.BorderColor = System.Drawing.Color.White;
            this.buttonTakeOut.BorderRadius = 50;
            this.buttonTakeOut.BorderSize = 0;
            this.buttonTakeOut.FlatAppearance.BorderSize = 0;
            this.buttonTakeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.buttonTakeOut.ForeColor = System.Drawing.Color.White;
            this.buttonTakeOut.Location = new System.Drawing.Point(1040, 775);
            this.buttonTakeOut.Name = "buttonTakeOut";
            this.buttonTakeOut.Size = new System.Drawing.Size(600, 200);
            this.buttonTakeOut.TabIndex = 3;
            this.buttonTakeOut.Text = "Na wynos";
            this.buttonTakeOut.UseVisualStyleBackColor = false;
            this.buttonTakeOut.Click += new System.EventHandler(this.buttonTakeOut_Click);
            // 
            // TakeOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wypozyczalnia.Properties.Resources.TakeOutBackground;
            this.Controls.Add(this.buttonTakeOut);
            this.Controls.Add(this.buttonEatIn);
            this.Name = "TakeOut";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton buttonEatIn;
        private CustomButton buttonTakeOut;
    }
}
