using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramingPractice
{
    public partial class _03_ReverseAString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            div1.InnerText="Reverse of Hello is : "+ Reverse("Hello");
        }

        public string Reverse(string word)
        {            
            char[] charArray = word.ToCharArray();
            char[] reverseArray =new char[charArray.Length];
            for (int i = charArray.Length - 1,j=0; i >= 0; i--)
            {
                reverseArray[j] = charArray[i];
                j++;
            }
            string str = new string(reverseArray);
            return str;
        }
    }
}