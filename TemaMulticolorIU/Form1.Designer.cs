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
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaxzimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelMenu.Size = new System.Drawing.Size(220, 481);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonSetting
            // 
            this.buttonSetting.AutoSize = true;
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
            this.buttonNotification.AutoSize = true;
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
            this.buttonReporting.AutoSize = true;
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
            this.buttonCustomer.AutoSize = true;
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
            this.buttonOrders.AutoSize = true;
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
            this.btnProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RJ Code Advance";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaxzimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(714, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(609, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaxzimize
            // 
            this.btnMaxzimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxzimize.FlatAppearance.BorderSize = 0;
            this.btnMaxzimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxzimize.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxzimize.ForeColor = System.Drawing.Color.White;
            this.btnMaxzimize.Location = new System.Drawing.Point(645, 0);
            this.btnMaxzimize.Name = "btnMaxzimize";
            this.btnMaxzimize.Size = new System.Drawing.Size(30, 30);
            this.btnMaxzimize.TabIndex = 3;
            this.btnMaxzimize.Text = "O";
            this.btnMaxzimize.UseVisualStyleBackColor = true;
            this.btnMaxzimize.Click += new System.EventHandler(this.btnMaxzimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(681, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::TemaMulticolorIU.Properties.Resources.cross_out__2_;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(320, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(714, 401);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::TemaMulticolorIU.Properties.Resources.bell;
            this.pictureBox1.Location = new System.Drawing.Point(249, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 481);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMainMenu_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaxzimize;
        private System.Windows.Forms.Button btnClose;
    }
}

