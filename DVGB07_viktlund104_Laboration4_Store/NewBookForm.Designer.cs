using System.ComponentModel;

namespace DVGB07_viktlund104_Laboration4_Store
{
	partial class NewBookForm
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
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.priceLabel = new System.Windows.Forms.Label();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.authorLabel = new System.Windows.Forms.Label();
			this.authorTextBox = new System.Windows.Forms.TextBox();
			this.genreLabel = new System.Windows.Forms.Label();
			this.genreTextBox = new System.Windows.Forms.TextBox();
			this.formatLabel = new System.Windows.Forms.Label();
			this.formatTextBox = new System.Windows.Forms.TextBox();
			this.languageLabel = new System.Windows.Forms.Label();
			this.languageTextBox = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.Location = new System.Drawing.Point(12, 9);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(100, 15);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Name";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(94, 6);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(223, 20);
			this.nameTextBox.TabIndex = 1;
			// 
			// priceLabel
			// 
			this.priceLabel.Location = new System.Drawing.Point(12, 35);
			this.priceLabel.Name = "priceLabel";
			this.priceLabel.Size = new System.Drawing.Size(100, 15);
			this.priceLabel.TabIndex = 0;
			this.priceLabel.Text = "Price (SEK)";
			// 
			// priceTextBox
			// 
			this.priceTextBox.Location = new System.Drawing.Point(94, 32);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(223, 20);
			this.priceTextBox.TabIndex = 2;
			// 
			// authorLabel
			// 
			this.authorLabel.Location = new System.Drawing.Point(12, 61);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(100, 15);
			this.authorLabel.TabIndex = 0;
			this.authorLabel.Text = "Author";
			// 
			// authorTextBox
			// 
			this.authorTextBox.Location = new System.Drawing.Point(94, 58);
			this.authorTextBox.Name = "authorTextBox";
			this.authorTextBox.Size = new System.Drawing.Size(223, 20);
			this.authorTextBox.TabIndex = 3;
			// 
			// genreLabel
			// 
			this.genreLabel.Location = new System.Drawing.Point(12, 87);
			this.genreLabel.Name = "genreLabel";
			this.genreLabel.Size = new System.Drawing.Size(100, 15);
			this.genreLabel.TabIndex = 0;
			this.genreLabel.Text = "Genre";
			// 
			// genreTextBox
			// 
			this.genreTextBox.Location = new System.Drawing.Point(94, 84);
			this.genreTextBox.Name = "genreTextBox";
			this.genreTextBox.Size = new System.Drawing.Size(223, 20);
			this.genreTextBox.TabIndex = 4;
			// 
			// formatLabel
			// 
			this.formatLabel.Location = new System.Drawing.Point(12, 113);
			this.formatLabel.Name = "formatLabel";
			this.formatLabel.Size = new System.Drawing.Size(100, 15);
			this.formatLabel.TabIndex = 0;
			this.formatLabel.Text = "Format";
			// 
			// formatTextBox
			// 
			this.formatTextBox.Location = new System.Drawing.Point(94, 110);
			this.formatTextBox.Name = "formatTextBox";
			this.formatTextBox.Size = new System.Drawing.Size(223, 20);
			this.formatTextBox.TabIndex = 5;
			// 
			// languageLabel
			// 
			this.languageLabel.Location = new System.Drawing.Point(12, 139);
			this.languageLabel.Name = "languageLabel";
			this.languageLabel.Size = new System.Drawing.Size(100, 15);
			this.languageLabel.TabIndex = 0;
			this.languageLabel.Text = "Language";
			// 
			// languageTextBox
			// 
			this.languageTextBox.Location = new System.Drawing.Point(94, 136);
			this.languageTextBox.Name = "languageTextBox";
			this.languageTextBox.Size = new System.Drawing.Size(223, 20);
			this.languageTextBox.TabIndex = 6;
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(161, 162);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 8;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(242, 162);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// NewBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(327, 194);
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
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.priceLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameLabel);
			this.Name = "NewBookForm";
			this.Text = "New Book";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;

		private System.Windows.Forms.Label priceLabel;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.TextBox authorTextBox;
		private System.Windows.Forms.Label genreLabel;
		private System.Windows.Forms.TextBox genreTextBox;
		private System.Windows.Forms.Label formatLabel;
		private System.Windows.Forms.TextBox formatTextBox;
		private System.Windows.Forms.Label languageLabel;
		private System.Windows.Forms.TextBox languageTextBox;

		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox nameTextBox;

		#endregion
	}
}