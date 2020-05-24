namespace BookStore
{
    partial class BookControl
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
            this.authorLabel = new System.Windows.Forms.Label();
            this.bookPictureBox = new System.Windows.Forms.PictureBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.addtoCartButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.authorLabel.Location = new System.Drawing.Point(156, 98);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(57, 20);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "Author:";
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookPictureBox.Location = new System.Drawing.Point(29, 36);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(110, 145);
            this.bookPictureBox.TabIndex = 1;
            this.bookPictureBox.TabStop = false;
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isbnLabel.Location = new System.Drawing.Point(156, 67);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(44, 20);
            this.isbnLabel.TabIndex = 2;
            this.isbnLabel.Text = "ISBN:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.publisherLabel.Location = new System.Drawing.Point(156, 129);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(72, 20);
            this.publisherLabel.TabIndex = 3;
            this.publisherLabel.Text = "Publisher:";
            // 
            // addtoCartButton
            // 
            this.addtoCartButton.BackColor = System.Drawing.Color.ForestGreen;
            this.addtoCartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addtoCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtoCartButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addtoCartButton.ForeColor = System.Drawing.Color.White;
            this.addtoCartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addtoCartButton.Location = new System.Drawing.Point(281, 183);
            this.addtoCartButton.Name = "addtoCartButton";
            this.addtoCartButton.Size = new System.Drawing.Size(89, 32);
            this.addtoCartButton.TabIndex = 4;
            this.addtoCartButton.Text = "Add to Cart";
            this.addtoCartButton.UseVisualStyleBackColor = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(156, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 20);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.priceLabel.Location = new System.Drawing.Point(156, 160);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idLabel.Location = new System.Drawing.Point(4, 6);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 20);
            this.idLabel.TabIndex = 15;
            this.idLabel.Text = "#";
            // 
            // BookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addtoCartButton);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.bookPictureBox);
            this.Controls.Add(this.authorLabel);
            this.Name = "BookControl";
            this.Size = new System.Drawing.Size(387, 232);
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.PictureBox bookPictureBox;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Button addtoCartButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label idLabel;
    }
}
