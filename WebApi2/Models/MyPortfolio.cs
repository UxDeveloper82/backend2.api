using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Models
{
    public class MyPortfolio
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string MainTitle { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
