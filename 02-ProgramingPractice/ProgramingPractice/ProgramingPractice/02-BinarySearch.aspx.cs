using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramingPractice
{
    public partial class _02_BinarySearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] arr = new int[] { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 };
            int R = arr.Length - 1;
            int L = 0;
            int  x = 96;
            int result = BinarySearch(arr, L, R, x);
            h2.InnerText = "96 is present at array position : " + result.ToString();
        }
        public int BinarySearch(int[] arr, int L, int R, int x )
        {
            if (R > L)
            {
                int mid = L + (R - L) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }

                if (arr[mid] > x )
                {
                   return BinarySearch(arr,L ,mid-1, x);
                }

                else
                  //when arr[mid] < x 
                {
                   return BinarySearch(arr,mid + 1,R, x);
                }
            }
            return -1;
        }
    }
}