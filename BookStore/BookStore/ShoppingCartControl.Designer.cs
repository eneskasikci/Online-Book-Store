namespace BookStore
{
    partial class ShoppingCartControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deletefromCartButton = new System.Windows.Forms.Button();
            this.bookPictureBox = new System.Windows.Forms.PictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // deletefromCartButton
            // 
            this.deletefromCartButton.BackColor = System.Drawing.Color.ForestGreen;
            this.deletefromCartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deletefromCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletefromCartButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deletefromCartButton.ForeColor = System.Drawing.Color.White;
            this.deletefromCartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletefromCartButton.Location = new System.Drawing.Point(239, 167);
            this.deletefromCartButton.Name = "deletefromCartButton";
            this.deletefromCartButton.Size = new System.Drawing.Size(121, 32);
            this.deletefromCartButton.TabIndex = 20;
            this.deletefromCartButton.Text = "Delete from Cart";
            this.deletefromCartButton.UseVisualStyleBackColor = false;
            this.deletefromCartButton.Click += new System.EventHandler(this.deletefromCartButton_Click);
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookPictureBox.Location = new System.Drawing.Point(29, 36);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(110, 145);
            this.bookPictureBox.TabIndex = 19;
            this.bookPictureBox.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.priceLabel.Location = new System.Drawing.Point(156, 86);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 22;
            this.priceLabel.Text = "Price:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(156, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 20);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(156, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quantity:";
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown.Location = new System.Drawing.Point(230, 122);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown.TabIndex = 25;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShoppingCartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.deletefromCartButton);
            this.Controls.Add(this.bookPictureBox);
            this.Name = "ShoppingCartControl";
            this.Size = new System.Drawing.Size(387, 221);
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletefromCartButton;
        private System.Windows.Forms.PictureBox bookPictureBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}
