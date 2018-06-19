using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerBIEmbedded_AppOwnsData.Models
{
    public class ReportModel
    {
        public string Id { get; set; }

        public string EmbedUrl { get; set; }

        public string Name { get; set; }

        public string EmbedToken { get; set; }
    }
}