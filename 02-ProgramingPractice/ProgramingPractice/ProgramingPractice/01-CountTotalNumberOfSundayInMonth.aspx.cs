using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramingPractice
{
    public partial class _01_CountTotalNumberOfSundayInMonth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int month = 11;
            int year = 2019;
            int totalSaturday =  TotalSaturdays(month, year);
            div1.InnerText = "Total Number of Saturday in Nov 2019 are :" + totalSaturday ;

        }

        public int TotalSaturdays(int month, int year)
        {

            DateTime date = new DateTime( year, month, 1 );
            int count = 0;

            //get total number of days of the month
            int totalDays = DateTime.DaysInMonth(year, month);

            //loop through out the month and check dayname
            for (int i = 1; i <= totalDays; i++)
            {
                DateTime date2 = new DateTime(year, month, i);
                string dayName = date2.ToString("dddd");
                if (dayName.ToLower() == "saturday")
                {
                    count++;
                }
                    
            }

            return count;
        }
    }
}