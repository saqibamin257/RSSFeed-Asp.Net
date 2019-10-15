using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramingPractice
{
    public partial class _05_CountOccuranceOfCharacter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "Hello World";
            ArrayList ts = Occurance(str);
            foreach (var s in ts)
            {
                p1.InnerText += s.ToString();
            }
        }
        public ArrayList Occurance(string str)
        {
            char[] charArray = str.ToCharArray();
            
            ArrayList arryList1 = new ArrayList();
            ArrayList arryList2 = new ArrayList();
            for (int i = 0; i <= charArray.Length - 1; i++)
            {
                int count = 0;
                for (int j=i; j<=charArray.Length-1; j++)
                {
                    if (charArray[i] == charArray[j])
                    {
                        count++;                        
                    }                    
                }
                if (!arryList2.Contains(charArray[i]))
                {
                    arryList2.Add(charArray[i]);
                    arryList1.Add(charArray[i] + " = " + count + " -times. \n");
                }
            }

            return arryList1;
        }
    }
}