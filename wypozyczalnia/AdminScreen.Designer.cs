namespace wypozyczalnia
{
    partial class AdminScreen
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
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.buttonQuit = new wypozyczalnia.CustomButton();
            this.buttonDelProduct = new wypozyczalnia.CustomButton();
            this.buttonModifyProduct = new wypozyczalnia.CustomButton();
            this.buttonAddProduct = new wypozyczalnia.CustomButton();
            this.panel.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(194)))));
            this.panel.Controls.Add(this.buttonQuit);
            this.panel.Controls.Add(this.buttonDelProduct);
            this.panel.Controls.Add(this.buttonModifyProduct);
            this.panel.Controls.Add(this.buttonAddProduct);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(450, 1080);
            this.panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(101, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1297, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "Witaj w panelu administratora";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Location = new System.Drawing.Point(450, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1470, 1080);
            this.panelContent.TabIndex = 2;
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(194)))));
            this.buttonQuit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(170)))), ((int)(((byte)(108)))));
            this.buttonQuit.BorderRadius = 0;
            this.buttonQuit.BorderSize = 2;
            this.buttonQuit.FlatAppearance.BorderSize = 0;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonQuit.ForeColor = System.Drawing.Color.Black;
            this.buttonQuit.Location = new System.Drawing.Point(0, 450);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(450, 150);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Wyjdź";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonDelProduct
            // 
            this.buttonDelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(194)))));
            this.buttonDelProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(170)))), ((int)(((byte)(108)))));
            this.buttonDelProduct.BorderRadius = 0;
            this.buttonDelProduct.BorderSize = 2;
            this.buttonDelProduct.FlatAppearance.BorderSize = 0;
            this.buttonDelProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelProduct.ForeColor = System.Drawing.Color.Black;
            this.buttonDelProduct.Location = new System.Drawing.Point(0, 300);
            this.buttonDelProduct.Name = "buttonDelProduct";
            this.buttonDelProduct.Size = new System.Drawing.Size(450, 150);
            this.buttonDelProduct.TabIndex = 2;
            this.buttonDelProduct.Text = "Usuń produkt";
            this.buttonDelProduct.UseVisualStyleBackColor = false;
            this.buttonDelProduct.Click += new System.EventHandler(this.buttonDelProduct_Click);
            // 
            // buttonModifyProduct
            // 
            this.buttonModifyProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(194)))));
            this.buttonModifyProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(170)))), ((int)(((byte)(108)))));
            this.buttonModifyProduct.BorderRadius = 0;
            this.buttonModifyProduct.BorderSize = 2;
            this.buttonModifyProduct.FlatAppearance.BorderSize = 0;
            this.buttonModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonModifyProduct.ForeColor = System.Drawing.Color.Black;
            this.buttonModifyProduct.Location = new System.Drawing.Point(0, 150);
            this.buttonModifyProduct.Name = "buttonModifyProduct";
            this.buttonModifyProduct.Size = new System.Drawing.Size(450, 150);
            this.buttonModifyProduct.TabIndex = 1;
            this.buttonModifyProduct.Text = "Edytuj produkt";
            this.buttonModifyProduct.UseVisualStyleBackColor = false;
            this.buttonModifyProduct.Click += new System.EventHandler(this.buttonModifyProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(194)))));
            this.buttonAddProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(170)))), ((int)(((byte)(108)))));
            this.buttonAddProduct.BorderRadius = 0;
            this.buttonAddProduct.BorderSize = 2;
            this.buttonAddProduct.FlatAppearance.BorderSize = 0;
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddProduct.ForeColor = System.Drawing.Color.Black;
            this.buttonAddProduct.Location = new System.Drawing.Point(0, 0);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(450, 150);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Dodaj produkt";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel);
            this.Name = "AdminScreen";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.panel.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private CustomButton buttonAddProduct;
        private CustomButton buttonDelProduct;
        private CustomButton buttonModifyProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContent;
        private CustomButton buttonQuit;
    }
}
