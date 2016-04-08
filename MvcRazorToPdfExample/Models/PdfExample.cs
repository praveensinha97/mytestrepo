using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRazorToPdfExample.Models
{
    public class PdfExample
    {
        public string Heading { get; set; }
        // my new changes
        public IEnumerable<BasketItem> Items { get; set; }
    }
}