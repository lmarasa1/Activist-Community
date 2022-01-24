using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Luca.Models
{
    public class Petition
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CaptureDate { get; set; }
        public string Image { get; set; }

    }
}