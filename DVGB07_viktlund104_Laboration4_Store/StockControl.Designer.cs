using System.ComponentModel;

namespace DVGB07_viktlund104_Laboration4_Store
{
	partial class StockControl
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
			this.bookDataGridView = new System.Windows.Forms.DataGridView();
			this.gameDataGridView = new System.Windows.Forms.DataGridView();
			this.movieDataGridView = new System.Windows.Forms.DataGridView();
			this.booksLabel = new System.Windows.Forms.Label();
			this.gamesLabel = new System.Windows.Forms.Label();
			this.moviesLabel = new System.Windows.Forms.Label();
			this.newBookButton = new System.Windows.Forms.Button();
			this.deleteBookButton = new System.Windows.Forms.Button();
			this.editBookButton = new System.Windows.Forms.Button();
			this.newGameButton = new System.Windows.Forms.Button();
			this.deleteGameButton = new System.Windows.Forms.Button();
			this.editGameButton = new System.Windows.Forms.Button();
			this.newMovieButton = new System.Windows.Forms.Button();
			this.deleteMovieButton = new System.Windows.Forms.Button();
			this.editMovieButton = new System.Windows.Forms.Button();
			this.shipmentListBox = new System.Windows.Forms.ListBox();
			this.addShipmentLabel = new System.Windows.Forms.Label();
			this.itemIdShipmentTextBox = new System.Windows.Forms.TextBox();
			this.itemIdShipmentLabel = new System.Windows.Forms.Label();
			this.quantityShipmentLabel = new System.Windows.Forms.Label();
			this.quantityShipmentTextBox = new System.Windows.Forms.TextBox();
			this.cancelProductShipmentButton = new System.Windows.Forms.Button();
			this.addProductShipmentButton = new System.Windows.Forms.Button();
			this.finalizeShipmentButton = new System.Windows.Forms.Button();
			this.stockSplitContainer = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize) (this.bookDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.gameDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.movieDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.stockSplitContainer)).BeginInit();
			this.stockSplitContainer.Panel1.SuspendLayout();
			this.stockSplitContainer.Panel2.SuspendLayout();
			this.stockSplitContainer.SuspendLayout();
			this.SuspendLayout();
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
			this.bookDataGridView.SelectionChanged += new System.EventHandler(this.bookDataGridView_SelectionChanged);
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
			this.gameDataGridView.SelectionChanged += new System.EventHandler(this.gameDataGridView_SelectionChanged);
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
			this.movieDataGridView.SelectionChanged += new System.EventHandler(this.movieDataGridView_SelectionChanged);
			// 
			// booksLabel
			// 
			this.booksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.booksLabel.Location = new System.Drawing.Point(0, 0);
			this.booksLabel.Name = "booksLabel";
			this.booksLabel.Size = new System.Drawing.Size(100, 23);
			this.booksLabel.TabIndex = 1;
			this.booksLabel.Text = "Books";
			// 
			// gamesLabel
			// 
			this.gamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.gamesLabel.Location = new System.Drawing.Point(0, 220);
			this.gamesLabel.Name = "gamesLabel";
			this.gamesLabel.Size = new System.Drawing.Size(100, 23);
			this.gamesLabel.TabIndex = 1;
			this.gamesLabel.Text = "Games";
			// 
			// moviesLabel
			// 
			this.moviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.moviesLabel.Location = new System.Drawing.Point(0, 444);
			this.moviesLabel.Name = "moviesLabel";
			this.moviesLabel.Size = new System.Drawing.Size(100, 23);
			this.moviesLabel.TabIndex = 1;
			this.moviesLabel.Text = "Movies";
			// 
			// newBookButton
			// 
			this.newBookButton.Location = new System.Drawing.Point(0, 182);
			this.newBookButton.Name = "newBookButton";
			this.newBookButton.Size = new System.Drawing.Size(75, 23);
			this.newBookButton.TabIndex = 6;
			this.newBookButton.Text = "New Book";
			this.newBookButton.UseVisualStyleBackColor = true;
			this.newBookButton.Click += new System.EventHandler(this.newBookButton_Click);
			// 
			// deleteBookButton
			// 
			this.deleteBookButton.Location = new System.Drawing.Point(202, 182);
			this.deleteBookButton.Name = "deleteBookButton";
			this.deleteBookButton.Size = new System.Drawing.Size(126, 23);
			this.deleteBookButton.TabIndex = 8;
			this.deleteBookButton.Text = "Delete Selected Book";
			this.deleteBookButton.UseVisualStyleBackColor = true;
			this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
			// 
			// editBookButton
			// 
			this.editBookButton.Location = new System.Drawing.Point(81, 182);
			this.editBookButton.Name = "editBookButton";
			this.editBookButton.Size = new System.Drawing.Size(115, 23);
			this.editBookButton.TabIndex = 7;
			this.editBookButton.Text = "Edit Selected Book";
			this.editBookButton.UseVisualStyleBackColor = true;
			this.editBookButton.Click += new System.EventHandler(this.editBookButton_Click);
			// 
			// newGameButton
			// 
			this.newGameButton.Location = new System.Drawing.Point(0, 402);
			this.newGameButton.Name = "newGameButton";
			this.newGameButton.Size = new System.Drawing.Size(75, 23);
			this.newGameButton.TabIndex = 9;
			this.newGameButton.Text = "New Game";
			this.newGameButton.UseVisualStyleBackColor = true;
			this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
			// 
			// deleteGameButton
			// 
			this.deleteGameButton.Location = new System.Drawing.Point(202, 402);
			this.deleteGameButton.Name = "deleteGameButton";
			this.deleteGameButton.Size = new System.Drawing.Size(126, 23);
			this.deleteGameButton.TabIndex = 11;
			this.deleteGameButton.Text = "Delete Selected Game";
			this.deleteGameButton.UseVisualStyleBackColor = true;
			this.deleteGameButton.Click += new System.EventHandler(this.deleteGameButton_Click);
			// 
			// editGameButton
			// 
			this.editGameButton.Location = new System.Drawing.Point(81, 402);
			this.editGameButton.Name = "editGameButton";
			this.editGameButton.Size = new System.Drawing.Size(115, 23);
			this.editGameButton.TabIndex = 10;
			this.editGameButton.Text = "Edit Selected Game";
			this.editGameButton.UseVisualStyleBackColor = true;
			this.editGameButton.Click += new System.EventHandler(this.editGameButton_Click);
			// 
			// newMovieButton
			// 
			this.newMovieButton.Location = new System.Drawing.Point(0, 626);
			this.newMovieButton.Name = "newMovieButton";
			this.newMovieButton.Size = new System.Drawing.Size(75, 23);
			this.newMovieButton.TabIndex = 12;
			this.newMovieButton.Text = "New Movie";
			this.newMovieButton.UseVisualStyleBackColor = true;
			this.newMovieButton.Click += new System.EventHandler(this.newMovieButton_Click);
			// 
			// deleteMovieButton
			// 
			this.deleteMovieButton.Location = new System.Drawing.Point(202, 626);
			this.deleteMovieButton.Name = "deleteMovieButton";
			this.deleteMovieButton.Size = new System.Drawing.Size(126, 23);
			this.deleteMovieButton.TabIndex = 14;
			this.deleteMovieButton.Text = "Delete Selected Movie";
			this.deleteMovieButton.UseVisualStyleBackColor = true;
			this.deleteMovieButton.Click += new System.EventHandler(this.deleteMovieButton_Click);
			// 
			// editMovieButton
			// 
			this.editMovieButton.Location = new System.Drawing.Point(81, 626);
			this.editMovieButton.Name = "editMovieButton";
			this.editMovieButton.Size = new System.Drawing.Size(115, 23);
			this.editMovieButton.TabIndex = 13;
			this.editMovieButton.Text = "Edit Selected Movie";
			this.editMovieButton.UseVisualStyleBackColor = true;
			this.editMovieButton.Click += new System.EventHandler(this.editMovieButton_Click);
			// 
			// shipmentListBox
			// 
			this.shipmentListBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.shipmentListBox.FormattingEnabled = true;
			this.shipmentListBox.Location = new System.Drawing.Point(5, 182);
			this.shipmentListBox.Name = "shipmentListBox";
			this.shipmentListBox.Size = new System.Drawing.Size(152, 121);
			this.shipmentListBox.TabIndex = 99;
			this.shipmentListBox.TabStop = false;
			// 
			// addShipmentLabel
			// 
			this.addShipmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.addShipmentLabel.Location = new System.Drawing.Point(3, 26);
			this.addShipmentLabel.Name = "addShipmentLabel";
			this.addShipmentLabel.Size = new System.Drawing.Size(154, 17);
			this.addShipmentLabel.TabIndex = 4;
			this.addShipmentLabel.Text = "Add shipment products";
			// 
			// itemIdShipmentTextBox
			// 
			this.itemIdShipmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.itemIdShipmentTextBox.Location = new System.Drawing.Point(57, 55);
			this.itemIdShipmentTextBox.Name = "itemIdShipmentTextBox";
			this.itemIdShipmentTextBox.Size = new System.Drawing.Size(100, 20);
			this.itemIdShipmentTextBox.TabIndex = 1;
			// 
			// itemIdShipmentLabel
			// 
			this.itemIdShipmentLabel.Location = new System.Drawing.Point(3, 58);
			this.itemIdShipmentLabel.Name = "itemIdShipmentLabel";
			this.itemIdShipmentLabel.Size = new System.Drawing.Size(48, 17);
			this.itemIdShipmentLabel.TabIndex = 4;
			this.itemIdShipmentLabel.Text = "Item ID";
			// 
			// quantityShipmentLabel
			// 
			this.quantityShipmentLabel.Location = new System.Drawing.Point(3, 85);
			this.quantityShipmentLabel.Name = "quantityShipmentLabel";
			this.quantityShipmentLabel.Size = new System.Drawing.Size(48, 17);
			this.quantityShipmentLabel.TabIndex = 4;
			this.quantityShipmentLabel.Text = "Quantity";
			// 
			// quantityShipmentTextBox
			// 
			this.quantityShipmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.quantityShipmentTextBox.Location = new System.Drawing.Point(57, 81);
			this.quantityShipmentTextBox.Name = "quantityShipmentTextBox";
			this.quantityShipmentTextBox.Size = new System.Drawing.Size(100, 20);
			this.quantityShipmentTextBox.TabIndex = 2;
			// 
			// cancelProductShipmentButton
			// 
			this.cancelProductShipmentButton.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelProductShipmentButton.Location = new System.Drawing.Point(82, 107);
			this.cancelProductShipmentButton.Name = "cancelProductShipmentButton";
			this.cancelProductShipmentButton.Size = new System.Drawing.Size(75, 23);
			this.cancelProductShipmentButton.TabIndex = 4;
			this.cancelProductShipmentButton.Text = "Cancel";
			this.cancelProductShipmentButton.UseVisualStyleBackColor = true;
			this.cancelProductShipmentButton.Click += new System.EventHandler(this.cancelProductShipmentButton_Click);
			// 
			// addProductShipmentButton
			// 
			this.addProductShipmentButton.Location = new System.Drawing.Point(4, 107);
			this.addProductShipmentButton.Name = "addProductShipmentButton";
			this.addProductShipmentButton.Size = new System.Drawing.Size(75, 23);
			this.addProductShipmentButton.TabIndex = 3;
			this.addProductShipmentButton.Text = "Add";
			this.addProductShipmentButton.UseVisualStyleBackColor = true;
			this.addProductShipmentButton.Click += new System.EventHandler(this.addProductShipmentButton_Click);
			// 
			// finalizeShipmentButton
			// 
			this.finalizeShipmentButton.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.finalizeShipmentButton.Location = new System.Drawing.Point(57, 309);
			this.finalizeShipmentButton.Name = "finalizeShipmentButton";
			this.finalizeShipmentButton.Size = new System.Drawing.Size(100, 23);
			this.finalizeShipmentButton.TabIndex = 5;
			this.finalizeShipmentButton.Text = "Finalize Shipment";
			this.finalizeShipmentButton.UseVisualStyleBackColor = true;
			this.finalizeShipmentButton.Click += new System.EventHandler(this.finalizeShipmentButton_Click);
			// 
			// stockSplitContainer
			// 
			this.stockSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stockSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.stockSplitContainer.Name = "stockSplitContainer";
			// 
			// stockSplitContainer.Panel1
			// 
			this.stockSplitContainer.Panel1.Controls.Add(this.booksLabel);
			this.stockSplitContainer.Panel1.Controls.Add(this.editMovieButton);
			this.stockSplitContainer.Panel1.Controls.Add(this.bookDataGridView);
			this.stockSplitContainer.Panel1.Controls.Add(this.editGameButton);
			this.stockSplitContainer.Panel1.Controls.Add(this.gameDataGridView);
			this.stockSplitContainer.Panel1.Controls.Add(this.deleteMovieButton);
			this.stockSplitContainer.Panel1.Controls.Add(this.movieDataGridView);
			this.stockSplitContainer.Panel1.Controls.Add(this.deleteGameButton);
			this.stockSplitContainer.Panel1.Controls.Add(this.gamesLabel);
			this.stockSplitContainer.Panel1.Controls.Add(this.newMovieButton);
			this.stockSplitContainer.Panel1.Controls.Add(this.moviesLabel);
			this.stockSplitContainer.Panel1.Controls.Add(this.editBookButton);
			this.stockSplitContainer.Panel1.Controls.Add(this.newBookButton);
			this.stockSplitContainer.Panel1.Controls.Add(this.newGameButton);
			this.stockSplitContainer.Panel1.Controls.Add(this.deleteBookButton);
			// 
			// stockSplitContainer.Panel2
			// 
			this.stockSplitContainer.Panel2.Controls.Add(this.addShipmentLabel);
			this.stockSplitContainer.Panel2.Controls.Add(this.finalizeShipmentButton);
			this.stockSplitContainer.Panel2.Controls.Add(this.shipmentListBox);
			this.stockSplitContainer.Panel2.Controls.Add(this.addProductShipmentButton);
			this.stockSplitContainer.Panel2.Controls.Add(this.itemIdShipmentLabel);
			this.stockSplitContainer.Panel2.Controls.Add(this.cancelProductShipmentButton);
			this.stockSplitContainer.Panel2.Controls.Add(this.quantityShipmentLabel);
			this.stockSplitContainer.Panel2.Controls.Add(this.quantityShipmentTextBox);
			this.stockSplitContainer.Panel2.Controls.Add(this.itemIdShipmentTextBox);
			this.stockSplitContainer.Size = new System.Drawing.Size(1032, 656);
			this.stockSplitContainer.SplitterDistance = 860;
			this.stockSplitContainer.TabIndex = 100;
			// 
			// StockControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.stockSplitContainer);
			this.Name = "StockControl";
			this.Size = new System.Drawing.Size(1032, 656);
			((System.ComponentModel.ISupportInitialize) (this.bookDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.gameDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.movieDataGridView)).EndInit();
			this.stockSplitContainer.Panel1.ResumeLayout(false);
			this.stockSplitContainer.Panel2.ResumeLayout(false);
			this.stockSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.stockSplitContainer)).EndInit();
			this.stockSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.SplitContainer stockSplitContainer;

		private System.Windows.Forms.Button finalizeShipmentButton;

		private System.Windows.Forms.ListBox shipmentListBox;
		private System.Windows.Forms.Label itemIdShipmentLabel;
		private System.Windows.Forms.Label quantityShipmentLabel;
		private System.Windows.Forms.TextBox quantityShipmentTextBox;
		private System.Windows.Forms.Button cancelProductShipmentButton;
		private System.Windows.Forms.Button addProductShipmentButton;

		private System.Windows.Forms.Label addShipmentLabel;
		private System.Windows.Forms.TextBox itemIdShipmentTextBox;

		private System.Windows.Forms.Button newMovieButton;
		private System.Windows.Forms.Button deleteMovieButton;
		private System.Windows.Forms.Button editMovieButton;

		private System.Windows.Forms.Button newGameButton;
		private System.Windows.Forms.Button deleteGameButton;
		private System.Windows.Forms.Button editGameButton;

		private System.Windows.Forms.Button editBookButton;

		private System.Windows.Forms.Button newBookButton;

		private System.Windows.Forms.Button deleteBookButton;

		private System.Windows.Forms.Label gamesLabel;
		private System.Windows.Forms.Label moviesLabel;

		private System.Windows.Forms.Label booksLabel;

		private System.Windows.Forms.DataGridView gameDataGridView;
		private System.Windows.Forms.DataGridView movieDataGridView;

		private System.Windows.Forms.DataGridView bookDataGridView;

		#endregion
	}
}