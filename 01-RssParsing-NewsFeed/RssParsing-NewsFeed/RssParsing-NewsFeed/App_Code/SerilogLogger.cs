using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Serilog;

namespace RssParsing_NewsFeed.App_Code
{
    public class SerilogLogger
    {
        public static void WriteErrorLog(string error)
        {
            var logger = new LoggerConfiguration()
                 .WriteTo.RollingFile(@"D:\Log-{Date}.txt")
                 .CreateLogger();
            var appointment =
           new { Id = 1, Subject = "ERROR DETAILS", Timestamp = new DateTime(2015, 3, 12) };
            logger.Error("ERROR DETAILS: {@error}", error);

        }
    }
}