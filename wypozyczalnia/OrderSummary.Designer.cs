namespace wypozyczalnia
{
    partial class OrderSummary
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.ButtonBack = new wypozyczalnia.CustomButton();
            this.ButtonPay = new wypozyczalnia.CustomButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 930);
            this.panel1.TabIndex = 0;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPrice.Location = new System.Drawing.Point(20, 995);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(171, 55);
            this.LabelPrice.TabIndex = 11;
            this.LabelPrice.Text = "Kwota:";
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ButtonBack.BorderColor = System.Drawing.Color.White;
            this.ButtonBack.BorderRadius = 5;
            this.ButtonBack.BorderSize = 0;
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonBack.ForeColor = System.Drawing.Color.White;
            this.ButtonBack.Location = new System.Drawing.Point(1180, 980);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(350, 80);
            this.ButtonBack.TabIndex = 12;
            this.ButtonBack.Text = "Cofnij";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonPay
            // 
            this.ButtonPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ButtonPay.BorderColor = System.Drawing.Color.White;
            this.ButtonPay.BorderRadius = 5;
            this.ButtonPay.BorderSize = 0;
            this.ButtonPay.FlatAppearance.BorderSize = 0;
            this.ButtonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPay.ForeColor = System.Drawing.Color.White;
            this.ButtonPay.Location = new System.Drawing.Point(1550, 980);
            this.ButtonPay.Name = "ButtonPay";
            this.ButtonPay.Size = new System.Drawing.Size(350, 80);
            this.ButtonPay.TabIndex = 10;
            this.ButtonPay.Text = "Zapłać";
            this.ButtonPay.UseVisualStyleBackColor = false;
            this.ButtonPay.Click += new System.EventHandler(this.ButtonPay_Click);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.ButtonPay);
            this.Controls.Add(this.panel1);
            this.Name = "OrderSummary";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.VisibleChanged += new System.EventHandler(this.OrderSummary_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomButton ButtonPay;
        private System.Windows.Forms.Label LabelPrice;
        private CustomButton ButtonBack;
    }
}
