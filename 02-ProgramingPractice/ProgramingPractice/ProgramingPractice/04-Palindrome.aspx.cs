using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramingPractice
{
    public partial class _04_Palindrome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //level,anna,civic,
            string str = "redder";
            div1.InnerText = str + " is " + isPalindrome(str);
        }

        public string isPalindrome(string str)
        {
            string result = "Palindrome";
            char[] charArray = str.ToCharArray();

            for (int i = 0, j = charArray.Length - 1; i <= (charArray.Length - 1)/2; i++,j--)
            {
                if (charArray[i] != charArray[j])
                {
                    result = "Not Palindrome";
                }
            }

            return result;
        }
    }
}