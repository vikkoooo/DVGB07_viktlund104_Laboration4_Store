using System;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class MainForm : Form
	{
		private FileHandler db;
		
		// Constructor
		public MainForm()
		{
			InitializeComponent();
			
			// Initialize our FileHandling
			db = new FileHandler();
			db.Load();
		}

		/*
		 * EVENTS
		 */
		// This event will be triggered when the form is loaded, after the constructor.
		// This has to be done in this order, because we have to have the database already initialized and loaded
		// before we can use it to something. If this code would have been in the constructor, we can have random crash
		private void MainForm_Load(object sender, EventArgs e)
		{
			// Add StockControl to stock tab in MainForm
			StockControl stock = new StockControl(db);
			stockTab.Dock = DockStyle.Fill;
			stockTab.Controls.Add(stock);
			
			// Add SalesControl to sales tab in MainForm
			SalesControl sales = new SalesControl(db);
			salesTab.Dock = DockStyle.Fill;
			salesTab.Controls.Add(sales);
		}

		// Event will be triggered every time the program closes. In other words, save on exit.
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			db.Save();
		}
	}
}