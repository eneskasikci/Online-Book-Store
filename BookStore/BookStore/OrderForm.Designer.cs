namespace BookStore
{
    partial class OrderForm
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
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.creditcardRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.totalLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.sendInvoiceGroup = new System.Windows.Forms.GroupBox();
            this.emailRadioButton = new System.Windows.Forms.RadioButton();
            this.smsRadioButton = new System.Windows.Forms.RadioButton();
            this.typeGroupBox.SuspendLayout();
            this.sendInvoiceGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.creditcardRadioButton);
            this.typeGroupBox.Controls.Add(this.cashRadioButton);
            this.typeGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.typeGroupBox.Location = new System.Drawing.Point(28, 22);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(185, 98);
            this.typeGroupBox.TabIndex = 35;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Payment Type";
            // 
            // creditcardRadioButton
            // 
            this.creditcardRadioButton.AutoSize = true;
            this.creditcardRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.creditcardRadioButton.Location = new System.Drawing.Point(26, 32);
            this.creditcardRadioButton.Name = "creditcardRadioButton";
            this.creditcardRadioButton.Size = new System.Drawing.Size(107, 25);
            this.creditcardRadioButton.TabIndex = 32;
            this.creditcardRadioButton.TabStop = true;
            this.creditcardRadioButton.Text = "Credit Card";
            this.creditcardRadioButton.UseVisualStyleBackColor = true;
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cashRadioButton.Location = new System.Drawing.Point(26, 63);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(62, 25);
            this.cashRadioButton.TabIndex = 33;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.totalLabel.Location = new System.Drawing.Point(207, 141);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(62, 25);
            this.totalLabel.TabIndex = 37;
            // 
            // orderLabel
            // 
            this.orderLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.orderLabel.Location = new System.Drawing.Point(79, 141);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(122, 25);
            this.orderLabel.TabIndex = 36;
            this.orderLabel.Text = "Order Total: ";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(170, 192);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 32);
            this.cancelButton.TabIndex = 39;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.makeOrderButton.BackColor = System.Drawing.Color.ForestGreen;
            this.makeOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.makeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeOrderButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.makeOrderButton.ForeColor = System.Drawing.Color.White;
            this.makeOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.makeOrderButton.Location = new System.Drawing.Point(304, 192);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(93, 32);
            this.makeOrderButton.TabIndex = 38;
            this.makeOrderButton.Text = "Make Order";
            this.makeOrderButton.UseVisualStyleBackColor = false;
            this.makeOrderButton.Click += new System.EventHandler(this.makeOrderButton_Click);
            // 
            // sendInvoiceGroup
            // 
            this.sendInvoiceGroup.Controls.Add(this.emailRadioButton);
            this.sendInvoiceGroup.Controls.Add(this.smsRadioButton);
            this.sendInvoiceGroup.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.sendInvoiceGroup.Location = new System.Drawing.Point(238, 22);
            this.sendInvoiceGroup.Name = "sendInvoiceGroup";
            this.sendInvoiceGroup.Size = new System.Drawing.Size(185, 98);
            this.sendInvoiceGroup.TabIndex = 36;
            this.sendInvoiceGroup.TabStop = false;
            this.sendInvoiceGroup.Text = "Send Invoice";
            // 
            // emailRadioButton
            // 
            this.emailRadioButton.AutoSize = true;
            this.emailRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailRadioButton.Location = new System.Drawing.Point(26, 32);
            this.emailRadioButton.Name = "emailRadioButton";
            this.emailRadioButton.Size = new System.Drawing.Size(66, 25);
            this.emailRadioButton.TabIndex = 32;
            this.emailRadioButton.TabStop = true;
            this.emailRadioButton.Text = "Email";
            this.emailRadioButton.UseVisualStyleBackColor = true;
            // 
            // smsRadioButton
            // 
            this.smsRadioButton.AutoSize = true;
            this.smsRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.smsRadioButton.Location = new System.Drawing.Point(26, 63);
            this.smsRadioButton.Name = "smsRadioButton";
            this.smsRadioButton.Size = new System.Drawing.Size(60, 25);
            this.smsRadioButton.TabIndex = 33;
            this.smsRadioButton.TabStop = true;
            this.smsRadioButton.Text = "SMS";
            this.smsRadioButton.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 252);
            this.Controls.Add(this.sendInvoiceGroup);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.makeOrderButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.typeGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.sendInvoiceGroup.ResumeLayout(false);
            this.sendInvoiceGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.RadioButton creditcardRadioButton;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button makeOrderButton;
        private System.Windows.Forms.GroupBox sendInvoiceGroup;
        private System.Windows.Forms.RadioButton emailRadioButton;
        private System.Windows.Forms.RadioButton smsRadioButton;
    }
}