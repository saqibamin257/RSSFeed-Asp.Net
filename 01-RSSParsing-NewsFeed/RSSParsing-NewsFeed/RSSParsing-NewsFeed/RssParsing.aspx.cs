using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using RSSParsing_NewsFeed.App_Code;

namespace RSSParsing_NewsFeed
{
    public partial class RssParsing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    NewsGridView.DataSource = ParseRssFile();
                    NewsGridView.DataBind();
                }
                catch (Exception ex)
                {
                    //Serilog Logger to save error in text file location D:\\

                    SerilogLogger.WriteErrorLog(ex.Message);
                }

            }
        }
        private ArrayList ParseRssFile()
        {
            //counter is used for NewsID
            int counter = 1;

            //arraylist object
            ArrayList newsArrayList = new ArrayList();

            //XML reader
            XmlDocument rssXmlDoc = new XmlDocument();

            // Load the RSS file from the RSS URL
            rssXmlDoc.Load("http://ajans.dha.com.tr/dha_public_rss.php");

            // To raise an exception and genarate SerilogLogger
            // uncomment below line and comment above news data fetch line
            //rssXmlDoc.Load("http://ajanss.dha.com.tr/dha_public_rss.php");

            // Parse the Items in the RSS file
            XmlNodeList rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");

            // Iterate through the items in the RSS file
            foreach (XmlNode rssNode in rssNodes)
            {

                XmlNode rssSubNode;

                rssSubNode = rssNode.SelectSingleNode("title");
                string title = rssSubNode != null ? rssSubNode.InnerText : "N/A";

                rssSubNode = rssNode.SelectSingleNode("description");
                string description = rssSubNode != null ? rssSubNode.InnerText : "N/A";

                rssSubNode = rssNode.SelectSingleNode("category");
                string category = rssSubNode != null ? rssSubNode.InnerText : "N/A";

                rssSubNode = rssNode.SelectSingleNode("author");
                string author = rssSubNode != null ? rssSubNode.InnerText : "N/A";

                rssSubNode = rssNode.SelectSingleNode("pubDate");
                string pubDate = rssSubNode != null ? rssSubNode.InnerText : "N/A";

                rssSubNode = rssNode.SelectSingleNode("image/url");
                string ImageUrl = rssSubNode != null ? rssSubNode.InnerText : "N/A";

                News objNews = new News(counter, title, description, category, author, pubDate, ImageUrl);
                newsArrayList.Add(objNews);

                //increment in counter for new NewsID
                counter++;

            }

            // Return Array List
            return newsArrayList;
        }
    }
}