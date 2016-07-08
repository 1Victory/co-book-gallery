using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoBookGallery.Models
{
    public class CoBook
    {
        public int Id { get; set; }
        public string SeriesTItle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml{ get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }
    }
}