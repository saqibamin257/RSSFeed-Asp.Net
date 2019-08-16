using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSSParsing_NewsFeed.App_Code
{
    public class News
    {
        //properties
        public int NewsID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string PubDate { get; set; }
        public string ImageUrl { get; set; }

        //constructor
        public News(int NewsID, string Title, string Description, string Category, string Author, string PubDate, string ImageUrl)
        {
            this.NewsID = NewsID;
            this.Title = Title;
            this.Description = Description;
            this.Category = Category;
            this.Author = Author;
            this.PubDate = PubDate;
            this.ImageUrl = ImageUrl;
        }
    }
}