namespace BookStore
{
    partial class MagazineControl
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addtoCartButton = new System.Windows.Forms.Button();
            this.issueLabel = new System.Windows.Forms.Label();
            this.bookPictureBox = new System.Windows.Forms.PictureBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.priceLabel.Location = new System.Drawing.Point(156, 129);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "Price:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(156, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 20);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name:";
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
            this.addtoCartButton.TabIndex = 11;
            this.addtoCartButton.Text = "Add to Cart";
            this.addtoCartButton.UseVisualStyleBackColor = false;
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.issueLabel.Location = new System.Drawing.Point(156, 67);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(44, 20);
            this.issueLabel.TabIndex = 9;
            this.issueLabel.Text = "Issue:";
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookPictureBox.Location = new System.Drawing.Point(29, 36);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(110, 145);
            this.bookPictureBox.TabIndex = 8;
            this.bookPictureBox.TabStop = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.typeLabel.Location = new System.Drawing.Point(156, 98);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(43, 20);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Type:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idLabel.Location = new System.Drawing.Point(4, 6);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 20);
            this.idLabel.TabIndex = 14;
            this.idLabel.Text = "#";
            // 
            // MagazineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addtoCartButton);
            this.Controls.Add(this.issueLabel);
            this.Controls.Add(this.bookPictureBox);
            this.Controls.Add(this.typeLabel);
            this.Name = "MagazineControl";
            this.Size = new System.Drawing.Size(387, 232);
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addtoCartButton;
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.PictureBox bookPictureBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label idLabel;
    }
}
