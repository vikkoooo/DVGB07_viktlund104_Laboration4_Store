using System.ComponentModel;

namespace DVGB07_viktlund104_Laboration4_Store
{
	partial class SalesControl
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.moviesLabel = new System.Windows.Forms.Label();
			this.gamesLabel = new System.Windows.Forms.Label();
			this.booksLabel = new System.Windows.Forms.Label();
			this.movieDataGridView = new System.Windows.Forms.DataGridView();
			this.gameDataGridView = new System.Windows.Forms.DataGridView();
			this.bookDataGridView = new System.Windows.Forms.DataGridView();
			this.finalizePurchaseButton = new System.Windows.Forms.Button();
			this.addProductShoppingCartButton = new System.Windows.Forms.Button();
			this.cancelProductShoppingCartButton = new System.Windows.Forms.Button();
			this.quantityShoppingCartTextBox = new System.Windows.Forms.TextBox();
			this.itemIdShoppingCartTextBox = new System.Windows.Forms.TextBox();
			this.quantityShoppingCartLabel = new System.Windows.Forms.Label();
			this.itemIdShoppingCartLabel = new System.Windows.Forms.Label();
			this.shoppingCartLabel = new System.Windows.Forms.Label();
			this.shoppingCartListBox = new System.Windows.Forms.ListBox();
			this.currentPriceLabel = new System.Windows.Forms.Label();
			this.emptyShoppingCartButton = new System.Windows.Forms.Button();
			this.salesSplitContainer = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize) (this.movieDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.gameDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.bookDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.salesSplitContainer)).BeginInit();
			this.salesSplitContainer.Panel1.SuspendLayout();
			this.salesSplitContainer.Panel2.SuspendLayout();
			this.salesSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// moviesLabel
			// 
			this.moviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.moviesLabel.Location = new System.Drawing.Point(0, 444);
			this.moviesLabel.Name = "moviesLabel";
			this.moviesLabel.Size = new System.Drawing.Size(100, 23);
			this.moviesLabel.TabIndex = 7;
			this.moviesLabel.Text = "Movies";
			// 
			// gamesLabel
			// 
			this.gamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.gamesLabel.Location = new System.Drawing.Point(0, 220);
			this.gamesLabel.Name = "gamesLabel";
			this.gamesLabel.Size = new System.Drawing.Size(100, 23);
			this.gamesLabel.TabIndex = 6;
			this.gamesLabel.Text = "Games";
			// 
			// booksLabel
			// 
			this.booksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.booksLabel.Location = new System.Drawing.Point(0, 0);
			this.booksLabel.Name = "booksLabel";
			this.booksLabel.Size = new System.Drawing.Size(100, 23);
			this.booksLabel.TabIndex = 8;
			this.booksLabel.Text = "Books";
			// 
			// movieDataGridView
			// 
			this.movieDataGridView.AllowUserToAddRows = false;
			this.movieDataGridView.AllowUserToDeleteRows = false;
			this.movieDataGridView.AllowUserToResizeRows = false;
			this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.movieDataGridView.Location = new System.Drawing.Point(0, 470);
			this.movieDataGridView.MultiSelect = false;
			this.movieDataGridView.Name = "movieDataGridView";
			this.movieDataGridView.ReadOnly = true;
			this.movieDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.movieDataGridView.Size = new System.Drawing.Size(845, 150);
			this.movieDataGridView.TabIndex = 99;
			this.movieDataGridView.TabStop = false;
			// 
			// gameDataGridView
			// 
			this.gameDataGridView.AllowUserToAddRows = false;
			this.gameDataGridView.AllowUserToDeleteRows = false;
			this.gameDataGridView.AllowUserToResizeRows = false;
			this.gameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gameDataGridView.Location = new System.Drawing.Point(0, 246);
			this.gameDataGridView.MultiSelect = false;
			this.gameDataGridView.Name = "gameDataGridView";
			this.gameDataGridView.ReadOnly = true;
			this.gameDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gameDataGridView.Size = new System.Drawing.Size(845, 150);
			this.gameDataGridView.TabIndex = 99;
			this.gameDataGridView.TabStop = false;
			// 
			// bookDataGridView
			// 
			this.bookDataGridView.AllowUserToAddRows = false;
			this.bookDataGridView.AllowUserToDeleteRows = false;
			this.bookDataGridView.AllowUserToResizeRows = false;
			this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bookDataGridView.Location = new System.Drawing.Point(0, 26);
			this.bookDataGridView.MultiSelect = false;
			this.bookDataGridView.Name = "bookDataGridView";
			this.bookDataGridView.ReadOnly = true;
			this.bookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.bookDataGridView.Size = new System.Drawing.Size(845, 150);
			this.bookDataGridView.TabIndex = 99;
			this.bookDataGridView.TabStop = false;
			// 
			// finalizePurchaseButton
			// 
			this.finalizePurchaseButton.Location = new System.Drawing.Point(57, 309);
			this.finalizePurchaseButton.Name = "finalizePurchaseButton";
			this.finalizePurchaseButton.Size = new System.Drawing.Size(100, 23);
			this.finalizePurchaseButton.TabIndex = 5;
			this.finalizePurchaseButton.Text = "Finalize Purchase";
			this.finalizePurchaseButton.UseVisualStyleBackColor = true;
			this.finalizePurchaseButton.Click += new System.EventHandler(this.finalizePurchaseButton_Click);
			// 
			// addProductShoppingCartButton
			// 
			this.addProductShoppingCartButton.Location = new System.Drawing.Point(4, 107);
			this.addProductShoppingCartButton.Name = "addProductShoppingCartButton";
			this.addProductShoppingCartButton.Size = new System.Drawing.Size(75, 23);
			this.addProductShoppingCartButton.TabIndex = 3;
			this.addProductShoppingCartButton.Text = "Add";
			this.addProductShoppingCartButton.UseVisualStyleBackColor = true;
			this.addProductShoppingCartButton.Click += new System.EventHandler(this.addProductShoppingCartButton_Click);
			// 
			// cancelProductShoppingCartButton
			// 
			this.cancelProductShoppingCartButton.Location = new System.Drawing.Point(82, 107);
			this.cancelProductShoppingCartButton.Name = "cancelProductShoppingCartButton";
			this.cancelProductShoppingCartButton.Size = new System.Drawing.Size(75, 23);
			this.cancelProductShoppingCartButton.TabIndex = 4;
			this.cancelProductShoppingCartButton.Text = "Cancel";
			this.cancelProductShoppingCartButton.UseVisualStyleBackColor = true;
			this.cancelProductShoppingCartButton.Click += new System.EventHandler(this.cancelProductShoppingCartButton_Click);
			// 
			// quantityShoppingCartTextBox
			// 
			this.quantityShoppingCartTextBox.Location = new System.Drawing.Point(57, 81);
			this.quantityShoppingCartTextBox.Name = "quantityShoppingCartTextBox";
			this.quantityShoppingCartTextBox.Size = new System.Drawing.Size(100, 20);
			this.quantityShoppingCartTextBox.TabIndex = 2;
			// 
			// itemIdShoppingCartTextBox
			// 
			this.itemIdShoppingCartTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.itemIdShoppingCartTextBox.Location = new System.Drawing.Point(57, 55);
			this.itemIdShoppingCartTextBox.Name = "itemIdShoppingCartTextBox";
			this.itemIdShoppingCartTextBox.Size = new System.Drawing.Size(100, 20);
			this.itemIdShoppingCartTextBox.TabIndex = 1;
			// 
			// quantityShoppingCartLabel
			// 
			this.quantityShoppingCartLabel.Location = new System.Drawing.Point(3, 85);
			this.quantityShoppingCartLabel.Name = "quantityShoppingCartLabel";
			this.quantityShoppingCartLabel.Size = new System.Drawing.Size(48, 17);
			this.quantityShoppingCartLabel.TabIndex = 10;
			this.quantityShoppingCartLabel.Text = "Quantity";
			// 
			// itemIdShoppingCartLabel
			// 
			this.itemIdShoppingCartLabel.Location = new System.Drawing.Point(3, 58);
			this.itemIdShoppingCartLabel.Name = "itemIdShoppingCartLabel";
			this.itemIdShoppingCartLabel.Size = new System.Drawing.Size(48, 17);
			this.itemIdShoppingCartLabel.TabIndex = 11;
			this.itemIdShoppingCartLabel.Text = "Item ID";
			// 
			// shoppingCartLabel
			// 
			this.shoppingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.shoppingCartLabel.Location = new System.Drawing.Point(3, 26);
			this.shoppingCartLabel.Name = "shoppingCartLabel";
			this.shoppingCartLabel.Size = new System.Drawing.Size(154, 17);
			this.shoppingCartLabel.TabIndex = 12;
			this.shoppingCartLabel.Text = "Shopping Cart";
			// 
			// shoppingCartListBox
			// 
			this.shoppingCartListBox.FormattingEnabled = true;
			this.shoppingCartListBox.Location = new System.Drawing.Point(5, 182);
			this.shoppingCartListBox.Name = "shoppingCartListBox";
			this.shoppingCartListBox.Size = new System.Drawing.Size(152, 121);
			this.shoppingCartListBox.TabIndex = 99;
			this.shoppingCartListBox.TabStop = false;
			// 
			// currentPriceLabel
			// 
			this.currentPriceLabel.Location = new System.Drawing.Point(5, 314);
			this.currentPriceLabel.Name = "currentPriceLabel";
			this.currentPriceLabel.Size = new System.Drawing.Size(46, 23);
			this.currentPriceLabel.TabIndex = 18;
			// 
			// emptyShoppingCartButton
			// 
			this.emptyShoppingCartButton.Location = new System.Drawing.Point(57, 338);
			this.emptyShoppingCartButton.Name = "emptyShoppingCartButton";
			this.emptyShoppingCartButton.Size = new System.Drawing.Size(100, 23);
			this.emptyShoppingCartButton.TabIndex = 6;
			this.emptyShoppingCartButton.Text = "Empty Cart";
			this.emptyShoppingCartButton.UseVisualStyleBackColor = true;
			this.emptyShoppingCartButton.Click += new System.EventHandler(this.emptyShoppingCartButton_Click);
			// 
			// salesSplitContainer
			// 
			this.salesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.salesSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.salesSplitContainer.Name = "salesSplitContainer";
			// 
			// salesSplitContainer.Panel1
			// 
			this.salesSplitContainer.Panel1.Controls.Add(this.booksLabel);
			this.salesSplitContainer.Panel1.Controls.Add(this.bookDataGridView);
			this.salesSplitContainer.Panel1.Controls.Add(this.gameDataGridView);
			this.salesSplitContainer.Panel1.Controls.Add(this.movieDataGridView);
			this.salesSplitContainer.Panel1.Controls.Add(this.gamesLabel);
			this.salesSplitContainer.Panel1.Controls.Add(this.moviesLabel);
			// 
			// salesSplitContainer.Panel2
			// 
			this.salesSplitContainer.Panel2.Controls.Add(this.shoppingCartLabel);
			this.salesSplitContainer.Panel2.Controls.Add(this.currentPriceLabel);
			this.salesSplitContainer.Panel2.Controls.Add(this.shoppingCartListBox);
			this.salesSplitContainer.Panel2.Controls.Add(this.emptyShoppingCartButton);
			this.salesSplitContainer.Panel2.Controls.Add(this.itemIdShoppingCartLabel);
			this.salesSplitContainer.Panel2.Controls.Add(this.finalizePurchaseButton);
			this.salesSplitContainer.Panel2.Controls.Add(this.quantityShoppingCartLabel);
			this.salesSplitContainer.Panel2.Controls.Add(this.addProductShoppingCartButton);
			this.salesSplitContainer.Panel2.Controls.Add(this.itemIdShoppingCartTextBox);
			this.salesSplitContainer.Panel2.Controls.Add(this.cancelProductShoppingCartButton);
			this.salesSplitContainer.Panel2.Controls.Add(this.quantityShoppingCartTextBox);
			this.salesSplitContainer.Size = new System.Drawing.Size(1041, 645);
			this.salesSplitContainer.SplitterDistance = 860;
			this.salesSplitContainer.TabIndex = 100;
			// 
			// SalesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.salesSplitContainer);
			this.Name = "SalesControl";
			this.Size = new System.Drawing.Size(1041, 645);
			((System.ComponentModel.ISupportInitialize) (this.movieDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.gameDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.bookDataGridView)).EndInit();
			this.salesSplitContainer.Panel1.ResumeLayout(false);
			this.salesSplitContainer.Panel2.ResumeLayout(false);
			this.salesSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.salesSplitContainer)).EndInit();
			this.salesSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.SplitContainer salesSplitContainer;

		private System.Windows.Forms.Button emptyShoppingCartButton;

		private System.Windows.Forms.Label currentPriceLabel;

		private System.Windows.Forms.Button finalizePurchaseButton;
		private System.Windows.Forms.Button addProductShoppingCartButton;
		private System.Windows.Forms.Button cancelProductShoppingCartButton;
		private System.Windows.Forms.TextBox quantityShoppingCartTextBox;
		private System.Windows.Forms.TextBox itemIdShoppingCartTextBox;
		private System.Windows.Forms.Label quantityShoppingCartLabel;
		private System.Windows.Forms.Label itemIdShoppingCartLabel;
		private System.Windows.Forms.Label shoppingCartLabel;
		private System.Windows.Forms.ListBox shoppingCartListBox;

		private System.Windows.Forms.Label moviesLabel;
		private System.Windows.Forms.Label gamesLabel;
		private System.Windows.Forms.Label booksLabel;
		private System.Windows.Forms.DataGridView movieDataGridView;
		private System.Windows.Forms.DataGridView gameDataGridView;
		private System.Windows.Forms.DataGridView bookDataGridView;

		#endregion
	}
}