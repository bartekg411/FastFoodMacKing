namespace wypozyczalnia
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.buttonWelcomePageStart = new wypozyczalnia.CustomButton();
            this.SuspendLayout();
            // 
            // buttonWelcomePageStart
            // 
            this.buttonWelcomePageStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.buttonWelcomePageStart.BorderColor = System.Drawing.Color.Black;
            this.buttonWelcomePageStart.BorderRadius = 50;
            this.buttonWelcomePageStart.BorderSize = 0;
            this.buttonWelcomePageStart.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonWelcomePageStart, "buttonWelcomePageStart");
            this.buttonWelcomePageStart.ForeColor = System.Drawing.Color.White;
            this.buttonWelcomePageStart.Name = "buttonWelcomePageStart";
            this.buttonWelcomePageStart.UseVisualStyleBackColor = false;
            this.buttonWelcomePageStart.Click += new System.EventHandler(this.buttonWelcomePageStart_Click);
            this.buttonWelcomePageStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonWelcomePageStart_KeyDown);
            // 
            // WelcomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.BackgroundImage = global::wypozyczalnia.Properties.Resources.WelcomePageBackground;
            this.Controls.Add(this.buttonWelcomePageStart);
            this.Name = "WelcomePage";
            this.VisibleChanged += new System.EventHandler(this.WelcomePage_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton buttonWelcomePageStart;
    }
}
