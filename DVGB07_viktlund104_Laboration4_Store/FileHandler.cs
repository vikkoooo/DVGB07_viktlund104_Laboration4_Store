﻿using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public class FileHandler
	{
		public BindingList<Book> BookList { get; private set; }
		public BindingList<Game> GameList { get; private set; }
		public BindingList<Movie> MovieList { get; private set; }
		public static int IdGenerator = 1;

		public FileHandler()
		{
			// Initialize lists
			BookList = new BindingList<Book>();
			GameList = new BindingList<Game>();
			MovieList = new BindingList<Movie>();
			
			// Add dummy data during dev
			// BookList.Add(new Book() { Name = "Bello Gallico et Civili", Price = 449, Author = "Julius Caesar", Genre = "Historia", Format = "Inbunden", Language = "Latin" });
			// BookList.Add(new Book() { Name = "How to Read a Book", Price = 149, Author = "Mortimer J. Adler", Genre = "Kursliteratur", Format = "Pocket" });
			// BookList.Add(new Book() { Name = "Moby Dick", Price = 49, Author = "Herman Melville", Genre = "Historia", Format = "Pocket" });
			// BookList.Add(new Book() { Name = "Great Gatsby", Price = 79, Author = "F. Scott Fitzgerald", Genre = "Historia", Format = "E-Bok" });
			// BookList.Add(new Book() { Name = "House of Leaves", Price = 49, Author = "Mark Z. Danielewski", Genre = "Historia" });
			//
			// GameList.Add(new Game() { Name = "Elden Ring", Price = 599, Platform = "Playstation 5" });
			// GameList.Add(new Game() { Name = "Demon's Souls", Price = 499, Platform = "Playstation 5" });
			// GameList.Add(new Game() { Name = "Microsoft Flight Simulator", Price = 499, Platform = "PC" });
			// GameList.Add(new Game() { Name = "Planescape Torment", Price = 99, Platform = "PC" });
			// GameList.Add(new Game() { Name = "Disco Elysium", Price = 399, Platform = "PC" });
			//
			// MovieList.Add(new Movie() { Name = "Nyckeln till frihet", Price = 99, Format = "DVD", PlayingTime = 142 });
			// MovieList.Add(new Movie() { Name = "Gudfadern", Price = 99, Format = "DVD", PlayingTime = 152 });
			// MovieList.Add(new Movie() { Name = "Konungens återkomst", Price = 199, Format = "Blu-Ray", PlayingTime = 154 });
			// MovieList.Add(new Movie() { Name = "Pulp fiction", Price = 199, Format = "Blu-Ray" });
			// MovieList.Add(new Movie() { Name = "Schindlers list", Price = 99, Format = "DVD" });
		}

		private void SaveBooks()
		{
			XmlDocument doc = new XmlDocument();
			XmlElement root = doc.CreateElement("BookDatabase"); // <BookDatabase>
			foreach (var entry in BookList)
			{
				XmlElement elem = doc.CreateElement("book"); // <book>

				XmlElement id = doc.CreateElement("id");
				id.InnerText = entry.Id.ToString();
				elem.AppendChild(id);
				
				XmlElement quantity = doc.CreateElement("quantity");
				quantity.InnerText = entry.Quantity.ToString();
				elem.AppendChild(quantity);
				
				XmlElement name = doc.CreateElement("name");
				name.InnerText = entry.Name;
				elem.AppendChild(name);
				
				XmlElement price = doc.CreateElement("price"); 
				price.InnerText = entry.Price.ToString();
				elem.AppendChild(price); 
				
				XmlElement author = doc.CreateElement("author"); 
				author.InnerText = entry.Author;
				elem.AppendChild(author); 
				
				XmlElement genre = doc.CreateElement("genre"); 
				genre.InnerText = entry.Genre;
				elem.AppendChild(genre); 
				
				XmlElement format = doc.CreateElement("format");
				format.InnerText = entry.Format;
				elem.AppendChild(format); 
				
				XmlElement language = doc.CreateElement("language");
				language.InnerText = entry.Language;
				elem.AppendChild(language); 
				
				root.AppendChild(elem); // </book>
			}
			doc.AppendChild(root); // </BookDatabase>
			doc.Save("booksDB.xml");
		}
		
		private void SaveGames()
		{
			XmlDocument doc = new XmlDocument();
			XmlElement root = doc.CreateElement("GameDatabase"); 
			foreach (var entry in GameList)
			{
				XmlElement elem = doc.CreateElement("game"); 
				
				XmlElement id = doc.CreateElement("id");
				id.InnerText = entry.Id.ToString();
				elem.AppendChild(id);
				
				XmlElement quantity = doc.CreateElement("quantity");
				quantity.InnerText = entry.Quantity.ToString();
				elem.AppendChild(quantity);
				
				XmlElement name = doc.CreateElement("name");
				name.InnerText = entry.Name;
				elem.AppendChild(name);
				
				XmlElement price = doc.CreateElement("price"); 
				price.InnerText = entry.Price.ToString();
				elem.AppendChild(price); 
				
				XmlElement platform = doc.CreateElement("platform"); 
				platform.InnerText = entry.Platform;
				elem.AppendChild(platform); 
				
				root.AppendChild(elem);
			}
			doc.AppendChild(root);
			doc.Save("gamesDB.xml");
		}
		
		private void SaveMovies()
		{
			XmlDocument doc = new XmlDocument();
			XmlElement root = doc.CreateElement("MovieDatabase"); 
			foreach (var entry in MovieList)
			{
				XmlElement elem = doc.CreateElement("movie"); 
				
				XmlElement id = doc.CreateElement("id");
				id.InnerText = entry.Id.ToString();
				elem.AppendChild(id);
				
				XmlElement quantity = doc.CreateElement("quantity");
				quantity.InnerText = entry.Quantity.ToString();
				elem.AppendChild(quantity);
				
				XmlElement name = doc.CreateElement("name");
				name.InnerText = entry.Name;
				elem.AppendChild(name);
				
				XmlElement price = doc.CreateElement("price"); 
				price.InnerText = entry.Price.ToString();
				elem.AppendChild(price); 
				
				XmlElement format = doc.CreateElement("format"); 
				format.InnerText = entry.Format;
				elem.AppendChild(format); 
				
				XmlElement playingTime = doc.CreateElement("playingTime"); 
				playingTime.InnerText = entry.PlayingTime.ToString();
				elem.AppendChild(playingTime); 
				
				root.AppendChild(elem);
			}
			doc.AppendChild(root);
			doc.Save("moviesDB.xml");
		}

		private void SaveIdGenerator()
		{
			XmlDocument doc = new XmlDocument();
			XmlElement root = doc.CreateElement("idGenerator");

			root.InnerText = IdGenerator.ToString();
			doc.AppendChild(root);
			doc.Save("IdGenerator.xml");
		}

		public void Save()
		{
			SaveBooks();
			SaveGames();
			SaveMovies();
			SaveIdGenerator();
		}
		
		public void LoadBooks()
		{
			XmlDocument document = new XmlDocument();
			document.Load("booksDB.xml");

			var root = document.FirstChild;
			foreach (XmlElement entry in root.ChildNodes)
			{
				var book = new Book(0);
				
				foreach (XmlElement node in entry.ChildNodes)
				{
					if (node.Name == "id")
						book.Id = int.Parse(node.InnerText);
					if (node.Name == "quantity")
						book.Quantity = int.Parse(node.InnerText);
					if (node.Name == "name")
						book.Name = node.InnerText;
					if (node.Name == "price")
						book.Price = double.Parse(node.InnerText);
					if (node.Name == "author")
						book.Author = node.InnerText;
					if (node.Name == "genre")
						book.Genre = node.InnerText;
					if (node.Name == "format")
						book.Format = node.InnerText;
					if (node.Name == "language")
						book.Language = node.InnerText;
				}
				BookList.Add(book);
			}
		}
		
		public void LoadGames()
		{
			XmlDocument document = new XmlDocument();
			document.Load("gamesDB.xml");

			var root = document.FirstChild;
			foreach (XmlElement entry in root.ChildNodes)
			{
				var game = new Game(0);
				
				foreach (XmlElement node in entry.ChildNodes)
				{
					if (node.Name == "id")
						game.Id = int.Parse(node.InnerText);
					if (node.Name == "quantity")
						game.Quantity = int.Parse(node.InnerText);
					if (node.Name == "name")
						game.Name = node.InnerText;
					if (node.Name == "price")
						game.Price = double.Parse(node.InnerText);
					if (node.Name == "platform")
						game.Platform = node.InnerText;
				}
				GameList.Add(game);
			}
		}
		
		public void LoadMovies()
		{
			XmlDocument document = new XmlDocument();
			document.Load("moviesDB.xml");

			var root = document.FirstChild;
			foreach (XmlElement entry in root.ChildNodes)
			{
				var movie = new Movie(0);
				
				foreach (XmlElement node in entry.ChildNodes)
				{
					if (node.Name == "id")
						movie.Id = int.Parse(node.InnerText);
					if (node.Name == "quantity")
						movie.Quantity = int.Parse(node.InnerText);
					if (node.Name == "name")
						movie.Name = node.InnerText;
					if (node.Name == "price")
						movie.Price = double.Parse(node.InnerText);
					if (node.Name == "format")
						movie.Format = node.InnerText;
					if (node.Name == "playingTime")
						movie.PlayingTime = int.Parse(node.InnerText);
				}
				MovieList.Add(movie);
			}
		}

		private void LoadIdGenerator()
		{
			XmlDocument document = new XmlDocument();
			document.Load("idGenerator.xml");

			var root = document.FirstChild;
			IdGenerator = int.Parse(root.InnerText);
		}
		
		public void Load()
		{
			LoadBooks();
			LoadGames();
			LoadMovies();
			LoadIdGenerator();
		}
	}
}