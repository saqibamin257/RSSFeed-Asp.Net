using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramingPractice
{
    public partial class _06_MultiThreading : System.Web.UI.Page
    {
        public void FirstThread()
        {            
            for (int i = 1; i <= 10; i++)
            {
                p2.InnerHtml += $"M1 - {i} <br/>";
                //Console.WriteLine("M1 is : {0} ", i);
                if (i == 5)
                {
                    Thread.Sleep(6000);
                }
            }
        }
        public void SecondThread()
        {
            for (int j = 1; j <= 10; j++)
            {
                p2.InnerHtml += $"M2 - {j} <br/>";
                //Console.WriteLine("M2 is : {0} ", j);

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            p2.InnerHtml = "";

        }

        protected void SingleThread_Click(object sender, EventArgs e)
        {
            FirstThread();
            SecondThread();
        }
        protected void MultiThread_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(FirstThread);
            Thread th2 = new Thread(SecondThread);
            th1.Start();
            th2.Start();
        }

    }
}