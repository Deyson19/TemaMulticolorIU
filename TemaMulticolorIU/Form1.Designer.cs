namespace TemaMulticolorIU
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonNotification = new System.Windows.Forms.Button();
            this.buttonReporting = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonSetting);
            this.panelMenu.Controls.Add(this.buttonNotification);
            this.panelMenu.Controls.Add(this.buttonReporting);
            this.panelMenu.Controls.Add(this.buttonCustomer);
            this.panelMenu.Controls.Add(this.buttonOrders);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 456);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSetting.Image = global::TemaMulticolorIU.Properties.Resources.settings;
            this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.Location = new System.Drawing.Point(0, 380);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonSetting.Size = new System.Drawing.Size(220, 60);
            this.buttonSetting.TabIndex = 6;
            this.buttonSetting.Text = "   Setting";
            this.buttonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonNotification
            // 
            this.buttonNotification.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNotification.FlatAppearance.BorderSize = 0;
            this.buttonNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotification.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNotification.Image = global::TemaMulticolorIU.Properties.Resources.alarm__1_;
            this.buttonNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNotification.Location = new System.Drawing.Point(0, 320);
            this.buttonNotification.Name = "buttonNotification";
            this.buttonNotification.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonNotification.Size = new System.Drawing.Size(220, 60);
            this.buttonNotification.TabIndex = 5;
            this.buttonNotification.Text = "   Notifications";
            this.buttonNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNotification.UseVisualStyleBackColor = true;
            this.buttonNotification.Click += new System.EventHandler(this.buttonNotification_Click);
            // 
            // buttonReporting
            // 
            this.buttonReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReporting.FlatAppearance.BorderSize = 0;
            this.buttonReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReporting.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonReporting.Image = global::TemaMulticolorIU.Properties.Resources.bar_chart;
            this.buttonReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReporting.Location = new System.Drawing.Point(0, 260);
            this.buttonReporting.Name = "buttonReporting";
            this.buttonReporting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonReporting.Size = new System.Drawing.Size(220, 60);
            this.buttonReporting.TabIndex = 4;
            this.buttonReporting.Text = "   Reporting";
            this.buttonReporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReporting.UseVisualStyleBackColor = true;
            this.buttonReporting.Click += new System.EventHandler(this.buttonReporting_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCustomer.FlatAppearance.BorderSize = 0;
            this.buttonCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCustomer.Image = global::TemaMulticolorIU.Properties.Resources.value__1_;
            this.buttonCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomer.Location = new System.Drawing.Point(0, 200);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonCustomer.Size = new System.Drawing.Size(220, 60);
            this.buttonCustomer.TabIndex = 3;
            this.buttonCustomer.Text = "   Customer";
            this.buttonCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOrders.Image = global::TemaMulticolorIU.Properties.Resources.shopping_list;
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.Location = new System.Drawing.Point(0, 140);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonOrders.Size = new System.Drawing.Size(220, 60);
            this.buttonOrders.TabIndex = 2;
            this.buttonOrders.Text = "  Orders";
            this.buttonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.Image = global::TemaMulticolorIU.Properties.Resources.shopping_cart__1_;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 80);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(220, 60);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "   Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 456);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonNotification;
        private System.Windows.Forms.Button buttonReporting;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonOrders;
    }
}

