namespace wypozyczalnia
{
    partial class ConfirmProduct
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
            this.Count = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.ButtonCancel = new wypozyczalnia.CustomButton();
            this.ButtonConfirm = new wypozyczalnia.CustomButton();
            this.ButtonMore = new wypozyczalnia.CustomButton();
            this.ButtonLess = new wypozyczalnia.CustomButton();
            this.PictureBoxProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // Count
            // 
            this.Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Count.Location = new System.Drawing.Point(684, 600);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(104, 73);
            this.Count.TabIndex = 4;
            this.Count.Text = "1";
            this.Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProductName.Location = new System.Drawing.Point(0, 470);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(1470, 55);
            this.ProductName.TabIndex = 5;
            this.ProductName.Text = "Label2";
            this.ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Price.Location = new System.Drawing.Point(0, 535);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(1470, 39);
            this.Price.TabIndex = 6;
            this.Price.Text = "Label1";
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ButtonCancel.BorderColor = System.Drawing.Color.White;
            this.ButtonCancel.BorderRadius = 5;
            this.ButtonCancel.BorderSize = 0;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(610, 800);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(250, 70);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Anuluj";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ButtonConfirm.BorderColor = System.Drawing.Color.White;
            this.ButtonConfirm.BorderRadius = 5;
            this.ButtonConfirm.BorderSize = 0;
            this.ButtonConfirm.FlatAppearance.BorderSize = 0;
            this.ButtonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonConfirm.ForeColor = System.Drawing.Color.White;
            this.ButtonConfirm.Location = new System.Drawing.Point(610, 720);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(250, 70);
            this.ButtonConfirm.TabIndex = 2;
            this.ButtonConfirm.Text = "Dodaj";
            this.ButtonConfirm.UseVisualStyleBackColor = false;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // ButtonMore
            // 
            this.ButtonMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ButtonMore.BorderColor = System.Drawing.Color.White;
            this.ButtonMore.BorderRadius = 5;
            this.ButtonMore.BorderSize = 0;
            this.ButtonMore.FlatAppearance.BorderSize = 0;
            this.ButtonMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMore.ForeColor = System.Drawing.Color.White;
            this.ButtonMore.Location = new System.Drawing.Point(795, 600);
            this.ButtonMore.Name = "ButtonMore";
            this.ButtonMore.Size = new System.Drawing.Size(76, 76);
            this.ButtonMore.TabIndex = 1;
            this.ButtonMore.Text = "+";
            this.ButtonMore.UseVisualStyleBackColor = false;
            this.ButtonMore.Click += new System.EventHandler(this.ButtonMore_Click);
            // 
            // ButtonLess
            // 
            this.ButtonLess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ButtonLess.BorderColor = System.Drawing.Color.White;
            this.ButtonLess.BorderRadius = 5;
            this.ButtonLess.BorderSize = 0;
            this.ButtonLess.FlatAppearance.BorderSize = 0;
            this.ButtonLess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonLess.ForeColor = System.Drawing.Color.White;
            this.ButtonLess.Location = new System.Drawing.Point(599, 600);
            this.ButtonLess.Name = "ButtonLess";
            this.ButtonLess.Size = new System.Drawing.Size(76, 76);
            this.ButtonLess.TabIndex = 0;
            this.ButtonLess.Text = "-";
            this.ButtonLess.UseVisualStyleBackColor = false;
            this.ButtonLess.Click += new System.EventHandler(this.ButtonLess_Click);
            // 
            // PictureBoxProduct
            // 
            this.PictureBoxProduct.Location = new System.Drawing.Point(548, 50);
            this.PictureBoxProduct.Name = "PictureBoxProduct";
            this.PictureBoxProduct.Size = new System.Drawing.Size(376, 376);
            this.PictureBoxProduct.TabIndex = 7;
            this.PictureBoxProduct.TabStop = false;
            this.PictureBoxProduct.Click += new System.EventHandler(this.PictureBoxProduct_Click);
            // 
            // ConfirmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.PictureBoxProduct);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.ButtonMore);
            this.Controls.Add(this.ButtonLess);
            this.Name = "ConfirmProduct";
            this.Size = new System.Drawing.Size(1470, 930);
            this.Load += new System.EventHandler(this.ConfirmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton ButtonLess;
        private CustomButton ButtonMore;
        private CustomButton ButtonConfirm;
        private CustomButton ButtonCancel;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.PictureBox PictureBoxProduct;
    }
}
