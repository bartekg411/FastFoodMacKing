namespace wypozyczalnia
{
    partial class DelProduct
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
            this.panelProducts = new System.Windows.Forms.Panel();
            this.labelNameCategory = new System.Windows.Forms.Label();
            this.buttonNext = new wypozyczalnia.CustomButton();
            this.buttonPrevious = new wypozyczalnia.CustomButton();
            this.SuspendLayout();
            // 
            // panelProducts
            // 
            this.panelProducts.AutoScroll = true;
            this.panelProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.panelProducts.Location = new System.Drawing.Point(0, 150);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(1470, 930);
            this.panelProducts.TabIndex = 5;
            // 
            // labelNameCategory
            // 
            this.labelNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameCategory.Location = new System.Drawing.Point(510, 42);
            this.labelNameCategory.Name = "labelNameCategory";
            this.labelNameCategory.Size = new System.Drawing.Size(450, 75);
            this.labelNameCategory.TabIndex = 10;
            this.labelNameCategory.Text = "label1";
            this.labelNameCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.buttonNext.BorderColor = System.Drawing.Color.White;
            this.buttonNext.BorderRadius = 5;
            this.buttonNext.BorderSize = 0;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(965, 53);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(60, 60);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.buttonPrevious.BorderColor = System.Drawing.Color.White;
            this.buttonPrevious.BorderRadius = 5;
            this.buttonPrevious.BorderSize = 0;
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrevious.ForeColor = System.Drawing.Color.White;
            this.buttonPrevious.Location = new System.Drawing.Point(445, 53);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(60, 60);
            this.buttonPrevious.TabIndex = 9;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // DelProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelNameCategory);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.buttonPrevious);
            this.Name = "DelProduct";
            this.Size = new System.Drawing.Size(1470, 1080);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProducts;
        private CustomButton buttonNext;
        private System.Windows.Forms.Label labelNameCategory;
        private CustomButton buttonPrevious;
    }
}
