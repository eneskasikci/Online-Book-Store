namespace BookStore
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.bookshopLBL = new System.Windows.Forms.Label();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.homepageButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.magazinesButton = new System.Windows.Forms.Button();
            this.cdButton = new System.Windows.Forms.Button();
            this.homepagePanel = new System.Windows.Forms.Panel();
            this.welcomeCLabel = new System.Windows.Forms.Label();
            this.magazinesPanel = new System.Windows.Forms.Panel();
            this.cdsPanel = new System.Windows.Forms.Panel();
            this.shoppingCartPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.sidecolorButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            this.homepagePanel.SuspendLayout();
            this.shoppingCartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.bookshopLBL);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1184, 68);
            this.topPanel.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeButton.Location = new System.Drawing.Point(1147, 9);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 28);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bookshopLBL
            // 
            this.bookshopLBL.AutoSize = true;
            this.bookshopLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.bookshopLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookshopLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookshopLBL.Location = new System.Drawing.Point(83, 23);
            this.bookshopLBL.Name = "bookshopLBL";
            this.bookshopLBL.Size = new System.Drawing.Size(118, 25);
            this.bookshopLBL.TabIndex = 2;
            this.bookshopLBL.Text = "Book Store";
            // 
            // booksPanel
            // 
            this.booksPanel.AutoScroll = true;
            this.booksPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.booksPanel.Location = new System.Drawing.Point(108, 131);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(980, 551);
            this.booksPanel.TabIndex = 10;
            this.booksPanel.Visible = false;
            // 
            // homepageButton
            // 
            this.homepageButton.FlatAppearance.BorderSize = 0;
            this.homepageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homepageButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.homepageButton.Location = new System.Drawing.Point(108, 82);
            this.homepageButton.Name = "homepageButton";
            this.homepageButton.Size = new System.Drawing.Size(196, 34);
            this.homepageButton.TabIndex = 1;
            this.homepageButton.Text = "Homepage";
            this.homepageButton.UseVisualStyleBackColor = true;
            this.homepageButton.Click += new System.EventHandler(this.homepageButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.FlatAppearance.BorderSize = 0;
            this.booksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.booksButton.Location = new System.Drawing.Point(304, 82);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(196, 34);
            this.booksButton.TabIndex = 14;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // magazinesButton
            // 
            this.magazinesButton.FlatAppearance.BorderSize = 0;
            this.magazinesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magazinesButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.magazinesButton.Location = new System.Drawing.Point(500, 82);
            this.magazinesButton.Name = "magazinesButton";
            this.magazinesButton.Size = new System.Drawing.Size(196, 34);
            this.magazinesButton.TabIndex = 15;
            this.magazinesButton.Text = "Magazines";
            this.magazinesButton.UseVisualStyleBackColor = true;
            this.magazinesButton.Click += new System.EventHandler(this.magazinesButton_Click);
            // 
            // cdButton
            // 
            this.cdButton.FlatAppearance.BorderSize = 0;
            this.cdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cdButton.Location = new System.Drawing.Point(696, 82);
            this.cdButton.Name = "cdButton";
            this.cdButton.Size = new System.Drawing.Size(196, 34);
            this.cdButton.TabIndex = 16;
            this.cdButton.Text = "CDs";
            this.cdButton.UseVisualStyleBackColor = true;
            this.cdButton.Click += new System.EventHandler(this.cdButton_Click);
            // 
            // homepagePanel
            // 
            this.homepagePanel.AutoScroll = true;
            this.homepagePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.homepagePanel.Controls.Add(this.welcomeCLabel);
            this.homepagePanel.Location = new System.Drawing.Point(108, 131);
            this.homepagePanel.Name = "homepagePanel";
            this.homepagePanel.Size = new System.Drawing.Size(980, 551);
            this.homepagePanel.TabIndex = 11;
            // 
            // welcomeCLabel
            // 
            this.welcomeCLabel.AutoSize = true;
            this.welcomeCLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.welcomeCLabel.Location = new System.Drawing.Point(24, 19);
            this.welcomeCLabel.Name = "welcomeCLabel";
            this.welcomeCLabel.Size = new System.Drawing.Size(93, 28);
            this.welcomeCLabel.TabIndex = 0;
            this.welcomeCLabel.Text = "Welcome";
            // 
            // magazinesPanel
            // 
            this.magazinesPanel.AutoScroll = true;
            this.magazinesPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.magazinesPanel.Location = new System.Drawing.Point(108, 131);
            this.magazinesPanel.Name = "magazinesPanel";
            this.magazinesPanel.Size = new System.Drawing.Size(980, 551);
            this.magazinesPanel.TabIndex = 12;
            this.magazinesPanel.Visible = false;
            // 
            // cdsPanel
            // 
            this.cdsPanel.AutoScroll = true;
            this.cdsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cdsPanel.Location = new System.Drawing.Point(108, 131);
            this.cdsPanel.Name = "cdsPanel";
            this.cdsPanel.Size = new System.Drawing.Size(980, 551);
            this.cdsPanel.TabIndex = 13;
            this.cdsPanel.Visible = false;
            // 
            // shoppingCartPanel
            // 
            this.shoppingCartPanel.AutoScroll = true;
            this.shoppingCartPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.shoppingCartPanel.Controls.Add(this.label6);
            this.shoppingCartPanel.Location = new System.Drawing.Point(108, 131);
            this.shoppingCartPanel.Name = "shoppingCartPanel";
            this.shoppingCartPanel.Size = new System.Drawing.Size(980, 551);
            this.shoppingCartPanel.TabIndex = 14;
            this.shoppingCartPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label6.Location = new System.Drawing.Point(711, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total:";
            // 
            // sidecolorButton
            // 
            this.sidecolorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.sidecolorButton.FlatAppearance.BorderSize = 0;
            this.sidecolorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.sidecolorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidecolorButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.sidecolorButton.Location = new System.Drawing.Point(108, 116);
            this.sidecolorButton.Name = "sidecolorButton";
            this.sidecolorButton.Size = new System.Drawing.Size(196, 15);
            this.sidecolorButton.TabIndex = 19;
            this.sidecolorButton.UseVisualStyleBackColor = false;
            // 
            // cartButton
            // 
            this.cartButton.BackgroundImage = global::BookStore.Properties.Resources.icons8_shopping_cart_50;
            this.cartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cartButton.FlatAppearance.BorderSize = 0;
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cartButton.Location = new System.Drawing.Point(892, 82);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(196, 34);
            this.cartButton.TabIndex = 17;
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BookStore.Properties.Resources.book_store_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.sidecolorButton);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.cdButton);
            this.Controls.Add(this.magazinesButton);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.homepageButton);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.shoppingCartPanel);
            this.Controls.Add(this.booksPanel);
            this.Controls.Add(this.homepagePanel);
            this.Controls.Add(this.magazinesPanel);
            this.Controls.Add(this.cdsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.homepagePanel.ResumeLayout(false);
            this.homepagePanel.PerformLayout();
            this.shoppingCartPanel.ResumeLayout(false);
            this.shoppingCartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bookshopLBL;
        private System.Windows.Forms.Panel booksPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button homepageButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button magazinesButton;
        private System.Windows.Forms.Button cdButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Panel homepagePanel;
        private System.Windows.Forms.Label welcomeCLabel;
        private System.Windows.Forms.Panel magazinesPanel;
        private System.Windows.Forms.Panel cdsPanel;
        private System.Windows.Forms.Panel shoppingCartPanel;
        private System.Windows.Forms.Button sidecolorButton;
        private System.Windows.Forms.Label label6;
    }
}