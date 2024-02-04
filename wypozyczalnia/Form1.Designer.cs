namespace wypozyczalnia
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.ButtonOrderCancel = new wypozyczalnia.CustomButton();
            this.ButtonSummary = new wypozyczalnia.CustomButton();
            this.payment1 = new wypozyczalnia.Payment();
            this.orderSummary1 = new wypozyczalnia.OrderSummary();
            this.confirmProduct1 = new wypozyczalnia.ConfirmProduct();
            this.products1 = new wypozyczalnia.Products();
            this.welcomePage1 = new wypozyczalnia.WelcomePage();
            this.takeOut1 = new wypozyczalnia.TakeOut();
            this.employeeScreen1 = new wypozyczalnia.EmployeeScreen();
            this.log1 = new wypozyczalnia.Log();
            this.adminScreen1 = new wypozyczalnia.AdminScreen();
            this.PanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoScroll = true;
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(194)))));
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(450, 1080);
            this.PanelMenu.TabIndex = 4;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPrice.Location = new System.Drawing.Point(30, 65);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(171, 55);
            this.LabelPrice.TabIndex = 7;
            this.LabelPrice.Text = "Kwota:";
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.LabelPrice);
            this.PanelBottom.Controls.Add(this.ButtonOrderCancel);
            this.PanelBottom.Controls.Add(this.ButtonSummary);
            this.PanelBottom.Location = new System.Drawing.Point(450, 930);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1470, 150);
            this.PanelBottom.TabIndex = 11;
            // 
            // ButtonOrderCancel
            // 
            this.ButtonOrderCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ButtonOrderCancel.BorderColor = System.Drawing.Color.White;
            this.ButtonOrderCancel.BorderRadius = 5;
            this.ButtonOrderCancel.BorderSize = 0;
            this.ButtonOrderCancel.FlatAppearance.BorderSize = 0;
            this.ButtonOrderCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOrderCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOrderCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonOrderCancel.Location = new System.Drawing.Point(730, 50);
            this.ButtonOrderCancel.Name = "ButtonOrderCancel";
            this.ButtonOrderCancel.Size = new System.Drawing.Size(350, 80);
            this.ButtonOrderCancel.TabIndex = 8;
            this.ButtonOrderCancel.Text = "Anuluj zamówienie";
            this.ButtonOrderCancel.UseVisualStyleBackColor = false;
            this.ButtonOrderCancel.Click += new System.EventHandler(this.ButtonOrderCancel_Click);
            // 
            // ButtonSummary
            // 
            this.ButtonSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ButtonSummary.BorderColor = System.Drawing.Color.White;
            this.ButtonSummary.BorderRadius = 5;
            this.ButtonSummary.BorderSize = 0;
            this.ButtonSummary.FlatAppearance.BorderSize = 0;
            this.ButtonSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSummary.ForeColor = System.Drawing.Color.White;
            this.ButtonSummary.Location = new System.Drawing.Point(1100, 50);
            this.ButtonSummary.Name = "ButtonSummary";
            this.ButtonSummary.Size = new System.Drawing.Size(350, 80);
            this.ButtonSummary.TabIndex = 9;
            this.ButtonSummary.Text = "Podsumowanie";
            this.ButtonSummary.UseVisualStyleBackColor = false;
            this.ButtonSummary.Click += new System.EventHandler(this.ButtonSummary_Click);
            // 
            // payment1
            // 
            this.payment1.BackColor = System.Drawing.Color.Lime;
            this.payment1.Location = new System.Drawing.Point(0, 0);
            this.payment1.Name = "payment1";
            this.payment1.Size = new System.Drawing.Size(1920, 1080);
            this.payment1.TabIndex = 12;
            this.payment1.VisibleChanged += new System.EventHandler(this.payment1_VisibleChanged);
            // 
            // orderSummary1
            // 
            this.orderSummary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.orderSummary1.Location = new System.Drawing.Point(0, 0);
            this.orderSummary1.Name = "orderSummary1";
            this.orderSummary1.Size = new System.Drawing.Size(1920, 1080);
            this.orderSummary1.TabIndex = 0;
            this.orderSummary1.VisibleChanged += new System.EventHandler(this.orderSummary1_VisibleChanged);
            // 
            // confirmProduct1
            // 
            this.confirmProduct1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.confirmProduct1.Location = new System.Drawing.Point(450, 0);
            this.confirmProduct1.Name = "confirmProduct1";
            this.confirmProduct1.Size = new System.Drawing.Size(1470, 930);
            this.confirmProduct1.TabIndex = 10;
            this.confirmProduct1.Visible = false;
            this.confirmProduct1.VisibleChanged += new System.EventHandler(this.confirmProduct1_VisibleChanged);
            // 
            // products1
            // 
            this.products1.AutoScroll = true;
            this.products1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.products1.Location = new System.Drawing.Point(450, 0);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(1470, 930);
            this.products1.TabIndex = 6;
            this.products1.VisibleChanged += new System.EventHandler(this.products1_VisibleChanged);
            // 
            // welcomePage1
            // 
            this.welcomePage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.welcomePage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomePage1.BackgroundImage")));
            this.welcomePage1.Location = new System.Drawing.Point(0, 0);
            this.welcomePage1.Name = "welcomePage1";
            this.welcomePage1.Size = new System.Drawing.Size(1920, 1080);
            this.welcomePage1.TabIndex = 0;
            this.welcomePage1.VisibleChanged += new System.EventHandler(this.welcomePage1_VisibleChanged);
            // 
            // takeOut1
            // 
            this.takeOut1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("takeOut1.BackgroundImage")));
            this.takeOut1.Location = new System.Drawing.Point(0, 0);
            this.takeOut1.Name = "takeOut1";
            this.takeOut1.Size = new System.Drawing.Size(1920, 1080);
            this.takeOut1.TabIndex = 5;
            this.takeOut1.VisibleChanged += new System.EventHandler(this.takeOut1_VisibleChanged);
            // 
            // employeeScreen1
            // 
            this.employeeScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.employeeScreen1.Location = new System.Drawing.Point(0, 0);
            this.employeeScreen1.Name = "employeeScreen1";
            this.employeeScreen1.Size = new System.Drawing.Size(1920, 1080);
            this.employeeScreen1.TabIndex = 13;
            this.employeeScreen1.VisibleChanged += new System.EventHandler(this.employeeScreen1_VisibleChanged);
            // 
            // log1
            // 
            this.log1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.log1.Location = new System.Drawing.Point(0, 0);
            this.log1.Name = "log1";
            this.log1.Size = new System.Drawing.Size(1920, 1080);
            this.log1.TabIndex = 14;
            this.log1.VisibleChanged += new System.EventHandler(this.log1_VisibleChanged);
            // 
            // adminScreen1
            // 
            this.adminScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.adminScreen1.Location = new System.Drawing.Point(0, 0);
            this.adminScreen1.Name = "adminScreen1";
            this.adminScreen1.Size = new System.Drawing.Size(1920, 1080);
            this.adminScreen1.TabIndex = 15;
            this.adminScreen1.VisibleChanged += new System.EventHandler(this.adminScreen1_VisibleChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.adminScreen1);
            this.Controls.Add(this.log1);
            this.Controls.Add(this.employeeScreen1);
            this.Controls.Add(this.payment1);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.orderSummary1);
            this.Controls.Add(this.confirmProduct1);
            this.Controls.Add(this.products1);
            this.Controls.Add(this.welcomePage1);
            this.Controls.Add(this.takeOut1);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private WelcomePage welcomePage1;
        private TakeOut takeOut1;
        private Products products1;
        private System.Windows.Forms.Label LabelPrice;
        private CustomButton ButtonOrderCancel;
        private CustomButton ButtonSummary;
        private ConfirmProduct confirmProduct1;
        private OrderSummary orderSummary1;
        private System.Windows.Forms.Panel PanelBottom;
        private Payment payment1;
        private EmployeeScreen employeeScreen1;
        private Log log1;
        private AdminScreen adminScreen1;
    }
}

