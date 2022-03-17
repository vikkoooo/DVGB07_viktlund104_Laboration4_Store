using System.ComponentModel;

namespace DVGB07_viktlund104_Laboration4_Store
{
	partial class EditBookForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.languageTextBox = new System.Windows.Forms.TextBox();
			this.languageLabel = new System.Windows.Forms.Label();
			this.formatTextBox = new System.Windows.Forms.TextBox();
			this.formatLabel = new System.Windows.Forms.Label();
			this.genreTextBox = new System.Windows.Forms.TextBox();
			this.genreLabel = new System.Windows.Forms.Label();
			this.authorTextBox = new System.Windows.Forms.TextBox();
			this.authorLabel = new System.Windows.Forms.Label();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.priceLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.idLabel = new System.Windows.Forms.Label();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.quantityLabel = new System.Windows.Forms.Label();
			this.quantityTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(238, 224);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 9;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(157, 224);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 10;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// languageTextBox
			// 
			this.languageTextBox.Location = new System.Drawing.Point(90, 192);
			this.languageTextBox.Name = "languageTextBox";
			this.languageTextBox.Size = new System.Drawing.Size(223, 20);
			this.languageTextBox.TabIndex = 8;
			// 
			// languageLabel
			// 
			this.languageLabel.Location = new System.Drawing.Point(8, 195);
			this.languageLabel.Name = "languageLabel";
			this.languageLabel.Size = new System.Drawing.Size(100, 15);
			this.languageLabel.TabIndex = 12;
			this.languageLabel.Text = "Language";
			// 
			// formatTextBox
			// 
			this.formatTextBox.Location = new System.Drawing.Point(90, 166);
			this.formatTextBox.Name = "formatTextBox";
			this.formatTextBox.Size = new System.Drawing.Size(223, 20);
			this.formatTextBox.TabIndex = 7;
			// 
			// formatLabel
			// 
			this.formatLabel.Location = new System.Drawing.Point(8, 169);
			this.formatLabel.Name = "formatLabel";
			this.formatLabel.Size = new System.Drawing.Size(100, 15);
			this.formatLabel.TabIndex = 10;
			this.formatLabel.Text = "Format";
			// 
			// genreTextBox
			// 
			this.genreTextBox.Location = new System.Drawing.Point(90, 140);
			this.genreTextBox.Name = "genreTextBox";
			this.genreTextBox.Size = new System.Drawing.Size(223, 20);
			this.genreTextBox.TabIndex = 6;
			// 
			// genreLabel
			// 
			this.genreLabel.Location = new System.Drawing.Point(8, 143);
			this.genreLabel.Name = "genreLabel";
			this.genreLabel.Size = new System.Drawing.Size(100, 15);
			this.genreLabel.TabIndex = 9;
			this.genreLabel.Text = "Genre";
			// 
			// authorTextBox
			// 
			this.authorTextBox.Location = new System.Drawing.Point(90, 114);
			this.authorTextBox.Name = "authorTextBox";
			this.authorTextBox.Size = new System.Drawing.Size(223, 20);
			this.authorTextBox.TabIndex = 5;
			// 
			// authorLabel
			// 
			this.authorLabel.Location = new System.Drawing.Point(8, 117);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(100, 15);
			this.authorLabel.TabIndex = 11;
			this.authorLabel.Text = "Author";
			// 
			// priceTextBox
			// 
			this.priceTextBox.Location = new System.Drawing.Point(90, 88);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(223, 20);
			this.priceTextBox.TabIndex = 4;
			// 
			// priceLabel
			// 
			this.priceLabel.Location = new System.Drawing.Point(8, 91);
			this.priceLabel.Name = "priceLabel";
			this.priceLabel.Size = new System.Drawing.Size(100, 15);
			this.priceLabel.TabIndex = 14;
			this.priceLabel.Text = "Price (SEK)";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(90, 62);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(223, 20);
			this.nameTextBox.TabIndex = 3;
			// 
			// nameLabel
			// 
			this.nameLabel.Location = new System.Drawing.Point(8, 65);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(100, 15);
			this.nameLabel.TabIndex = 13;
			this.nameLabel.Text = "Name";
			// 
			// idLabel
			// 
			this.idLabel.Location = new System.Drawing.Point(8, 39);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(100, 15);
			this.idLabel.TabIndex = 13;
			this.idLabel.Text = "ID";
			// 
			// idTextBox
			// 
			this.idTextBox.Location = new System.Drawing.Point(90, 36);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(223, 20);
			this.idTextBox.TabIndex = 2;
			// 
			// quantityLabel
			// 
			this.quantityLabel.Location = new System.Drawing.Point(8, 13);
			this.quantityLabel.Name = "quantityLabel";
			this.quantityLabel.Size = new System.Drawing.Size(100, 15);
			this.quantityLabel.TabIndex = 14;
			this.quantityLabel.Text = "Quantity";
			// 
			// quantityTextBox
			// 
			this.quantityTextBox.Location = new System.Drawing.Point(90, 10);
			this.quantityTextBox.Name = "quantityTextBox";
			this.quantityTextBox.Size = new System.Drawing.Size(223, 20);
			this.quantityTextBox.TabIndex = 1;
			// 
			// EditBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 259);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.languageTextBox);
			this.Controls.Add(this.languageLabel);
			this.Controls.Add(this.formatTextBox);
			this.Controls.Add(this.formatLabel);
			this.Controls.Add(this.genreTextBox);
			this.Controls.Add(this.genreLabel);
			this.Controls.Add(this.authorTextBox);
			this.Controls.Add(this.authorLabel);
			this.Controls.Add(this.quantityTextBox);
			this.Controls.Add(this.quantityLabel);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(this.priceLabel);
			this.Controls.Add(this.idLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameLabel);
			this.Name = "EditBookForm";
			this.Text = "Edit Book";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox languageTextBox;
		private System.Windows.Forms.Label languageLabel;
		private System.Windows.Forms.TextBox formatTextBox;
		private System.Windows.Forms.Label formatLabel;
		private System.Windows.Forms.TextBox genreTextBox;
		private System.Windows.Forms.Label genreLabel;
		private System.Windows.Forms.TextBox authorTextBox;
		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.Label priceLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label idLabel;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.Label quantityLabel;
		private System.Windows.Forms.TextBox quantityTextBox;

		#endregion
	}
}